using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SceneMenu : MonoBehaviour
{
	public Image TaskPanel;

	public Text TaskText;

	public Image BasePanel;

	public Image HandImage;

	public Text BaseName;

	public Text BaseLevel;

	public Text BaseHp;

	public Image WeaponPanel;

	public Text WeaponRange;

	public Text WeaponHit;

	public Text WeaponFire;

	public Image MenuPanel;

	public Button MoveItem;

	public Button DeformItem;

	public Button SpiritItem;

	public Button StateItem;

	public Button ToolItem;

	public Button FinishItem;

	public Button SaveItem;

	public Button TroopsItem;

	public Button AttackItem;

	public Button CarryItem;

	public Button CancelItem;

	public Button TakeOffItem;

	public Button SuspendItem;

	public Button CapitulateItem;

	public EventTrigger[] WeaponItems;

	public Text[] WeaponTexts;

	public Image DescribePanel;

	public Text DescribeText;

	private Dictionary<Fighter, Text> m_TakeOffButton = new Dictionary<Fighter, Text>();

	private Dictionary<Actor.ActorData, Button> m_VariantButton = new Dictionary<Actor.ActorData, Button>();

	private Dictionary<Fighter, Text> m_TroopsButton = new Dictionary<Fighter, Text>();

	private Dictionary<Spirit, EventTrigger> m_SpiritButton = new Dictionary<Spirit, EventTrigger>();

	private Dictionary<int, EventTrigger> m_ToolsButton = new Dictionary<int, EventTrigger>();

	private void Start()
	{
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_CloseMenu, CloseMenu);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ShowMenu, ShowMenu);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ShowTask, ShowTask);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ShowBase, ShowBase);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ShowWeapon, ShowWeapon);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_TakeOff, ShowTakeOff);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ShowAllVariant, ShowAllVariant);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ShowTroops, ShowTroops);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ShowBaseSkew, ShowBaseSkew);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ResetMenu, ResetMenu);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ShowSpirit, ShowSpirit);
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ShowTools, ShowTools);
		CloseMenu();
	}

	private void ShowDescribe(string describe)
	{
		if (MenuPanel.gameObject.activeSelf)
		{
			LayoutRebuilder.ForceRebuildLayoutImmediate(MenuPanel.rectTransform);
			if (Input.mousePosition.x > (float)(Define.WindowWidth / 2))
			{
				DescribePanel.rectTransform.localPosition = new Vector2(MenuPanel.rectTransform.localPosition.x - (DescribePanel.rectTransform.sizeDelta.x + MenuPanel.rectTransform.sizeDelta.x) / 2f, MenuPanel.rectTransform.localPosition.y);
			}
			else
			{
				DescribePanel.rectTransform.localPosition = new Vector2(MenuPanel.rectTransform.localPosition.x + (DescribePanel.rectTransform.sizeDelta.x + MenuPanel.rectTransform.sizeDelta.x) / 2f, MenuPanel.rectTransform.localPosition.y);
			}
		}
		else
		{
			TaskPanel.rectTransform.localPosition = MouseToGamePos();
		}
		DescribeText.text = describe;
		DescribePanel.gameObject.SetActive(value: true);
	}

	private void ShowTools(object prame)
	{
		CloseMenu();
		MsgDefine.MsgPrame_ShowTools data = (MsgDefine.MsgPrame_ShowTools)prame;
		foreach (int id in data.AllTools.Keys)
		{
			Item item = GameDataBase.Instance.GetItem(id);
			if (!m_ToolsButton.ContainsKey(id))
			{
				GameObject gameObject = new GameObject();
				gameObject.transform.SetParent(MenuPanel.gameObject.transform);
				EventTrigger value = gameObject.AddComponent<EventTrigger>();
				Text text = gameObject.AddComponent<Text>();
				text.rectTransform.localScale = new Vector3(1f, 1f, 1f);
				text.rectTransform.sizeDelta = new Vector2(300f, 75f);
				text.font = DataManager.Instance.Font;
				text.fontStyle = FontStyle.Normal;
				text.fontSize = 64;
				text.alignment = TextAnchor.MiddleCenter;
				text.text = item.Name;
				text.color = new Color(1f, 1f, 1f, 1f);
				m_ToolsButton.Add(id, value);
			}
			m_ToolsButton[id].triggers.Clear();
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = EventTriggerType.PointerEnter;
			UnityAction<BaseEventData> call = delegate
			{
				string text2 = "拥有:" + data.AllTools[id] + "个 \n";
				ShowDescribe(text2 + item.Describe);
			};
			entry.callback.AddListener(call);
			EventTrigger.Entry entry2 = new EventTrigger.Entry();
			entry2.eventID = EventTriggerType.PointerClick;
			UnityAction<BaseEventData> call2 = delegate
			{
				CloseMenu();
				MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_UseTools(id));
			};
			entry2.callback.AddListener(call2);
			m_ToolsButton[id].triggers.Add(entry);
			m_ToolsButton[id].triggers.Add(entry2);
			m_ToolsButton[id].gameObject.SetActive(value: true);
		}
		base.gameObject.SetActive(value: true);
		MenuPanel.gameObject.SetActive(value: true);
		MenuPanel.rectTransform.localPosition = MouseToGamePos();
	}

	private void ShowSpirit(object prame)
	{
		CloseMenu();
		MsgDefine.MsgPrame_ShowSpirit data = (MsgDefine.MsgPrame_ShowSpirit)prame;
		foreach (int id in data.Spirit)
		{
			Spirit spirit = GameDataBase.Instance.GetSpirit(id);
			if (!m_SpiritButton.ContainsKey(spirit))
			{
				GameObject gameObject = new GameObject();
				gameObject.transform.SetParent(MenuPanel.gameObject.transform);
				EventTrigger value = gameObject.AddComponent<EventTrigger>();
				Text text = gameObject.AddComponent<Text>();
				text.rectTransform.localScale = new Vector3(1f, 1f, 1f);
				text.rectTransform.sizeDelta = new Vector2(300f, 75f);
				text.font = DataManager.Instance.Font;
				text.fontStyle = FontStyle.Normal;
				text.fontSize = 64;
				text.alignment = TextAnchor.MiddleCenter;
				text.text = spirit.Name;
				text.color = new Color(1f, 1f, 1f, 1f);
				m_SpiritButton.Add(spirit, value);
			}
			m_SpiritButton[spirit].triggers.Clear();
			EventTrigger.Entry entry = new EventTrigger.Entry();
			entry.eventID = EventTriggerType.PointerEnter;
			UnityAction<BaseEventData> call = delegate
			{
				string text2 = "消耗:" + spirit.Expend + "SP \n";
				ShowDescribe(text2 + spirit.Describe);
			};
			entry.callback.AddListener(call);
			EventTrigger.Entry entry2 = new EventTrigger.Entry();
			entry2.eventID = EventTriggerType.PointerClick;
			UnityAction<BaseEventData> call2 = delegate
			{
				CloseMenu();
				MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_UseSpirit(data.FighterID, id));
			};
			entry2.callback.AddListener(call2);
			m_SpiritButton[spirit].triggers.Add(entry);
			m_SpiritButton[spirit].triggers.Add(entry2);
			m_SpiritButton[spirit].gameObject.SetActive(value: true);
		}
		base.gameObject.SetActive(value: true);
		MenuPanel.gameObject.SetActive(value: true);
		MenuPanel.rectTransform.localPosition = MouseToGamePos();
	}

	private void ResetMenu(object prame)
	{
		foreach (Fighter key in m_TakeOffButton.Keys)
		{
			Object.Destroy(m_TakeOffButton[key].gameObject);
		}
		foreach (Actor.ActorData key2 in m_VariantButton.Keys)
		{
			Object.Destroy(m_VariantButton[key2].gameObject);
		}
		foreach (Fighter key3 in m_TroopsButton.Keys)
		{
			Object.Destroy(m_TroopsButton[key3].gameObject);
		}
		foreach (Spirit key4 in m_SpiritButton.Keys)
		{
			Object.Destroy(m_SpiritButton[key4].gameObject);
		}
		foreach (int key5 in m_ToolsButton.Keys)
		{
			Object.Destroy(m_ToolsButton[key5].gameObject);
		}
		m_TakeOffButton.Clear();
		m_VariantButton.Clear();
		m_TroopsButton.Clear();
		m_SpiritButton.Clear();
		m_ToolsButton.Clear();
	}

	private void ShowWeaponInfo(Weapon weapon, int str)
	{
		if (MenuPanel.gameObject.activeSelf)
		{
			if (Input.mousePosition.x > (float)(Define.WindowWidth / 2))
			{
				WeaponPanel.rectTransform.localPosition = new Vector2(MenuPanel.rectTransform.localPosition.x - (WeaponPanel.rectTransform.sizeDelta.x + MenuPanel.rectTransform.sizeDelta.x) / 2f, MenuPanel.rectTransform.localPosition.y);
			}
			else
			{
				WeaponPanel.rectTransform.localPosition = new Vector2(MenuPanel.rectTransform.localPosition.x + (WeaponPanel.rectTransform.sizeDelta.x + MenuPanel.rectTransform.sizeDelta.x) / 2f, MenuPanel.rectTransform.localPosition.y);
			}
		}
		else
		{
			WeaponPanel.rectTransform.localPosition = MouseToGamePos();
		}
		WeaponRange.text = "范围: " + weapon.Range;
		WeaponHit.text = "命中: " + weapon.Hit;
		WeaponFire.text = "海: " + ((weapon.FireSea != 0) ? (weapon.FireSea + str).ToString() : "----") + " 陆:" + ((weapon.FireLand != 0) ? (weapon.FireLand + str).ToString() : "----") + " 空: " + ((weapon.FireSky != 0) ? (weapon.FireSky + str).ToString() : "----");
		WeaponPanel.gameObject.SetActive(value: true);
	}

	private void ShowWeapon(object prame)
	{
		CloseMenu();
		MsgDefine.MsgPrame_ShowWeapon data = (MsgDefine.MsgPrame_ShowWeapon)prame;
		WeaponTexts[0].text = GameDataBase.Instance.GetWeapon(data.WeaponList[0]).Name;
		WeaponItems[0].triggers.Clear();
		WeaponItems[0].gameObject.SetActive(value: true);
		EventTrigger.Entry entry = new EventTrigger.Entry();
		entry.eventID = EventTriggerType.PointerEnter;
		UnityAction<BaseEventData> call = delegate
		{
			ShowWeaponInfo(GameDataBase.Instance.GetWeapon(data.WeaponList[0]), data.Fighter.Str);
		};
		entry.callback.AddListener(call);
		EventTrigger.Entry entry2 = new EventTrigger.Entry();
		entry2.eventID = EventTriggerType.PointerClick;
		UnityAction<BaseEventData> call2 = delegate
		{
			CloseMenu();
			MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowWeaponRange(data.Fighter.ID, data.WeaponList[0]));
		};
		entry2.callback.AddListener(call2);
		WeaponItems[0].triggers.Add(entry);
		WeaponItems[0].triggers.Add(entry2);
		if (data.WeaponList.Count > 1)
		{
			WeaponTexts[1].text = GameDataBase.Instance.GetWeapon(data.WeaponList[1]).Name;
			WeaponItems[1].triggers.Clear();
			WeaponItems[1].gameObject.SetActive(value: true);
			entry = new EventTrigger.Entry();
			entry.eventID = EventTriggerType.PointerEnter;
			call = delegate
			{
				ShowWeaponInfo(GameDataBase.Instance.GetWeapon(data.WeaponList[1]), data.Fighter.Str);
			};
			entry.callback.AddListener(call);
			entry2 = new EventTrigger.Entry();
			entry2.eventID = EventTriggerType.PointerClick;
			call2 = delegate
			{
				CloseMenu();
				MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowWeaponRange(data.Fighter.ID, data.WeaponList[1]));
			};
			entry2.callback.AddListener(call2);
			WeaponItems[1].triggers.Add(entry);
			WeaponItems[1].triggers.Add(entry2);
		}
		base.gameObject.SetActive(value: true);
		MenuPanel.gameObject.SetActive(value: true);
		MenuPanel.rectTransform.localPosition = MouseToGamePos();
	}

	private void ShowTroops(object prame)
	{
		CloseMenu();
		MsgDefine.MsgPrame_ShowTroops msgPrame_ShowTroops = (MsgDefine.MsgPrame_ShowTroops)prame;
		foreach (Fighter fighter in msgPrame_ShowTroops.Troops)
		{
			if (!m_TroopsButton.ContainsKey(fighter))
			{
				GameObject gameObject = new GameObject();
				gameObject.transform.SetParent(MenuPanel.gameObject.transform);
				EventTrigger eventTrigger = gameObject.AddComponent<EventTrigger>();
				EventTrigger.Entry entry = new EventTrigger.Entry();
				entry.eventID = EventTriggerType.PointerEnter;
				UnityAction<BaseEventData> call = delegate
				{
					MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowBase(fighter));
				};
				entry.callback.AddListener(call);
				EventTrigger.Entry entry2 = new EventTrigger.Entry();
				entry2.eventID = EventTriggerType.PointerClick;
				UnityAction<BaseEventData> call2 = delegate
				{
					CloseMenu();
					MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ClickFighter(fighter));
				};
				entry2.callback.AddListener(call2);
				eventTrigger.triggers.Add(entry);
				eventTrigger.triggers.Add(entry2);
				Text text = gameObject.AddComponent<Text>();
				text.rectTransform.localScale = new Vector3(1f, 1f, 1f);
				text.rectTransform.sizeDelta = new Vector2(300f, 75f);
				text.font = DataManager.Instance.Font;
				text.fontStyle = FontStyle.Normal;
				text.fontSize = 64;
				text.alignment = TextAnchor.MiddleCenter;
				m_TroopsButton.Add(fighter, text);
			}
			if (fighter.IsAction)
			{
				m_TroopsButton[fighter].color = new Color(0f, 40f / 51f, 1f, 1f);
			}
			else
			{
				m_TroopsButton[fighter].color = new Color(1f, 1f, 1f, 1f);
			}
			m_TroopsButton[fighter].text = fighter.RobotName;
			m_TroopsButton[fighter].gameObject.SetActive(value: true);
		}
		foreach (Fighter item in msgPrame_ShowTroops.CarryFighter)
		{
			m_TroopsButton[item].text = "※" + item.RobotName;
		}
		base.gameObject.SetActive(value: true);
		MenuPanel.gameObject.SetActive(value: true);
		MenuPanel.rectTransform.localPosition = MouseToGamePos();
	}

	public void CloseMenu(object prame = null)
	{
		TaskPanel.gameObject.SetActive(value: false);
		BasePanel.gameObject.SetActive(value: false);
		WeaponPanel.gameObject.SetActive(value: false);
		MenuPanel.gameObject.SetActive(value: false);
		DescribePanel.gameObject.SetActive(value: false);
		MoveItem.gameObject.SetActive(value: false);
		DeformItem.gameObject.SetActive(value: false);
		SpiritItem.gameObject.SetActive(value: false);
		StateItem.gameObject.SetActive(value: false);
		ToolItem.gameObject.SetActive(value: false);
		FinishItem.gameObject.SetActive(value: false);
		SaveItem.gameObject.SetActive(value: false);
		TroopsItem.gameObject.SetActive(value: false);
		AttackItem.gameObject.SetActive(value: false);
		CarryItem.gameObject.SetActive(value: false);
		CancelItem.gameObject.SetActive(value: false);
		SuspendItem.gameObject.SetActive(value: false);
		TakeOffItem.gameObject.SetActive(value: false);
		CapitulateItem.gameObject.SetActive(value: false);
		foreach (Fighter key in m_TakeOffButton.Keys)
		{
			m_TakeOffButton[key].gameObject.SetActive(value: false);
		}
		foreach (Actor.ActorData key2 in m_VariantButton.Keys)
		{
			m_VariantButton[key2].gameObject.SetActive(value: false);
		}
		foreach (Fighter key3 in m_TroopsButton.Keys)
		{
			m_TroopsButton[key3].gameObject.SetActive(value: false);
		}
		foreach (Spirit key4 in m_SpiritButton.Keys)
		{
			m_SpiritButton[key4].gameObject.SetActive(value: false);
		}
		foreach (int key5 in m_ToolsButton.Keys)
		{
			m_ToolsButton[key5].gameObject.SetActive(value: false);
		}
		EventTrigger[] weaponItems = WeaponItems;
		foreach (EventTrigger eventTrigger in weaponItems)
		{
			eventTrigger.gameObject.SetActive(value: false);
		}
		base.gameObject.SetActive(value: false);
	}

	private void ShowBaseSkew(object prame)
	{
		CloseMenu();
		MsgDefine.MsgPrame_ShowBaseSkew msgPrame_ShowBaseSkew = (MsgDefine.MsgPrame_ShowBaseSkew)prame;
		Vector3 vector = MouseToGamePos();
		if (vector.x > (float)(Define.WindowWidth / 2))
		{
			BasePanel.rectTransform.localPosition = new Vector2(vector.x - (BasePanel.rectTransform.sizeDelta.x + 250f) / 2f, vector.y);
		}
		else
		{
			BasePanel.rectTransform.localPosition = new Vector2(vector.x + (BasePanel.rectTransform.sizeDelta.x + 250f) / 2f, vector.y);
		}
		if (msgPrame_ShowBaseSkew.Fighter.Hand == -1)
		{
			HandImage.sprite = null;
			HandImage.color = new Color(0f, 0f, 0f, 0f);
		}
		else
		{
			HandImage.sprite = DataManager.Instance.HandSprite[msgPrame_ShowBaseSkew.Fighter.Hand];
			HandImage.color = new Color(1f, 1f, 1f, 1f);
		}
		BaseName.text = msgPrame_ShowBaseSkew.Fighter.RobotName;
		if (!msgPrame_ShowBaseSkew.Fighter.IsSelf && msgPrame_ShowBaseSkew.Fighter.HasTrait(Define.UserTrait.ShenMiJiTi))
		{
			BaseLevel.text = "水平:???";
			BaseHp.text = "HP:????/????";
		}
		else
		{
			BaseLevel.text = "水平:" + msgPrame_ShowBaseSkew.Fighter.Level;
			BaseHp.text = "HP:" + msgPrame_ShowBaseSkew.Fighter.NHP + "/" + msgPrame_ShowBaseSkew.Fighter.HP;
		}
		base.gameObject.SetActive(value: true);
		BasePanel.gameObject.SetActive(value: true);
	}

	private void ShowBase(object prame)
	{
		MsgDefine.MsgPrame_ShowBase msgPrame_ShowBase = (MsgDefine.MsgPrame_ShowBase)prame;
		if (MenuPanel.gameObject.activeSelf)
		{
			LayoutRebuilder.ForceRebuildLayoutImmediate(MenuPanel.rectTransform);
			if (Input.mousePosition.x > (float)(Define.WindowWidth / 2))
			{
				BasePanel.rectTransform.localPosition = new Vector2(MenuPanel.rectTransform.localPosition.x - (BasePanel.rectTransform.sizeDelta.x + MenuPanel.rectTransform.sizeDelta.x) / 2f, MenuPanel.rectTransform.localPosition.y);
			}
			else
			{
				BasePanel.rectTransform.localPosition = new Vector2(MenuPanel.rectTransform.localPosition.x + (BasePanel.rectTransform.sizeDelta.x + MenuPanel.rectTransform.sizeDelta.x) / 2f, MenuPanel.rectTransform.localPosition.y);
			}
		}
		else
		{
			BasePanel.rectTransform.localPosition = MouseToGamePos();
		}
		if (msgPrame_ShowBase.Fighter.Hand == -1)
		{
			HandImage.sprite = null;
			HandImage.color = new Color(0f, 0f, 0f, 0f);
		}
		else
		{
			HandImage.sprite = DataManager.Instance.HandSprite[msgPrame_ShowBase.Fighter.Hand];
			HandImage.color = new Color(1f, 1f, 1f, 1f);
		}
		BaseName.text = msgPrame_ShowBase.Fighter.RobotName;
		BaseLevel.text = "水平:" + msgPrame_ShowBase.Fighter.Level;
		BaseHp.text = "HP:" + msgPrame_ShowBase.Fighter.NHP + "/" + msgPrame_ShowBase.Fighter.HP;
		BasePanel.gameObject.SetActive(value: true);
	}

	private void ShowAllVariant(object prame)
	{
		CloseMenu();
		MsgDefine.MsgPrame_ShowAllVariant data = (MsgDefine.MsgPrame_ShowAllVariant)prame;
		foreach (Actor.ActorData variant in data.Fighter.ActorDataList)
		{
			if (data.Fighter.NowActorDataIndex != data.Fighter.ActorDataList.IndexOf(variant))
			{
				if (!m_VariantButton.ContainsKey(variant))
				{
					GameObject gameObject = new GameObject();
					gameObject.transform.SetParent(MenuPanel.gameObject.transform);
					Button value = gameObject.AddComponent<Button>();
					Text text = gameObject.AddComponent<Text>();
					text.rectTransform.localScale = new Vector3(1f, 1f, 1f);
					text.rectTransform.sizeDelta = new Vector2(300f, 75f);
					text.font = DataManager.Instance.Font;
					text.fontStyle = FontStyle.Normal;
					text.text = GameDataBase.Instance.GetRobot(variant.RobotID).Name;
					text.fontSize = 64;
					text.alignment = TextAnchor.MiddleCenter;
					m_VariantButton.Add(variant, value);
				}
				m_VariantButton[variant].onClick.RemoveAllListeners();
				m_VariantButton[variant].onClick.AddListener(delegate
				{
					CloseMenu();
					MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_DoVariant(data.Fighter, variant));
				});
				m_VariantButton[variant].gameObject.SetActive(value: true);
			}
		}
		base.gameObject.SetActive(value: true);
		MenuPanel.gameObject.SetActive(value: true);
		MenuPanel.rectTransform.localPosition = MouseToGamePos();
	}

	private void ShowTakeOff(object prame)
	{
		CloseMenu();
		MsgDefine.MsgPrame_TakeOff data = (MsgDefine.MsgPrame_TakeOff)prame;
		foreach (Fighter fighter in data.Fighter)
		{
			if (!m_TakeOffButton.ContainsKey(fighter))
			{
				GameObject gameObject = new GameObject();
				gameObject.transform.SetParent(MenuPanel.gameObject.transform);
				EventTrigger eventTrigger = gameObject.AddComponent<EventTrigger>();
				EventTrigger.Entry entry = new EventTrigger.Entry();
				entry.eventID = EventTriggerType.PointerEnter;
				UnityAction<BaseEventData> call = delegate
				{
					MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_ShowBase(fighter));
				};
				entry.callback.AddListener(call);
				EventTrigger.Entry entry2 = new EventTrigger.Entry();
				entry2.eventID = EventTriggerType.PointerExit;
				UnityAction<BaseEventData> call2 = delegate
				{
					Debug.Log("鼠标移出");
				};
				entry2.callback.AddListener(call2);
				EventTrigger.Entry entry3 = new EventTrigger.Entry();
				entry3.eventID = EventTriggerType.PointerClick;
				UnityAction<BaseEventData> call3 = delegate
				{
					CloseMenu();
					MsgManager.Instance.PostMsg(new MsgDefine.MsgPrame_DoTakeOff(data.Carry, fighter));
				};
				entry3.callback.AddListener(call3);
				eventTrigger.triggers.Add(entry);
				eventTrigger.triggers.Add(entry2);
				eventTrigger.triggers.Add(entry3);
				Text text = gameObject.AddComponent<Text>();
				text.rectTransform.localScale = new Vector3(1f, 1f, 1f);
				text.rectTransform.sizeDelta = new Vector2(300f, 75f);
				text.font = DataManager.Instance.Font;
				text.fontStyle = FontStyle.Normal;
				text.fontSize = 64;
				text.alignment = TextAnchor.MiddleCenter;
				m_TakeOffButton.Add(fighter, text);
			}
			if (fighter.IsAction)
			{
				m_TakeOffButton[fighter].color = new Color(0f, 40f / 51f, 1f, 1f);
			}
			else
			{
				m_TakeOffButton[fighter].color = new Color(1f, 1f, 1f, 1f);
			}
			m_TakeOffButton[fighter].text = fighter.RobotName;
			m_TakeOffButton[fighter].gameObject.SetActive(value: true);
		}
		base.gameObject.SetActive(value: true);
		MenuPanel.gameObject.SetActive(value: true);
		MenuPanel.rectTransform.localPosition = MouseToGamePos();
	}

	private void ResetButtonClick(Button btn, UnityAction action)
	{
		btn.onClick.RemoveAllListeners();
		btn.gameObject.SetActive(value: true);
		btn.onClick.AddListener(action);
	}

	private Vector3 MouseToGamePos()
	{
		return Input.mousePosition - new Vector3(Define.WindowWidth / 2, Define.WindowHeight / 2);
	}

	private void ShowMenu(object prame)
	{
		CloseMenu();
		MsgDefine.MsgPrame_ShowMenu msgPrame_ShowMenu = (MsgDefine.MsgPrame_ShowMenu)prame;
		if (msgPrame_ShowMenu.MuneItem.Count == 0)
		{
			return;
		}
		foreach (Define.MenuType key in msgPrame_ShowMenu.MuneItem.Keys)
		{
			switch (key)
			{
			case Define.MenuType.Attack:
				ResetButtonClick(AttackItem, msgPrame_ShowMenu.MuneItem[key]);
				break;
			case Define.MenuType.Carry:
				ResetButtonClick(CarryItem, msgPrame_ShowMenu.MuneItem[key]);
				break;
			case Define.MenuType.Deform:
				ResetButtonClick(DeformItem, msgPrame_ShowMenu.MuneItem[key]);
				break;
			case Define.MenuType.Finish:
				ResetButtonClick(FinishItem, msgPrame_ShowMenu.MuneItem[key]);
				break;
			case Define.MenuType.Move:
				ResetButtonClick(MoveItem, msgPrame_ShowMenu.MuneItem[key]);
				break;
			case Define.MenuType.Save:
				ResetButtonClick(SaveItem, msgPrame_ShowMenu.MuneItem[key]);
				break;
			case Define.MenuType.Spirit:
				ResetButtonClick(SpiritItem, msgPrame_ShowMenu.MuneItem[key]);
				break;
			case Define.MenuType.State:
				ResetButtonClick(StateItem, msgPrame_ShowMenu.MuneItem[key]);
				break;
			case Define.MenuType.Tool:
				ResetButtonClick(ToolItem, msgPrame_ShowMenu.MuneItem[key]);
				break;
			case Define.MenuType.Troops:
				ResetButtonClick(TroopsItem, msgPrame_ShowMenu.MuneItem[key]);
				break;
			case Define.MenuType.Cancel:
				ResetButtonClick(CancelItem, msgPrame_ShowMenu.MuneItem[key]);
				break;
			case Define.MenuType.Suspend:
				ResetButtonClick(SuspendItem, msgPrame_ShowMenu.MuneItem[key]);
				break;
			case Define.MenuType.TakeOff:
				ResetButtonClick(TakeOffItem, msgPrame_ShowMenu.MuneItem[key]);
				break;
			case Define.MenuType.Capitulate:
				ResetButtonClick(CapitulateItem, msgPrame_ShowMenu.MuneItem[key]);
				break;
			}
		}
		base.gameObject.SetActive(value: true);
		MenuPanel.gameObject.SetActive(value: true);
		MenuPanel.rectTransform.localPosition = MouseToGamePos();
	}

	private void ShowTask(object prame)
	{
		MsgDefine.MsgPrame_ShowTask msgPrame_ShowTask = (MsgDefine.MsgPrame_ShowTask)prame;
		if (MenuPanel.gameObject.activeSelf)
		{
			LayoutRebuilder.ForceRebuildLayoutImmediate(MenuPanel.rectTransform);
			if (Input.mousePosition.x > (float)(Define.WindowWidth / 2))
			{
				TaskPanel.rectTransform.localPosition = new Vector2(MenuPanel.rectTransform.localPosition.x - (TaskPanel.rectTransform.sizeDelta.x + MenuPanel.rectTransform.sizeDelta.x) / 2f, MenuPanel.rectTransform.localPosition.y);
			}
			else
			{
				TaskPanel.rectTransform.localPosition = new Vector2(MenuPanel.rectTransform.localPosition.x + (TaskPanel.rectTransform.sizeDelta.x + MenuPanel.rectTransform.sizeDelta.x) / 2f, MenuPanel.rectTransform.localPosition.y);
			}
		}
		else
		{
			TaskPanel.rectTransform.localPosition = MouseToGamePos();
		}
		TaskText.text = msgPrame_ShowTask.Task;
		TaskPanel.gameObject.SetActive(value: true);
	}

	private void Update()
	{
	}
}
