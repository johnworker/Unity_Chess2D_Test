public class GameEvent_DoVariant : GameEvent
{
	private int m_ID;

	private int m_Variant;

	public int ID => m_ID;

	public int Variant => m_Variant;

	public GameEvent_DoVariant(int id, int variant)
		: base(Define.EventType.DoVariant)
	{
		m_ID = id;
		m_Variant = variant;
	}
}
