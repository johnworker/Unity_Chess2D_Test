public class GameEvent_WaitTime : GameEvent
{
	private float m_Time;

	public float Time => m_Time;

	public GameEvent_WaitTime(float time)
		: base(Define.EventType.WaitTime)
	{
		m_Time = time;
	}
}
