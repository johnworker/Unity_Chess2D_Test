using System.Collections.Generic;
using UnityEngine;

public class Actor
{
	public struct ActorData
	{
		public int UserID;

		public int RobotID;

		public ActorData(int user, int robot)
		{
			UserID = user;
			RobotID = robot;
		}
	}

	public struct ActorDataEx
	{
		public Robot ActorRobot;

		public User ActorUser;

		public ActorDataEx(User user, Robot robot)
		{
			ActorRobot = robot;
			ActorUser = user;
		}
	}

	private int m_NowActorDataIndex;

	private List<ActorData> m_ActorData = new List<ActorData>();

	private List<ActorDataEx> m_ActorDataEx = new List<ActorDataEx>();

	private Define.AIType m_AIType;

	private int m_BGM = -1;

	private int m_HP;

	private int m_NHP;

	private int m_SP;

	private int m_NSP;

	private int m_Str;

	private int m_Def;

	private int m_Agi;

	private int m_Speed;

	private bool m_IsSelf;

	private int m_Level = 1;

	private int m_Exp;

	private int m_Money;

	private bool m_DataSource;

	public int[] BaseInfo
	{
		get
		{
			return new int[7] { m_Str, m_Def, m_Agi, m_HP, m_SP, m_Level, m_Exp };
		}
		set
		{
			m_Str = value[0];
			m_Def = value[1];
			m_Agi = value[2];
			m_HP = value[3];
			m_SP = value[4];
			m_Level = value[5];
			m_Exp = value[6];
		}
	}

	public int BaseStr
	{
		get
		{
			return m_Str;
		}
		set
		{
			m_Str = value;
		}
	}

	public int BaseDef
	{
		get
		{
			return m_Def;
		}
		set
		{
			m_Def = value;
		}
	}

	public int BaseAgi
	{
		get
		{
			return m_Agi;
		}
		set
		{
			m_Agi = value;
		}
	}

	public int BaseHP
	{
		get
		{
			return m_HP;
		}
		set
		{
			m_HP = value;
		}
	}

	public List<int> Weapon
	{
		get
		{
			if (m_DataSource)
			{
				return GameDataBase.Instance.GetRobot(m_ActorData[m_NowActorDataIndex].RobotID).Weapon;
			}
			return m_ActorDataEx[m_NowActorDataIndex].ActorRobot.Weapon;
		}
	}

	public List<int> Spirit
	{
		get
		{
			if (m_ActorData[m_NowActorDataIndex].UserID == -1)
			{
				return null;
			}
			if (m_DataSource)
			{
				return GameDataBase.Instance.GetUser(m_ActorData[m_NowActorDataIndex].UserID).Spirit;
			}
			return m_ActorDataEx[m_NowActorDataIndex].ActorUser.Spirit;
		}
	}

	public int Speed
	{
		get
		{
			if (m_DataSource)
			{
				return GameDataBase.Instance.GetRobot(m_ActorData[m_NowActorDataIndex].RobotID).Speed + m_Speed;
			}
			return m_ActorDataEx[m_NowActorDataIndex].ActorRobot.Speed + m_Speed;
		}
	}

	public HashSet<Define.UserTrait> Trait
	{
		get
		{
			if (m_DataSource)
			{
				return GameDataBase.Instance.GetRobot(m_ActorData[m_NowActorDataIndex].RobotID).Trait;
			}
			return m_ActorDataEx[m_NowActorDataIndex].ActorRobot.Trait;
		}
	}

	public Robot.EngineType EngineType
	{
		get
		{
			if (m_DataSource)
			{
				return GameDataBase.Instance.GetRobot(m_ActorData[m_NowActorDataIndex].RobotID).Type;
			}
			return m_ActorDataEx[m_NowActorDataIndex].ActorRobot.Type;
		}
	}

	public string UserName
	{
		get
		{
			if (m_DataSource)
			{
				if (m_ActorData[m_NowActorDataIndex].UserID == -1)
				{
					return string.Empty;
				}
				return GameDataBase.Instance.GetUser(m_ActorData[m_NowActorDataIndex].UserID).Name;
			}
			if (m_ActorDataEx[m_NowActorDataIndex].ActorUser == null)
			{
				return string.Empty;
			}
			return m_ActorDataEx[m_NowActorDataIndex].ActorUser.Name;
		}
	}

	public string RobotName
	{
		get
		{
			if (m_DataSource)
			{
				return GameDataBase.Instance.GetRobot(m_ActorData[m_NowActorDataIndex].RobotID).Name;
			}
			return m_ActorDataEx[m_NowActorDataIndex].ActorRobot.Name;
		}
	}

	public int Icon
	{
		get
		{
			if (m_DataSource)
			{
				return GameDataBase.Instance.GetRobot(m_ActorData[m_NowActorDataIndex].RobotID).Icon;
			}
			return m_ActorDataEx[m_NowActorDataIndex].ActorRobot.Icon;
		}
	}

	public int Hand
	{
		get
		{
			if (m_DataSource)
			{
				if (m_ActorData[m_NowActorDataIndex].UserID == -1)
				{
					return -1;
				}
				return GameDataBase.Instance.GetUser(m_ActorData[m_NowActorDataIndex].UserID).Hand;
			}
			if (m_ActorDataEx[m_NowActorDataIndex].ActorUser == null)
			{
				return -1;
			}
			return m_ActorDataEx[m_NowActorDataIndex].ActorUser.Hand;
		}
	}

	public int Battle
	{
		get
		{
			if (m_DataSource)
			{
				return GameDataBase.Instance.GetRobot(m_ActorData[m_NowActorDataIndex].RobotID).Battle;
			}
			return m_ActorDataEx[m_NowActorDataIndex].ActorRobot.Battle;
		}
	}

	public List<ActorData> ActorDataList => m_ActorData;

	public int NowActorDataIndex => m_NowActorDataIndex;

	public bool IsSelf => m_IsSelf;

	public Define.AIType AIType
	{
		get
		{
			return m_AIType;
		}
		set
		{
			m_AIType = value;
		}
	}

	public int Exp => m_Exp;

	public int Money => m_Money;

	public int BGM => m_BGM;

	public int Level => m_Level;

	public int Str
	{
		get
		{
			if (m_DataSource)
			{
				return GameDataBase.Instance.GetRobot(m_ActorData[m_NowActorDataIndex].RobotID).Str + m_Str;
			}
			return m_ActorDataEx[m_NowActorDataIndex].ActorRobot.Str + m_Str;
		}
	}

	public int Def
	{
		get
		{
			if (m_DataSource)
			{
				return GameDataBase.Instance.GetRobot(m_ActorData[m_NowActorDataIndex].RobotID).Def + m_Def;
			}
			return m_ActorDataEx[m_NowActorDataIndex].ActorRobot.Def + m_Def;
		}
	}

	public int Agi
	{
		get
		{
			if (m_DataSource)
			{
				return GameDataBase.Instance.GetRobot(m_ActorData[m_NowActorDataIndex].RobotID).Agi + m_Agi;
			}
			return m_ActorDataEx[m_NowActorDataIndex].ActorRobot.Agi + m_Agi;
		}
	}

	public int HP
	{
		get
		{
			if (m_DataSource)
			{
				return GameDataBase.Instance.GetRobot(m_ActorData[m_NowActorDataIndex].RobotID).HP + m_HP;
			}
			return m_ActorDataEx[m_NowActorDataIndex].ActorRobot.HP + m_HP;
		}
	}

	public int NHP
	{
		get
		{
			return m_NHP;
		}
		set
		{
			m_NHP = value;
			if (m_NHP < 0)
			{
				m_NHP = 0;
			}
			if (m_NHP > HP)
			{
				m_NHP = HP;
			}
		}
	}

	public int SP => m_SP;

	public int NSP
	{
		get
		{
			return m_NSP;
		}
		set
		{
			m_NSP = value;
			if (m_NSP < 0)
			{
				m_NSP = 0;
			}
			if (m_NSP > SP)
			{
				m_NSP = SP;
			}
		}
	}

	public Actor(ActorData[] data, Define.AIType ai, int level, int sp, int exp, int money, int bgm = -1, bool isSelf = false)
	{
		m_DataSource = true;
		m_Str = 0;
		m_Def = 0;
		m_Agi = 0;
		m_SP = sp;
		m_NowActorDataIndex = 0;
		m_AIType = ai;
		m_IsSelf = isSelf;
		m_Level = level;
		m_BGM = bgm;
		m_Exp = exp;
		m_Money = money;
		if (data != null)
		{
			foreach (ActorData item in data)
			{
				m_ActorData.Add(item);
			}
		}
	}

	public Actor(ActorDataEx[] data, Define.AIType ai, int level, int sp, int exp, int money, int bgm = -1, bool isSelf = false)
	{
		m_DataSource = false;
		m_Str = 0;
		m_Def = 0;
		m_Agi = 0;
		m_SP = sp;
		m_NowActorDataIndex = 0;
		m_AIType = ai;
		m_IsSelf = isSelf;
		m_Level = level;
		m_BGM = bgm;
		m_Exp = exp;
		m_Money = money;
		if (data != null)
		{
			foreach (ActorDataEx item in data)
			{
				m_ActorDataEx.Add(item);
			}
		}
	}

	public void Init()
	{
		m_NHP = HP;
		m_NSP = SP;
		m_NowActorDataIndex = 0;
	}

	public void SetText(int power, int exp)
	{
		m_Str += power;
		m_Def += power;
		m_Agi += power;
		AddExp(exp);
	}

	public bool AddExp(int exp)
	{
		bool result = false;
		m_Exp += exp;
		while (m_Exp > Define.GetLevelNextExp(m_Level))
		{
			result = true;
			m_Exp -= Define.GetLevelNextExp(m_Level);
			m_Level++;
			m_Str += 3;
			m_Def += 2;
			m_Agi += 3;
			m_HP += 10;
			m_SP += 2;
		}
		return result;
	}

	public void Variant(int index)
	{
		if (m_DataSource)
		{
			if (index < 0 || index >= m_ActorData.Count)
			{
				Debug.Log("错误的变形 !" + index);
				return;
			}
		}
		else if (index < 0 || index >= m_ActorDataEx.Count)
		{
			Debug.Log("错误的变形 !" + index);
			return;
		}
		m_NowActorDataIndex = index;
	}

	public bool HasTrait(Define.UserTrait trait)
	{
		if (m_DataSource)
		{
			return GameDataBase.Instance.GetRobot(m_ActorData[m_NowActorDataIndex].RobotID).HasTrait(trait);
		}
		return m_ActorDataEx[m_NowActorDataIndex].ActorRobot.HasTrait(trait);
	}

	public void ChooseActor(ActorData[] actorData)
	{
		m_ActorData.Clear();
		if (actorData != null)
		{
			foreach (ActorData item in actorData)
			{
				m_ActorData.Add(item);
			}
		}
		m_NHP = HP;
	}
}
