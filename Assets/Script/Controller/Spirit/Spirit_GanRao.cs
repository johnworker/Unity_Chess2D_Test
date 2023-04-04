using System.Collections.Generic;

public class Spirit_GanRao : Spirit
{
	public Spirit_GanRao(int id)
		: base(id, 100, "干扰", "敌方全部命中*50%(不叠加)", SpiritScope.EnemyAll)
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
