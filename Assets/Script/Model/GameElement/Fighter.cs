using System.Collections.Generic;
using System.Linq;

public class Fighter
{
	private Define.Point m_Pos = default(Define.Point);

	private bool m_IsAction;

	private Actor m_Actor;

	private Dictionary<Define.Point, Define.MovePath> m_CanMovePath;

	private int m_ID = -1;

	private HashSet<Define.UserStatus> m_State = new HashSet<Define.UserStatus>();

	public HashSet<Define.UserStatus> State => m_State;

	public List<int> CanUseSpririt
	{
		get
		{
			List<int> list = new List<int>();
			List<int> spirit = m_Actor.Spirit;
			if (spirit != null)
			{
				foreach (int item in spirit)
				{
					Spirit spirit2 = GameDataBase.Instance.GetSpirit(item);
					if (NSP >= spirit2.Expend)
					{
						list.Add(item);
					}
				}
				return list;
			}
			return list;
		}
	}

	public int NowActorDataIndex => m_Actor.NowActorDataIndex;

	public Dictionary<Define.Point, Define.MovePath> CanMovePath
	{
		set
		{
			m_CanMovePath = value;
		}
	}

	public int BGM => m_Actor.BGM;

	public int Exp => m_Actor.Exp;

	public int Money => m_Actor.Money;

	public bool IsAction
	{
		get
		{
			return m_IsAction;
		}
		set
		{
			m_IsAction = value;
		}
	}

	public int Level => m_Actor.Level;

	public List<int> Weapon => m_Actor.Weapon;

	public bool IsSelf => m_Actor.IsSelf;

	public Define.AIType AIType
	{
		get
		{
			return m_Actor.AIType;
		}
		set
		{
			m_Actor.AIType = value;
		}
	}

	public Robot.EngineType EngineType => m_Actor.EngineType;

	public string RobotName => m_Actor.RobotName;

	public string UserName => m_Actor.UserName;

	public int Icon => m_Actor.Icon;

	public int X
	{
		get
		{
			return m_Pos.X;
		}
		set
		{
			m_Pos.X = value;
		}
	}

	public int Y
	{
		get
		{
			return m_Pos.Y;
		}
		set
		{
			m_Pos.Y = value;
		}
	}

	public int Speed
	{
		get
		{
			if (DataManager.Instance.IsText && IsSelf)
			{
				return 25;
			}
			int num = 0;
			if (m_State.Contains(Define.UserStatus.JiaSu))
			{
				num += 3;
			}
			if (m_State.Contains(Define.UserStatus.JiFeng))
			{
				num += 5;
			}
			return m_Actor.Speed + num;
		}
	}

	public int ID => m_ID;

	public int Battle => m_Actor.Battle;

	public int Hand => m_Actor.Hand;

	public int Str => m_Actor.Str;

	public int Def => m_Actor.Def;

	public int Agi => m_Actor.Agi;

	public int BaseStr
	{
		get
		{
			return m_Actor.BaseStr;
		}
		set
		{
			m_Actor.BaseStr = value;
		}
	}

	public int BaseDef
	{
		get
		{
			return m_Actor.BaseDef;
		}
		set
		{
			m_Actor.BaseDef = value;
		}
	}

	public int BaseAgi
	{
		get
		{
			return m_Actor.BaseAgi;
		}
		set
		{
			m_Actor.BaseAgi = value;
		}
	}

	public int BaseHP
	{
		get
		{
			return m_Actor.BaseHP;
		}
		set
		{
			m_Actor.BaseHP = value;
		}
	}

	public int HP => m_Actor.HP;

	public int NHP
	{
		get
		{
			return m_Actor.NHP;
		}
		set
		{
			m_Actor.NHP = value;
		}
	}

	public int SP => m_Actor.SP;

	public int NSP
	{
		get
		{
			return m_Actor.NSP;
		}
		set
		{
			m_Actor.NSP = value;
		}
	}

	public HashSet<Define.UserTrait> Trait => m_Actor.Trait;

	public List<Actor.ActorData> ActorDataList => m_Actor.ActorDataList;

	public int Score
	{
		get
		{
			int num = NHP / 10 * (Def + Agi / 2 + Str / 8) / 20;
			int num2 = 0;
			foreach (int item in Weapon)
			{
				Weapon weapon = GameDataBase.Instance.GetWeapon(item);
				if (weapon.Cure)
				{
					num2 -= Str * 2;
				}
				else if (weapon.Range > 1)
				{
					num2 -= Str;
				}
			}
			return num + ((num2 == 0) ? 1 : num2);
		}
	}

	public Fighter(int x, int y, Actor actor, int id)
	{
		m_Pos.X = x;
		m_Pos.Y = y;
		m_Actor = actor;
		m_ID = id;
		m_Actor.Init();
	}

	public bool HasState(Define.UserStatus status)
	{
		return m_State.Contains(status);
	}

	public Define.Point[] GetCanMovePoint()
	{
		if (m_CanMovePath == null)
		{
			return new Define.Point[0];
		}
		return m_CanMovePath.Keys.ToArray();
	}

	public void ChooseActor(Actor.ActorData[] actorData)
	{
		m_Actor.ChooseActor(actorData);
	}

	public void Variant(Actor.ActorData data)
	{
		m_Actor.Variant(m_Actor.ActorDataList.IndexOf(data));
	}

	public void Variant(int index)
	{
		m_Actor.Variant(index);
	}

	public List<Define.Point> GetMovePath(Define.Point point)
	{
		if (m_CanMovePath == null)
		{
			return null;
		}
		if (!m_CanMovePath.ContainsKey(point))
		{
			return null;
		}
		return m_CanMovePath[point].Path;
	}

	public bool AddExp(int exp)
	{
		return m_Actor.AddExp(exp);
	}

	public bool HasTrait(Define.UserTrait trait)
	{
		return m_Actor.HasTrait(trait);
	}
}
