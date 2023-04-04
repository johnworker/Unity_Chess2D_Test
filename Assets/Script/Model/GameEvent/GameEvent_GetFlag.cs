using System.Collections.Generic;

public class GameEvent_GetFlag : GameEvent
{
	private string m_Key;

	private List<GameEvent> m_TrueEvent;

	private List<GameEvent> m_FalseEvent;

	public string Key => m_Key;

	public List<GameEvent> TrueEvent => m_TrueEvent;

	public List<GameEvent> FalseEvent => m_FalseEvent;

	public GameEvent_GetFlag(string key, List<GameEvent> TrueEvent, List<GameEvent> FalseEvent)
		: base(Define.EventType.GetFlag)
	{
		m_Key = key;
		m_TrueEvent = TrueEvent;
		m_FalseEvent = FalseEvent;
	}
}
