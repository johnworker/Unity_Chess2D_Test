public class GameEvent_DoBattle : GameEvent
{
	private int m_ID;

	private int m_Weapon;

	private int m_Target;

	public int ID => m_ID;

	public int Weapon => m_Weapon;

	public int Target => m_Target;

	public GameEvent_DoBattle(int id, int weapon, int target)
		: base(Define.EventType.DoBattle)
	{
		m_ID = id;
		m_Weapon = weapon;
		m_Target = target;
	}
}
