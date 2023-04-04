public class GameEvent_AddAttr : GameEvent
{
	private int m_ID;

	private int m_Str;

	private int m_Agi;

	private int m_Def;

	private int m_HP;

	public int ID => m_ID;

	public int Str => m_Str;

	public int Agi => m_Agi;

	public int Def => m_Def;

	public int HP => m_HP;

	public GameEvent_AddAttr(int id, int str, int agi, int def, int hp)
		: base(Define.EventType.AddAttr)
	{
		m_ID = id;
		m_Agi = agi;
		m_Str = str;
		m_Def = def;
		m_HP = hp;
	}
}
