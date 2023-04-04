public class GameEvent_Damage : GameEvent
{
	private int m_ID;

	private int m_Damage;

	public int ID => m_ID;

	public int Damage => m_Damage;

	public GameEvent_Damage(int id, int damage)
		: base(Define.EventType.Damage)
	{
		m_ID = id;
		m_Damage = damage;
	}
}
