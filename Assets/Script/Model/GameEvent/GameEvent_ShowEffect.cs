public class GameEvent_ShowEffect : GameEvent
{
	private int m_EffectID;

	private int m_FighterID;

	private int m_StartSE;

	private float m_OverTime;

	public float OverTime => m_OverTime;

	public int EffectID => m_EffectID;

	public int StartSE => m_StartSE;

	public int FighterID => m_FighterID;

	public GameEvent_ShowEffect(int fighterID, int effectID, int startSE = -1, float ovarTime = 0f)
		: base(Define.EventType.ShowEffect)
	{
		m_EffectID = effectID;
		m_FighterID = fighterID;
		m_StartSE = startSE;
		m_OverTime = OverTime;
	}
}
