using System.Collections.Generic;
using UnityEngine;

public class Spirit_YiLi : Spirit
{
	public Spirit_YiLi(int id)
		: base(id, 10, "毅力", "自身血量回复50", SpiritScope.Self)
	{
	}

	public override bool CanUse(Fighter f)
	{
		return f.HP > f.NHP;
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		int num = target.HP - target.NHP;
		if (num > 50)
		{
			num = 50;
		}
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_LookFighter(target.ID));
		list.Add(new GameEvent_Damage(target.ID, -num));
		list.Add(new GameEvent_Dialogue("生命恢复" + num + "!", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
