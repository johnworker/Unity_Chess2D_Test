public class Weapon
{
	public enum Entry
	{
		Cure = 1,
		All = 2,
		IgnoreDis = 4
	}

	private int m_Entry;

	private string m_Name = string.Empty;

	private int m_Range;

	private int m_Hit;

	private int m_FireSea;

	private int m_FireLand;

	private int m_FireSky;

	public string Name => m_Name;

	public int Range => m_Range;

	public int Hit => m_Hit;

	public int FireSea => m_FireSea;

	public int FireLand => m_FireLand;

	public int FireSky => m_FireSky;

	public bool All => (m_Entry & 2) != 0;

	public bool Cure => (m_Entry & 1) != 0;

	public bool IgnoreDis => (m_Entry & 4) != 0;

	public Weapon(string name, int hit, int range, int sea, int land, int sky, int entry = 0)
	{
		m_Name = name;
		m_Range = range;
		m_Hit = hit;
		m_FireSea = sea;
		m_FireLand = land;
		m_FireSky = sky;
		m_Entry = entry;
	}
}
