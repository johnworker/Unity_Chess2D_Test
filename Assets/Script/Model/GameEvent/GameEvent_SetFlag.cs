public class GameEvent_SetFlag : GameEvent
{
	private string m_Key;

	private int m_Value;

	public string Key => m_Key;

	public int Value => m_Value;

	public GameEvent_SetFlag(string key, bool value = true)
		: base(Define.EventType.SetFlag)
	{
		m_Key = key;
		m_Value = (value ? 1 : 0);
	}

	public GameEvent_SetFlag(string key, int value)
		: base(Define.EventType.SetFlag)
	{
		m_Key = key;
		m_Value = value;
	}
}
