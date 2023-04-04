public class GameEvent_AddSwitch : GameEvent
{
	private string m_Key;

	private int m_Value;

	public string Key => m_Key;

	public int Value => m_Value;

	public GameEvent_AddSwitch(string key, int value)
		: base(Define.EventType.AddSwitch)
	{
		m_Key = key;
		m_Value = value;
	}
}
