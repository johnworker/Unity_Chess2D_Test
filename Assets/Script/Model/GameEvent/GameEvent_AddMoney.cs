public class GameEvent_AddMoney : GameEvent
{
	private int m_Num;

	public int Num => m_Num;

	public GameEvent_AddMoney(int num)
		: base(Define.EventType.AddMoney)
	{
		m_Num = num;
	}
}
