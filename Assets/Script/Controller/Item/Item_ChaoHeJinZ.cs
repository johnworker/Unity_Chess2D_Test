using System.Collections.Generic;
using UnityEngine;

public class Item_ChaoHeJinZ : Item
{
	public Item_ChaoHeJinZ(int id)
		: base(id, 3000, "超合金Z", "防御提高1", ItemScope.SelfOne)
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
		list.Add(new GameEvent_AddAttr(target.ID, 0, 0, 1, 0));
		list.Add(new GameEvent_Dialogue("防御提高 1!", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
