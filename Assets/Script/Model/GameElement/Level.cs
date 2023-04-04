using System.Collections.Generic;

public class Level
{
	public enum TaskTypeEnum
	{
		KillAll,
		UnKillAll
	}

	protected List<Define.Point> m_Hospital = new List<Define.Point>();

	protected Dictionary<string, int> m_LevelSwitch = new Dictionary<string, int>();

	protected Map m_Map;

	protected int m_SelfBGM = -1;

	protected int m_EnemyBGM = -1;

	protected string m_Name = string.Empty;

	protected string m_Task = string.Empty;

	protected TaskTypeEnum m_TaskType;

	protected GameEvent[] m_MoveOverEvent;

	protected Dictionary<Define.Point, GameEvent[]> m_ShopEvent = new Dictionary<Define.Point, GameEvent[]>();

	protected GameEvent[] m_CarryEvent;

	protected GameEvent[] m_GameEventEvery;

	protected Dictionary<int, Dictionary<int, GameEvent[]>> m_CapitulateMap = new Dictionary<int, Dictionary<int, GameEvent[]>>();

	protected Dictionary<int, Fighter> m_FighterData = new Dictionary<int, Fighter>();

	protected Dictionary<int, GameEvent[]> m_GameEvent = new Dictionary<int, GameEvent[]>();

	protected Dictionary<int, GameEvent[]> m_FighterEvent = new Dictionary<int, GameEvent[]>();

	protected GameEvent[] m_AttackEvent;

	public string Name => m_Name;

	public string Task => m_Task;

	public TaskTypeEnum TaskType => m_TaskType;

	public GameEvent[] EveryEvent => m_GameEventEvery;

	public Dictionary<Define.Point, GameEvent[]> ShopEvent => m_ShopEvent;

	public GameEvent[] MoveOverEvent => m_MoveOverEvent;

	public GameEvent[] CarryEvent => m_CarryEvent;

	public List<Define.Point> Hospital => m_Hospital;

	public Dictionary<int, Fighter> FighterData => m_FighterData;

	public Map Map => m_Map;

	public GameEvent[] AttackEvent => m_AttackEvent;

	public int SelfBGM => m_SelfBGM;

	public int EnemyBGM => m_EnemyBGM;

	public bool CanCapitulate(int aID, int bID)
	{
		if (m_CapitulateMap.ContainsKey(aID))
		{
			return m_CapitulateMap[aID].ContainsKey(bID);
		}
		return false;
	}

	public GameEvent[] GetCapitulateEvent(int aID, int bID)
	{
		if (m_CapitulateMap.ContainsKey(aID) && m_CapitulateMap[aID].ContainsKey(bID))
		{
			return m_CapitulateMap[aID][bID];
		}
		return new GameEvent[0];
	}

	public void SetSwitch(string key, int value)
	{
		if (!m_LevelSwitch.ContainsKey(key))
		{
			m_LevelSwitch.Add(key, value);
		}
		else
		{
			m_LevelSwitch[key] = value;
		}
	}

	public void AddSwitch(string key, int value)
	{
		if (!m_LevelSwitch.ContainsKey(key))
		{
			m_LevelSwitch.Add(key, value);
		}
		else
		{
			m_LevelSwitch[key] += value;
		}
	}

	public int GetSwitch(string key)
	{
		if (m_LevelSwitch.ContainsKey(key))
		{
			return m_LevelSwitch[key];
		}
		return 0;
	}

	public GameEvent[] GetFighterEvent(int id)
	{
		if (!m_FighterEvent.ContainsKey(id))
		{
			return null;
		}
		return m_FighterEvent[id];
	}

	public GameEvent[] GetGameEvent(int index)
	{
		if (!m_GameEvent.ContainsKey(index))
		{
			return null;
		}
		return m_GameEvent[index];
	}

	public void AddShopEvent(Define.Point pos, List<int> item)
	{
		m_ShopEvent.Add(pos, new GameEvent[5]
		{
			new GameEvent_MapLock(),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_PlayBGM(4),
			new GameEvent_ShowShop(item),
			new GameEvent_MapUnlock()
		});
	}
}
