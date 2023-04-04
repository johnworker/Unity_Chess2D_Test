public class GameEvent_SetAction : GameEvent
{
	private int m_ID;

	private bool m_Action;

	public int ID => m_ID;

	public bool Action => m_Action;

	public GameEvent_SetAction(int id, bool action)
		: base(Define.EventType.SetAction)
	{
		m_ID = id;
		m_Action = action;
	}
}
