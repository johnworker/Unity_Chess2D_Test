using System.Collections.Generic;
using UnityEngine;

public class Item_CiXingTuLiao : Item
{
	public Item_CiXingTuLiao(int id)
		: base(id, 4000, "磁性涂料", "速度提高1", ItemScope.SelfOne)
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
		list.Add(new GameEvent_AddAttr(target.ID, 0, 1, 0, 0));
		list.Add(new GameEvent_Dialogue("速度提高 1!", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
