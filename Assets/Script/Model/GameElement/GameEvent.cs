public class GameEvent
{
	private Define.EventType m_Type;

	public Define.EventType Type => m_Type;

	public GameEvent()
	{
		m_Type = Define.EventType.Null;
	}

	protected GameEvent(Define.EventType type)
	{
		m_Type = type;
	}

	public T GetData<T>() where T : GameEvent
	{
		return this as T;
	}
}
