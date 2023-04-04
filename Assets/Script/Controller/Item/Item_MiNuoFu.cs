using System.Collections.Generic;

public class Item_MiNuoFu : Item
{
	public Item_MiNuoFu(int id)
		: base(id, 18000, "米诺夫粒子", "敌方全体命中减半", ItemScope.EnemyAll)
	{
	}

	public override bool CanUse(Fighter f)
	{
		return !f.State.Contains(Define.UserStatus.GanRao);
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_LookFighter(target.ID));
		list.Add(new GameEvent_ShowEffect(target.ID, 0));
		list.Add(new GameEvent_SetStatus(target.ID, Define.UserStatus.GanRao));
		return list;
	}
}
