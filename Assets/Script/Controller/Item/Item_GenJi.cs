using System.Collections.Generic;
using UnityEngine;

public class Item_GenJi : Item
{
	public Item_GenJi(int id)
		: base(id, 5000, "根基", "经验值提高1-255", ItemScope.SelfOne)
	{
	}

	public override bool CanUse(Fighter f)
	{
		return f.AIType == Define.AIType.Null;
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		int num = 1 + Random.Range(0, 255);
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_LookFighter(target.ID));
		list.Add(new GameEvent_ShowEffect(target.ID, 0));
		list.Add(new GameEvent_Dialogue("获得经验 " + num + "!", target.UserName + ":", target.Hand, Vector2.zero));
		list.Add(new GameEvent_AddExp(target.ID, num));
		return list;
	}
}
