using System.Collections.Generic;
using UnityEngine;

public class Spirit_MiaoZhun : Spirit
{
	public Spirit_MiaoZhun(int id)
		: base(id, 10, "瞄准", "命中+10%", SpiritScope.Self)
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
		list.Add(new GameEvent_SetStatus(target.ID, Define.UserStatus.MiaoZhun));
		list.Add(new GameEvent_Dialogue("命中提高10% !", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
