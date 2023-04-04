public class GameEvent_MoveTo : GameEvent
{
	private int m_ID;

	private Define.Point m_Pos;

	private bool m_Look;

	public int ID => m_ID;

	public Define.Point Pos => m_Pos;

	public bool Look => m_Look;

	public GameEvent_MoveTo(int id, int x, int y, bool look = true)
		: base(Define.EventType.MoveTo)
	{
		m_ID = id;
		m_Pos = new Define.Point(x, y);
		m_Look = look;
	}
}
