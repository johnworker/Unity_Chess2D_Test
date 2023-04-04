using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneHint : MonoBehaviour
{
	public Image Hand;

	public Image Battle;

	public Text UserName;

	public Text RobotName;

	public Text RobotType;

	public Text Speed;

	public Text Spirit;

	public Text Level;

	public Text Exp;

	public Text Str;

	public Text Def;

	public Text Agi;

	public Text Hp;

	public Text Trait;

	public GameObject Skill1;

	public Text Skill1Name;

	public Text Skill1Hit;

	public Text Skill1Range;

	public Text Skill1Sea;

	public Text Skill1Land;

	public Text Skill1Sky;

	public GameObject Skill2;

	public Text Skill2Name;

	public Text Skill2Hit;

	public Text Skill2Range;

	public Text Skill2Sea;

	public Text Skill2Land;

	public Text Skill2Sky;

	private void Start()
	{
		MsgManager.Instance.Listen(MsgDefine.MsgID.Msg_ShowHint, ShowHint);
		base.gameObject.SetActive(value: false);
	}

	private void ShowHint(object prame)
	{
		MsgDefine.MsgPrame_ShowHint msgPrame_ShowHint = (MsgDefine.MsgPrame_ShowHint)prame;
		Battle.sprite = ((msgPrame_ShowHint.Fighter.Battle != -1) ? DataManager.Instance.BattleSprite[msgPrame_ShowHint.Fighter.Battle] : null);
		if (msgPrame_ShowHint.Fighter.Hand == -1)
		{
			Hand.color = new Color(0f, 0f, 0f, 0f);
			Hand.sprite = null;
		}
		else
		{
			Hand.color = new Color(1f, 1f, 1f, 1f);
			Hand.sprite = DataManager.Instance.HandSprite[msgPrame_ShowHint.Fighter.Hand];
		}
		UserName.text = msgPrame_ShowHint.Fighter.UserName;
		RobotName.text = msgPrame_ShowHint.Fighter.RobotName;
		switch (msgPrame_ShowHint.Fighter.EngineType)
		{
		case Robot.EngineType.Sea:
			RobotType.text = "海";
			break;
		case Robot.EngineType.Land:
			RobotType.text = "陆";
			break;
		case Robot.EngineType.Sky:
			RobotType.text = "空";
			break;
		}
		bool flag = !msgPrame_ShowHint.Fighter.IsSelf && msgPrame_ShowHint.Fighter.HasTrait(Define.UserTrait.ShenMiJiTi);
		if (flag)
		{
			Speed.text = "???";
			Spirit.text = "???/???";
			Level.text = "???";
			Str.text = "????";
			Def.text = "????";
			Agi.text = "????";
			Hp.text = "????/????";
		}
		else
		{
			Speed.text = msgPrame_ShowHint.Fighter.Speed.ToString();
			Spirit.text = msgPrame_ShowHint.Fighter.NSP + "/" + msgPrame_ShowHint.Fighter.SP;
			Level.text = msgPrame_ShowHint.Fighter.Level.ToString();
			Str.text = msgPrame_ShowHint.Fighter.Str.ToString();
			Def.text = msgPrame_ShowHint.Fighter.Def.ToString();
			Agi.text = msgPrame_ShowHint.Fighter.Agi.ToString();
			Hp.text = msgPrame_ShowHint.Fighter.NHP + "/" + msgPrame_ShowHint.Fighter.HP;
		}
		if (msgPrame_ShowHint.Fighter.IsSelf && msgPrame_ShowHint.Fighter.AIType == Define.AIType.Null)
		{
			Exp.text = msgPrame_ShowHint.Fighter.Exp + "/" + Define.GetLevelNextExp(msgPrame_ShowHint.Fighter.Level);
		}
		else
		{
			Exp.text = 0 + "/" + 0;
		}
		string text = "特性:";
		if (msgPrame_ShowHint.Fighter.Trait.Count == 0)
		{
			text += "\n无";
		}
		else
		{
			foreach (Define.UserTrait item in msgPrame_ShowHint.Fighter.Trait)
			{
				text = text + "\n" + Define.TraitString(item);
			}
		}
		Trait.text = text;
		List<int> weapon = msgPrame_ShowHint.Fighter.Weapon;
		Weapon weapon2 = GameDataBase.Instance.GetWeapon(weapon[0]);
		Weapon weapon3 = ((weapon.Count > 1) ? GameDataBase.Instance.GetWeapon(weapon[1]) : null);
		if (weapon2 == null)
		{
			Skill1.SetActive(value: false);
		}
		else
		{
			Skill1.SetActive(value: true);
			Skill1Name.text = weapon2.Name;
			Skill1Hit.text = weapon2.Hit.ToString();
			Skill1Range.text = weapon2.Range.ToString();
			if (flag)
			{
				Skill1Sea.text = "????";
				Skill1Land.text = "????";
				Skill1Sky.text = "????";
			}
			else
			{
				Skill1Sea.text = ((weapon2.FireSea != 0) ? (weapon2.FireSea + msgPrame_ShowHint.Fighter.Str).ToString() : "----");
				Skill1Land.text = ((weapon2.FireLand != 0) ? (weapon2.FireLand + msgPrame_ShowHint.Fighter.Str).ToString() : "----");
				Skill1Sky.text = ((weapon2.FireSky != 0) ? (weapon2.FireSky + msgPrame_ShowHint.Fighter.Str).ToString() : "----");
			}
		}
		if (weapon3 == null)
		{
			Skill2.SetActive(value: false);
		}
		else
		{
			Skill2.SetActive(value: true);
			Skill2Name.text = weapon3.Name;
			Skill2Hit.text = weapon3.Hit.ToString();
			Skill2Range.text = weapon3.Range.ToString();
			if (flag)
			{
				Skill2Sea.text = "????";
				Skill2Land.text = "????";
				Skill2Sky.text = "????";
			}
			else
			{
				Skill2Sea.text = ((weapon3.FireSea != 0) ? (weapon3.FireSea + msgPrame_ShowHint.Fighter.Str).ToString() : "----");
				Skill2Land.text = ((weapon3.FireLand != 0) ? (weapon3.FireLand + msgPrame_ShowHint.Fighter.Str).ToString() : "----");
				Skill2Sky.text = ((weapon3.FireSky != 0) ? (weapon3.FireSky + msgPrame_ShowHint.Fighter.Str).ToString() : "----");
			}
		}
		base.gameObject.SetActive(value: true);
	}

	public void ClickThis()
	{
		AudioManager.Instance.PlaySE(0);
		base.gameObject.SetActive(value: false);
	}

	private void Update()
	{
	}
}
