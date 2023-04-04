using System.Collections.Generic;

public class GameDataBase
{
	private static GameDataBase m_Instance;

	private GameItemData m_ItemData = new GameItemData();

	private GameSpiritData m_SpiritData = new GameSpiritData();

	private GameWeaponData m_WeaponData = new GameWeaponData();

	private GamePartyData m_PartyData = new GamePartyData();

	private GameTerrainData m_TerrainData = new GameTerrainData();

	private GameLevelData m_LevelData = new GameLevelData();

	public static GameDataBase Instance
	{
		get
		{
			if (m_Instance == null)
			{
				m_Instance = new GameDataBase();
			}
			return m_Instance;
		}
	}

	public Dictionary<int, int> Item => m_PartyData.Items;

	public int NowLevel
	{
		get
		{
			return m_PartyData.NowLevel;
		}
		set
		{
			m_PartyData.NowLevel = value;
		}
	}

	public int GamePlus
	{
		get
		{
			return m_PartyData.GamePlus;
		}
		set
		{
			m_PartyData.GamePlus = value;
		}
	}

	public int NowMoney
	{
		get
		{
			return m_PartyData.NowMoney;
		}
		set
		{
			m_PartyData.NowMoney = value;
		}
	}

	private GameDataBase()
	{
	}

	public void ResetGameData(bool text = false, int level = 0, int power = 0, int exp = 0)
	{
		m_ItemData = new GameItemData();
		m_SpiritData = new GameSpiritData();
		m_WeaponData = new GameWeaponData();
		m_PartyData = new GamePartyData();
		m_TerrainData = new GameTerrainData();
		m_LevelData = new GameLevelData();
		if (text)
		{
			m_PartyData.Text(power, exp);
			m_PartyData.NowLevel = level;
			m_PartyData.NowMoney += 1000000;
			for (int i = 0; i < m_ItemData.AllItemCount; i++)
			{
				m_PartyData.AddItem(i, 99);
			}
		}
	}

	public Level GetLevel(int level)
	{
		return m_LevelData[level];
	}

	public Spirit GetSpirit(int id)
	{
		return m_SpiritData[id];
	}

	public Weapon GetWeapon(int id)
	{
		return m_WeaponData[id];
	}

	public Actor GetActor(int id)
	{
		return m_PartyData[id];
	}

	public Terrain GetTerrain(int id)
	{
		return m_TerrainData[id];
	}

	public Item GetItem(int id)
	{
		return m_ItemData[id];
	}

	public int GetItemCount(int id)
	{
		return m_PartyData.GetItemCount(id);
	}

	public void AddItem(int id, int number)
	{
		m_PartyData.AddItem(id, number);
	}

	public void UseItem(int id, int number)
	{
		m_PartyData.UseItem(id, number);
	}

	public string Save()
	{
		return m_PartyData.Save();
	}

	public string SaveInfo()
	{
		return m_PartyData.SaveInfo();
	}

	public void Load(string loadStr)
	{
		m_PartyData.Load(loadStr);
	}

	public bool GetFlag(string flag)
	{
		return m_PartyData.GetFlag(flag);
	}

	public void SetFlag(string flag, int state = 1)
	{
		m_PartyData.SetFlag(flag, state);
	}

	public Robot GetRobot(int id)
	{
		return m_PartyData.GetRobot(id);
	}

	public User GetUser(int id)
	{
		return m_PartyData.GetUser(id);
	}
}
