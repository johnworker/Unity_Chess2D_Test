using System.Collections.Generic;
using UnityEngine;

public class Item_ZhengYi : Item
{
	public Item_ZhengYi(int id)
		: base(id, 5000, "正义", "精神回复20", ItemScope.SelfOne)
	{
	}

	public override bool CanUse(Fighter f)
	{
		return f.SP > f.NSP;
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		int num = ((target.SP - target.NSP <= 20) ? (target.HP - target.NHP) : 20);
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_LookFighter(target.ID));
		list.Add(new GameEvent_ShowEffect(target.ID, 0));
		list.Add(new GameEvent_AddSP(target.ID, -num));
		list.Add(new GameEvent_Dialogue("精神恢复" + num + "!", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
