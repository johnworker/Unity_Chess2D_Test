using System.Collections.Generic;
using UnityEngine;

public class Item_QiDongZhuangZhi : Item
{
	public Item_QiDongZhuangZhi(int id)
		: base(id, 25000, "启动装置", "使角色再次行动", ItemScope.SelfOne)
	{
	}

	public override bool CanUse(Fighter f)
	{
		return f.IsAction;
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_LookFighter(target.ID));
		list.Add(new GameEvent_ShowEffect(target.ID, 0));
		list.Add(new GameEvent_SetAction(target.ID, action: false));
		list.Add(new GameEvent_Dialogue(target.RobotName + "启动!", target.UserName + ":", target.Hand, Vector2.zero));
		return list;
	}
}
