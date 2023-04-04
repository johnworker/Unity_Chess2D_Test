using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MsgDefine
{
	public enum MsgID
	{
		Msg_LoadLevel = 0,
		Msg_ClickFighter = 1,
		Msg_ClickTerrain = 2,
		Msg_Dialogue = 3,
		Msg_NextDialogue = 4,
		Msg_ShowMenu = 5,
		Msg_ShowTask = 6,
		Msg_ShowBase = 7,
		Msg_ShowWeapon = 8,
		Msg_OnMoveOver = 10,
		Msg_CloseMenu = 11,
		Msg_TakeOff = 12,
		Msg_ShowAllVariant = 13,
		Msg_DoVariant = 14,
		Msg_DoTakeOff = 15,
		Msg_ShowTroops = 16,
		Msg_ShowHint = 17,
		Msg_ResetMenu = 18,
		Msg_ShowWeaponRange = 19,
		Msg_GameOver = 20,
		Msg_Effect = 21,
		Msg_EnterFighter = 22,
		Msg_ShowBaseSkew = 23,
		Msg_ExitFighter = 24,
		Msg_GameEnd = 25,
		Msg_BackTitle = 26,
		Msg_ShowSpirit = 27,
		Msg_UseSpirit = 28,
		Msg_ShowShop = 29,
		Msg_ShowTools = 30,
		Msg_UseTools = 31,
		Msg_CloseShop = 32,
		Msg_ReachSuccess = 33,
		Msg_OpenSuccess = 34,
		Msg_EscKeyDown = 35,
		Msg_ShowPlan = 36,
		Msg_ShowLevelTittle = 37
	}

	public class MsgPrame_ShowPlan : MsgBase
	{
		public MsgPrame_ShowPlan()
			: base(MsgID.Msg_ShowPlan)
		{
		}
	}

	public class MsgPrame_ReachSuccess : MsgBase
	{
		private int m_ID;

		public int ID => m_ID;

		public MsgPrame_ReachSuccess(int id)
			: base(MsgID.Msg_ReachSuccess)
		{
			m_ID = id;
		}
	}

	public class MsgPrame_UseTools : MsgBase
	{
		private int m_ItemID;

		public int ItemID => m_ItemID;

		public MsgPrame_UseTools(int itemID)
			: base(MsgID.Msg_UseTools)
		{
			m_ItemID = itemID;
		}
	}

	public class MsgPrame_ShowTools : MsgBase
	{
		private Dictionary<int, int> m_AllTools;

		public Dictionary<int, int> AllTools => m_AllTools;

		public MsgPrame_ShowTools(Dictionary<int, int> tools)
			: base(MsgID.Msg_ShowTools)
		{
			m_AllTools = tools;
		}
	}

	public class MsgPrame_ShowShop : MsgBase
	{
		private List<int> m_GoodsID;

		public List<int> GoodsID => m_GoodsID;

		public MsgPrame_ShowShop(List<int> goodsID)
			: base(MsgID.Msg_ShowShop)
		{
			m_GoodsID = goodsID;
		}
	}

	public class MsgPrame_UseSpirit : MsgBase
	{
		private int m_Spirit;

		private int m_FighterID;

		public int Spirit => m_Spirit;

		public int FighterID => m_FighterID;

		public MsgPrame_UseSpirit(int fighterID, int spirit)
			: base(MsgID.Msg_UseSpirit)
		{
			m_Spirit = spirit;
			m_FighterID = fighterID;
		}
	}

	public class MsgPrame_ShowSpirit : MsgBase
	{
		private List<int> m_Spirit;

		private int m_FighterID;

		public List<int> Spirit => m_Spirit;

		public int FighterID => m_FighterID;

		public MsgPrame_ShowSpirit(int fighterID, List<int> spirit)
			: base(MsgID.Msg_ShowSpirit)
		{
			m_Spirit = spirit;
			m_FighterID = fighterID;
		}
	}

	public class MsgPrame_ShowWeaponRange : MsgBase
	{
		private int m_WeaponID;

		private int m_FighterID;

		public int WeaponID => m_WeaponID;

		public int FighterID => m_FighterID;

		public MsgPrame_ShowWeaponRange(int fighterID, int weaponID)
			: base(MsgID.Msg_ShowWeaponRange)
		{
			m_WeaponID = weaponID;
			m_FighterID = fighterID;
		}
	}

	public class MsgPrame_ShowWeapon : MsgBase
	{
		private List<int> m_WeaponList;

		private Fighter m_Fighter;

		public List<int> WeaponList => m_WeaponList;

		public Fighter Fighter => m_Fighter;

		public MsgPrame_ShowWeapon(Fighter fighter, List<int> weaponList)
			: base(MsgID.Msg_ShowWeapon)
		{
			m_WeaponList = weaponList;
			m_Fighter = fighter;
		}
	}

	public class MsgPrame_ShowHint : MsgBase
	{
		private Fighter m_Fighter;

		public Fighter Fighter => m_Fighter;

		public MsgPrame_ShowHint(Fighter fighter)
			: base(MsgID.Msg_ShowHint)
		{
			m_Fighter = fighter;
		}
	}

	public class MsgPrame_ShowTroops : MsgBase
	{
		private List<Fighter> m_Troops;

		private List<Fighter> m_CarryFighter;

		public List<Fighter> Troops => m_Troops;

		public List<Fighter> CarryFighter => m_CarryFighter;

		public MsgPrame_ShowTroops(List<Fighter> troops, List<Fighter> carry)
			: base(MsgID.Msg_ShowTroops)
		{
			m_Troops = troops;
			m_CarryFighter = carry;
		}
	}

	public class MsgPrame_DoTakeOff : MsgBase
	{
		private Fighter m_Fighter;

		private Fighter m_Carry;

		public Fighter Fighter => m_Fighter;

		public Fighter Carry => m_Carry;

		public MsgPrame_DoTakeOff(Fighter carry, Fighter fighter)
			: base(MsgID.Msg_DoTakeOff)
		{
			m_Carry = carry;
			m_Fighter = fighter;
		}
	}

	public class MsgPrame_DoVariant : MsgBase
	{
		private Fighter m_Fighter;

		private Actor.ActorData m_ActorData;

		public Fighter Fighter => m_Fighter;

		public Actor.ActorData ActorData => m_ActorData;

		public MsgPrame_DoVariant(Fighter fighter, Actor.ActorData actorData)
			: base(MsgID.Msg_DoVariant)
		{
			m_Fighter = fighter;
			m_ActorData = actorData;
		}
	}

	public class MsgPrame_ShowAllVariant : MsgBase
	{
		private Fighter m_Fighter;

		public Fighter Fighter => m_Fighter;

		public MsgPrame_ShowAllVariant(Fighter fighter)
			: base(MsgID.Msg_ShowAllVariant)
		{
			m_Fighter = fighter;
		}
	}

	public class MsgPrame_ShowBase : MsgBase
	{
		private Fighter m_Fighter;

		public Fighter Fighter => m_Fighter;

		public MsgPrame_ShowBase(Fighter fighter)
			: base(MsgID.Msg_ShowBase)
		{
			m_Fighter = fighter;
		}
	}

	public class MsgPrame_TakeOff : MsgBase
	{
		private List<Fighter> m_Fighter;

		private Fighter m_Carry;

		public List<Fighter> Fighter => m_Fighter;

		public Fighter Carry => m_Carry;

		public MsgPrame_TakeOff(Fighter carry, List<Fighter> fighter)
			: base(MsgID.Msg_TakeOff)
		{
			m_Fighter = fighter;
			m_Carry = carry;
		}
	}

	public class MsgPrame_ShowTask : MsgBase
	{
		private string m_Task;

		public string Task => m_Task;

		public MsgPrame_ShowTask(string task)
			: base(MsgID.Msg_ShowTask)
		{
			m_Task = task;
		}
	}

	public class MsgPrame_ShowMenu : MsgBase
	{
		private Dictionary<Define.MenuType, UnityAction> m_MuneItem;

		public Dictionary<Define.MenuType, UnityAction> MuneItem => m_MuneItem;

		public MsgPrame_ShowMenu(Dictionary<Define.MenuType, UnityAction> item)
			: base(MsgID.Msg_ShowMenu)
		{
			m_MuneItem = item;
		}
	}

	public class MsgPrame_Dialogue : MsgBase
	{
		private int m_Hand;

		private string m_Name;

		private string m_Line;

		private Vector2 m_Pos;

		public int Hand => m_Hand;

		public string Name => m_Name;

		public string Line => m_Line;

		public Vector2 Pos => m_Pos;

		public MsgPrame_Dialogue(string line, string name, int hand, Vector2 pos)
			: base(MsgID.Msg_Dialogue)
		{
			m_Hand = hand;
			m_Name = name;
			m_Line = line;
			m_Pos = pos;
		}
	}

	public class MsgPrame_LoadLevel : MsgBase
	{
		private int m_Level;

		public int Level => m_Level;

		public MsgPrame_LoadLevel(int level)
			: base(MsgID.Msg_LoadLevel)
		{
			m_Level = level;
		}
	}

	public class MsgPrame_ShowBaseSkew : MsgBase
	{
		private Fighter m_Fighter;

		public Fighter Fighter => m_Fighter;

		public MsgPrame_ShowBaseSkew(Fighter fighter)
			: base(MsgID.Msg_ShowBaseSkew)
		{
			m_Fighter = fighter;
		}
	}

	public class MsgPrame_EnterFighter : MsgBase
	{
		private Fighter m_Fighter;

		public Fighter EnterFighter => m_Fighter;

		public MsgPrame_EnterFighter(Fighter fighter)
			: base(MsgID.Msg_EnterFighter)
		{
			m_Fighter = fighter;
		}
	}

	public class MsgPrame_ClickFighter : MsgBase
	{
		private Fighter m_Fighter;

		public Fighter ClickFighter => m_Fighter;

		public MsgPrame_ClickFighter(Fighter fighter)
			: base(MsgID.Msg_ClickFighter)
		{
			m_Fighter = fighter;
		}
	}

	public class MsgPrame_ClickTerrain : MsgBase
	{
		private Terrain m_Terrain;

		private int m_X;

		private int m_Y;

		public Terrain ClickTerrain => m_Terrain;

		public int X => m_X;

		public int Y => m_Y;

		public MsgPrame_ClickTerrain(Terrain terrain, int x, int y)
			: base(MsgID.Msg_ClickTerrain)
		{
			m_Terrain = terrain;
			m_X = x;
			m_Y = y;
		}
	}
}
