using System.Collections.Generic;
using UnityEngine;

public class Spirit_KuangNu : Spirit
{
	public Spirit_KuangNu(int id)
		: base(id, 150, "狂怒", "对敌方机体造成10-255伤害", SpiritScope.EnemyAll)
	{
	}

	public override List<GameEvent> GetUseEvent(Fighter user, List<Fighter> target, Define.Point pos)
	{
		if (target.Count == 0)
		{
			return null;
		}
		bool flag = false;
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_MapLock());
		int num = 0;
		int num2 = 0;
		foreach (Fighter item in target)
		{
			if (CanUse(item))
			{
				flag = true;
				bool flag2 = false;
				int num3 = 10 + Random.Range(0, 245);
				if (num3 >= item.NHP)
				{
					num3 = item.NHP;
					flag2 = true;
					num += item.Exp;
					num2 += item.Money;
				}
				list.Add(new GameEvent_LookFighter(item.ID));
				list.Add(new GameEvent_Damage(item.ID, num3));
				if (flag2)
				{
					list.Add(new GameEvent_ActorDie(item.ID));
				}
			}
		}
		if (num > 0)
		{
			if (user.HasTrait(Define.UserTrait.KuaiSuXueXi))
			{
				list.Add(new GameEvent_Dialogue("经验获得提升 !", user.UserName, user.Hand, Vector2.zero));
				num *= 2;
			}
			list.Add(new GameEvent_Dialogue("获得经验" + num + "!", user.UserName + ":", user.Hand, Vector2.zero));
			list.Add(new GameEvent_AddExp(user.ID, num));
		}
		if (num2 > 0)
		{
			list.Add(new GameEvent_Dialogue("获得金钱" + num2 + "!", user.UserName + ":", user.Hand, Vector2.zero));
			list.Add(new GameEvent_AddMoney(num2));
		}
		list.Add(new GameEvent_AddSP(user.ID, -base.Expend));
		list.Add(new GameEvent_MapUnlock());
		return (!flag) ? null : list;
	}

	protected override List<GameEvent> Use(Fighter target)
	{
		return null;
	}
}
