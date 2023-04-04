using System.Collections.Generic;
using UnityEngine;

public class Item_MiaoZhun : Item
{
	public Item_MiaoZhun(int id)
		: base(id, 1000, "瞄准", "下场战斗命中+10%", ItemScope.SelfOne)
	{
	}

	public override bool CanUse(Fighter f)
	{
		return !f.State.Contains(Define.UserStatus.MiaoZhun) && !f.State.Contains(Define.UserStatus.BiSha);
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_LookFighter(target.ID));
		list.Add(new GameEvent_ShowEffect(target.ID, 0));
		list.Add(new GameEvent_Dialogue("命中提高 10%", target.UserName + ":", target.Hand, Vector2.zero));
		list.Add(new GameEvent_SetStatus(target.ID, Define.UserStatus.MiaoZhun));
		return list;
	}
}
