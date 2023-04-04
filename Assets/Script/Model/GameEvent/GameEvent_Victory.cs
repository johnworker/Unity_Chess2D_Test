public class GameEvent_Victory : GameEvent
{
	private int m_NextLevel;

	public int NextLevel => m_NextLevel;

	public GameEvent_Victory(int next = 0)
		: base(Define.EventType.Victory)
	{
		m_NextLevel = next;
	}
}
