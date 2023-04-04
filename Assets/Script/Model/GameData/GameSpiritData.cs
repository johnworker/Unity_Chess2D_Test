using System.Collections.Generic;

public class GameSpiritData
{
	private List<Spirit> m_SpiritData = new List<Spirit>();

	public Spirit this[int id] => m_SpiritData[id];

	public GameSpiritData()
	{
		m_SpiritData.Add(new Spirit_QiangGong(0));
		m_SpiritData.Add(new Spirit_ReXue(1));
		m_SpiritData.Add(new Spirit_MiaoZhun(2));
		m_SpiritData.Add(new Spirit_BiSha(3));
		m_SpiritData.Add(new Spirit_FangShou(4));
		m_SpiritData.Add(new Spirit_GanRao(5));
		m_SpiritData.Add(new Spirit_HuiBi(6));
		m_SpiritData.Add(new Spirit_YiLi(7));
		m_SpiritData.Add(new Spirit_QianLi(8));
		m_SpiritData.Add(new Spirit_YouQin(9));
		m_SpiritData.Add(new Spirit_QinYi(10));
		m_SpiritData.Add(new Spirit_YuanZhu(11));
		m_SpiritData.Add(new Spirit_QiDao(12));
		m_SpiritData.Add(new Spirit_AiXin(13));
		m_SpiritData.Add(new Spirit_Nu(14));
		m_SpiritData.Add(new Spirit_KuangNu(15));
		m_SpiritData.Add(new Spirit_JiaSu(16));
		m_SpiritData.Add(new Spirit_JiFeng(17));
		m_SpiritData.Add(new Spirit_ChuanZhen(18));
	}
}
