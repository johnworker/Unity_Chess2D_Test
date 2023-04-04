using System.Collections.Generic;
using UnityEngine;

public class Spirit_JiFeng : Spirit
{
	public Spirit_JiFeng(int id)
		: base(id, 50, "疾风", "移动力+5", SpiritScope.Self)
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
		list.Add(new GameEvent_SetStatus(target.ID, Define.UserStatus.JiFeng));
		list.Add(new GameEvent_Dialogue("机动性提升 5 !", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
