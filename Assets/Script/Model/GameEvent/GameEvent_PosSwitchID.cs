using System.Collections.Generic;

public class GameEvent_PosSwitchID : GameEvent
{
	private HashSet<Define.Point> m_Point;

	private List<GameEvent> m_TrueEvent;

	private int m_ID;

	public List<GameEvent> TrueEvent => m_TrueEvent;

	public HashSet<Define.Point> Point => m_Point;

	public int ID => m_ID;

	public GameEvent_PosSwitchID(int id, HashSet<Define.Point> points, List<GameEvent> trueEvent)
		: base(Define.EventType.PosSwitchID)
	{
		m_ID = id;
		m_Point = points;
		m_TrueEvent = trueEvent;
	}
}
