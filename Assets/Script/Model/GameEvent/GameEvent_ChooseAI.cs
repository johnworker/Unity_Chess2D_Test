public class GameEvent_ChooseAI : GameEvent
{
	private Define.AIType m_AIType;

	private int m_FighterID;

	public int FighterID => m_FighterID;

	public Define.AIType AIType => m_AIType;

	public GameEvent_ChooseAI(int id, Define.AIType ai)
		: base(Define.EventType.ChooseAI)
	{
		m_AIType = ai;
		m_FighterID = id;
	}
}
