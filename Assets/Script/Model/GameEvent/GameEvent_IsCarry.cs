using System.Collections.Generic;

public class GameEvent_IsCarry : GameEvent
{
	private int m_MotherID;

	private int m_SonID;

	private List<GameEvent> m_TrueEvent;

	public int MotherID => m_MotherID;

	public int SonID => m_SonID;

	public List<GameEvent> TrueEvent => m_TrueEvent;

	public GameEvent_IsCarry(int mother, int son, List<GameEvent> TrueEvent)
		: base(Define.EventType.IsCarry)
	{
		m_MotherID = mother;
		m_SonID = son;
		m_TrueEvent = TrueEvent;
	}
}
