public class GameEvent_SetSuccess : GameEvent
{
	public enum SetSuccessWay
	{
		Add,
		Set
	}

	private SetSuccessWay m_Way;

	private int m_Key;

	private int m_Value;

	public SetSuccessWay Way => m_Way;

	public int Key => m_Key;

	public int Value => m_Value;

	public GameEvent_SetSuccess(int key, int value, SetSuccessWay way = SetSuccessWay.Add)
		: base(Define.EventType.SetSuccess)
	{
		m_Way = way;
		m_Key = key;
		m_Value = value;
	}
}
