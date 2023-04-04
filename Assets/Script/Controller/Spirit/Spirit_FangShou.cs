using System.Collections.Generic;
using UnityEngine;

public class Spirit_FangShou : Spirit
{
	public Spirit_FangShou(int id)
		: base(id, 20, "防守", "受到的伤害*50%", SpiritScope.Self)
	{
	}

	public override bool CanUse(Fighter f)
	{
		return !f.State.Contains(Define.UserStatus.FangShou);
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_LookFighter(target.ID));
		list.Add(new GameEvent_ShowEffect(target.ID, 0));
		list.Add(new GameEvent_SetStatus(target.ID, Define.UserStatus.FangShou));
		list.Add(new GameEvent_Dialogue("受伤减少50% !", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
