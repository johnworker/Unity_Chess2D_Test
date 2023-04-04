using System.Collections.Generic;

public class GameTerrainData
{
	private List<Terrain> m_TerrainData = new List<Terrain>();

	public Terrain this[int id] => m_TerrainData[id];

	public GameTerrainData()
	{
		m_TerrainData.Add(new Terrain(0, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(1, move: true, Terrain.TerrainType.Mountain));
		m_TerrainData.Add(new Terrain(2, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(3, move: true, Terrain.TerrainType.Forest));
		m_TerrainData.Add(new Terrain(4, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(5, move: true, Terrain.TerrainType.Gobi));
		m_TerrainData.Add(new Terrain(6, move: true, Terrain.TerrainType.Gobi));
		m_TerrainData.Add(new Terrain(7, move: true, Terrain.TerrainType.Sea));
		m_TerrainData.Add(new Terrain(8, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(9, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(10, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(11, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(12, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(13, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(14, move: false, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(15, move: true, Terrain.TerrainType.Mountain));
		m_TerrainData.Add(new Terrain(16, move: true, Terrain.TerrainType.Gobi));
		m_TerrainData.Add(new Terrain(17, move: false, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(18, move: true, Terrain.TerrainType.Forest));
		m_TerrainData.Add(new Terrain(19, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(20, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(21, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(22, move: true, Terrain.TerrainType.Gobi));
		m_TerrainData.Add(new Terrain(23, move: false, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(24, move: false, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(25, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(26, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(27, move: true, Terrain.TerrainType.Sea));
		m_TerrainData.Add(new Terrain(28, move: true, Terrain.TerrainType.Cosmos));
		m_TerrainData.Add(new Terrain(29, move: true, Terrain.TerrainType.Cosmos));
		m_TerrainData.Add(new Terrain(30, move: true, Terrain.TerrainType.Cosmos));
		m_TerrainData.Add(new Terrain(31, move: true, Terrain.TerrainType.Forest));
		m_TerrainData.Add(new Terrain(32, move: false, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(33, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(34, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(35, move: true, Terrain.TerrainType.Cosmos));
		m_TerrainData.Add(new Terrain(36, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(37, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(38, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(39, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(40, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(41, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(42, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(43, move: true, Terrain.TerrainType.Plain));
		m_TerrainData.Add(new Terrain(44, move: false, Terrain.TerrainType.Plain));
	}
}
