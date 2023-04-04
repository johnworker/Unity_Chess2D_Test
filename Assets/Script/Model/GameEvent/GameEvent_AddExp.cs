public class GameEvent_AddExp : GameEvent
{
	private int m_ID;

	private int m_Num;

	public int ID => m_ID;

	public int Num => m_Num;

	public GameEvent_AddExp(int id, int num)
		: base(Define.EventType.AddExp)
	{
		m_ID = id;
		m_Num = num;
	}
}
