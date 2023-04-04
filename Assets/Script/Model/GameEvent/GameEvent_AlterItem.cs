public class GameEvent_AlterItem : GameEvent
{
	private int m_ID;

	private int m_Num;

	public int ID => m_ID;

	public int Num => m_Num;

	public GameEvent_AlterItem(int id, int num)
		: base(Define.EventType.AlterItem)
	{
		m_ID = id;
		m_Num = num;
	}
}
