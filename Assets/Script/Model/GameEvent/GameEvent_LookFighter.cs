public class GameEvent_LookFighter : GameEvent
{
	private int m_ID;

	public int ID => m_ID;

	public GameEvent_LookFighter(int id)
		: base(Define.EventType.LookFighter)
	{
		m_ID = id;
	}
}
