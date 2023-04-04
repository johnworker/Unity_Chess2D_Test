public class GameEvent_PlayBGM : GameEvent
{
	private int m_IndexBGM;

	public int IndexBGM => m_IndexBGM;

	public GameEvent_PlayBGM(int indexBGM)
		: base(Define.EventType.PlayBGM)
	{
		m_IndexBGM = indexBGM;
	}
}
