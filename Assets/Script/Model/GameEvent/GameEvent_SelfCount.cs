using System.Collections.Generic;

public class GameEvent_SelfCount : GameEvent
{
	private int m_Count;

	private List<GameEvent> m_TrueEvent;

	public int Count => m_Count;

	public List<GameEvent> TrueEvent => m_TrueEvent;

	public GameEvent_SelfCount(int count, List<GameEvent> TrueEvent)
		: base(Define.EventType.SelfCount)
	{
		m_Count = count;
		m_TrueEvent = TrueEvent;
	}
}
