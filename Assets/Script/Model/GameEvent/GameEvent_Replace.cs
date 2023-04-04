public class GameEvent_Replace : GameEvent
{
	private int m_IDA;

	private int m_IDB;

	public int IDA => m_IDA;

	public int IDB => m_IDB;

	public GameEvent_Replace(int a, int b)
		: base(Define.EventType.Replace)
	{
		m_IDA = a;
		m_IDB = b;
	}
}
