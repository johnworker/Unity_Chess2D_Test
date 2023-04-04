using System.Collections.Generic;

public abstract class Item
{
	public enum ItemScope
	{
		SelfOne,
		SelfAll,
		EnemyOne,
		EnemyAll
	}

	private ItemScope m_Scope;

	private string m_Name = string.Empty;

	private int m_Expend;

	private string m_Describe = string.Empty;

	private int m_ID;

	public int ID => m_ID;

	public string Name => m_Name;

	public int Expend => m_Expend;

	public string Describe => m_Describe;

	public ItemScope Scope => m_Scope;

	public Item(int id, int expend, string name, string describe, ItemScope scope)
	{
		m_ID = id;
		m_Name = name;
		m_Expend = expend;
		m_Describe = describe;
		m_Scope = scope;
	}

	public virtual List<GameEvent> GetUseEvent(List<Fighter> target)
	{
		if (target.Count == 0)
		{
			return null;
		}
		bool flag = false;
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_MapLock());
		foreach (Fighter item in target)
		{
			if (CanUse(item))
			{
				flag = true;
				list.AddRange(Use(item));
			}
		}
		list.Add(new GameEvent_AlterItem(ID, -1));
		list.Add(new GameEvent_MapUnlock());
		return (!flag) ? null : list;
	}

	protected abstract List<GameEvent> Use(Fighter target);

	public virtual bool CanUse(Fighter f)
	{
		return true;
	}
}
