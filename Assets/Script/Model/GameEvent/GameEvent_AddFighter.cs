public class GameEvent_AddFighter : GameEvent
{
	private int m_ID;

	public int ID => m_ID;

	public GameEvent_AddFighter(int id)
		: base(Define.EventType.AddFighter)
	{
		m_ID = id;
	}
}
