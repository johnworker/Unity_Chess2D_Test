using System.Collections.Generic;

public class GameSuccessData
{
	private List<Success> m_SuccessData = new List<Success>();

	public List<Success> SuccessData => m_SuccessData;

	public Success this[int id] => m_SuccessData[id];

	public GameSuccessData()
	{
		m_SuccessData.Add(new Success("出师未捷", "第一关团灭", 1));
		m_SuccessData.Add(new Success("忠实玩家", "通关一次", 1));
		m_SuccessData.Add(new Success("一掷千金", "在商店花费超过50000元", 50000));
		m_SuccessData.Add(new Success("不差钱", "修理费用超过50000元", 50000));
		m_SuccessData.Add(new Success("战神降临", "第20关击败古兰森", 1));
		m_SuccessData.Add(new Success("越挫越勇", "游戏失败5次", 5));
		m_SuccessData.Add(new Success("大富豪", "赚取50000元", 50000));
		m_SuccessData.Add(new Success("尼娜,是谁?", "第三关击杀妮娜", 1));
		m_SuccessData.Add(new Success("割韭菜", "击杀200个敌人", 200));
		m_SuccessData.Add(new Success("菜鸟指挥官", "机体被击杀超过20次", 20));
	}

	public void LoadData(string data)
	{
		string[] array = data.Split(';');
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (!(text == string.Empty))
			{
				string[] array3 = text.Split(',');
				m_SuccessData[int.Parse(array3[0])].Schedule = int.Parse(array3[1]);
			}
		}
	}

	public string SaveData()
	{
		string text = string.Empty;
		for (int i = 0; i < m_SuccessData.Count; i++)
		{
			text = text + i + ",";
			text = text + m_SuccessData[i].Schedule + ";";
		}
		return text;
	}
}
