using System.Collections.Generic;

public class GameEvent_SwitchNHP : GameEvent
{
	private int m_ID;

	private int m_NHP;

	private List<GameEvent> m_TrueEvent;

	private List<GameEvent> m_FalseEvent;

	public int ID => m_ID;

	public int NHP => m_NHP;

	public List<GameEvent> TrueEvent => m_TrueEvent;

	public List<GameEvent> FalseEvent => m_FalseEvent;

	public GameEvent_SwitchNHP(int id, int nhp, List<GameEvent> TrueEvent, List<GameEvent> FalseEvent)
		: base(Define.EventType.SwitchNHP)
	{
		m_ID = id;
		m_NHP = nhp;
		m_TrueEvent = TrueEvent;
		m_FalseEvent = FalseEvent;
	}
}
