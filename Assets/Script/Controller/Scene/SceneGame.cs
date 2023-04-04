using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SceneGame : MonoBehaviour
{
	private class BattleData
	{
		public enum BattleStatus
		{
			Attack,
			Counter,
			DoubleAttack,
			DoubleCounter
		}

		public Fighter Attacker;

		public Weapon WeaponA;

		public int HitA;

		public int FireA;

		public int DamageA;

		public Fighter Target;

		public Weapon WeaponT;

		public int HitT;

		public int FireT;

		public int DamageT;

		public int Distance;

		public void SetDouble(int id)
		{
			if (Attacker.ID != id)
			{
				if (Target.ID == id)
				{
					Swop();
				}
				else
				{
					Debug.Log("Error ID is Other");
				}
			}
		}

		public void Swop()
		{
			Fighter target = Target;
			Weapon weaponT = WeaponT;
			int hitT = HitT;
			int fireT = FireT;
			int damageT = DamageT;
			Target = Attacker;
			WeaponT = WeaponA;
			HitT = HitA;
			FireT = FireA;
			DamageT = DamageA;
			Attacker = target;
			WeaponA = weaponT;
			HitA = hitT;
			FireA = fireT;
			DamageA = damageT;
		}
	}

	private Level m_Level;

	private List<Fighter> m_DamageFighter = new List<Fighter>();

	private List<List<VTerrain>> m_MapData = new List<List<VTerrain>>();

	private Dictionary<int, VFighter> m_Fighter = new Dictionary<int, VFighter>();

	private RectTransform m_RootRectTransform;

	private ScrollRect m_ScrollRect;

	private GameObject m_MapRoot;

	private int m_RepriseNum;

	private Define.GameState m_GameState;

	private Define.GameState m_EventLastGameState = Define.GameState.Wait;

	private List<GameEvent> m_GameEvent = new List<GameEvent>();

	private Fighter m_TargetOne;

	private Fighter m_TargetTwo;

	private int m_UseToolsID = -1;

	public Text LevelTitle;

	private VFighter m_LookFighter;

	private VFighter LookFighter
	{
		get
		{
			return m_LookFighter;
		}
		set
		{
			m_LookFighter = value;
			if (m_LookFighter == null)
			{
				m_ScrollRect.enabled = true;
			}
			else
			{
				m_ScrollRect.enabled = false;
			}
		}
	}

	private void Awake()
	{
		m_ScrollRect = base.gameObject.AddComponent<ScrollRect>();
	}

	private void ResetData()
	{
		m_GameState = Define.GameState.Tittle;
		m_MapData.Clear();
		m_Fighter.Clear();
		m_DamageFighter.Clear();
		m_Level = null;
		m_RootRectTransform = null;
		m_GameEvent.Clear();
		m_RepriseNum = 0;
		UnityEngine.Object.Destroy(m_MapRoot);
	}

	private void AddGameEvent(List<GameEvent> list)
	{
		if (list != null && list.Count != 0)
		{
			list.AddRange(m_GameEvent);
			m_GameEvent = list;
		}
	}

	private void AddGameEvent(GameEvent[] list)
	{
		if (list != null && list.Length != 0)
		{
			List<GameEvent> list2 = new List<GameEvent>(list);
			list2.AddRange(m_GameEvent);
			m_GameEvent = list2;
		}
	}

	private void GameOver()
	{
		ResetData();
		AudioManager.Instance.PlayBGM(-1);
		AudioManager.Instance.PlayME(2);
		DataManager.Instance.SetSuccess(5, DataManager.Instance.GetSchedule(5) + 1);
		if (GameDataBase.Instance.NowLevel == 0 && GameDataBase.Instance.GamePlus == 1)
		{
			DataManager.Instance.SetSuccess(0, DataManager.Instance.GetSchedule(0) + 1);
		}
		MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_ResetMenu));
		MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_GameOver));
	}

	private void Repair()
	{
		if (m_DamageFighter.Count <= 0)
		{
			return;
		}
		DoStartEvent(m_GameState);
		List<GameEvent> list = new List<GameEvent>();
		foreach (Fighter item in m_DamageFighter)
		{
			GameDataBase.Instance.NowMoney -= item.Money;
			DataManager.Instance.SetSuccess(3, DataManager.Instance.GetSchedule(3) + item.Money);
			if (GameDataBase.Instance.NowMoney < 0)
			{
				list.Add(new GameEvent_Dialogue("哎呀你的钱都不够修理费了!", "尤里:", 29, Vector2.zero));
				list.Add(new GameEvent_Dialogue("剩下的我就免费修理了,以后可要注意啊!", "尤里:", 29, Vector2.zero));
				GameDataBase.Instance.NowMoney = 0;
				break;
			}
			list.Add(new GameEvent_Dialogue(item.RobotName + "被破坏了,修理费" + item.Money, "尤里:", 29, Vector2.zero));
		}
		m_DamageFighter.Clear();
		list.Add(new GameEvent_Dialogue("年轻人,再小心一点怎么样?", "尤里:", 29, Vector2.zero));
		AddGameEvent(list);
	}

	private void Victory(int next)
	{
		GameDataBase.Instance.NowLevel = ((next != -1) ? next : 0);
		ResetData();
		MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_ResetMenu));
		if (next == -1)
		{
			GameDataBase.Instance.GamePlus++;
			GameDataBase.Instance.NowLevel = 0;
			DataManager.Instance.SetSuccess(1, DataManager.Instance.GetSchedule(1) + 1);
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_GameEnd));
		}
		else
		{
			MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_LoadLevel(GameDataBase.Instance.NowLevel));
		}
		PlayerPrefs.SetString("Save", GameDataBase.Instance.Save());
		PlayerPrefs.SetString("SaveInfo", GameDataBase.Instance.SaveInfo());
		PlayerPrefs.Save();
	}

	private void Start()
	{
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_LoadLevel, LoadLevel);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ClickFighter, ClickFighter);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ClickTerrain, ClickTerrain);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_OnMoveOver, OnMoveOver);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_DoVariant, OnDoVariant);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_DoTakeOff, DoTakeOff);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_Effect, WaitEffect);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ShowWeaponRange, ShowWeaponRange);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_EnterFighter, EnterFighter);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ExitFighter, ExitFighter);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_UseSpirit, UseSpirit);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_UseTools, UseTools);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_CloseShop, CloseShop);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ShowLevelTittle, ShowLevelTitle);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_BackTitle, BackTittle);
		LevelTitle.gameObject.SetActive(value: false);
	}

	private void BackTittle(object prame)
	{
		ResetData();
	}

	private void UseSpirit(Fighter user, int spiritID, Fighter target, int x, int y)
	{
		AudioManager.Instance.PlaySE(0);
		if (spiritID == -1)
		{
			Debug.Log("Spirit ID Error");
			return;
		}
		Spirit spirit = GameDataBase.Instance.GetSpirit(spiritID);
		Spirit.SpiritScope scope = spirit.Scope;
		if (scope == Spirit.SpiritScope.SelfOneOther && m_MapData[x][y].CanMove())
		{
			DoStartEvent(Define.GameState.Wait);
			AddGameEvent(spirit.GetUseEvent(user, new List<Fighter> { target }, new Define.Point(x, y)));
			if (m_Level.MoveOverEvent != null)
			{
				m_GameEvent.AddRange(m_Level.MoveOverEvent);
			}
			ResetMapShow();
			m_Fighter[m_TargetOne.ID].UseSpiritID = -1;
			m_TargetOne = null;
			m_TargetTwo = null;
		}
	}

	private void UseSpirit(Fighter user, int spiritID, Fighter target)
	{
		AudioManager.Instance.PlaySE(0);
		if (spiritID == -1)
		{
			Debug.Log("Spirit ID Error");
			return;
		}
		Spirit spirit = GameDataBase.Instance.GetSpirit(spiritID);
		switch (spirit.Scope)
		{
		case Spirit.SpiritScope.SelfOne:
			if (user.IsSelf == target.IsSelf && spirit.CanUse(target))
			{
				DoStartEvent(Define.GameState.Wait);
				AddGameEvent(spirit.GetUseEvent(user, new List<Fighter> { target }, new Define.Point(0, 0)));
				ResetMapShow();
				m_Fighter[m_TargetOne.ID].UseSpiritID = -1;
				m_TargetOne = null;
			}
			break;
		case Spirit.SpiritScope.SelfOneOther:
		{
			if (user.IsSelf != target.IsSelf || !spirit.CanUse(target))
			{
				break;
			}
			m_GameState = Define.GameState.Spirit_Two;
			m_TargetTwo = target;
			for (int i = 0; i < m_MapData.Count; i++)
			{
				for (int j = 0; j < m_MapData[i].Count; j++)
				{
					m_MapData[i][j].SetBlack(!m_MapData[i][j].CanMove());
				}
			}
			{
				foreach (int key in m_Fighter.Keys)
				{
					m_Fighter[key].SetBlack(black: true);
				}
				break;
			}
		}
		}
	}

	private void UseSpirit(object prame)
	{
		AudioManager.Instance.PlaySE(0);
		MsgDefine.MsgPrame_UseSpirit msgPrame_UseSpirit = (MsgDefine.MsgPrame_UseSpirit)prame;
		Fighter fighter = m_Fighter[msgPrame_UseSpirit.FighterID].Fighter;
		if (fighter == null)
		{
			return;
		}
		Spirit spirit = GameDataBase.Instance.GetSpirit(msgPrame_UseSpirit.Spirit);
		switch (spirit.Scope)
		{
		case Spirit.SpiritScope.Self:
			DoStartEvent(m_GameState);
			AddGameEvent(spirit.GetUseEvent(fighter, new List<Fighter> { fighter }, new Define.Point(0, 0)));
			break;
		case Spirit.SpiritScope.SelfOne:
		case Spirit.SpiritScope.SelfOneOther:
		{
			m_GameState = Define.GameState.Spirit_One;
			m_Fighter[fighter.ID].UseSpiritID = msgPrame_UseSpirit.Spirit;
			m_TargetOne = fighter;
			for (int i = 0; i < m_MapData.Count; i++)
			{
				for (int j = 0; j < m_MapData[i].Count; j++)
				{
					m_MapData[i][j].SetBlack(black: true);
				}
			}
			{
				foreach (int key in m_Fighter.Keys)
				{
					m_Fighter[key].SetBlack(!spirit.CanUse(m_Fighter[key].Fighter) || m_Fighter[key].IsSelf != fighter.IsSelf);
				}
				break;
			}
		}
		case Spirit.SpiritScope.SelfAll:
		{
			DoStartEvent(m_GameState);
			List<Fighter> list2 = new List<Fighter>();
			foreach (int key2 in m_Fighter.Keys)
			{
				if (m_Fighter[key2].IsSelf)
				{
					list2.Add(m_Fighter[key2].Fighter);
				}
			}
			AddGameEvent(spirit.GetUseEvent(fighter, list2, new Define.Point(0, 0)));
			break;
		}
		case Spirit.SpiritScope.EnemyAll:
		{
			DoStartEvent(m_GameState);
			List<Fighter> list = new List<Fighter>();
			foreach (int key3 in m_Fighter.Keys)
			{
				if (!m_Fighter[key3].IsSelf)
				{
					list.Add(m_Fighter[key3].Fighter);
				}
			}
			AddGameEvent(spirit.GetUseEvent(fighter, list, new Define.Point(0, 0)));
			break;
		}
		case Spirit.SpiritScope.EnemyOne:
			break;
		}
	}

	private void UseTools(Fighter user, int itemID)
	{
		AudioManager.Instance.PlaySE(0);
		Item item = GameDataBase.Instance.GetItem(itemID);
		if (item.CanUse(user))
		{
			DoStartEvent(Define.GameState.Wait);
			AddGameEvent(item.GetUseEvent(new List<Fighter> { user }));
			m_UseToolsID = -1;
			ResetMapShow();
		}
	}

	private void UseTools(object prame)
	{
		AudioManager.Instance.PlaySE(0);
		MsgDefine.MsgPrame_UseTools msgPrame_UseTools = (MsgDefine.MsgPrame_UseTools)prame;
		if (GameDataBase.Instance.GetItemCount(msgPrame_UseTools.ItemID) < 1)
		{
			return;
		}
		Item item = GameDataBase.Instance.GetItem(msgPrame_UseTools.ItemID);
		switch (item.Scope)
		{
		case Item.ItemScope.SelfOne:
		{
			m_GameState = Define.GameState.Tools_One;
			m_UseToolsID = msgPrame_UseTools.ItemID;
			for (int i = 0; i < m_MapData.Count; i++)
			{
				for (int j = 0; j < m_MapData[i].Count; j++)
				{
					m_MapData[i][j].SetBlack(black: true);
				}
			}
			{
				foreach (int key in m_Fighter.Keys)
				{
					m_Fighter[key].SetBlack(!m_Fighter[key].IsSelf || !item.CanUse(m_Fighter[key].Fighter));
				}
				break;
			}
		}
		case Item.ItemScope.EnemyAll:
		{
			DoStartEvent(m_GameState);
			List<Fighter> list = new List<Fighter>();
			foreach (int key2 in m_Fighter.Keys)
			{
				if (!m_Fighter[key2].IsSelf)
				{
					list.Add(m_Fighter[key2].Fighter);
				}
			}
			AddGameEvent(item.GetUseEvent(list));
			break;
		}
		}
	}

	private void EnterFighter(object prame)
	{
		if (!BannedClick() && (m_GameState == Define.GameState.Attack || m_GameState == Define.GameState.Move_Attack || m_GameState == Define.GameState.TakeOff_Attack || m_GameState == Define.GameState.Spirit_One))
		{
			MsgDefine.MsgPrame_EnterFighter msgPrame_EnterFighter = (MsgDefine.MsgPrame_EnterFighter)prame;
			if (!m_Fighter[msgPrame_EnterFighter.EnterFighter.ID].GetBlack())
			{
				MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowBaseSkew(msgPrame_EnterFighter.EnterFighter));
			}
		}
	}

	private void ExitFighter(object prame)
	{
		if (!BannedClick() && (m_GameState == Define.GameState.Attack || m_GameState == Define.GameState.Move_Attack || m_GameState == Define.GameState.TakeOff_Attack || m_GameState == Define.GameState.Spirit_One))
		{
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
		}
	}

	private void ShowWeaponRange(object prame)
	{
		MsgDefine.MsgPrame_ShowWeaponRange msgPrame_ShowWeaponRange = (MsgDefine.MsgPrame_ShowWeaponRange)prame;
		m_TargetOne = m_Fighter[msgPrame_ShowWeaponRange.FighterID].Fighter;
		Weapon weapon = GameDataBase.Instance.GetWeapon(msgPrame_ShowWeaponRange.WeaponID);
		if (weapon.All)
		{
			switch (m_GameState)
			{
			case Define.GameState.Attack_Ready:
				m_GameState = Define.GameState.Wait;
				DoBattle(msgPrame_ShowWeaponRange.FighterID, msgPrame_ShowWeaponRange.WeaponID, -1);
				m_TargetOne = null;
				break;
			case Define.GameState.Move_Attack_Ready:
			{
				m_GameState = Define.GameState.Wait;
				DoBattle(msgPrame_ShowWeaponRange.FighterID, msgPrame_ShowWeaponRange.WeaponID, -1);
				m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
				ChooseMoveOverEvent();
				Define.Point key2 = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
				if (m_Level.ShopEvent.ContainsKey(key2))
				{
					DoStartEvent(m_GameState);
					m_GameEvent.AddRange(m_Level.ShopEvent[key2]);
				}
				m_TargetOne = null;
				break;
			}
			case Define.GameState.TakeOff_Attack_Ready:
			{
				m_GameState = Define.GameState.Wait;
				DoBattle(msgPrame_ShowWeaponRange.FighterID, msgPrame_ShowWeaponRange.WeaponID, -1);
				m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
				ChooseMoveOverEvent();
				Define.Point key = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
				if (m_Level.ShopEvent.ContainsKey(key))
				{
					DoStartEvent(m_GameState);
					m_GameEvent.AddRange(m_Level.ShopEvent[key]);
				}
				m_TargetOne = null;
				m_TargetTwo = null;
				break;
			}
			}
			return;
		}
		List<int> list = SkillHasTarget(new Define.Point(m_TargetOne.X, m_TargetOne.Y), msgPrame_ShowWeaponRange.WeaponID, m_TargetOne.IsSelf);
		m_Fighter[msgPrame_ShowWeaponRange.FighterID].CanAttackTraget = list;
		m_Fighter[msgPrame_ShowWeaponRange.FighterID].UseWeaponID = msgPrame_ShowWeaponRange.WeaponID;
		switch (m_GameState)
		{
		case Define.GameState.Attack_Ready:
			m_GameState = Define.GameState.Attack;
			break;
		case Define.GameState.Move_Attack_Ready:
			m_GameState = Define.GameState.Move_Attack;
			break;
		case Define.GameState.TakeOff_Attack_Ready:
			m_GameState = Define.GameState.TakeOff_Attack;
			break;
		}
		for (int i = 0; i < m_MapData.Count; i++)
		{
			for (int j = 0; j < m_MapData[i].Count; j++)
			{
				int num = Math.Abs(i - m_TargetOne.X) + Math.Abs(j - m_TargetOne.Y);
				if (num > weapon.Range)
				{
					m_MapData[i][j].SetBlack(black: true);
				}
				else if (weapon.Range > 1 && num == 1)
				{
					m_MapData[i][j].SetBlack(black: true);
				}
			}
		}
		foreach (int key3 in m_Fighter.Keys)
		{
			if (m_TargetOne.ID != key3)
			{
				m_Fighter[key3].SetBlack(black: true);
			}
		}
		foreach (int item in list)
		{
			m_Fighter[item].SetBlack(black: false);
		}
	}

	private void WaitEffect(object prame)
	{
		m_GameState = Define.GameState.DoEvent;
	}

	private void DoTakeOff(object prame)
	{
		AudioManager.Instance.PlaySE(0);
		MsgDefine.MsgPrame_DoTakeOff msgPrame_DoTakeOff = (MsgDefine.MsgPrame_DoTakeOff)prame;
		if (msgPrame_DoTakeOff.Fighter.IsAction)
		{
			MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowHint(msgPrame_DoTakeOff.Fighter));
			return;
		}
		m_TargetOne = msgPrame_DoTakeOff.Fighter;
		m_TargetTwo = msgPrame_DoTakeOff.Carry;
		m_TargetOne.CanMovePath = null;
		m_TargetOne.X = m_TargetTwo.X;
		m_TargetOne.Y = m_TargetTwo.Y;
		m_Fighter[m_TargetOne.ID].SetPosition(m_MapData[m_TargetTwo.X][m_TargetTwo.Y].Position);
		GetMoveRange(m_TargetOne);
		ShowMoveRange(m_TargetOne.GetCanMovePoint());
		m_GameState = Define.GameState.TakeOff_Ready;
		MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
	}

	private void OnDoVariant(object prame)
	{
		MsgDefine.MsgPrame_DoVariant msgPrame_DoVariant = (MsgDefine.MsgPrame_DoVariant)prame;
		msgPrame_DoVariant.Fighter.Variant(msgPrame_DoVariant.ActorData);
		m_Fighter[msgPrame_DoVariant.Fighter.ID].SetIcon(msgPrame_DoVariant.Fighter.Icon);
		DoStartEvent(m_GameState);
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_Dialogue(msgPrame_DoVariant.Fighter.RobotName + "出发!", msgPrame_DoVariant.Fighter.UserName, msgPrame_DoVariant.Fighter.Hand, Vector2.zero));
		List<GameEvent> collection = list;
		m_GameEvent.AddRange(collection);
	}

	private void LoadMap()
	{
		Map map = m_Level.Map;
		m_MapRoot = new GameObject("GameMapRoot");
		m_MapRoot.transform.SetParent(base.transform);
		m_RootRectTransform = m_MapRoot.AddComponent<RectTransform>();
		m_RootRectTransform.sizeDelta = new Vector2((float)(map.Width + 2) * Define.MapElementWidth, (float)(map.Height + 3) * (0f - Define.MapElementWidth));
		m_RootRectTransform.pivot = new Vector2(0.5f, 0.5f);
		m_RootRectTransform.localScale = new Vector3(1f, 1f, 1f);
		int num = 7;
		int num2 = map.Width + num * 2;
		int num3 = map.Height + num * 2;
		for (int i = 0; i < num2; i++)
		{
			for (int j = 0; j < num3; j++)
			{
				if (i < num || i >= map.Width + num || j < num || j >= map.Height + num)
				{
					GameObject gameObject = new GameObject("Frame");
					gameObject.transform.SetParent(m_MapRoot.transform);
					VTerrain vTerrain = gameObject.AddComponent<VTerrain>();
					vTerrain.Init(i, j, GameDataBase.Instance.GetTerrain(14), new Vector3(Define.MapElementWidth * (float)i - Define.MapElementWidth * (float)(num2 - 1) / 2f, 0f - Define.MapElementWidth * (float)j + Define.MapElementWidth * (float)(num3 - 1) / 2f));
				}
			}
		}
		for (int k = 0; k < map.Width; k++)
		{
			m_MapData.Add(new List<VTerrain>());
			for (int l = 0; l < map.Height; l++)
			{
				GameObject gameObject2 = new GameObject("Map_" + k + "_" + l);
				gameObject2.transform.SetParent(m_MapRoot.transform);
				VTerrain vTerrain2 = gameObject2.AddComponent<VTerrain>();
				vTerrain2.Init(k, l, GameDataBase.Instance.GetTerrain(map[k, l]), new Vector3(Define.MapElementWidth * (float)k - Define.MapElementWidth * (float)(map.Width - 1) / 2f, 0f - Define.MapElementWidth * (float)l + Define.MapElementWidth * (float)(map.Height - 1) / 2f));
				m_MapData[k].Add(vTerrain2);
			}
		}
	}

	private Define.Point GetNullFightrPos(Define.Point pos)
	{
		Define.Point result = default(Define.Point);
		int num = int.MaxValue;
		for (int i = 0; i < m_MapData.Count; i++)
		{
			for (int j = 0; j < m_MapData[i].Count; j++)
			{
				int num2 = Math.Abs(m_MapData[i][j].X - pos.X) + Math.Abs(m_MapData[i][j].Y - pos.Y);
				if (num2 < num && m_MapData[i][j].FighterID == -1)
				{
					num = num2;
					result.X = i;
					result.Y = j;
				}
			}
		}
		return result;
	}

	private void LoadFighter(int id)
	{
		if (!m_Level.FighterData.ContainsKey(id))
		{
			Debug.Log("Error ! Fighter ID is Null !" + id);
			return;
		}
		GameObject gameObject = new GameObject("Fighter");
		gameObject.transform.SetParent(m_MapRoot.transform);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		gameObject.transform.localPosition = new Vector3(0f, 0f, 0f);
		VFighter vFighter = gameObject.AddComponent<VFighter>();
		vFighter.Init(m_Level.FighterData[id], id);
		m_Fighter.Add(id, vFighter);
		if (vFighter.X != -1 && vFighter.Y != -1)
		{
			if (m_MapData[vFighter.X][vFighter.Y].FighterID != -1)
			{
				Define.Point nullFightrPos = GetNullFightrPos(new Define.Point(vFighter.X, vFighter.Y));
				vFighter.X = nullFightrPos.X;
				vFighter.Y = nullFightrPos.Y;
			}
			vFighter.SetPosition(m_MapData[vFighter.X][vFighter.Y].Position);
			m_MapData[vFighter.X][vFighter.Y].Carry(id);
		}
	}

	private void ChooseMoveOverEvent()
	{
		if (m_Level.MoveOverEvent != null)
		{
			DoStartEvent(m_GameState);
			m_GameEvent.AddRange(m_Level.MoveOverEvent);
		}
	}

	private void MoveOver()
	{
		if (m_TargetOne == null)
		{
			return;
		}
		if (m_TargetOne.IsSelf && m_TargetOne.AIType == Define.AIType.Null)
		{
			m_GameState = Define.GameState.Move_Over;
			Dictionary<Define.MenuType, UnityAction> dictionary = new Dictionary<Define.MenuType, UnityAction>();
			dictionary.Add(Define.MenuType.Cancel, delegate
			{
				m_GameState = Define.GameState.Wait;
				m_Fighter[m_TargetOne.ID].LoadPoint();
				m_Fighter[m_TargetOne.ID].SetPosition(m_MapData[m_TargetOne.X][m_TargetOne.Y].Position);
				m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
				m_TargetOne = null;
				if (m_TargetTwo != null)
				{
					m_TargetTwo = null;
				}
				AudioManager.Instance.PlaySE(0);
				MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			});
			if (m_TargetTwo != null)
			{
				if (m_TargetOne.X == m_TargetTwo.X && m_TargetOne.Y == m_TargetTwo.Y)
				{
					dictionary.Add(Define.MenuType.Carry, delegate
					{
						m_TargetOne.IsAction = true;
						m_Fighter[m_TargetTwo.ID].Carry(m_TargetOne);
						m_Fighter[m_TargetOne.ID].ThisCarry = m_TargetTwo;
						m_Fighter[m_TargetOne.ID].gameObject.SetActive(value: false);
						DoStartEvent(Define.GameState.Wait);
						List<GameEvent> list2 = new List<GameEvent>
						{
							new GameEvent_Dialogue(m_TargetOne.RobotName + "准备搭载!", m_TargetOne.UserName, m_TargetOne.Hand, Vector2.zero),
							new GameEvent_Dialogue(m_TargetTwo.RobotName + "搭载完成!", m_TargetTwo.UserName, m_TargetTwo.Hand, Vector2.zero)
						};
						AddGameEvent(list2);
						AddGameEvent(m_Level.CarryEvent);
						m_TargetTwo = null;
						m_TargetOne = null;
						AudioManager.Instance.PlaySE(0);
						MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
					});
				}
			}
			else
			{
				dictionary.Add(Define.MenuType.Suspend, delegate
				{
					m_GameState = Define.GameState.Wait;
					m_TargetOne.IsAction = true;
					m_Fighter[m_TargetOne.ID].SetBlack(m_TargetOne.IsAction);
					m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
					AudioManager.Instance.PlaySE(0);
					MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
					ChooseMoveOverEvent();
					Define.Point key2 = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
					if (m_Level.ShopEvent.ContainsKey(key2))
					{
						DoStartEvent(m_GameState);
						m_GameEvent.AddRange(m_Level.ShopEvent[key2]);
					}
					m_TargetOne = null;
				});
				if (OnCanAttack(m_TargetOne))
				{
					dictionary.Add(Define.MenuType.Attack, delegate
					{
						m_GameState = Define.GameState.Move_Attack_Ready;
						ShowHasTargetWeapon(m_TargetOne);
					});
				}
				List<int> canCapitulateList = OnCanCapitulate(m_TargetOne.ID);
				if (canCapitulateList.Count > 0)
				{
					dictionary.Add(Define.MenuType.Capitulate, delegate
					{
						m_GameState = Define.GameState.Wait;
						m_TargetOne.IsAction = true;
						m_Fighter[m_TargetOne.ID].SetBlack(m_TargetOne.IsAction);
						m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
						DoStartEvent(m_GameState);
						m_GameEvent.AddRange(m_Level.GetCapitulateEvent(m_TargetOne.ID, canCapitulateList[0]));
						AudioManager.Instance.PlaySE(0);
						MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
						ChooseMoveOverEvent();
						Define.Point key = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
						if (m_Level.ShopEvent.ContainsKey(key))
						{
							DoStartEvent(m_GameState);
							m_GameEvent.AddRange(m_Level.ShopEvent[key]);
						}
						m_TargetOne = null;
					});
				}
			}
			MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowMenu(dictionary));
			return;
		}
		if (m_GameState == Define.GameState.SelfAI_Move)
		{
			m_GameState = Define.GameState.SelfAI_Move_Attack_Ready;
		}
		if (m_GameState == Define.GameState.Enemy_Move)
		{
			m_GameState = Define.GameState.Enemy_Move_Attack_Ready;
		}
		int num = -1;
		int num2 = -1;
		for (int i = 0; i < m_TargetOne.Weapon.Count; i++)
		{
			List<int> list = SkillHasTarget(new Define.Point(m_TargetOne.X, m_TargetOne.Y), m_TargetOne.Weapon[i], m_TargetOne.IsSelf);
			if (list.Count <= 0)
			{
				continue;
			}
			foreach (int item in list)
			{
				if (num == -1)
				{
					num = item;
					num2 = i;
				}
				else if (AttackPriority(num, item) == item)
				{
					num = item;
					num2 = i;
				}
			}
		}
		if (m_GameState == Define.GameState.SelfAI_Move_Attack_Ready)
		{
			m_GameState = Define.GameState.SelfAI;
		}
		if (m_GameState == Define.GameState.Enemy_Move_Attack_Ready)
		{
			m_GameState = Define.GameState.Enemy;
		}
		if (num2 != -1 && m_TargetOne.AIType != Define.AIType.Retreat)
		{
			DoBattle(m_TargetOne.ID, m_TargetOne.Weapon[num2], num);
		}
		else
		{
			m_TargetOne.IsAction = true;
			m_Fighter[m_TargetOne.ID].SetBlack(black: true);
		}
		m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
		m_TargetOne = null;
		ChooseMoveOverEvent();
	}

	private void TakeOffOver()
	{
		m_GameState = Define.GameState.TakeOff_Over;
		Dictionary<Define.MenuType, UnityAction> dictionary = new Dictionary<Define.MenuType, UnityAction>();
		dictionary.Add(Define.MenuType.Cancel, delegate
		{
			m_GameState = Define.GameState.Wait;
			m_Fighter[m_TargetOne.ID].gameObject.SetActive(value: false);
			m_Fighter[m_TargetTwo.ID].Carry(m_TargetOne);
			m_Fighter[m_TargetOne.ID].ThisCarry = m_TargetTwo;
			m_TargetOne = null;
			m_TargetTwo = null;
			AudioManager.Instance.PlaySE(0);
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
		});
		dictionary.Add(Define.MenuType.Suspend, delegate
		{
			m_GameState = Define.GameState.Wait;
			m_TargetOne.IsAction = true;
			m_Fighter[m_TargetOne.ID].SetBlack(m_TargetOne.IsAction);
			m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
			AudioManager.Instance.PlaySE(0);
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			ChooseMoveOverEvent();
			Define.Point key2 = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
			if (m_Level.ShopEvent.ContainsKey(key2))
			{
				DoStartEvent(m_GameState);
				m_GameEvent.AddRange(m_Level.ShopEvent[key2]);
			}
			m_TargetOne = null;
			m_TargetTwo = null;
		});
		List<int> canCapitulateList = OnCanCapitulate(m_TargetOne.ID);
		if (canCapitulateList.Count > 0)
		{
			dictionary.Add(Define.MenuType.Capitulate, delegate
			{
				m_GameState = Define.GameState.Wait;
				m_TargetOne.IsAction = true;
				m_Fighter[m_TargetOne.ID].SetBlack(m_TargetOne.IsAction);
				m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
				DoStartEvent(m_GameState);
				m_GameEvent.AddRange(m_Level.GetCapitulateEvent(m_TargetOne.ID, canCapitulateList[0]));
				AudioManager.Instance.PlaySE(0);
				MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
				ChooseMoveOverEvent();
				Define.Point key = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
				if (m_Level.ShopEvent.ContainsKey(key))
				{
					DoStartEvent(m_GameState);
					m_GameEvent.AddRange(m_Level.ShopEvent[key]);
				}
				m_TargetOne = null;
				m_TargetTwo = null;
			});
		}
		if (OnCanAttack(m_TargetOne))
		{
			dictionary.Add(Define.MenuType.Attack, delegate
			{
				m_GameState = Define.GameState.TakeOff_Attack_Ready;
				ShowHasTargetWeapon(m_TargetOne);
			});
		}
		MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowMenu(dictionary));
	}

	private void CloseShop(object prame)
	{
		AudioManager.Instance.PlayBGM(m_Level.SelfBGM);
	}

	private void OnMoveOver(object prame)
	{
		if (m_GameState == Define.GameState.Moveing || m_GameState == Define.GameState.Enemy_Move || m_GameState == Define.GameState.SelfAI_Move)
		{
			LookFighter = null;
			MoveOver();
		}
		else if (m_GameState == Define.GameState.TakeOffing)
		{
			LookFighter = null;
			TakeOffOver();
		}
		else if (m_GameState == Define.GameState.DoEvent_Move)
		{
			m_GameState = Define.GameState.DoEvent;
			if (m_LookFighter != null)
			{
				m_LookFighter = null;
			}
			OnDoGameEvent();
		}
	}

	private void LoadLevel(MsgBase msg)
	{
		MsgDefine.MsgPrame_LoadLevel msgPrame_LoadLevel = msg.Prame<MsgDefine.MsgPrame_LoadLevel>();
		ResetData();
		m_Level = GameDataBase.Instance.GetLevel(msgPrame_LoadLevel.Level);
		LoadMap();
		m_ScrollRect.content = m_RootRectTransform;
		m_RootRectTransform.anchorMin = new Vector2(0.5f, 0.5f);
		m_RootRectTransform.anchorMax = new Vector2(0.5f, 0.5f);
		if (DataManager.Instance.IsText)
		{
			if (msgPrame_LoadLevel.Level == 0 && GameDataBase.Instance.GamePlus == 1)
			{
				ShowLevelTitle(null);
			}
			else
			{
				ShowPlan();
			}
		}
		else
		{
			ShowLevelTitle(null);
		}
	}

	private void ClickTerrain(object prame)
	{
		AudioManager.Instance.PlaySE(0);
		if (BannedClick())
		{
			return;
		}
		if (m_GameState == Define.GameState.Spirit_One)
		{
			m_GameState = Define.GameState.Wait;
			ResetMapShow();
			m_Fighter[m_TargetOne.ID].UseSpiritID = -1;
			m_TargetOne = null;
			return;
		}
		if (m_GameState == Define.GameState.Tools_One)
		{
			m_GameState = Define.GameState.Wait;
			ResetMapShow();
			m_UseToolsID = -1;
			return;
		}
		if (m_GameState == Define.GameState.Move_Over)
		{
			m_GameState = Define.GameState.Wait;
			m_Fighter[m_TargetOne.ID].LoadPoint();
			m_Fighter[m_TargetOne.ID].SetPosition(m_MapData[m_TargetOne.X][m_TargetOne.Y].Position);
			m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
			m_TargetOne = null;
			if (m_TargetTwo != null)
			{
				m_TargetTwo = null;
			}
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			return;
		}
		if (m_GameState == Define.GameState.TakeOff_Over)
		{
			m_GameState = Define.GameState.Wait;
			m_Fighter[m_TargetOne.ID].gameObject.SetActive(value: false);
			m_Fighter[m_TargetTwo.ID].Carry(m_TargetOne);
			m_Fighter[m_TargetOne.ID].ThisCarry = m_TargetTwo;
			m_TargetOne = null;
			m_TargetTwo = null;
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			return;
		}
		if (m_GameState == Define.GameState.Attack || m_GameState == Define.GameState.Attack_Ready)
		{
			m_GameState = Define.GameState.Wait;
			m_TargetOne = null;
			ResetMapShow();
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			return;
		}
		if (m_GameState == Define.GameState.Move_Attack || m_GameState == Define.GameState.Move_Attack_Ready)
		{
			m_GameState = Define.GameState.Wait;
			m_Fighter[m_TargetOne.ID].LoadPoint();
			m_Fighter[m_TargetOne.ID].SetPosition(m_MapData[m_TargetOne.X][m_TargetOne.Y].Position);
			m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
			m_TargetOne = null;
			ResetMapShow();
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			return;
		}
		if (m_GameState == Define.GameState.TakeOff_Attack || m_GameState == Define.GameState.TakeOff_Attack_Ready)
		{
			m_GameState = Define.GameState.Wait;
			m_Fighter[m_TargetOne.ID].gameObject.SetActive(value: false);
			m_Fighter[m_TargetTwo.ID].Carry(m_TargetOne);
			m_Fighter[m_TargetOne.ID].ThisCarry = m_TargetTwo;
			m_TargetOne = null;
			m_TargetTwo = null;
			ResetMapShow();
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			return;
		}
		MsgDefine.MsgPrame_ClickTerrain msgPrame_ClickTerrain = (MsgDefine.MsgPrame_ClickTerrain)prame;
		if (m_GameState == Define.GameState.Spirit_Two)
		{
			if (m_TargetOne == null || m_TargetTwo == null)
			{
				Debug.Log("Fighter is null !");
			}
			else
			{
				UseSpirit(m_TargetOne, m_Fighter[m_TargetOne.ID].UseSpiritID, m_TargetTwo, msgPrame_ClickTerrain.X, msgPrame_ClickTerrain.Y);
			}
			return;
		}
		if (m_GameState == Define.GameState.Move_Ready)
		{
			if (m_TargetOne == null)
			{
				Debug.Log("错误的目标 !");
				return;
			}
			List<Define.Point> movePath = m_TargetOne.GetMovePath(new Define.Point(msgPrame_ClickTerrain.X, msgPrame_ClickTerrain.Y));
			if (movePath != null)
			{
				m_GameState = Define.GameState.Moveing;
				m_MapData[m_TargetOne.X][m_TargetOne.Y].TakeOff();
				m_Fighter[m_TargetOne.ID].DoMovePath(movePath);
				LookFighter = m_Fighter[m_TargetOne.ID];
				ResetMapShow();
			}
			return;
		}
		if (m_GameState == Define.GameState.TakeOff_Ready)
		{
			if (m_TargetOne == null || m_TargetTwo == null)
			{
				Debug.Log("错误的目标 !");
				return;
			}
			List<Define.Point> movePath2 = m_TargetOne.GetMovePath(new Define.Point(msgPrame_ClickTerrain.X, msgPrame_ClickTerrain.Y));
			if (movePath2 != null)
			{
				m_GameState = Define.GameState.TakeOffing;
				m_Fighter[m_TargetOne.ID].gameObject.SetActive(value: true);
				m_Fighter[m_TargetOne.ID].SetBlack(black: false);
				m_Fighter[m_TargetTwo.ID].TakeOff(m_TargetOne);
				m_Fighter[m_TargetOne.ID].ThisCarry = null;
				m_Fighter[m_TargetOne.ID].DoMovePath(movePath2);
				LookFighter = m_Fighter[m_TargetOne.ID];
				ResetMapShow();
			}
			return;
		}
		Dictionary<Define.MenuType, UnityAction> dictionary = new Dictionary<Define.MenuType, UnityAction>();
		dictionary.Add(Define.MenuType.Finish, delegate
		{
			NextReprise();
			AudioManager.Instance.PlaySE(0);
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
		});
		dictionary.Add(Define.MenuType.Troops, delegate
		{
			List<Fighter> list = new List<Fighter>();
			List<Fighter> list2 = new List<Fighter>();
			foreach (int key in m_Fighter.Keys)
			{
				if (m_Fighter[key].IsSelf)
				{
					list.Add(m_Fighter[key].Fighter);
					if (m_Fighter[key].Fighter.HasTrait(Define.UserTrait.ZhuangZaiJi))
					{
						foreach (Fighter item in m_Fighter[key].CarryFighter)
						{
							list2.Add(item);
						}
					}
				}
			}
			AudioManager.Instance.PlaySE(0);
			MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowTroops(list, list2));
		});
		if (GameDataBase.Instance.Item.Count > 0)
		{
			dictionary.Add(Define.MenuType.Tool, delegate
			{
				AudioManager.Instance.PlaySE(0);
				MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowTools(GameDataBase.Instance.Item));
			});
		}
		dictionary.Add(Define.MenuType.Cancel, delegate
		{
			m_GameState = Define.GameState.Wait;
			AudioManager.Instance.PlaySE(0);
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
		});
		MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowMenu(dictionary));
		string task = "回合:" + m_RepriseNum + "\n金钱:" + GameDataBase.Instance.NowMoney + "\n目标:\n" + m_Level.Task;
		MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowTask(task));
	}

	private void DoStartEvent(Define.GameState last)
	{
		if (m_GameState != Define.GameState.DoEvent)
		{
			m_EventLastGameState = last;
			m_GameState = Define.GameState.DoEvent;
		}
	}

	private void DoAttackAll(int attackID, int weaponID, List<int> target, bool beginMapState = true)
	{
		int indexBGM = ((m_GameState != Define.GameState.Wait) ? m_Level.EnemyBGM : m_Level.SelfBGM);
		Fighter fighter = m_Fighter[attackID].Fighter;
		Weapon weapon = GameDataBase.Instance.GetWeapon(weaponID);
		DoStartEvent(m_GameState);
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_PlayBGM(fighter.BGM));
		list.Add(new GameEvent_MapLock());
		list.Add(new GameEvent_LookFighter(attackID));
		list.Add(new GameEvent_Dialogue(fighter.RobotName + "出发! 使用" + weapon.Name + " 攻击 !", fighter.UserName, fighter.Hand, Vector2.zero));
		int num = 0;
		int num2 = 0;
		foreach (int item in target)
		{
			Fighter fighter2 = m_Fighter[item].Fighter;
			Terrain.TerrainType terrainType = m_MapData[fighter2.X][fighter2.Y].TerrainType;
			int num3 = (Robot.EngineType)((fighter2.EngineType == Robot.EngineType.Sky) ? 2 : ((terrainType != Terrain.TerrainType.Sea) ? 1 : 0)) switch
			{
				Robot.EngineType.Land => weapon.FireLand, 
				Robot.EngineType.Sea => weapon.FireSea, 
				_ => weapon.FireSky, 
			};
			int num4 = ((num3 != 0) ? (num3 + fighter.Str - fighter2.Def) : 0);
			int num5 = fighter.Agi - fighter2.Agi + weapon.Hit;
			if (UnityEngine.Random.Range(0, 100) >= num5)
			{
				num4 = 0;
			}
			else
			{
				if (fighter.HasState(Define.UserStatus.QiangGong))
				{
					num4 *= 2;
				}
				if (fighter.HasState(Define.UserStatus.ReXue))
				{
					num4 *= 3;
				}
				if (fighter2.HasState(Define.UserStatus.FangShou))
				{
					fighter2.State.Clear();
					num4 /= 2;
				}
			}
			int nHP = fighter2.NHP;
			list.Add(new GameEvent_LookFighter(item));
			list.Add(new GameEvent_Damage(item, (num4 <= nHP) ? num4 : nHP));
			if (num4 >= nHP)
			{
				list.Add(new GameEvent_ActorDie(item));
				num2 += fighter2.Money;
				num += Define.GetKillExp(fighter.Level, fighter2.Level, fighter2.Exp);
				GameEvent[] fighterEvent = m_Level.GetFighterEvent(item);
				if (fighterEvent != null)
				{
					list.AddRange(fighterEvent);
				}
			}
		}
		if ((num > 0 || num2 > 0) && fighter.IsSelf && fighter.AIType == Define.AIType.Null)
		{
			if (fighter.HasTrait(Define.UserTrait.KuaiSuXueXi))
			{
				num *= 2;
				list.Add(new GameEvent_Dialogue("经验获得提升 !", fighter.UserName, fighter.Hand, Vector2.zero));
			}
			list.Add(new GameEvent_LookFighter(attackID));
			list.Add(new GameEvent_Dialogue("获得经验 " + num + "获得金钱" + num2, fighter.UserName, fighter.Hand, Vector2.zero));
			list.Add(new GameEvent_SetSuccess(6, num2));
			list.Add(new GameEvent_AddExp(attackID, num));
			list.Add(new GameEvent_AddMoney(num2));
		}
		list.Add(new GameEvent_SetAction(attackID, action: true));
		if (beginMapState)
		{
			list.Add(new GameEvent_MapUnlock());
		}
		list.Add(new GameEvent_PlayBGM(indexBGM));
		GameEvent[] attackEvent = m_Level.AttackEvent;
		if (attackEvent != null)
		{
			list.AddRange(attackEvent);
		}
		AddGameEvent(list);
		fighter.State.Clear();
	}

	private List<GameEvent> BattleEvent(BattleData data, BattleData.BattleStatus status)
	{
		List<GameEvent> list = new List<GameEvent>();
		if (status == BattleData.BattleStatus.Counter || status == BattleData.BattleStatus.DoubleCounter || status == BattleData.BattleStatus.DoubleAttack)
		{
			if (data.WeaponA == null)
			{
				list.Add(new GameEvent_LookFighter(data.Attacker.ID));
				switch (status)
				{
				case BattleData.BattleStatus.Counter:
					list.Add(new GameEvent_Dialogue(data.Attacker.RobotName + "反击不能 ! 可恶 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
					break;
				case BattleData.BattleStatus.DoubleCounter:
					list.Add(new GameEvent_Dialogue(data.Attacker.RobotName + "二次反击不能 ! 可恶 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
					break;
				}
				return list;
			}
			if (data.Target.HasTrait(Define.UserTrait.FanJiZuZhi) && UnityEngine.Random.Range(0, 100) < 30)
			{
				if (status == BattleData.BattleStatus.DoubleAttack || status == BattleData.BattleStatus.DoubleCounter)
				{
					list.Add(new GameEvent_Dialogue("还没有结束 !使用" + data.WeaponA.Name + "再次攻击 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
				}
				list.Add(new GameEvent_LookFighter(data.Target.ID));
				list.Add(new GameEvent_Dialogue(data.Target.RobotName + "释放干扰电波 !", data.Target.UserName, data.Target.Hand, Vector2.zero));
				list.Add(new GameEvent_LookFighter(data.Attacker.ID));
				switch (status)
				{
				case BattleData.BattleStatus.Counter:
					list.Add(new GameEvent_Dialogue("反击被干扰 ! 无法反击!", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
					break;
				case BattleData.BattleStatus.DoubleAttack:
					list.Add(new GameEvent_Dialogue("二次攻击被干扰 ! 无法攻击 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
					break;
				case BattleData.BattleStatus.DoubleCounter:
					list.Add(new GameEvent_Dialogue("二次反击被干扰 ! 无法反击 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
					break;
				}
				return list;
			}
		}
		list.Add(new GameEvent_LookFighter(data.Attacker.ID));
		if (status == BattleData.BattleStatus.Attack || status == BattleData.BattleStatus.Counter)
		{
			list.Add(new GameEvent_Dialogue("距离" + data.Distance + "命中" + data.HitA, data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
		}
		switch (status)
		{
		case BattleData.BattleStatus.Attack:
			list.Add(new GameEvent_Dialogue(data.Attacker.RobotName + "出发! 使用" + data.WeaponA.Name + " 攻击 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
			break;
		case BattleData.BattleStatus.Counter:
			list.Add(new GameEvent_Dialogue(data.Attacker.RobotName + "出发! 使用" + data.WeaponA.Name + " 反击 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
			break;
		case BattleData.BattleStatus.DoubleAttack:
			list.Add(new GameEvent_Dialogue("还没有结束 !" + data.Attacker.RobotName + "使用" + data.WeaponA.Name + "再次攻击 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
			break;
		case BattleData.BattleStatus.DoubleCounter:
			list.Add(new GameEvent_Dialogue("反击加倍 !" + data.Attacker.RobotName + "使用" + data.WeaponA.Name + "再来一次 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
			break;
		}
		if (data.Distance > 1 && data.Target.HasTrait(Define.UserTrait.JianJieWuXiao))
		{
			list.Add(new GameEvent_LookFighter(data.Target.ID));
			list.Add(new GameEvent_Damage(data.Target.ID, 0));
			list.Add(new GameEvent_Dialogue(data.Target.RobotName + "毫发无伤 !", data.Target.UserName, data.Target.Hand, Vector2.zero));
			list.Add(new GameEvent_LookFighter(data.Attacker.ID));
			list.Add(new GameEvent_Dialogue("间接攻击行不通!", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
		}
		else if (UnityEngine.Random.Range(0, 100) >= data.HitA)
		{
			list.Add(new GameEvent_LookFighter(data.Target.ID));
			list.Add(new GameEvent_Damage(data.Target.ID, 0));
			switch (status)
			{
			case BattleData.BattleStatus.Attack:
				list.Add(new GameEvent_Dialogue(data.Target.RobotName + "毫发无伤 ! 速度太慢了 !", data.Target.UserName, data.Target.Hand, Vector2.zero));
				list.Add(new GameEvent_LookFighter(data.Attacker.ID));
				list.Add(new GameEvent_Dialogue(" 等着瞧!!", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
				break;
			case BattleData.BattleStatus.Counter:
				list.Add(new GameEvent_Dialogue("你还差得远呢 !", data.Target.UserName, data.Target.Hand, Vector2.zero));
				list.Add(new GameEvent_LookFighter(data.Attacker.ID));
				list.Add(new GameEvent_Dialogue("果然还是不行吗 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
				break;
			case BattleData.BattleStatus.DoubleAttack:
				list.Add(new GameEvent_Dialogue("想得美 ! 快速闪避 !", data.Target.UserName, data.Target.Hand, Vector2.zero));
				list.Add(new GameEvent_LookFighter(data.Attacker.ID));
				list.Add(new GameEvent_Dialogue("失误失误 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
				break;
			case BattleData.BattleStatus.DoubleCounter:
				list.Add(new GameEvent_Dialogue("哼 ! 你还差得远呢 ! ", data.Target.UserName, data.Target.Hand, Vector2.zero));
				list.Add(new GameEvent_LookFighter(data.Attacker.ID));
				list.Add(new GameEvent_Dialogue("可惜! 这次放过你 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
				break;
			}
		}
		else
		{
			int num = data.FireA;
			if (data.Attacker.HasTrait(Define.UserTrait.KuoNengZhuangZhi) && UnityEngine.Random.Range(0, 100) < 30)
			{
				num += data.Attacker.Str;
				list.Add(new GameEvent_Dialogue(data.Attacker.RobotName + "启用扩能装置 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
			}
			list.Add(new GameEvent_LookFighter(data.Target.ID));
			if (data.Target.HasTrait(Define.UserTrait.FangYuTiXi))
			{
				num -= data.Target.Def / 2;
				list.Add(new GameEvent_Dialogue(data.Target.RobotName + "拥有防御系统 !", data.Target.UserName, data.Target.Hand, Vector2.zero));
			}
			if (data.Target.HasTrait(Define.UserTrait.GuangDunFangYu) && UnityEngine.Random.Range(0, 100) < 30)
			{
				num /= 2;
				list.Add(new GameEvent_Dialogue(data.Target.RobotName + "使用光盾防御 !", data.Target.UserName, data.Target.Hand, Vector2.zero));
			}
			if (data.Attacker.HasState(Define.UserStatus.QiangGong))
			{
				num *= 2;
			}
			if (data.Attacker.HasState(Define.UserStatus.ReXue))
			{
				num *= 3;
			}
			if (data.Target.HasState(Define.UserStatus.FangShou))
			{
				num /= 2;
			}
			num = ((num <= data.Target.NHP) ? num : data.Target.NHP);
			num = ((num >= 0) ? num : 0);
			data.DamageT += num;
			list.Add(new GameEvent_Damage(data.Target.ID, num));
			list.Add(new GameEvent_Dialogue(data.Target.RobotName + "受到损伤" + num + "!", data.Target.UserName, data.Target.Hand, Vector2.zero));
			list.Add(new GameEvent_LookFighter(data.Attacker.ID));
			switch (status)
			{
			case BattleData.BattleStatus.Attack:
				list.Add(new GameEvent_Dialogue(" 干的漂亮 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
				break;
			case BattleData.BattleStatus.Counter:
				list.Add(new GameEvent_Dialogue(" 反击成功 !", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
				break;
			}
			if (data.Attacker.HasTrait(Define.UserTrait.GongJiXiXue))
			{
				int num2 = num / 5;
				int num3 = data.Attacker.HP - (data.Attacker.NHP - data.DamageA);
				if (num2 > num3)
				{
					num2 = num3;
				}
				if (num2 > 0)
				{
					list.Add(new GameEvent_Damage(data.Attacker.ID, -num2));
					list.Add(new GameEvent_Dialogue("机体修复 " + num2 + "!", data.Attacker.UserName, data.Attacker.Hand, Vector2.zero));
				}
			}
			if (data.DamageT >= data.Target.NHP)
			{
				list.Add(new GameEvent_LookFighter(data.Target.ID));
				list.Add(new GameEvent_ActorDie(data.Target.ID));
			}
		}
		return list;
	}

	private void DoBattle(int attackID, int weaponID, int targetID)
	{
		MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
		bool flag = m_ScrollRect.enabled;
		Fighter fighter = m_Fighter[attackID].Fighter;
		Weapon weapon = GameDataBase.Instance.GetWeapon(weaponID);
		if (weapon.All)
		{
			DoAttackAll(attackID, weaponID, SkillHasTarget(new Define.Point(fighter.X, fighter.Y), weaponID, fighter.IsSelf), flag);
			return;
		}
		Fighter fighter2 = m_Fighter[targetID].Fighter;
		Weapon weapon2 = null;
		int num = Math.Abs(fighter.X - fighter2.X) + Math.Abs(fighter.Y - fighter2.Y);
		Terrain.TerrainType terrainType = m_MapData[fighter.X][fighter.Y].TerrainType;
		Terrain.TerrainType terrainType2 = m_MapData[fighter2.X][fighter2.Y].TerrainType;
		Robot.EngineType engineType = ((fighter.EngineType == Robot.EngineType.Sky) ? Robot.EngineType.Sky : ((terrainType != Terrain.TerrainType.Sea) ? Robot.EngineType.Land : Robot.EngineType.Sea));
		Robot.EngineType engineType2 = ((fighter2.EngineType == Robot.EngineType.Sky) ? Robot.EngineType.Sky : ((terrainType2 != Terrain.TerrainType.Sea) ? Robot.EngineType.Land : Robot.EngineType.Sea));
		if (fighter.IsSelf == fighter2.IsSelf && weapon.Cure && weapon.Range >= num)
		{
			DoStartEvent(m_GameState);
			List<GameEvent> list = new List<GameEvent>();
			int num2 = fighter.Str * 2;
			if (num2 > fighter2.HP - fighter2.NHP)
			{
				num2 = fighter2.HP - fighter2.NHP;
			}
			list.Add(new GameEvent_MapLock());
			list.Add(new GameEvent_LookFighter(targetID));
			list.Add(new GameEvent_Damage(targetID, -num2));
			list.Add(new GameEvent_Dialogue(fighter2.RobotName + "受到" + num2 + "治疗!", fighter2.UserName, fighter2.Hand, Vector2.zero));
			list.Add(new GameEvent_SetAction(attackID, action: true));
			if (flag)
			{
				list.Add(new GameEvent_MapUnlock());
			}
			AddGameEvent(list);
			return;
		}
		foreach (int item in fighter2.Weapon)
		{
			Weapon weapon3 = GameDataBase.Instance.GetWeapon(item);
			if ((weapon3.Range > 1 && num == 1) || num > weapon3.Range)
			{
				continue;
			}
			if (weapon2 == null)
			{
				switch (engineType)
				{
				case Robot.EngineType.Land:
					if (weapon3.FireLand > 0)
					{
						weapon2 = weapon3;
					}
					break;
				case Robot.EngineType.Sea:
					if (weapon3.FireSea > 0)
					{
						weapon2 = weapon3;
					}
					break;
				case Robot.EngineType.Sky:
					if (weapon3.FireSky > 0)
					{
						weapon2 = weapon3;
					}
					break;
				}
				continue;
			}
			switch (engineType)
			{
			case Robot.EngineType.Land:
				if (weapon3.FireLand > weapon2.FireLand)
				{
					weapon2 = weapon3;
				}
				break;
			case Robot.EngineType.Sea:
				if (weapon3.FireSea > weapon2.FireSea)
				{
					weapon2 = weapon3;
				}
				break;
			case Robot.EngineType.Sky:
				if (weapon3.FireSky > weapon2.FireSky)
				{
					weapon2 = weapon3;
				}
				break;
			}
		}
		Fighter fighter3 = ((fighter.Agi - fighter2.Agi > 50) ? fighter : ((fighter2.Agi - fighter.Agi <= 50 || weapon2 == null) ? null : fighter2));
		int num3 = weapon.Hit + fighter.Agi - fighter2.Agi;
		int num4 = ((weapon2 != null) ? (weapon2.Hit + fighter2.Agi - fighter.Agi) : 0);
		num3 = num3 * Define.GetTerrainHit(terrainType2) / 100;
		num4 = num4 * Define.GetTerrainHit(terrainType) / 100;
		if (num > 1)
		{
			for (int i = 1; i < num; i++)
			{
				if (!weapon.IgnoreDis)
				{
					num3 -= num3 / 20 + 1;
				}
				if (weapon2 != null && !weapon2.IgnoreDis)
				{
					num4 -= num4 / 20 + 1;
				}
			}
		}
		int num5 = engineType2 switch
		{
			Robot.EngineType.Land => weapon.FireLand, 
			Robot.EngineType.Sea => weapon.FireSea, 
			_ => weapon.FireSky, 
		};
		int num6 = ((weapon2 != null) ? (engineType switch
		{
			Robot.EngineType.Land => weapon2.FireLand, 
			Robot.EngineType.Sea => weapon2.FireSea, 
			_ => weapon2.FireSky, 
		}) : 0);
		int num7 = ((num5 != 0) ? (num5 + fighter.Str - fighter2.Def) : 0);
		int num8 = ((num6 != 0) ? (num6 + fighter2.Str - fighter.Def) : 0);
		num7 = ((num7 >= 0) ? num7 : 0);
		num8 = ((num8 >= 0) ? num8 : 0);
		int indexBGM = ((m_GameState != Define.GameState.Wait) ? m_Level.EnemyBGM : m_Level.SelfBGM);
		int indexBGM2 = (fighter2.IsSelf ? ((fighter.BGM != -1) ? fighter.BGM : fighter2.BGM) : ((fighter2.BGM != -1) ? fighter2.BGM : fighter.BGM));
		DoStartEvent(m_GameState);
		List<GameEvent> list2 = new List<GameEvent>();
		list2.Add(new GameEvent_PlayBGM(indexBGM2));
		list2.Add(new GameEvent_MapLock());
		Fighter fighter4 = null;
		Fighter fighter5 = null;
		if (fighter.HasState(Define.UserStatus.MiaoZhun))
		{
			num3 += 10;
		}
		if (fighter2.HasState(Define.UserStatus.MiaoZhun))
		{
			num4 += 10;
		}
		if (fighter.HasState(Define.UserStatus.BiSha))
		{
			num3 = 100;
		}
		if (fighter2.HasState(Define.UserStatus.BiSha))
		{
			num4 = 100;
		}
		num3 = ((num3 <= 100) ? num3 : 100);
		num4 = ((num4 <= 100) ? num4 : 100);
		if (fighter.HasState(Define.UserStatus.HuiBi))
		{
			num4 = 0;
		}
		if (fighter2.HasState(Define.UserStatus.HuiBi))
		{
			num3 = 0;
		}
		if (fighter.HasState(Define.UserStatus.GanRao))
		{
			num3 /= 2;
		}
		if (fighter2.HasState(Define.UserStatus.GanRao))
		{
			num4 /= 2;
		}
		if (fighter.HasTrait(Define.UserTrait.MinZhongGanRao) && UnityEngine.Random.Range(0, 100) < 30)
		{
			num4 -= 30;
			list2.Add(new GameEvent_LookFighter(attackID));
			list2.Add(new GameEvent_Dialogue("释放米诺夫粒子! 干扰成功 ", fighter.UserName, fighter.Hand, Vector2.zero));
		}
		if (fighter2.HasTrait(Define.UserTrait.MinZhongGanRao) && UnityEngine.Random.Range(0, 100) < 30)
		{
			num3 -= 30;
			list2.Add(new GameEvent_LookFighter(targetID));
			list2.Add(new GameEvent_Dialogue("释放米诺夫粒子! 干扰成功 ", fighter2.UserName, fighter2.Hand, Vector2.zero));
		}
		num3 = ((num3 >= 0) ? num3 : 0);
		num4 = ((num4 >= 0) ? num4 : 0);
		BattleData battleData = new BattleData();
		battleData.Distance = num;
		battleData.Attacker = fighter;
		battleData.HitA = num3;
		battleData.FireA = num7;
		battleData.WeaponA = weapon;
		battleData.Target = fighter2;
		battleData.HitT = num4;
		battleData.FireT = num8;
		battleData.WeaponT = weapon2;
		list2.AddRange(BattleEvent(battleData, BattleData.BattleStatus.Attack));
		if (battleData.DamageT >= battleData.Target.NHP)
		{
			fighter4 = battleData.Target;
			fighter5 = battleData.Attacker;
		}
		else
		{
			battleData.Swop();
			list2.AddRange(BattleEvent(battleData, BattleData.BattleStatus.Counter));
			if (battleData.DamageT >= battleData.Target.NHP)
			{
				fighter4 = battleData.Target;
				fighter5 = battleData.Attacker;
			}
			else if (fighter3 != null)
			{
				battleData.SetDouble(fighter3.ID);
				if (fighter3 == fighter)
				{
					list2.AddRange(BattleEvent(battleData, BattleData.BattleStatus.DoubleAttack));
				}
				else
				{
					list2.AddRange(BattleEvent(battleData, BattleData.BattleStatus.DoubleCounter));
				}
				if (battleData.DamageT >= battleData.Target.NHP)
				{
					fighter4 = battleData.Target;
					fighter5 = battleData.Attacker;
				}
			}
		}
		GameEvent[] attackEvent = m_Level.AttackEvent;
		if (attackEvent != null)
		{
			list2.AddRange(attackEvent);
		}
		if (fighter4 != null && fighter5 != null)
		{
			if (!fighter4.IsSelf)
			{
				if (fighter5.AIType == Define.AIType.Null)
				{
					list2.Add(new GameEvent_MapMove(fighter5.X, fighter5.Y));
					GameDataBase.Instance.NowMoney += fighter4.Money;
					list2.Add(new GameEvent_SetSuccess(6, fighter4.Money));
					int num9 = Define.GetKillExp(fighter5.Level, fighter4.Level, fighter4.Exp);
					if (fighter5.HasTrait(Define.UserTrait.KuaiSuXueXi))
					{
						num9 *= 2;
						list2.Add(new GameEvent_Dialogue("经验获得提升 !", fighter5.UserName, fighter5.Hand, Vector2.zero));
					}
					list2.Add(new GameEvent_Dialogue("获得经验 " + num9 + "获得金钱" + fighter4.Money, fighter5.UserName, fighter5.Hand, Vector2.zero));
					list2.Add(new GameEvent_AddExp(fighter5.ID, num9));
				}
			}
			else
			{
				m_DamageFighter.Add(fighter4);
				list2.Add(new GameEvent_Dialogue("对不起...", fighter4.UserName, fighter4.Hand, Vector2.zero));
				foreach (Fighter item2 in m_Fighter[fighter4.ID].CarryFighter)
				{
					m_DamageFighter.Add(item2);
					GameEvent[] fighterEvent = m_Level.GetFighterEvent(item2.ID);
					if (fighterEvent != null)
					{
						list2.AddRange(fighterEvent);
					}
				}
			}
			GameEvent[] fighterEvent2 = m_Level.GetFighterEvent(fighter4.ID);
			if (fighterEvent2 != null)
			{
				list2.AddRange(fighterEvent2);
			}
		}
		if (fighter5 != null && fighter5.HasTrait(Define.UserTrait.JiShaZaiDong))
		{
			list2.Add(new GameEvent_ShowEffect(attackID, 0));
		}
		else
		{
			list2.Add(new GameEvent_SetAction(attackID, action: true));
		}
		if (flag)
		{
			list2.Add(new GameEvent_MapUnlock());
		}
		list2.Add(new GameEvent_PlayBGM(indexBGM));
		AddGameEvent(list2);
		fighter.State.Clear();
		fighter2.State.Clear();
	}

	private bool BannedClick()
	{
		if (m_GameState == Define.GameState.Enemy || m_GameState == Define.GameState.Enemy_Attack || m_GameState == Define.GameState.Enemy_Move || m_GameState == Define.GameState.Enemy_Move_Attack || m_GameState == Define.GameState.Enemy_Attack_Ready || m_GameState == Define.GameState.Enemy_Move_Ready || m_GameState == Define.GameState.Enemy_Move_Attack_Ready || m_GameState == Define.GameState.SelfAI || m_GameState == Define.GameState.SelfAI_Attack || m_GameState == Define.GameState.SelfAI_Attack_Ready || m_GameState == Define.GameState.SelfAI_Move || m_GameState == Define.GameState.SelfAI_Move_Attack || m_GameState == Define.GameState.SelfAI_Move_Attack_Ready || m_GameState == Define.GameState.SelfAI_Move_Ready || m_GameState == Define.GameState.TakeOffing || m_GameState == Define.GameState.Moveing || m_GameState == Define.GameState.DoEvent || m_GameState == Define.GameState.DoEvent_Wait || m_GameState == Define.GameState.DoEvent_Effect || m_GameState == Define.GameState.DoEvent_Move || m_GameState == Define.GameState.DoEvent_Time)
		{
			return true;
		}
		return false;
	}

	private List<int> OnCanCapitulate(int id)
	{
		List<int> list = new List<int>();
		foreach (int key in m_Fighter.Keys)
		{
			if (id != key && m_Level.CanCapitulate(id, key) && GetDistance(new Define.Point(m_Fighter[id].X, m_Fighter[id].Y), new Define.Point(m_Fighter[key].X, m_Fighter[key].Y)) == 1)
			{
				list.Add(key);
			}
		}
		return list;
	}

	private void ClickFighter(object prame)
	{
		AudioManager.Instance.PlaySE(0);
		if (BannedClick())
		{
			return;
		}
		if (m_GameState == Define.GameState.Spirit_Two)
		{
			m_GameState = Define.GameState.Wait;
			ResetMapShow();
			m_Fighter[m_TargetOne.ID].UseSpiritID = -1;
			m_TargetOne = null;
			m_TargetTwo = null;
			return;
		}
		if (m_GameState == Define.GameState.TakeOff_Ready)
		{
			m_TargetOne = null;
			m_TargetTwo = null;
			ResetMapShow();
			m_GameState = Define.GameState.Wait;
			return;
		}
		if (m_GameState == Define.GameState.Move_Over)
		{
			m_GameState = Define.GameState.Wait;
			m_Fighter[m_TargetOne.ID].LoadPoint();
			m_Fighter[m_TargetOne.ID].SetPosition(m_MapData[m_TargetOne.X][m_TargetOne.Y].Position);
			m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
			m_TargetOne = null;
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			return;
		}
		if (m_GameState == Define.GameState.TakeOff_Over)
		{
			m_GameState = Define.GameState.Wait;
			m_Fighter[m_TargetOne.ID].gameObject.SetActive(value: false);
			m_Fighter[m_TargetTwo.ID].Carry(m_TargetOne);
			m_Fighter[m_TargetOne.ID].ThisCarry = m_TargetTwo;
			m_TargetOne = null;
			m_TargetTwo = null;
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			return;
		}
		MsgDefine.MsgPrame_ClickFighter data = (MsgDefine.MsgPrame_ClickFighter)prame;
		if (m_GameState == Define.GameState.Move_Ready)
		{
			if (m_TargetOne != null && data.ClickFighter.HasTrait(Define.UserTrait.ZhuangZaiJi))
			{
				if (m_TargetOne.ID == data.ClickFighter.ID)
				{
					m_TargetOne = null;
					ResetMapShow();
					m_GameState = Define.GameState.Wait;
					return;
				}
				m_TargetTwo = data.ClickFighter;
				List<Define.Point> movePath = m_TargetOne.GetMovePath(new Define.Point(m_TargetTwo.X, m_TargetTwo.Y));
				if (movePath != null)
				{
					m_GameState = Define.GameState.Moveing;
					m_MapData[m_TargetOne.X][m_TargetOne.Y].TakeOff();
					m_Fighter[m_TargetOne.ID].DoMovePath(movePath);
					LookFighter = m_Fighter[m_TargetOne.ID];
					ResetMapShow();
					return;
				}
			}
			m_TargetOne = null;
			ResetMapShow();
			m_GameState = Define.GameState.Wait;
			return;
		}
		if (m_GameState == Define.GameState.Spirit_One)
		{
			if (m_TargetOne == null)
			{
				Debug.Log("error Target is null !");
				return;
			}
			UseSpirit(m_TargetOne, m_Fighter[m_TargetOne.ID].UseSpiritID, data.ClickFighter);
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			return;
		}
		if (m_GameState == Define.GameState.Tools_One)
		{
			if (m_UseToolsID == -1)
			{
				Debug.Log("error tools id !");
				return;
			}
			UseTools(data.ClickFighter, m_UseToolsID);
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			return;
		}
		if (m_Fighter[data.ClickFighter.ID].ThisCarry != null)
		{
			if (data.ClickFighter.IsAction)
			{
				AudioManager.Instance.PlaySE(0);
				MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
				MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowHint(data.ClickFighter));
				return;
			}
			Dictionary<Define.MenuType, UnityAction> dictionary = new Dictionary<Define.MenuType, UnityAction>();
			dictionary.Add(Define.MenuType.TakeOff, delegate
			{
				AudioManager.Instance.PlaySE(0);
				MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
				MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_DoTakeOff(m_Fighter[data.ClickFighter.ID].ThisCarry, data.ClickFighter));
			});
			dictionary.Add(Define.MenuType.State, delegate
			{
				AudioManager.Instance.PlaySE(0);
				MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
				MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowHint(data.ClickFighter));
			});
			dictionary.Add(Define.MenuType.Cancel, delegate
			{
				AudioManager.Instance.PlaySE(0);
				MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			});
			MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowMenu(dictionary));
			return;
		}
		if (m_GameState == Define.GameState.Attack_Ready)
		{
			m_GameState = Define.GameState.Wait;
			m_TargetOne = null;
			ResetMapShow();
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			return;
		}
		if (m_GameState == Define.GameState.Move_Attack_Ready)
		{
			m_GameState = Define.GameState.Wait;
			m_Fighter[m_TargetOne.ID].LoadPoint();
			m_Fighter[m_TargetOne.ID].SetPosition(m_MapData[m_TargetOne.X][m_TargetOne.Y].Position);
			m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
			m_TargetOne = null;
			ResetMapShow();
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			return;
		}
		if (m_GameState == Define.GameState.TakeOff_Attack_Ready)
		{
			m_GameState = Define.GameState.Wait;
			m_Fighter[m_TargetOne.ID].gameObject.SetActive(value: false);
			m_Fighter[m_TargetTwo.ID].Carry(m_TargetOne);
			m_Fighter[m_TargetOne.ID].ThisCarry = m_TargetTwo;
			m_TargetOne = null;
			m_TargetTwo = null;
			ResetMapShow();
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			return;
		}
		if (m_GameState == Define.GameState.Attack && m_TargetOne != null)
		{
			if (data.ClickFighter.IsSelf)
			{
				if (m_Fighter[m_TargetOne.ID].CanDoAttack(data.ClickFighter.ID))
				{
					m_GameState = Define.GameState.Wait;
					m_TargetOne.IsAction = true;
					ResetMapShow();
					DoBattle(m_TargetOne.ID, m_Fighter[m_TargetOne.ID].UseWeaponID, data.ClickFighter.ID);
					m_Fighter[m_TargetOne.ID].CanAttackTraget = null;
					m_Fighter[m_TargetOne.ID].UseWeaponID = -1;
					m_TargetOne = null;
				}
				else
				{
					m_GameState = Define.GameState.Wait;
					if (m_TargetOne.ID == data.ClickFighter.ID)
					{
						MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
					}
					m_TargetOne = null;
					ResetMapShow();
				}
			}
			else if (m_Fighter[m_TargetOne.ID].CanDoAttack(data.ClickFighter.ID))
			{
				m_GameState = Define.GameState.Wait;
				ResetMapShow();
				DoBattle(m_TargetOne.ID, m_Fighter[m_TargetOne.ID].UseWeaponID, data.ClickFighter.ID);
				m_Fighter[m_TargetOne.ID].CanAttackTraget = null;
				m_Fighter[m_TargetOne.ID].UseWeaponID = -1;
				m_TargetOne = null;
			}
			return;
		}
		if (m_GameState == Define.GameState.Move_Attack && m_TargetOne != null)
		{
			if (data.ClickFighter.IsSelf)
			{
				if (m_Fighter[m_TargetOne.ID].CanDoAttack(data.ClickFighter.ID))
				{
					m_GameState = Define.GameState.Wait;
					m_TargetOne.IsAction = true;
					ResetMapShow();
					DoBattle(m_TargetOne.ID, m_Fighter[m_TargetOne.ID].UseWeaponID, data.ClickFighter.ID);
					m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
					m_Fighter[m_TargetOne.ID].CanAttackTraget = null;
					m_Fighter[m_TargetOne.ID].UseWeaponID = -1;
					ChooseMoveOverEvent();
					Define.Point key = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
					if (m_Level.ShopEvent.ContainsKey(key))
					{
						DoStartEvent(m_GameState);
						m_GameEvent.AddRange(m_Level.ShopEvent[key]);
					}
					m_TargetOne = null;
				}
				else
				{
					m_GameState = Define.GameState.Wait;
					m_Fighter[m_TargetOne.ID].LoadPoint();
					m_Fighter[m_TargetOne.ID].SetPosition(m_MapData[m_TargetOne.X][m_TargetOne.Y].Position);
					m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
					if (m_TargetOne.ID == data.ClickFighter.ID)
					{
						MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
					}
					m_TargetOne = null;
					ResetMapShow();
				}
			}
			else if (m_Fighter[m_TargetOne.ID].CanDoAttack(data.ClickFighter.ID))
			{
				m_GameState = Define.GameState.Wait;
				ResetMapShow();
				DoBattle(m_TargetOne.ID, m_Fighter[m_TargetOne.ID].UseWeaponID, data.ClickFighter.ID);
				m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
				m_Fighter[m_TargetOne.ID].CanAttackTraget = null;
				m_Fighter[m_TargetOne.ID].UseWeaponID = -1;
				ChooseMoveOverEvent();
				Define.Point key2 = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
				if (m_Level.ShopEvent.ContainsKey(key2))
				{
					DoStartEvent(m_GameState);
					m_GameEvent.AddRange(m_Level.ShopEvent[key2]);
				}
				m_TargetOne = null;
			}
			return;
		}
		if (m_GameState == Define.GameState.TakeOff_Attack && m_TargetOne != null)
		{
			if (data.ClickFighter.IsSelf)
			{
				if (m_Fighter[m_TargetOne.ID].CanDoAttack(data.ClickFighter.ID))
				{
					m_GameState = Define.GameState.Wait;
					m_TargetOne.IsAction = true;
					ResetMapShow();
					DoBattle(m_TargetOne.ID, m_Fighter[m_TargetOne.ID].UseWeaponID, data.ClickFighter.ID);
					m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
					m_Fighter[m_TargetOne.ID].CanAttackTraget = null;
					m_Fighter[m_TargetOne.ID].UseWeaponID = -1;
					ChooseMoveOverEvent();
					Define.Point key3 = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
					if (m_Level.ShopEvent.ContainsKey(key3))
					{
						DoStartEvent(m_GameState);
						m_GameEvent.AddRange(m_Level.ShopEvent[key3]);
					}
					m_TargetOne = null;
					m_TargetTwo = null;
				}
				else
				{
					m_GameState = Define.GameState.Wait;
					m_Fighter[m_TargetOne.ID].gameObject.SetActive(value: false);
					m_Fighter[m_TargetTwo.ID].Carry(m_TargetOne);
					m_Fighter[m_TargetOne.ID].ThisCarry = m_TargetTwo;
					if (m_TargetOne.ID == data.ClickFighter.ID)
					{
						MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
					}
					m_TargetOne = null;
					m_TargetTwo = null;
					ResetMapShow();
				}
			}
			else if (m_Fighter[m_TargetOne.ID].CanDoAttack(data.ClickFighter.ID))
			{
				m_GameState = Define.GameState.Wait;
				ResetMapShow();
				DoBattle(m_TargetOne.ID, m_Fighter[m_TargetOne.ID].UseWeaponID, data.ClickFighter.ID);
				m_MapData[m_TargetOne.X][m_TargetOne.Y].Carry(m_TargetOne.ID);
				m_Fighter[m_TargetOne.ID].CanAttackTraget = null;
				m_Fighter[m_TargetOne.ID].UseWeaponID = -1;
				ChooseMoveOverEvent();
				Define.Point key4 = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
				if (m_Level.ShopEvent.ContainsKey(key4))
				{
					DoStartEvent(m_GameState);
					m_GameEvent.AddRange(m_Level.ShopEvent[key4]);
				}
				m_TargetOne = null;
				m_TargetTwo = null;
			}
			return;
		}
		if (data.ClickFighter == m_TargetOne)
		{
			m_TargetOne = null;
		}
		if (m_TargetTwo != null)
		{
			m_TargetTwo = null;
		}
		Dictionary<Define.MenuType, UnityAction> dictionary2 = new Dictionary<Define.MenuType, UnityAction>();
		if (data.ClickFighter.IsSelf && data.ClickFighter.AIType == Define.AIType.Null)
		{
			if (!data.ClickFighter.IsAction)
			{
				if (data.ClickFighter.Speed > 0 && !data.ClickFighter.HasTrait(Define.UserTrait.BuKeYiDong))
				{
					dictionary2.Add(Define.MenuType.Move, delegate
					{
						m_TargetOne = data.ClickFighter;
						m_TargetOne.CanMovePath = null;
						GetMoveRange(m_TargetOne);
						ShowMoveRange(m_TargetOne.GetCanMovePoint());
						m_GameState = Define.GameState.Move_Ready;
						m_Fighter[m_TargetOne.ID].SetBlack(black: false);
						m_Fighter[m_TargetOne.ID].SavePoint();
						AudioManager.Instance.PlaySE(0);
						MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
					});
				}
				List<int> canUseSpririt = data.ClickFighter.CanUseSpririt;
				List<int> RealyUseSpirit = new List<int>();
				foreach (int item in canUseSpririt)
				{
					bool flag = false;
					Spirit spirit = GameDataBase.Instance.GetSpirit(item);
					switch (spirit.Scope)
					{
					case Spirit.SpiritScope.Self:
						if (spirit.CanUse(data.ClickFighter))
						{
							flag = true;
						}
						break;
					case Spirit.SpiritScope.SelfOne:
					case Spirit.SpiritScope.SelfAll:
					case Spirit.SpiritScope.SelfOneOther:
						foreach (int key5 in m_Fighter.Keys)
						{
							if (!m_Fighter[key5].IsSelf || !spirit.CanUse(m_Fighter[key5].Fighter))
							{
								continue;
							}
							flag = true;
							break;
						}
						break;
					case Spirit.SpiritScope.EnemyOne:
					case Spirit.SpiritScope.EnemyAll:
						foreach (int key6 in m_Fighter.Keys)
						{
							if (m_Fighter[key6].IsSelf || !spirit.CanUse(m_Fighter[key6].Fighter))
							{
								continue;
							}
							flag = true;
							break;
						}
						break;
					}
					if (flag)
					{
						RealyUseSpirit.Add(item);
					}
				}
				if (RealyUseSpirit.Count > 0)
				{
					dictionary2.Add(Define.MenuType.Spirit, delegate
					{
						AudioManager.Instance.PlaySE(0);
						MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowSpirit(data.ClickFighter.ID, RealyUseSpirit));
					});
				}
				int ClickFighterDataCount = data.ClickFighter.ActorDataList.Count;
				if (ClickFighterDataCount == 2)
				{
					dictionary2.Add(Define.MenuType.Deform, delegate
					{
						AudioManager.Instance.PlaySE(0);
						MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
						MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_DoVariant(data.ClickFighter, data.ClickFighter.ActorDataList[(data.ClickFighter.NowActorDataIndex + 1) % ClickFighterDataCount]));
					});
				}
				else if (ClickFighterDataCount > 2)
				{
					dictionary2.Add(Define.MenuType.Deform, delegate
					{
						AudioManager.Instance.PlaySE(0);
						MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowAllVariant(data.ClickFighter));
					});
				}
				if (OnCanAttack(data.ClickFighter))
				{
					dictionary2.Add(Define.MenuType.Attack, delegate
					{
						m_GameState = Define.GameState.Attack_Ready;
						ShowHasTargetWeapon(data.ClickFighter);
					});
				}
				List<int> canCapitulateList = OnCanCapitulate(data.ClickFighter.ID);
				if (canCapitulateList.Count > 0)
				{
					dictionary2.Add(Define.MenuType.Capitulate, delegate
					{
						m_Fighter[data.ClickFighter.ID].IsAction = true;
						m_Fighter[data.ClickFighter.ID].SetBlack(black: true);
						DoStartEvent(m_GameState);
						m_GameEvent.AddRange(m_Level.GetCapitulateEvent(data.ClickFighter.ID, canCapitulateList[0]));
						AudioManager.Instance.PlaySE(0);
						MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
					});
				}
			}
			if (m_Fighter[data.ClickFighter.ID].CarryFighter.Count > 0)
			{
				dictionary2.Add(Define.MenuType.TakeOff, delegate
				{
					AudioManager.Instance.PlaySE(0);
					MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_TakeOff(data.ClickFighter, m_Fighter[data.ClickFighter.ID].CarryFighter));
				});
			}
		}
		if (dictionary2.Count > 0)
		{
			dictionary2.Add(Define.MenuType.Cancel, delegate
			{
				AudioManager.Instance.PlaySE(0);
				MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			});
			dictionary2.Add(Define.MenuType.State, delegate
			{
				AudioManager.Instance.PlaySE(0);
				MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
				MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowHint(data.ClickFighter));
			});
			MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowMenu(dictionary2));
			MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowBase(data.ClickFighter));
		}
		else
		{
			MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_CloseMenu));
			MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowHint(data.ClickFighter));
		}
	}

	private void ShowHasTargetWeapon(Fighter fighter)
	{
		List<int> list = new List<int>();
		foreach (int item in fighter.Weapon)
		{
			if (SkillHasTarget(new Define.Point(fighter.X, fighter.Y), item, fighter.IsSelf).Count > 0)
			{
				list.Add(item);
			}
		}
		MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowWeapon(fighter, list));
	}

	private bool OnCanAttack(Fighter fighter)
	{
		foreach (int item in fighter.Weapon)
		{
			if (SkillHasTarget(new Define.Point(fighter.X, fighter.Y), item).Count > 0)
			{
				return true;
			}
		}
		return false;
	}

	private void TryMoveOne(Define.MovePath startPath, Define.Point posEnd, bool isSelf, int speed, Robot.EngineType engineType, ref Dictionary<Define.Point, Define.MovePath> newPoint, ref Dictionary<Define.Point, Define.MovePath> allPoint, bool overlook)
	{
		int fighterID = m_MapData[posEnd.X][posEnd.Y].FighterID;
		bool flag = overlook || fighterID == -1 || isSelf == m_Fighter[fighterID].IsSelf;
		if (!m_MapData[posEnd.X][posEnd.Y].CanMove() || !flag)
		{
			return;
		}
		int num = startPath.Drag + Define.GetAffect(engineType, m_MapData[posEnd.X][posEnd.Y].TerrainType);
		if (allPoint.ContainsKey(posEnd))
		{
			if (num < allPoint[posEnd].Drag)
			{
				Define.MovePath value = default(Define.MovePath);
				value.Drag = num;
				value.Path = new List<Define.Point>(startPath.Path);
				value.Path.Add(posEnd);
				allPoint[posEnd] = value;
				if (newPoint.ContainsKey(posEnd))
				{
					newPoint[posEnd] = value;
				}
				else
				{
					newPoint.Add(posEnd, value);
				}
			}
		}
		else if (num <= speed)
		{
			Define.MovePath value2 = default(Define.MovePath);
			value2.Drag = num;
			value2.Path = new List<Define.Point>(startPath.Path);
			value2.Path.Add(posEnd);
			allPoint.Add(posEnd, value2);
			newPoint.Add(posEnd, value2);
		}
	}

	private void TryMoveOne(bool isSelf, Robot.EngineType type, int speed, ref Dictionary<Define.Point, Define.MovePath> newPoint, ref Dictionary<Define.Point, Define.MovePath> allPoint, bool overlook = false)
	{
		Dictionary<Define.Point, Define.MovePath> newPoint2 = new Dictionary<Define.Point, Define.MovePath>();
		foreach (Define.Point key in newPoint.Keys)
		{
			if (key.Y > 0)
			{
				TryMoveOne(newPoint[key], new Define.Point(key.X, key.Y - 1), isSelf, speed, type, ref newPoint2, ref allPoint, overlook);
			}
			if (key.Y < m_Level.Map.Height - 1)
			{
				TryMoveOne(newPoint[key], new Define.Point(key.X, key.Y + 1), isSelf, speed, type, ref newPoint2, ref allPoint, overlook);
			}
			if (key.X > 0)
			{
				TryMoveOne(newPoint[key], new Define.Point(key.X - 1, key.Y), isSelf, speed, type, ref newPoint2, ref allPoint, overlook);
			}
			if (key.X < m_Level.Map.Width - 1)
			{
				TryMoveOne(newPoint[key], new Define.Point(key.X + 1, key.Y), isSelf, speed, type, ref newPoint2, ref allPoint, overlook);
			}
		}
		newPoint = newPoint2;
	}

	private void TryMoveOneEx(Robot.EngineType type, int speed, ref Dictionary<Define.Point, Define.MovePath> newPoint, ref Dictionary<Define.Point, Define.MovePath> allPoint, ref Dictionary<Define.Point, Define.MovePath> outPoint, bool overlook = false)
	{
		bool flag = true;
		if (m_GameState == Define.GameState.Enemy || m_GameState == Define.GameState.Enemy_Move || m_GameState == Define.GameState.Enemy_Attack || m_GameState == Define.GameState.Enemy_Move_Attack || m_GameState == Define.GameState.Enemy_Attack_Ready || m_GameState == Define.GameState.Enemy_Move_Ready || m_GameState == Define.GameState.Enemy_Move_Attack_Ready)
		{
			flag = false;
		}
		Dictionary<Define.Point, Define.MovePath> dictionary = new Dictionary<Define.Point, Define.MovePath>(newPoint);
		newPoint.Clear();
		foreach (Define.Point key in dictionary.Keys)
		{
			if (key.Y > 0)
			{
				int fighterID = m_MapData[key.X][key.Y - 1].FighterID;
				bool flag2 = overlook || fighterID == -1 || flag == m_Fighter[fighterID].IsSelf;
				if (m_MapData[key.X][key.Y - 1].CanMove() && flag2)
				{
					Define.Point point = new Define.Point(key.X, key.Y - 1);
					int num = dictionary[key].Drag + Define.GetAffect(type, m_MapData[key.X][key.Y - 1].TerrainType);
					if (allPoint.ContainsKey(point))
					{
						if (num < allPoint[point].Drag)
						{
							Define.MovePath value = default(Define.MovePath);
							value.Drag = num;
							value.Path = new List<Define.Point>(allPoint[key].Path);
							value.Path[value.Path.Count - 1] = point;
							allPoint[point] = value;
							if (outPoint.ContainsKey(point))
							{
								outPoint.Remove(point);
							}
							outPoint.Add(point, value);
						}
					}
					else if (num <= speed)
					{
						Define.MovePath value2 = default(Define.MovePath);
						value2.Drag = num;
						value2.Path = new List<Define.Point>(dictionary[key].Path);
						value2.Path.Add(point);
						allPoint.Add(point, value2);
						newPoint.Add(point, value2);
						outPoint.Add(point, value2);
						if (outPoint.ContainsKey(key))
						{
							outPoint.Remove(key);
						}
					}
				}
			}
			if (key.Y < m_Level.Map.Height - 1)
			{
				int fighterID2 = m_MapData[key.X][key.Y + 1].FighterID;
				bool flag3 = overlook || fighterID2 == -1 || flag == m_Fighter[fighterID2].IsSelf;
				if (m_MapData[key.X][key.Y + 1].CanMove() && flag3)
				{
					Define.Point point2 = new Define.Point(key.X, key.Y + 1);
					int num2 = dictionary[key].Drag + Define.GetAffect(type, m_MapData[key.X][key.Y + 1].TerrainType);
					if (allPoint.ContainsKey(point2))
					{
						if (num2 < allPoint[point2].Drag)
						{
							Define.MovePath value3 = default(Define.MovePath);
							value3.Drag = num2;
							value3.Path = new List<Define.Point>(allPoint[key].Path);
							value3.Path[value3.Path.Count - 1] = point2;
							allPoint[point2] = value3;
							if (outPoint.ContainsKey(point2))
							{
								outPoint.Remove(point2);
							}
							outPoint.Add(point2, value3);
						}
					}
					else if (num2 <= speed)
					{
						Define.MovePath value4 = default(Define.MovePath);
						value4.Drag = num2;
						value4.Path = new List<Define.Point>(dictionary[key].Path);
						value4.Path.Add(point2);
						allPoint.Add(point2, value4);
						newPoint.Add(point2, value4);
						outPoint.Add(point2, value4);
						if (outPoint.ContainsKey(key))
						{
							outPoint.Remove(key);
						}
					}
				}
			}
			if (key.X > 0)
			{
				int fighterID3 = m_MapData[key.X - 1][key.Y].FighterID;
				if ((overlook || fighterID3 == -1 || flag == m_Fighter[fighterID3].IsSelf) && m_MapData[key.X - 1][key.Y].CanMove())
				{
					Define.Point point3 = new Define.Point(key.X - 1, key.Y);
					int num3 = dictionary[key].Drag + Define.GetAffect(type, m_MapData[key.X - 1][key.Y].TerrainType);
					if (allPoint.ContainsKey(point3))
					{
						if (num3 < allPoint[point3].Drag)
						{
							Define.MovePath value5 = default(Define.MovePath);
							value5.Drag = num3;
							value5.Path = new List<Define.Point>(allPoint[key].Path);
							value5.Path[value5.Path.Count - 1] = point3;
							allPoint[point3] = value5;
							if (outPoint.ContainsKey(point3))
							{
								outPoint.Remove(point3);
							}
							outPoint.Add(point3, value5);
						}
					}
					else if (num3 <= speed)
					{
						Define.MovePath value6 = default(Define.MovePath);
						value6.Drag = num3;
						value6.Path = new List<Define.Point>(dictionary[key].Path);
						value6.Path.Add(point3);
						allPoint.Add(point3, value6);
						newPoint.Add(point3, value6);
						outPoint.Add(point3, value6);
						if (outPoint.ContainsKey(key))
						{
							outPoint.Remove(key);
						}
					}
				}
			}
			if (key.X >= m_Level.Map.Width - 1)
			{
				continue;
			}
			int fighterID4 = m_MapData[key.X + 1][key.Y].FighterID;
			if ((!overlook && fighterID4 != -1 && flag != m_Fighter[fighterID4].IsSelf) || !m_MapData[key.X + 1][key.Y].CanMove())
			{
				continue;
			}
			Define.Point point4 = new Define.Point(key.X + 1, key.Y);
			int num4 = dictionary[key].Drag + Define.GetAffect(type, m_MapData[key.X + 1][key.Y].TerrainType);
			if (allPoint.ContainsKey(point4))
			{
				if (num4 < allPoint[point4].Drag)
				{
					Define.MovePath value7 = default(Define.MovePath);
					value7.Drag = num4;
					value7.Path = new List<Define.Point>(allPoint[key].Path);
					value7.Path[value7.Path.Count - 1] = point4;
					allPoint[point4] = value7;
					if (outPoint.ContainsKey(point4))
					{
						outPoint.Remove(point4);
					}
					outPoint.Add(point4, value7);
				}
			}
			else if (num4 <= speed)
			{
				Define.MovePath value8 = default(Define.MovePath);
				value8.Drag = num4;
				value8.Path = new List<Define.Point>(dictionary[key].Path);
				value8.Path.Add(point4);
				allPoint.Add(point4, value8);
				newPoint.Add(point4, value8);
				outPoint.Add(point4, value8);
				if (outPoint.ContainsKey(key))
				{
					outPoint.Remove(key);
				}
			}
		}
	}

	private void ResetMapShow()
	{
		for (int i = 0; i < m_MapData.Count; i++)
		{
			for (int j = 0; j < m_MapData[i].Count; j++)
			{
				m_MapData[i][j].SetBlack(black: false);
			}
		}
		foreach (int key in m_Fighter.Keys)
		{
			if (m_Fighter[key].IsAction)
			{
				m_Fighter[key].SetBlack(black: true);
			}
			else
			{
				m_Fighter[key].SetBlack(black: false);
			}
		}
	}

	private void ShowMoveRange(Define.Point[] point)
	{
		for (int i = 0; i < m_MapData.Count; i++)
		{
			for (int j = 0; j < m_MapData[i].Count; j++)
			{
				m_MapData[i][j].SetBlack(black: true);
			}
		}
		foreach (int key in m_Fighter.Keys)
		{
			m_Fighter[key].SetBlack(black: true);
		}
		for (int k = 0; k < point.Length; k++)
		{
			Define.Point point2 = point[k];
			m_MapData[point2.X][point2.Y].SetBlack(black: false);
			if (m_MapData[point2.X][point2.Y].FighterID != -1 && m_Fighter[m_MapData[point2.X][point2.Y].FighterID].IsSelf && m_Fighter[m_MapData[point2.X][point2.Y].FighterID].Fighter.HasTrait(Define.UserTrait.ZhuangZaiJi))
			{
				m_Fighter[m_MapData[point2.X][point2.Y].FighterID].SetBlack(black: false);
			}
		}
	}

	private void GetMaxMoveRange(Fighter fighter)
	{
		if (fighter.GetCanMovePoint().Length > 0)
		{
			Debug.Log("移动点 不为空");
			return;
		}
		Dictionary<Define.Point, Define.MovePath> allPoint = new Dictionary<Define.Point, Define.MovePath>();
		Dictionary<Define.Point, Define.MovePath> newPoint = new Dictionary<Define.Point, Define.MovePath>();
		Dictionary<Define.Point, Define.MovePath> outPoint = new Dictionary<Define.Point, Define.MovePath>();
		Define.MovePath value = default(Define.MovePath);
		value.Drag = 0;
		value.Path = new List<Define.Point>();
		newPoint.Add(new Define.Point(fighter.X, fighter.Y), value);
		for (int i = 0; i < fighter.Speed; i++)
		{
			TryMoveOneEx(fighter.EngineType, fighter.Speed, ref newPoint, ref allPoint, ref outPoint);
		}
		List<Define.Point> list = new List<Define.Point>();
		foreach (Define.Point key in outPoint.Keys)
		{
			if (m_MapData[key.X][key.Y].FighterID != -1 && (m_Fighter[m_MapData[key.X][key.Y].FighterID].IsSelf != fighter.IsSelf || !m_Fighter[m_MapData[key.X][key.Y].FighterID].Fighter.HasTrait(Define.UserTrait.ZhuangZaiJi)))
			{
				list.Add(key);
			}
		}
		foreach (Define.Point item in list)
		{
			outPoint.Remove(item);
		}
		fighter.CanMovePath = outPoint;
	}

	private void GetMoveRange(Fighter fighter)
	{
		if (fighter.GetCanMovePoint().Length > 0)
		{
			Debug.Log("移动点 不为空");
			return;
		}
		Dictionary<Define.Point, Define.MovePath> allPoint = new Dictionary<Define.Point, Define.MovePath>();
		Dictionary<Define.Point, Define.MovePath> newPoint = new Dictionary<Define.Point, Define.MovePath>();
		Define.MovePath value = default(Define.MovePath);
		value.Drag = 0;
		value.Path = new List<Define.Point>();
		value.Path.Add(new Define.Point(fighter.X, fighter.Y));
		allPoint.Add(new Define.Point(fighter.X, fighter.Y), value);
		newPoint.Add(new Define.Point(fighter.X, fighter.Y), value);
		for (int i = 0; i < fighter.Speed; i++)
		{
			TryMoveOne(fighter.IsSelf, fighter.EngineType, fighter.Speed, ref newPoint, ref allPoint);
		}
		List<Define.Point> list = new List<Define.Point>();
		foreach (Define.Point key in allPoint.Keys)
		{
			if (m_MapData[key.X][key.Y].FighterID != -1 && (m_Fighter[m_MapData[key.X][key.Y].FighterID].IsSelf != fighter.IsSelf || !m_Fighter[m_MapData[key.X][key.Y].FighterID].Fighter.HasTrait(Define.UserTrait.ZhuangZaiJi)))
			{
				list.Add(key);
			}
		}
		foreach (Define.Point item in list)
		{
			allPoint.Remove(item);
		}
		fighter.CanMovePath = allPoint;
	}

	private void ShowPlan()
	{
		MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowPlan());
	}

	private void ShowLevelTitle(object p)
	{
		m_MapRoot.gameObject.SetActive(value: false);
		LevelTitle.text = m_Level.Name;
		LevelTitle.gameObject.SetActive(value: true);
		AudioManager.Instance.PlayBGM(-1);
		AudioManager.Instance.PlayME(0);
		TimeManager.Instance.SetTimer(AudioManager.Instance.GetLengthME(0) + 2f, delegate
		{
			LevelTitle.gameObject.SetActive(value: false);
			m_GameState = Define.GameState.Wait;
			ShowMap();
			OnChooseGameEvent();
		});
	}

	private void ShowMap()
	{
		m_MapRoot.SetActive(value: true);
	}

	private void OnChooseGameEvent()
	{
		GameEvent[] everyEvent = m_Level.EveryEvent;
		GameEvent[] gameEvent = m_Level.GetGameEvent(m_RepriseNum);
		if (everyEvent != null || gameEvent != null)
		{
			DoStartEvent(m_GameState);
			AddGameEvent(everyEvent);
			AddGameEvent(gameEvent);
		}
	}

	private int GetDistance(Define.Point a, Define.Point b)
	{
		return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y);
	}

	private bool ListPNodeHasPoint(int x, int y, List<PNode> list)
	{
		foreach (PNode item in list)
		{
			if (item.X == x && item.Y == y)
			{
				return true;
			}
		}
		return false;
	}

	private List<Define.Point> PathFinding(Define.Point origin, Define.Point target, Robot.EngineType engine)
	{
		List<PNode> list = new List<PNode>();
		List<PNode> list2 = new List<PNode>();
		PNode item = new PNode(origin.X, origin.Y, 0, GetDistance(origin, target));
		list.Add(item);
		PNode pNode = null;
		while (list.Count > 0)
		{
			foreach (PNode item2 in list)
			{
				if (pNode == null || item2.F < pNode.F)
				{
					pNode = item2;
				}
			}
			if (pNode == null)
			{
				return null;
			}
			if (pNode.X == target.X && pNode.Y == target.Y)
			{
				break;
			}
			list2.Add(pNode);
			list.Remove(pNode);
			if (pNode.Y > 0)
			{
				int affect = Define.GetAffect(engine, m_MapData[pNode.X][pNode.Y - 1].TerrainType);
				PNode pNode2 = new PNode(pNode.X, pNode.Y - 1, pNode.G + affect, GetDistance(new Define.Point(pNode.X, pNode.Y - 1), target), pNode);
				if (m_MapData[pNode2.X][pNode2.Y].CanMove() && !ListPNodeHasPoint(pNode2.X, pNode2.Y, list2) && !ListPNodeHasPoint(pNode2.X, pNode2.Y, list))
				{
					list.Add(pNode2);
				}
			}
			if (pNode.Y < m_Level.Map.Height - 1)
			{
				int affect2 = Define.GetAffect(engine, m_MapData[pNode.X][pNode.Y + 1].TerrainType);
				PNode pNode3 = new PNode(pNode.X, pNode.Y + 1, pNode.G + affect2, GetDistance(new Define.Point(pNode.X, pNode.Y + 1), target), pNode);
				if (m_MapData[pNode3.X][pNode3.Y].CanMove() && !ListPNodeHasPoint(pNode3.X, pNode3.Y, list2) && !ListPNodeHasPoint(pNode3.X, pNode3.Y, list))
				{
					list.Add(pNode3);
				}
			}
			if (pNode.X > 0)
			{
				int affect3 = Define.GetAffect(engine, m_MapData[pNode.X - 1][pNode.Y].TerrainType);
				PNode pNode4 = new PNode(pNode.X - 1, pNode.Y, pNode.G + affect3, GetDistance(new Define.Point(pNode.X - 1, pNode.Y), target), pNode);
				if (m_MapData[pNode4.X][pNode4.Y].CanMove() && !ListPNodeHasPoint(pNode4.X, pNode4.Y, list2) && !ListPNodeHasPoint(pNode4.X, pNode4.Y, list))
				{
					list.Add(pNode4);
				}
			}
			if (pNode.X < m_Level.Map.Width - 1)
			{
				int affect4 = Define.GetAffect(engine, m_MapData[pNode.X + 1][pNode.Y].TerrainType);
				PNode pNode5 = new PNode(pNode.X + 1, pNode.Y, pNode.G + affect4, GetDistance(new Define.Point(pNode.X + 1, pNode.Y), target), pNode);
				if (m_MapData[pNode5.X][pNode5.Y].CanMove() && !ListPNodeHasPoint(pNode5.X, pNode5.Y, list2) && !ListPNodeHasPoint(pNode5.X, pNode5.Y, list))
				{
					list.Add(pNode5);
				}
			}
			pNode = null;
		}
		return pNode?.PointList;
	}

	private int GetPathAffect(Robot.EngineType engine, List<Define.Point> path)
	{
		if (path == null)
		{
			return 0;
		}
		int num = 0;
		foreach (Define.Point item in path)
		{
			num += Define.GetAffect(engine, m_MapData[item.X][item.Y].TerrainType);
		}
		return num;
	}

	private List<Define.Point> CreatePath(Define.Point a, Define.Point b, Robot.EngineType engine = Robot.EngineType.Sky)
	{
		List<Define.Point> list = PathFinding(a, b, engine);
		if (list == null)
		{
			List<Define.Point> list2 = new List<Define.Point>();
			list2.Add(b);
			return list2;
		}
		return list;
	}

	private void OnDoGameEvent()
	{
		if (m_GameEvent.Count == 0)
		{
			bool flag = false;
			bool flag2 = false;
			foreach (int key in m_Fighter.Keys)
			{
				if (m_Fighter[key].IsSelf)
				{
					flag = true;
				}
				else
				{
					flag2 = true;
				}
				if (flag2 && flag)
				{
					break;
				}
			}
			if (flag2 && flag)
			{
				m_GameState = m_EventLastGameState;
				return;
			}
			if (!flag2 && m_Level.TaskType == Level.TaskTypeEnum.KillAll)
			{
				m_GameEvent.AddRange(m_Level.GetGameEvent(-1));
			}
			else if (!flag)
			{
				m_GameEvent.Add(new GameEvent_GameOver());
			}
		}
		if (m_GameEvent.Count <= 0)
		{
			m_GameState = m_EventLastGameState;
			return;
		}
		GameEvent gameEvent = m_GameEvent[0];
		m_GameEvent.RemoveAt(0);
		switch (gameEvent.Type)
		{
		case Define.EventType.AddMoney:
		{
			GameEvent_AddMoney data2 = gameEvent.GetData<GameEvent_AddMoney>();
			GameDataBase.Instance.NowMoney += data2.Num;
			break;
		}
		case Define.EventType.AddSP:
		{
			GameEvent_AddSP data13 = gameEvent.GetData<GameEvent_AddSP>();
			if (m_Fighter.ContainsKey(data13.ID))
			{
				m_Fighter[data13.ID].Fighter.NSP += data13.Num;
			}
			break;
		}
		case Define.EventType.SetStatus:
		{
			GameEvent_SetStatus data11 = gameEvent.GetData<GameEvent_SetStatus>();
			if (m_Fighter.ContainsKey(data11.ID))
			{
				m_Fighter[data11.ID].Fighter.State.Add(data11.Status);
			}
			break;
		}
		case Define.EventType.AddExp:
		{
			GameEvent_AddExp data32 = gameEvent.GetData<GameEvent_AddExp>();
			if (m_Fighter.ContainsKey(data32.ID) && m_Fighter[data32.ID].Fighter.AddExp(data32.Num))
			{
				List<GameEvent> list10 = new List<GameEvent>();
				list10.Add(new GameEvent_PlayME(1));
				list10.Add(new GameEvent_Dialogue("等级提升至 : " + m_Fighter[data32.ID].Fighter.Level, m_Fighter[data32.ID].Fighter.UserName, m_Fighter[data32.ID].Fighter.Hand, Vector2.zero));
				list10.Add(new GameEvent_Dialogue("强度提升至 : " + m_Fighter[data32.ID].Fighter.Str, m_Fighter[data32.ID].Fighter.UserName, m_Fighter[data32.ID].Fighter.Hand, Vector2.zero));
				list10.Add(new GameEvent_Dialogue("防御提升至 : " + m_Fighter[data32.ID].Fighter.Def, m_Fighter[data32.ID].Fighter.UserName, m_Fighter[data32.ID].Fighter.Hand, Vector2.zero));
				list10.Add(new GameEvent_Dialogue("速度提升至 : " + m_Fighter[data32.ID].Fighter.Agi, m_Fighter[data32.ID].Fighter.UserName, m_Fighter[data32.ID].Fighter.Hand, Vector2.zero));
				list10.Add(new GameEvent_Dialogue("HP提升至 : " + m_Fighter[data32.ID].Fighter.HP, m_Fighter[data32.ID].Fighter.UserName, m_Fighter[data32.ID].Fighter.Hand, Vector2.zero));
				list10.Add(new GameEvent_Dialogue("SP提升至 : " + m_Fighter[data32.ID].Fighter.SP, m_Fighter[data32.ID].Fighter.UserName, m_Fighter[data32.ID].Fighter.Hand, Vector2.zero));
				AddGameEvent(list10);
			}
			break;
		}
		case Define.EventType.AlterItem:
		{
			GameEvent_AlterItem data5 = gameEvent.GetData<GameEvent_AlterItem>();
			if (data5.Num > 0)
			{
				GameDataBase.Instance.AddItem(data5.ID, data5.Num);
			}
			else
			{
				GameDataBase.Instance.UseItem(data5.ID, -data5.Num);
			}
			break;
		}
		case Define.EventType.AddAttr:
		{
			GameEvent_AddAttr data36 = gameEvent.GetData<GameEvent_AddAttr>();
			if (m_Fighter.ContainsKey(data36.ID))
			{
				m_Fighter[data36.ID].Fighter.BaseHP += data36.HP;
				m_Fighter[data36.ID].Fighter.BaseStr += data36.Str;
				m_Fighter[data36.ID].Fighter.BaseAgi += data36.Agi;
				m_Fighter[data36.ID].Fighter.BaseDef += data36.Def;
			}
			break;
		}
		case Define.EventType.AddFighter:
		{
			GameEvent_AddFighter data35 = gameEvent.GetData<GameEvent_AddFighter>();
			LoadFighter(data35.ID);
			break;
		}
		case Define.EventType.ChooseAI:
		{
			GameEvent_ChooseAI data29 = gameEvent.GetData<GameEvent_ChooseAI>();
			if (m_Fighter.ContainsKey(data29.FighterID))
			{
				m_Fighter[data29.FighterID].AIType = data29.AIType;
			}
			break;
		}
		case Define.EventType.ChooseReprise:
		{
			GameEvent_ChooseReprise data28 = gameEvent.GetData<GameEvent_ChooseReprise>();
			m_RepriseNum = data28.Reprise;
			break;
		}
		case Define.EventType.Dialogue:
		{
			GameEvent_Dialogue data24 = gameEvent.GetData<GameEvent_Dialogue>();
			m_GameState = Define.GameState.DoEvent_Wait;
			MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_Dialogue(data24.Line, data24.Name, data24.Hand, data24.Pos));
			return;
		}
		case Define.EventType.MapLock:
			m_ScrollRect.enabled = false;
			break;
		case Define.EventType.WaitTime:
		{
			GameEvent_WaitTime data20 = gameEvent.GetData<GameEvent_WaitTime>();
			m_GameState = Define.GameState.DoEvent_Time;
			TimeManager.Instance.SetTimer(data20.Time, delegate
			{
				m_GameState = Define.GameState.DoEvent;
			});
			return;
		}
		case Define.EventType.MapMove:
		{
			GameEvent_MapMove data15 = gameEvent.GetData<GameEvent_MapMove>();
			LookPoint(data15.Pos);
			break;
		}
		case Define.EventType.SetSuccess:
		{
			GameEvent_SetSuccess data14 = gameEvent.GetData<GameEvent_SetSuccess>();
			switch (data14.Way)
			{
			case GameEvent_SetSuccess.SetSuccessWay.Add:
				DataManager.Instance.SetSuccess(data14.Key, DataManager.Instance.GetSchedule(data14.Key) + data14.Value);
				break;
			case GameEvent_SetSuccess.SetSuccessWay.Set:
				DataManager.Instance.SetSuccess(data14.Key, data14.Value);
				break;
			}
			break;
		}
		case Define.EventType.PosSwitchSelf:
		{
			GameEvent_PosSwitchSelf data19 = gameEvent.GetData<GameEvent_PosSwitchSelf>();
			foreach (Define.Point item in data19.Point)
			{
				if (m_MapData[item.X][item.Y].FighterID != -1 && m_Fighter[m_MapData[item.X][item.Y].FighterID].IsSelf == data19.Self)
				{
					List<GameEvent> list4 = new List<GameEvent>(data19.TrueEvent);
					list4.AddRange(m_GameEvent);
					m_GameEvent = list4;
					break;
				}
			}
			break;
		}
		case Define.EventType.ShowShop:
		{
			GameEvent_ShowShop data12 = gameEvent.GetData<GameEvent_ShowShop>();
			MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowShop(data12.Item));
			break;
		}
		case Define.EventType.PosSwitchID:
		{
			GameEvent_PosSwitchID data21 = gameEvent.GetData<GameEvent_PosSwitchID>();
			foreach (Define.Point item2 in data21.Point)
			{
				if (m_MapData[item2.X][item2.Y].FighterID == data21.ID)
				{
					List<GameEvent> list5 = new List<GameEvent>(data21.TrueEvent);
					list5.AddRange(m_GameEvent);
					m_GameEvent = list5;
					break;
				}
			}
			break;
		}
		case Define.EventType.SelfCount:
		{
			GameEvent_SelfCount data9 = gameEvent.GetData<GameEvent_SelfCount>();
			int num2 = 0;
			foreach (int key2 in m_Fighter.Keys)
			{
				if (m_Fighter[key2].IsSelf && m_Fighter[key2].AIType == Define.AIType.Null)
				{
					num2++;
				}
			}
			if (num2 == data9.Count)
			{
				List<GameEvent> list2 = new List<GameEvent>(data9.TrueEvent);
				list2.AddRange(m_GameEvent);
				m_GameEvent = list2;
			}
			break;
		}
		case Define.EventType.IsCarry:
		{
			GameEvent_IsCarry data33 = gameEvent.GetData<GameEvent_IsCarry>();
			if (m_Fighter.ContainsKey(data33.MotherID) && m_Fighter.ContainsKey(data33.SonID) && m_Fighter[data33.SonID].ThisCarry != null && m_Fighter[data33.SonID].ThisCarry.ID == data33.MotherID)
			{
				List<GameEvent> list11 = new List<GameEvent>(data33.TrueEvent);
				list11.AddRange(m_GameEvent);
				m_GameEvent = list11;
			}
			break;
		}
		case Define.EventType.DoVariant:
		{
			GameEvent_DoVariant data31 = gameEvent.GetData<GameEvent_DoVariant>();
			if (m_Fighter.ContainsKey(data31.ID))
			{
				m_Fighter[data31.ID].Fighter.Variant(data31.Variant);
				m_Fighter[data31.ID].SetIcon(m_Fighter[data31.ID].Fighter.Icon);
			}
			break;
		}
		case Define.EventType.LookFighter:
		{
			GameEvent_LookFighter data22 = gameEvent.GetData<GameEvent_LookFighter>();
			if (m_Fighter.ContainsKey(data22.ID))
			{
				if (m_Fighter[data22.ID].ThisCarry == null)
				{
					LookPoint(new Define.Point(m_Fighter[data22.ID].X, m_Fighter[data22.ID].Y));
				}
				else
				{
					LookPoint(new Define.Point(m_Fighter[data22.ID].ThisCarry.X, m_Fighter[data22.ID].ThisCarry.Y));
				}
			}
			break;
		}
		case Define.EventType.DoBattle:
		{
			GameEvent_DoBattle data7 = gameEvent.GetData<GameEvent_DoBattle>();
			if (m_Fighter.ContainsKey(data7.ID) && (data7.Target == -1 || m_Fighter.ContainsKey(data7.Target)))
			{
				List<int> list = SkillHasTarget(new Define.Point(m_Fighter[data7.ID].X, m_Fighter[data7.ID].Y), m_Fighter[data7.ID].Weapon[data7.Weapon], m_Fighter[data7.ID].IsSelf);
				int num = ((data7.Target != -1) ? data7.Target : ((list.Count <= 0) ? (-1) : list[0]));
				if (num != -1 && list.Contains(num))
				{
					DoBattle(data7.ID, m_Fighter[data7.ID].Weapon[data7.Weapon], num);
				}
			}
			break;
		}
		case Define.EventType.SetSwitch:
		{
			GameEvent_SetSwitch data6 = gameEvent.GetData<GameEvent_SetSwitch>();
			m_Level.SetSwitch(data6.Key, data6.Value);
			break;
		}
		case Define.EventType.SetFlag:
		{
			GameEvent_SetFlag data8 = gameEvent.GetData<GameEvent_SetFlag>();
			GameDataBase.Instance.SetFlag(data8.Key, data8.Value);
			break;
		}
		case Define.EventType.InspectSwitch:
		{
			GameEvent_InspectSwitch data38 = gameEvent.GetData<GameEvent_InspectSwitch>();
			if (m_Level.GetSwitch(data38.Switch) == data38.Number)
			{
				List<GameEvent> list14 = new List<GameEvent>(data38.TrueEvent);
				list14.AddRange(m_GameEvent);
				m_GameEvent = list14;
			}
			else
			{
				List<GameEvent> list15 = new List<GameEvent>(data38.FalseEvent);
				list15.AddRange(m_GameEvent);
				m_GameEvent = list15;
			}
			break;
		}
		case Define.EventType.AddSwitch:
		{
			GameEvent_AddSwitch data37 = gameEvent.GetData<GameEvent_AddSwitch>();
			m_Level.AddSwitch(data37.Key, data37.Value);
			break;
		}
		case Define.EventType.HasFighter:
		{
			GameEvent_HasFighter data34 = gameEvent.GetData<GameEvent_HasFighter>();
			if (m_Fighter.ContainsKey(data34.ID))
			{
				List<GameEvent> list12 = new List<GameEvent>(data34.TrueEvent);
				list12.AddRange(m_GameEvent);
				m_GameEvent = list12;
			}
			else
			{
				List<GameEvent> list13 = new List<GameEvent>(data34.FalseEvent);
				list13.AddRange(m_GameEvent);
				m_GameEvent = list13;
			}
			break;
		}
		case Define.EventType.SwitchNHP:
		{
			GameEvent_SwitchNHP data30 = gameEvent.GetData<GameEvent_SwitchNHP>();
			if (m_Fighter.ContainsKey(data30.ID))
			{
				if (m_Fighter[data30.ID].NHP <= data30.NHP)
				{
					List<GameEvent> list8 = new List<GameEvent>(data30.TrueEvent);
					list8.AddRange(m_GameEvent);
					m_GameEvent = list8;
				}
				else
				{
					List<GameEvent> list9 = new List<GameEvent>(data30.FalseEvent);
					list9.AddRange(m_GameEvent);
					m_GameEvent = list9;
				}
			}
			break;
		}
		case Define.EventType.GetFlag:
		{
			GameEvent_GetFlag data27 = gameEvent.GetData<GameEvent_GetFlag>();
			if (GameDataBase.Instance.GetFlag(data27.Key))
			{
				List<GameEvent> list6 = new List<GameEvent>(data27.TrueEvent);
				list6.AddRange(m_GameEvent);
				m_GameEvent = list6;
			}
			else
			{
				List<GameEvent> list7 = new List<GameEvent>(data27.FalseEvent);
				list7.AddRange(m_GameEvent);
				m_GameEvent = list7;
			}
			break;
		}
		case Define.EventType.MapUnlock:
			m_ScrollRect.enabled = true;
			break;
		case Define.EventType.PlayBGM:
		{
			GameEvent_PlayBGM data26 = gameEvent.GetData<GameEvent_PlayBGM>();
			AudioManager.Instance.PlayBGM(data26.IndexBGM);
			break;
		}
		case Define.EventType.PlayME:
		{
			GameEvent_PlayME data25 = gameEvent.GetData<GameEvent_PlayME>();
			AudioManager.Instance.PlayME(data25.IndexME);
			break;
		}
		case Define.EventType.SetAction:
		{
			GameEvent_SetAction data23 = gameEvent.GetData<GameEvent_SetAction>();
			if (m_Fighter.ContainsKey(data23.ID))
			{
				m_Fighter[data23.ID].IsAction = data23.Action;
				ResetMapShow();
			}
			break;
		}
		case Define.EventType.MoveTo:
		{
			GameEvent_MoveTo data18 = gameEvent.GetData<GameEvent_MoveTo>();
			if (m_Fighter.ContainsKey(data18.ID))
			{
				Define.Point b = data18.Pos;
				if (m_MapData[b.X][b.Y].FighterID != -1)
				{
					b = GetNullFightrPos(new Define.Point(b.X, b.Y));
				}
				m_GameState = Define.GameState.DoEvent_Move;
				m_MapData[m_Fighter[data18.ID].X][m_Fighter[data18.ID].Y].TakeOff();
				m_Fighter[data18.ID].DoMovePath(CreatePath(new Define.Point(m_Fighter[data18.ID].X, m_Fighter[data18.ID].Y), b));
				if (data18.Look)
				{
					m_LookFighter = m_Fighter[data18.ID];
				}
				m_MapData[b.X][b.Y].Carry(data18.ID);
			}
			return;
		}
		case Define.EventType.Victory:
		{
			GameEvent_Victory data17 = gameEvent.GetData<GameEvent_Victory>();
			Victory(data17.NextLevel);
			return;
		}
		case Define.EventType.Repair:
			Repair();
			return;
		case Define.EventType.GameOver:
			GameOver();
			return;
		case Define.EventType.NextFrame:
			return;
		case Define.EventType.Damage:
		{
			GameEvent_Damage data16 = gameEvent.GetData<GameEvent_Damage>();
			m_GameState = Define.GameState.DoEvent_Effect;
			m_Fighter[data16.ID].Damage(data16.Damage);
			return;
		}
		case Define.EventType.Replace:
		{
			GameEvent_Replace data10 = gameEvent.GetData<GameEvent_Replace>();
			if (!m_Fighter.ContainsKey(data10.IDA))
			{
				break;
			}
			m_MapData[m_Fighter[data10.IDA].X][m_Fighter[data10.IDA].Y].TakeOff();
			if (data10.IDB != -1)
			{
				LoadFighter(data10.IDB);
				m_Fighter[data10.IDB].X = m_Fighter[data10.IDA].X;
				m_Fighter[data10.IDB].Y = m_Fighter[data10.IDA].Y;
				m_MapData[m_Fighter[data10.IDB].X][m_Fighter[data10.IDB].Y].Carry(data10.IDB);
				m_Fighter[data10.IDB].SetPosition(m_MapData[m_Fighter[data10.IDB].X][m_Fighter[data10.IDB].Y].Position);
			}
			List<int> list3 = new List<int>();
			foreach (Fighter item3 in m_Fighter[data10.IDA].CarryFighter)
			{
				list3.Add(item3.ID);
			}
			foreach (int item4 in list3)
			{
				UnityEngine.Object.Destroy(m_Fighter[item4]);
				m_Fighter.Remove(item4);
			}
			m_Fighter[data10.IDA].gameObject.SetActive(value: false);
			UnityEngine.Object.Destroy(m_Fighter[data10.IDA]);
			m_Fighter.Remove(data10.IDA);
			break;
		}
		case Define.EventType.ActorDie:
		{
			GameEvent_ActorDie data4 = gameEvent.GetData<GameEvent_ActorDie>();
			if (!m_Fighter.ContainsKey(data4.ID))
			{
				return;
			}
			m_GameState = Define.GameState.DoEvent_Effect;
			if (!m_Fighter[data4.ID].IsSelf)
			{
				DataManager.Instance.SetSuccess(8, DataManager.Instance.GetSchedule(8) + 1);
			}
			else
			{
				DataManager.Instance.SetSuccess(9, DataManager.Instance.GetSchedule(9) + 1);
			}
			m_Fighter[data4.ID].Die();
			m_MapData[m_Fighter[data4.ID].X][m_Fighter[data4.ID].Y].TakeOff();
			foreach (Fighter item5 in m_Fighter[data4.ID].CarryFighter)
			{
				m_Fighter.Remove(item5.ID);
			}
			m_Fighter.Remove(data4.ID);
			return;
		}
		case Define.EventType.ChooseActor:
		{
			GameEvent_ChooseActor data3 = gameEvent.GetData<GameEvent_ChooseActor>();
			m_Fighter[data3.ID].ChooseActor(data3.ActorData);
			break;
		}
		case Define.EventType.ShowEffect:
		{
			GameEvent_ShowEffect data = gameEvent.GetData<GameEvent_ShowEffect>();
			if (m_Fighter.ContainsKey(data.FighterID))
			{
				m_GameState = Define.GameState.DoEvent_Effect;
				m_Fighter[data.FighterID].ShowEffect(data.EffectID, 0, data.StartSE, data.OverTime);
			}
			return;
		}
		}
		OnDoGameEvent();
	}

	private void NextReprise()
	{
		if (m_GameState == Define.GameState.Enemy)
		{
			m_RepriseNum++;
			AudioManager.Instance.PlayBGM(m_Level.SelfBGM);
			foreach (int key in m_Fighter.Keys)
			{
				if (m_Fighter[key].IsSelf)
				{
					foreach (Fighter item in m_Fighter[key].CarryFighter)
					{
						item.NHP += item.HP / 4;
						if (item.NHP > item.HP)
						{
							item.NHP = item.HP;
						}
					}
					continue;
				}
				m_Fighter[key].IsAction = false;
				foreach (Fighter item2 in m_Fighter[key].CarryFighter)
				{
					item2.IsAction = false;
				}
			}
			ResetMapShow();
			List<GameEvent> list = new List<GameEvent>();
			foreach (int key2 in m_Fighter.Keys)
			{
				m_Fighter[key2].Fighter.State.Clear();
				if (!m_Fighter[key2].Fighter.HasTrait(Define.UserTrait.XiuFuXiTong))
				{
					continue;
				}
				int num = m_Fighter[key2].HP - m_Fighter[key2].NHP;
				if (num != 0)
				{
					if (num > m_Fighter[key2].HP / 5)
					{
						num = m_Fighter[key2].HP / 5;
					}
					list.Add(new GameEvent_LookFighter(key2));
					list.Add(new GameEvent_Damage(key2, -num));
				}
			}
			if (m_Level.Hospital.Count > 0)
			{
				foreach (Define.Point item3 in m_Level.Hospital)
				{
					int fighterID = m_MapData[item3.X][item3.Y].FighterID;
					if (fighterID == -1)
					{
						continue;
					}
					int num2 = m_Fighter[fighterID].HP - m_Fighter[fighterID].NHP;
					if (num2 != 0)
					{
						if (num2 > m_Fighter[fighterID].HP / 3)
						{
							num2 = m_Fighter[fighterID].HP / 3;
						}
						list.Add(new GameEvent_LookFighter(fighterID));
						list.Add(new GameEvent_Damage(fighterID, -num2));
					}
				}
			}
			if (list.Count > 0)
			{
				m_GameEvent.Add(new GameEvent_MapLock());
				m_GameEvent.AddRange(list);
				m_GameEvent.Add(new GameEvent_MapUnlock());
				DoStartEvent(Define.GameState.SelfAI);
			}
			else
			{
				m_GameState = Define.GameState.SelfAI;
			}
			return;
		}
		m_GameState = Define.GameState.Enemy;
		AudioManager.Instance.PlayBGM(m_Level.EnemyBGM);
		foreach (int key3 in m_Fighter.Keys)
		{
			if (!m_Fighter[key3].IsSelf)
			{
				continue;
			}
			m_Fighter[key3].IsAction = false;
			foreach (Fighter item4 in m_Fighter[key3].CarryFighter)
			{
				item4.IsAction = false;
			}
		}
		m_ScrollRect.enabled = false;
		ResetMapShow();
		OnChooseGameEvent();
	}

	private void LookPoint(Define.Point pos)
	{
		if (!(m_RootRectTransform == null))
		{
			float x = (((float)m_Level.Map.Width - 1f) / 2f - (float)pos.X) * Define.MapElementWidth;
			float y = ((0f - ((float)m_Level.Map.Height - 1f)) / 2f + (float)pos.Y) * Define.MapElementWidth;
			m_RootRectTransform.localPosition = new Vector2(x, y);
		}
	}

	private void LookPoint(Vector2 pos)
	{
		if (!(m_RootRectTransform == null))
		{
			m_RootRectTransform.localPosition = new Vector2(0f - pos.x, 0f - pos.y);
		}
	}

	public List<int> SkillHasTarget(Define.Point pos, int weaponid, bool self = true)
	{
		Weapon weapon = GameDataBase.Instance.GetWeapon(weaponid);
		if (weapon == null)
		{
			return new List<int>();
		}
		int range = weapon.Range;
		if (range > 1 && !weapon.All && (m_GameState == Define.GameState.Move_Attack_Ready || m_GameState == Define.GameState.TakeOff_Attack_Ready || m_GameState == Define.GameState.Enemy_Move_Ready || m_GameState == Define.GameState.Move_Over || m_GameState == Define.GameState.Enemy_Move_Attack_Ready || m_GameState == Define.GameState.TakeOff_Over || m_GameState == Define.GameState.SelfAI_Move_Attack_Ready || m_GameState == Define.GameState.SelfAI_Move_Ready))
		{
			return new List<int>();
		}
		List<int> list = new List<int>();
		foreach (int key in m_Fighter.Keys)
		{
			if (!m_Fighter[key].gameObject.activeSelf)
			{
				continue;
			}
			if (weapon.Cure)
			{
				if (self != m_Fighter[key].IsSelf)
				{
					continue;
				}
			}
			else if (self == m_Fighter[key].IsSelf)
			{
				continue;
			}
			int num = Math.Abs(pos.X - m_Fighter[key].X) + Math.Abs(pos.Y - m_Fighter[key].Y);
			if (range < num)
			{
				continue;
			}
			if (!weapon.Cure)
			{
				if (range > 1 && num == 1)
				{
					continue;
				}
				Terrain.TerrainType terrainType = m_MapData[m_Fighter[key].X][m_Fighter[key].Y].TerrainType;
				Robot.EngineType engineType = ((m_Fighter[key].EngineType == Robot.EngineType.Sky) ? Robot.EngineType.Sky : ((terrainType != Terrain.TerrainType.Sea) ? Robot.EngineType.Land : Robot.EngineType.Sea));
				if ((engineType == Robot.EngineType.Land && weapon.FireLand == 0) || (engineType == Robot.EngineType.Sea && weapon.FireSea == 0) || (engineType == Robot.EngineType.Sky && weapon.FireSky == 0))
				{
					continue;
				}
			}
			else if (m_Fighter[key].NHP >= m_Fighter[key].HP)
			{
				continue;
			}
			list.Add(key);
		}
		return list;
	}

	private int AttackPriority(int a, int b)
	{
		return (m_Fighter[a].Fighter.Score <= m_Fighter[b].Fighter.Score) ? a : b;
	}

	private bool WeaponPriority(int a, int b, Robot.EngineType type)
	{
		if (a == -1)
		{
			return true;
		}
		Weapon weapon = GameDataBase.Instance.GetWeapon(a);
		Weapon weapon2 = GameDataBase.Instance.GetWeapon(b);
		return type switch
		{
			Robot.EngineType.Land => weapon2.FireLand > weapon.FireLand, 
			Robot.EngineType.Sea => weapon2.FireSea > weapon.FireSea, 
			Robot.EngineType.Sky => weapon2.FireSky > weapon.FireSky, 
			_ => false, 
		};
	}

	private Robot.EngineType GetFighterEngineType(int id)
	{
		if (!m_Fighter.ContainsKey(id))
		{
			return Robot.EngineType.Land;
		}
		return (m_Fighter[id].EngineType == Robot.EngineType.Sky) ? Robot.EngineType.Sky : ((m_MapData[m_Fighter[id].X][m_Fighter[id].Y].TerrainType != Terrain.TerrainType.Sea) ? Robot.EngineType.Land : Robot.EngineType.Sea);
	}

	private void EnemyDoThink(int id)
	{
		m_TargetOne = m_Fighter[id].Fighter;
		LookPoint(new Define.Point(m_Fighter[id].X, m_Fighter[id].Y));
		Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
		for (int i = 0; i < m_TargetOne.Weapon.Count; i++)
		{
			List<int> list = SkillHasTarget(new Define.Point(m_TargetOne.X, m_TargetOne.Y), m_TargetOne.Weapon[i], m_TargetOne.IsSelf);
			if (list.Count > 0)
			{
				dictionary.Add(i, list);
			}
		}
		if (m_TargetOne.AIType == Define.AIType.Counter)
		{
			if (m_TargetOne.NHP >= m_TargetOne.HP)
			{
				if (dictionary.Count > 0)
				{
					int num = -1;
					int index = -1;
					foreach (int key in dictionary.Keys)
					{
						foreach (int item in dictionary[key])
						{
							if (num == -1)
							{
								num = item;
								index = key;
							}
							else if (AttackPriority(num, item) == item)
							{
								num = item;
								index = key;
							}
						}
					}
					DoBattle(m_TargetOne.ID, m_TargetOne.Weapon[index], num);
				}
				else
				{
					m_TargetOne.IsAction = true;
					m_Fighter[id].SetBlack(black: true);
				}
				m_TargetOne = null;
				return;
			}
			m_TargetOne.AIType = Define.AIType.Attack;
		}
		switch (m_TargetOne.AIType)
		{
		case Define.AIType.Null:
			m_TargetOne.IsAction = true;
			m_Fighter[id].SetBlack(black: true);
			m_TargetOne = null;
			break;
		case Define.AIType.Passivity:
			if (dictionary.Count > 0)
			{
				int num11 = -1;
				int index2 = -1;
				foreach (int key2 in dictionary.Keys)
				{
					foreach (int item2 in dictionary[key2])
					{
						if (num11 == -1)
						{
							num11 = item2;
							index2 = key2;
						}
						else if (AttackPriority(num11, item2) == item2)
						{
							num11 = item2;
							index2 = key2;
						}
					}
				}
				DoBattle(m_TargetOne.ID, m_TargetOne.Weapon[index2], num11);
			}
			else
			{
				m_TargetOne.IsAction = true;
				m_Fighter[id].SetBlack(black: true);
			}
			m_TargetOne = null;
			break;
		case Define.AIType.Patrol:
		{
			m_TargetOne.CanMovePath = null;
			GetMoveRange(m_TargetOne);
			Define.Point point3 = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
			int num4 = -1;
			int num5 = -1;
			m_GameState = ((!m_Fighter[id].IsSelf) ? Define.GameState.Enemy_Move_Ready : Define.GameState.SelfAI_Move_Ready);
			if (dictionary.Count > 0)
			{
				foreach (int key3 in dictionary.Keys)
				{
					foreach (int item3 in dictionary[key3])
					{
						if ((num4 == -1 || AttackPriority(num4, item3) == item3) && WeaponPriority((num5 != -1) ? m_TargetOne.Weapon[num5] : num5, m_TargetOne.Weapon[key3], GetFighterEngineType(item3)))
						{
							num4 = item3;
							point3 = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
							num5 = key3;
						}
					}
				}
			}
			Define.Point[] canMovePoint2 = m_TargetOne.GetCanMovePoint();
			foreach (Define.Point point4 in canMovePoint2)
			{
				for (int l = 0; l < m_TargetOne.Weapon.Count; l++)
				{
					List<int> list2 = SkillHasTarget(point4, m_TargetOne.Weapon[l], m_Fighter[id].IsSelf);
					if (list2.Count <= 0)
					{
						continue;
					}
					foreach (int item4 in list2)
					{
						if ((num4 == -1 || AttackPriority(num4, item4) == item4) && WeaponPriority((num5 != -1) ? m_TargetOne.Weapon[num5] : num5, m_TargetOne.Weapon[l], GetFighterEngineType(item4)))
						{
							num4 = item4;
							point3 = point4;
							num5 = l;
						}
					}
				}
			}
			if (num4 != -1)
			{
				if (num5 != -1 && point3.X == m_TargetOne.X && point3.Y == m_TargetOne.Y)
				{
					m_GameState = ((!m_Fighter[id].IsSelf) ? Define.GameState.Enemy : Define.GameState.SelfAI);
					DoBattle(m_TargetOne.ID, m_TargetOne.Weapon[num5], num4);
					m_TargetOne = null;
				}
				else
				{
					m_GameState = ((!m_Fighter[id].IsSelf) ? Define.GameState.Enemy_Move : Define.GameState.SelfAI_Move);
					m_MapData[m_TargetOne.X][m_TargetOne.Y].TakeOff();
					m_Fighter[id].DoMovePath(m_TargetOne.GetMovePath(point3));
					LookFighter = m_Fighter[id];
				}
			}
			else
			{
				m_GameState = ((!m_Fighter[id].IsSelf) ? Define.GameState.Enemy : Define.GameState.SelfAI);
				m_TargetOne.IsAction = true;
				m_Fighter[id].SetBlack(black: true);
				m_TargetOne = null;
			}
			break;
		}
		case Define.AIType.Attack:
		{
			m_TargetOne.CanMovePath = null;
			GetMoveRange(m_TargetOne);
			Define.Point point5 = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
			int num6 = -1;
			int num7 = -1;
			m_GameState = ((!m_Fighter[id].IsSelf) ? Define.GameState.Enemy_Move_Ready : Define.GameState.SelfAI_Move_Ready);
			if (dictionary.Count > 0)
			{
				foreach (int key4 in dictionary.Keys)
				{
					foreach (int item5 in dictionary[key4])
					{
						if ((num6 == -1 || AttackPriority(num6, item5) == item5) && WeaponPriority((num7 != -1) ? m_TargetOne.Weapon[num7] : num7, m_TargetOne.Weapon[key4], GetFighterEngineType(item5)))
						{
							num6 = item5;
							point5 = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
							num7 = key4;
						}
					}
				}
			}
			Define.Point[] canMovePoint3 = m_TargetOne.GetCanMovePoint();
			foreach (Define.Point point6 in canMovePoint3)
			{
				for (int n = 0; n < m_TargetOne.Weapon.Count; n++)
				{
					List<int> list3 = SkillHasTarget(point6, m_TargetOne.Weapon[n], m_Fighter[id].IsSelf);
					if (list3.Count <= 0)
					{
						continue;
					}
					foreach (int item6 in list3)
					{
						if ((num6 == -1 || AttackPriority(num6, item6) == item6) && WeaponPriority((num7 != -1) ? m_TargetOne.Weapon[num7] : num7, m_TargetOne.Weapon[n], GetFighterEngineType(item6)))
						{
							num6 = item6;
							point5 = point6;
							num7 = n;
						}
					}
				}
			}
			if (num6 != -1)
			{
				if (num7 != -1 && point5.X == m_TargetOne.X && point5.Y == m_TargetOne.Y)
				{
					m_GameState = ((!m_Fighter[id].IsSelf) ? Define.GameState.Enemy : Define.GameState.SelfAI);
					DoBattle(m_TargetOne.ID, m_TargetOne.Weapon[num7], num6);
					m_TargetOne = null;
				}
				else
				{
					m_GameState = ((!m_Fighter[id].IsSelf) ? Define.GameState.Enemy_Move : Define.GameState.SelfAI_Move);
					m_MapData[m_TargetOne.X][m_TargetOne.Y].TakeOff();
					m_Fighter[id].DoMovePath(m_TargetOne.GetMovePath(point5));
					LookFighter = m_Fighter[id];
				}
				break;
			}
			int num8 = int.MaxValue;
			Define.Point point7 = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
			int num9 = -1;
			foreach (int key5 in m_Fighter.Keys)
			{
				if (m_Fighter[key5].IsSelf != m_Fighter[id].IsSelf && m_Fighter[key5].gameObject.activeSelf)
				{
					int pathAffect2 = GetPathAffect(m_TargetOne.EngineType, CreatePath(new Define.Point(m_TargetOne.X, m_TargetOne.Y), new Define.Point(m_Fighter[key5].X, m_Fighter[key5].Y), m_TargetOne.EngineType));
					if (pathAffect2 < num8)
					{
						num8 = pathAffect2;
						num9 = key5;
					}
				}
			}
			m_TargetOne.CanMovePath = null;
			GetMaxMoveRange(m_TargetOne);
			if (num9 != -1)
			{
				Define.Point[] canMovePoint4 = m_TargetOne.GetCanMovePoint();
				for (int num10 = 0; num10 < canMovePoint4.Length; num10++)
				{
					Define.Point point8 = canMovePoint4[num10];
					List<Define.Point> path = CreatePath(point8, new Define.Point(m_Fighter[num9].X, m_Fighter[num9].Y), m_TargetOne.EngineType);
					int pathAffect3 = GetPathAffect(m_TargetOne.EngineType, path);
					if (pathAffect3 < num8 && m_MapData[point8.X][point8.Y].FighterID == -1)
					{
						num8 = pathAffect3;
						point7 = point8;
					}
				}
			}
			if (point7.X == m_TargetOne.X && point7.Y == m_TargetOne.Y)
			{
				m_GameState = ((!m_Fighter[id].IsSelf) ? Define.GameState.Enemy : Define.GameState.SelfAI);
				m_TargetOne.IsAction = true;
				m_Fighter[id].SetBlack(black: true);
				m_TargetOne = null;
			}
			else
			{
				m_GameState = ((!m_Fighter[id].IsSelf) ? Define.GameState.Enemy_Move : Define.GameState.SelfAI_Move);
				m_MapData[m_TargetOne.X][m_TargetOne.Y].TakeOff();
				m_Fighter[id].DoMovePath(m_TargetOne.GetMovePath(point7));
				LookFighter = m_Fighter[id];
			}
			break;
		}
		case Define.AIType.Retreat:
		{
			m_TargetOne.CanMovePath = null;
			GetMoveRange(m_TargetOne);
			int num2 = int.MaxValue;
			Define.Point point = new Define.Point(m_TargetOne.X, m_TargetOne.Y);
			int num3 = -1;
			foreach (int key6 in m_Fighter.Keys)
			{
				if (m_Fighter[key6].IsSelf != m_Fighter[id].IsSelf)
				{
					int count = CreatePath(new Define.Point(m_TargetOne.X, m_TargetOne.Y), new Define.Point(m_Fighter[key6].X, m_Fighter[key6].Y), m_TargetOne.EngineType).Count;
					if (count < num2)
					{
						num2 = count;
						num3 = key6;
					}
				}
			}
			num2 = 0;
			if (num3 != -1)
			{
				Define.Point[] canMovePoint = m_TargetOne.GetCanMovePoint();
				for (int j = 0; j < canMovePoint.Length; j++)
				{
					Define.Point point2 = canMovePoint[j];
					int pathAffect = GetPathAffect(m_TargetOne.EngineType, CreatePath(point2, new Define.Point(m_Fighter[num3].X, m_Fighter[num3].Y), m_TargetOne.EngineType));
					if (pathAffect > num2 && m_MapData[point2.X][point2.Y].FighterID == -1)
					{
						num2 = pathAffect;
						point = point2;
					}
				}
			}
			if (point.X == m_TargetOne.X && point.Y == m_TargetOne.Y)
			{
				m_GameState = ((!m_Fighter[id].IsSelf) ? Define.GameState.Enemy : Define.GameState.SelfAI);
				m_TargetOne.IsAction = true;
				m_Fighter[id].SetBlack(black: true);
				m_TargetOne = null;
			}
			else
			{
				m_GameState = ((!m_Fighter[id].IsSelf) ? Define.GameState.Enemy_Move : Define.GameState.SelfAI_Move);
				m_MapData[m_TargetOne.X][m_TargetOne.Y].TakeOff();
				m_Fighter[id].DoMovePath(m_TargetOne.GetMovePath(point));
				LookFighter = m_Fighter[id];
			}
			break;
		}
		}
	}

	private void Update()
	{
		if (m_LookFighter != null)
		{
			LookPoint(m_LookFighter.GetPosition());
			return;
		}
		if (m_GameState == Define.GameState.DoEvent)
		{
			OnDoGameEvent();
			return;
		}
		if (m_GameState == Define.GameState.DoEvent_Wait)
		{
			if (Input.GetMouseButtonUp(0))
			{
				m_GameState = Define.GameState.DoEvent;
				AudioManager.Instance.PlaySE(0);
				MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_NextDialogue));
				OnDoGameEvent();
			}
			return;
		}
		if (m_GameState == Define.GameState.Wait)
		{
			if (Input.GetKeyDown(KeyCode.Escape))
			{
				AudioManager.Instance.PlaySE(0);
				MsgManager.Instance.PostMsg(new MsgBase(MsgDefine.MsgID.Msg_EscKeyDown));
			}
			return;
		}
		if (m_GameState == Define.GameState.Enemy)
		{
			foreach (int key in m_Fighter.Keys)
			{
				if (m_Fighter[key].IsSelf || m_Fighter[key].IsAction)
				{
					continue;
				}
				EnemyDoThink(key);
				return;
			}
			NextReprise();
		}
		if (m_GameState != Define.GameState.SelfAI)
		{
			return;
		}
		foreach (int key2 in m_Fighter.Keys)
		{
			if (!m_Fighter[key2].IsSelf || m_Fighter[key2].AIType == Define.AIType.Null || m_Fighter[key2].IsAction)
			{
				continue;
			}
			EnemyDoThink(key2);
			return;
		}
		m_ScrollRect.enabled = true;
		m_GameState = Define.GameState.Wait;
		foreach (int key3 in m_Fighter.Keys)
		{
			if (!m_Fighter[key3].IsSelf || !m_Fighter[key3].gameObject.activeSelf)
			{
				continue;
			}
			LookPoint(new Define.Point(m_Fighter[key3].X, m_Fighter[key3].Y));
			break;
		}
	}
}
