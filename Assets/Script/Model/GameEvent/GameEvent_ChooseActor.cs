public class GameEvent_ChooseActor : GameEvent
{
	private int m_ID;

	private Actor.ActorData[] m_ActorData;

	public int ID => m_ID;

	public Actor.ActorData[] ActorData => m_ActorData;

	public GameEvent_ChooseActor(int id, Actor.ActorData[] actorData)
		: base(Define.EventType.ChooseActor)
	{
		m_ID = id;
		m_ActorData = actorData;
	}
}
