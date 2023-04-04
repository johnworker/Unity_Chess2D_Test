using System.Collections.Generic;

public class GameEvent_HasFighter : GameEvent
{
	private int m_ID;

	private List<GameEvent> m_TrueEvent;

	private List<GameEvent> m_FalseEvent;

	public int ID => m_ID;

	public List<GameEvent> TrueEvent => m_TrueEvent;

	public List<GameEvent> FalseEvent => m_FalseEvent;

	public GameEvent_HasFighter(int id, List<GameEvent> TrueEvent, List<GameEvent> FalseEvent)
		: base(Define.EventType.HasFighter)
	{
		m_ID = id;
		m_TrueEvent = TrueEvent;
		m_FalseEvent = FalseEvent;
	}
}
