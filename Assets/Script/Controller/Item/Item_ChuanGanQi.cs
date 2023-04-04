using System.Collections.Generic;
using UnityEngine;

public class Item_ChuanGanQi : Item
{
	public Item_ChuanGanQi(int id)
		: base(id, 2000, "传感器", "强度提高1", ItemScope.SelfOne)
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
		list.Add(new GameEvent_AddAttr(target.ID, 1, 0, 0, 0));
		list.Add(new GameEvent_Dialogue("强度提高 1!", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
