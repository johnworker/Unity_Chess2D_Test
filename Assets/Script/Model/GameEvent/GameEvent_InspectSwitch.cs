using System.Collections.Generic;

public class GameEvent_InspectSwitch : GameEvent
{
	private string m_Switch;

	private int m_Number;

	private List<GameEvent> m_TrueEvent;

	private List<GameEvent> m_FalseEvent;

	public string Switch => m_Switch;

	public int Number => m_Number;

	public List<GameEvent> TrueEvent => m_TrueEvent;

	public List<GameEvent> FalseEvent => m_FalseEvent;

	public GameEvent_InspectSwitch(string Switch, int Number, List<GameEvent> TrueEvent, List<GameEvent> FalseEvent)
		: base(Define.EventType.InspectSwitch)
	{
		m_Switch = Switch;
		m_Number = Number;
		m_TrueEvent = TrueEvent;
		m_FalseEvent = FalseEvent;
	}
}
