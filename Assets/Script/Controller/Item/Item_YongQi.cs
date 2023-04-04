using System.Collections.Generic;
using UnityEngine;

public class Item_YongQi : Item
{
	public Item_YongQi(int id)
		: base(id, 4000, "勇气", "单体血量回复100", ItemScope.SelfOne)
	{
	}

	public override bool CanUse(Fighter f)
	{
		return f.HP > f.NHP;
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		int num = ((target.HP - target.NHP <= 100) ? (target.HP - target.NHP) : 100);
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_LookFighter(target.ID));
		list.Add(new GameEvent_Damage(target.ID, -num));
		list.Add(new GameEvent_Dialogue("生命恢复" + num + "!", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
