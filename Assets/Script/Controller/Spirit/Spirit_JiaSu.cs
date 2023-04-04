using System.Collections.Generic;
using UnityEngine;

public class Spirit_JiaSu : Spirit
{
	public Spirit_JiaSu(int id)
		: base(id, 10, "加速", "移动力+3", SpiritScope.Self)
	{
	}

	public override bool CanUse(Fighter f)
	{
		return !f.State.Contains(Define.UserStatus.JiaSu) && !f.State.Contains(Define.UserStatus.JiFeng);
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_LookFighter(target.ID));
		list.Add(new GameEvent_ShowEffect(target.ID, 0));
		list.Add(new GameEvent_SetStatus(target.ID, Define.UserStatus.JiaSu));
		list.Add(new GameEvent_Dialogue("机动性提升 3 !", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
