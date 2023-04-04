using System.Collections.Generic;

public class User
{
	private string m_Name = string.Empty;

	private int m_Hand = -1;

	private List<int> m_Spirit = new List<int>();

	public int Hand => m_Hand;

	public string Name => m_Name;

	public List<int> Spirit => m_Spirit;

	public User(string name, int hand, int[] spirit)
	{
		m_Name = name;
		m_Hand = hand;
		if (spirit != null)
		{
			foreach (int item in spirit)
			{
				m_Spirit.Add(item);
			}
		}
	}
}
