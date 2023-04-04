public class GameEvent_SetStatus : GameEvent
{
	private int m_ID;

	private Define.UserStatus m_Status;

	public int ID => m_ID;

	public Define.UserStatus Status => m_Status;

	public GameEvent_SetStatus(int id, Define.UserStatus status)
		: base(Define.EventType.SetStatus)
	{
		m_ID = id;
		m_Status = status;
	}
}
