public class GameEvent_ActorDie : GameEvent
{
	private int m_ID;

	public int ID => m_ID;

	public GameEvent_ActorDie(int id)
		: base(Define.EventType.ActorDie)
	{
		m_ID = id;
	}
}
