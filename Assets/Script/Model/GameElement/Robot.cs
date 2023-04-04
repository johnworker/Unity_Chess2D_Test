using System.Collections.Generic;

public class Robot
{
	public enum EngineType
	{
		Sea,
		Land,
		Sky
	}

	private int m_Icon = -1;

	private EngineType m_Type = EngineType.Land;

	private int m_HP;

	private int m_Str;

	private int m_Def;

	private int m_Agi;

	private string m_Name = string.Empty;

	private int m_Battle = -1;

	private int m_Speed;

	private List<int> m_Weapon = new List<int>();

	private HashSet<Define.UserTrait> m_Trait = new HashSet<Define.UserTrait>();

	public HashSet<Define.UserTrait> Trait => m_Trait;

	public List<int> Weapon => m_Weapon;

	public int Speed => m_Speed;

	public string Name => m_Name;

	public EngineType Type => m_Type;

	public int Icon => m_Icon;

	public int HP => m_HP;

	public int Str => m_Str;

	public int Def => m_Def;

	public int Agi => m_Agi;

	public int Battle => m_Battle;

	public Robot(string name, EngineType type, int battle, int icon, int speed, int hp, int str, int def, int agi, int[] weapon, Define.UserTrait[] trait = null)
	{
		m_HP = hp;
		m_Str = str;
		m_Def = def;
		m_Agi = agi;
		m_Name = name;
		m_Icon = icon;
		m_Battle = battle;
		m_Speed = speed;
		m_Type = type;
		if (weapon != null)
		{
			foreach (int item in weapon)
			{
				m_Weapon.Add(item);
			}
		}
		if (trait != null)
		{
			foreach (Define.UserTrait item2 in trait)
			{
				m_Trait.Add(item2);
			}
		}
	}

	public bool HasTrait(Define.UserTrait trait)
	{
		return m_Trait.Contains(trait);
	}
}
