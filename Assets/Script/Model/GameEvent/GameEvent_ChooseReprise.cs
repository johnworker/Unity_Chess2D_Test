public class GameEvent_ChooseReprise : GameEvent
{
	private int m_Reprise;

	public int Reprise => m_Reprise;

	public GameEvent_ChooseReprise(int reprise)
		: base(Define.EventType.ChooseReprise)
	{
		m_Reprise = reprise;
	}
}
