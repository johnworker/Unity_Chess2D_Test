using System.Collections.Generic;
using UnityEngine;

public class Spirit_QiDao : Spirit
{
	public Spirit_QiDao(int id)
		: base(id, 100, "祈祷", "友方所有机体血量回复100", SpiritScope.SelfAll)
	{
	}

	public override bool CanUse(Fighter f)
	{
		return f.HP > f.NHP;
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		int num = target.HP - target.NHP;
		if (num > 100)
		{
			num = 100;
		}
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_LookFighter(target.ID));
		list.Add(new GameEvent_Damage(target.ID, -num));
		list.Add(new GameEvent_Dialogue("生命恢复" + num + "!", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
