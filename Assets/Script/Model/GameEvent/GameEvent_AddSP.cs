public class GameEvent_AddSP : GameEvent
{
	private int m_ID;

	private int m_Num;

	public int ID => m_ID;

	public int Num => m_Num;

	public GameEvent_AddSP(int id, int num)
		: base(Define.EventType.AddSP)
	{
		m_ID = id;
		m_Num = num;
	}
}
