using System.Collections.Generic;

public class GameEvent_ShowShop : GameEvent
{
	private List<int> m_Item;

	public List<int> Item => m_Item;

	public GameEvent_ShowShop(List<int> items)
		: base(Define.EventType.ShowShop)
	{
		m_Item = items;
	}
}
