using System.Collections.Generic;

public class Spirit_ChuanZhen : Spirit
{
	public Spirit_ChuanZhen(int id)
		: base(id, 150, "传真", "友方一人移动到任意位置", SpiritScope.SelfOneOther)
	{
	}

	public override List<GameEvent> GetUseEvent(Fighter user, List<Fighter> target, Define.Point pos)
	{
		if (target.Count != 1)
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
				list.Add(new GameEvent_LookFighter(item.ID));
				list.Add(new GameEvent_MoveTo(item.ID, pos.X, pos.Y));
			}
		}
		list.Add(new GameEvent_AddSP(user.ID, -base.Expend));
		list.Add(new GameEvent_MapUnlock());
		return (!flag) ? null : list;
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		return null;
	}
}
