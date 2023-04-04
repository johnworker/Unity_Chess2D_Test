using System.Collections.Generic;
using UnityEngine;

public class Spirit_QiangGong : Spirit
{
	public Spirit_QiangGong(int id)
		: base(id, 40, "强攻", "伤害*200%", SpiritScope.Self)
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
		list.Add(new GameEvent_SetStatus(target.ID, Define.UserStatus.QiangGong));
		list.Add(new GameEvent_Dialogue("伤害提升至200% !", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
