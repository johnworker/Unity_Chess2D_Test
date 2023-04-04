using UnityEngine.Events;

public class GameEvent_PlayME : GameEvent
{
	private int m_IndexME;

	private UnityAction m_OverAction;

	public int IndexME => m_IndexME;

	public UnityAction OverAction => m_OverAction;

	public GameEvent_PlayME(int indexME, UnityAction overAction = null)
		: base(Define.EventType.PlayME)
	{
		m_IndexME = indexME;
		m_OverAction = overAction;
	}
}
