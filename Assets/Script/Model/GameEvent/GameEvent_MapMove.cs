public class GameEvent_MapMove : GameEvent
{
	private Define.Point m_Pos;

	public Define.Point Pos => m_Pos;

	public GameEvent_MapMove(int x, int y)
		: base(Define.EventType.MapMove)
	{
		m_Pos = new Define.Point(x, y);
	}
}
