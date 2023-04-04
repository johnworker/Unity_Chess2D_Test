using System.Collections.Generic;
using UnityEngine;

public class Spirit_HuiBi : Spirit
{
	public Spirit_HuiBi(int id)
		: base(id, 50, "回避", "敌方命中降低100%", SpiritScope.Self)
	{
	}

	public override bool CanUse(Fighter f)
	{
		return !f.State.Contains(Define.UserStatus.HuiBi);
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_LookFighter(target.ID));
		list.Add(new GameEvent_ShowEffect(target.ID, 0));
		list.Add(new GameEvent_SetStatus(target.ID, Define.UserStatus.HuiBi));
		list.Add(new GameEvent_Dialogue("闪避几率100% !", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
