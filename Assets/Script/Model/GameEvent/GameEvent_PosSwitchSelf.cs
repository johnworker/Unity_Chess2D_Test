using System.Collections.Generic;

public class GameEvent_PosSwitchSelf : GameEvent
{
	private HashSet<Define.Point> m_Point;

	private List<GameEvent> m_TrueEvent;

	private bool m_SelfFlag;

	public List<GameEvent> TrueEvent => m_TrueEvent;

	public HashSet<Define.Point> Point => m_Point;

	public bool Self => m_SelfFlag;

	public GameEvent_PosSwitchSelf(bool self, HashSet<Define.Point> points, List<GameEvent> trueEvent)
		: base(Define.EventType.PosSwitchSelf)
	{
		m_SelfFlag = self;
		m_Point = points;
		m_TrueEvent = trueEvent;
	}
}
