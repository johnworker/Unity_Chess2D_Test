public class Terrain
{
	public enum TerrainType
	{
		Plain,
		Sea,
		Mountain,
		Gobi,
		Forest,
		Floor_Crack,
		Floor,
		Cosmos
	}

	private int m_Icon;

	private TerrainType m_Type;

	private bool m_CanMove;

	public TerrainType Type => m_Type;

	public bool CanMove => m_CanMove;

	public int Icon => m_Icon;

	public Terrain(int icon, bool move, TerrainType type)
	{
		m_Icon = icon;
		m_CanMove = move;
		m_Type = type;
	}
}
