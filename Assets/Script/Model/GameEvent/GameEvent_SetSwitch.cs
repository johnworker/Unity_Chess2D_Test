public class GameEvent_SetSwitch : GameEvent
{
	private string m_Key;

	private int m_Value;

	public string Key => m_Key;

	public int Value => m_Value;

	public GameEvent_SetSwitch(string key, bool value)
		: base(Define.EventType.SetSwitch)
	{
		m_Key = key;
		m_Value = (value ? 1 : 0);
	}

	public GameEvent_SetSwitch(string key, int value)
		: base(Define.EventType.SetSwitch)
	{
		m_Key = key;
		m_Value = value;
	}
}
