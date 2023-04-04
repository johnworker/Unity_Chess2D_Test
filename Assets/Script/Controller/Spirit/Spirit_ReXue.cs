using System.Collections.Generic;
using UnityEngine;

public class Spirit_ReXue : Spirit
{
	public Spirit_ReXue(int id)
		: base(id, 80, "热血", "伤害*300%", SpiritScope.Self)
	{
	}

	public override bool CanUse(Fighter f)
	{
		return !f.State.Contains(Define.UserStatus.QiangGong) && !f.State.Contains(Define.UserStatus.ReXue);
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_LookFighter(target.ID));
		list.Add(new GameEvent_ShowEffect(target.ID, 0));
		list.Add(new GameEvent_SetStatus(target.ID, Define.UserStatus.ReXue));
		list.Add(new GameEvent_Dialogue("伤害提升至300% !", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
