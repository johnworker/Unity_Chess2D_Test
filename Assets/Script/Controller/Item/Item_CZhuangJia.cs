using System.Collections.Generic;
using UnityEngine;

public class Item_CZhuangJia : Item
{
	public Item_CZhuangJia(int id)
		: base(id, 2000, "C装甲", "血量上限提高5", ItemScope.SelfOne)
	{
	}

	public override bool CanUse(Fighter f)
	{
		return f.AIType == Define.AIType.Null;
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_LookFighter(target.ID));
		list.Add(new GameEvent_ShowEffect(target.ID, 0));
		list.Add(new GameEvent_AddAttr(target.ID, 0, 0, 0, 5));
		list.Add(new GameEvent_Dialogue("生命提高 5!", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
