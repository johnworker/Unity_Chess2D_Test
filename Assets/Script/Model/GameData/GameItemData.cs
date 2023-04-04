using System.Collections.Generic;

public class GameItemData
{
	private List<Item> m_ItemData = new List<Item>();

	public int AllItemCount => m_ItemData.Count;

	public Item this[int id] => m_ItemData[id];

	public GameItemData()
	{
		m_ItemData.Add(new Item_ChuanGanQi(0));
		m_ItemData.Add(new Item_ChaoHeJinZ(1));
		m_ItemData.Add(new Item_CiXingTuLiao(2));
		m_ItemData.Add(new Item_CZhuangJia(3));
		m_ItemData.Add(new Item_GenJi(4));
		m_ItemData.Add(new Item_MiaoZhun(5));
		m_ItemData.Add(new Item_MiNuoFu(6));
		m_ItemData.Add(new Item_YongQi(7));
		m_ItemData.Add(new Item_ZhengYi(8));
		m_ItemData.Add(new Item_QiDongZhuangZhi(9));
	}
}
