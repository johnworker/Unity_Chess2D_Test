using System.Collections.Generic;
using UnityEngine;

public class GameLevel_26 : Level
{
	public GameLevel_26()
	{
		m_Name = "第26篇: 黎明的决斗";
		m_Task = "打败瓦尔希昂!";
		m_Map = new Map(20, 23, new byte[460]
		{
			23, 23, 23, 23, 23, 23, 23, 23, 23, 23,
			23, 23, 23, 23, 23, 23, 23, 23, 23, 23,
			23, 24, 24, 24, 24, 24, 23, 23, 23, 23,
			23, 23, 23, 23, 24, 24, 24, 24, 24, 23,
			23, 21, 21, 21, 21, 23, 24, 24, 24, 24,
			24, 24, 24, 24, 23, 21, 21, 21, 21, 23,
			23, 20, 20, 20, 23, 24, 42, 42, 42, 42,
			42, 42, 42, 42, 24, 23, 20, 20, 20, 23,
			23, 20, 20, 23, 24, 42, 43, 43, 43, 43,
			43, 43, 43, 43, 42, 24, 23, 20, 20, 23,
			23, 20, 20, 23, 42, 43, 43, 43, 43, 43,
			43, 43, 43, 43, 43, 42, 23, 20, 20, 23,
			23, 20, 20, 23, 43, 43, 43, 43, 43, 43,
			43, 43, 43, 43, 43, 43, 23, 20, 20, 23,
			23, 20, 20, 23, 43, 43, 43, 43, 43, 43,
			43, 43, 43, 43, 43, 43, 23, 20, 20, 23,
			23, 20, 20, 23, 43, 43, 43, 43, 43, 43,
			43, 43, 43, 43, 43, 43, 23, 20, 20, 23,
			23, 20, 20, 24, 23, 43, 43, 43, 43, 43,
			43, 43, 43, 43, 43, 23, 24, 20, 20, 23,
			23, 20, 20, 21, 24, 23, 43, 43, 43, 43,
			43, 43, 43, 43, 23, 24, 21, 20, 20, 23,
			23, 20, 20, 20, 21, 24, 24, 23, 43, 43,
			43, 43, 23, 24, 24, 21, 20, 20, 20, 23,
			23, 20, 23, 20, 20, 21, 21, 23, 20, 43,
			43, 20, 23, 21, 21, 20, 20, 23, 20, 23,
			23, 23, 23, 23, 20, 20, 20, 23, 20, 43,
			43, 20, 23, 20, 20, 20, 23, 23, 23, 23,
			23, 23, 23, 23, 20, 20, 20, 23, 20, 43,
			43, 20, 23, 20, 20, 20, 23, 23, 23, 23,
			23, 23, 23, 23, 20, 20, 20, 23, 20, 43,
			43, 20, 23, 20, 20, 20, 23, 23, 23, 23,
			23, 23, 23, 23, 20, 20, 20, 23, 20, 43,
			43, 20, 23, 20, 20, 20, 23, 23, 23, 23,
			23, 24, 23, 24, 20, 20, 20, 23, 20, 43,
			43, 20, 23, 20, 20, 20, 24, 23, 24, 23,
			23, 21, 24, 21, 20, 20, 23, 23, 20, 43,
			43, 20, 23, 23, 20, 20, 21, 24, 21, 23,
			23, 20, 21, 20, 20, 23, 23, 23, 20, 43,
			43, 20, 23, 23, 23, 20, 20, 21, 20, 23,
			23, 20, 20, 20, 20, 24, 24, 24, 24, 43,
			43, 24, 24, 24, 24, 20, 20, 20, 20, 23,
			23, 20, 20, 20, 20, 21, 21, 21, 21, 43,
			43, 21, 21, 21, 21, 20, 20, 20, 20, 23,
			23, 23, 23, 23, 23, 23, 23, 23, 23, 23,
			23, 23, 23, 23, 23, 23, 23, 23, 23, 23
		});
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(9, 16, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(10, 16, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(8, 17, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(11, 17, GameDataBase.Instance.GetActor(14), 3));
		m_FighterData.Add(4, new Fighter(10, 17, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(9, 18, GameDataBase.Instance.GetActor(13), 5));
		m_FighterData.Add(6, new Fighter(9, 17, GameDataBase.Instance.GetActor(16), 6));
		m_FighterData.Add(7, new Fighter(10, 18, GameDataBase.Instance.GetActor(9), 7));
		m_FighterData.Add(8, new Fighter(8, 18, GameDataBase.Instance.GetActor(7), 8));
		m_FighterData.Add(9, new Fighter(11, 18, GameDataBase.Instance.GetActor(17), 9));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("瓦尔希昂", Robot.EngineType.Land, 11, 56, 7, 6290, 248, 144, 168, new int[2] { 76, 77 });
		Robot robot2 = new Robot("古兰森", Robot.EngineType.Land, 102, 88, 8, 4020, 241, 237, 191, new int[2] { 132, 133 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot3 = new Robot("盖马", Robot.EngineType.Land, 87, 77, 8, 1470, 238, 121, 174, new int[2] { 65, 104 });
		Robot robot4 = new Robot("盖马", Robot.EngineType.Land, 87, 77, 8, 1370, 238, 118, 169, new int[2] { 65, 104 });
		User user = new User("诺恩", 43, null);
		User user2 = new User("贝克", 36, null);
		User user3 = new User("休", 57, null);
		User user4 = new User("温妮", 58, null);
		m_FighterData.Add(10, new Fighter(9, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot)
		}, Define.AIType.Counter, 46, 0, 1, 0, 9), 10));
		m_FighterData.Add(11, new Fighter(10, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot2)
		}, Define.AIType.Counter, 39, 0, 400, 5000, 13), 11));
		m_FighterData.Add(12, new Fighter(1, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot3)
		}, Define.AIType.Attack, 31, 0, 130, 100), 12));
		m_FighterData.Add(13, new Fighter(18, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot4)
		}, Define.AIType.Attack, 30, 0, 130, 100), 13));
	}

	private void LoadEventData()
	{
		GameEvent[] value = new GameEvent[27]
		{
			new GameEvent_MapLock(),
			new GameEvent_PlayBGM(4),
			new GameEvent_Dialogue("好,居然发展的这么强大了......那就没问题了......", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("像我这年纪的人也该让位了......", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("未来是属于你们年轻人的......", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("你们一定要记住:即使在和平年代,也会爆发战争......", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("敢于对抗战争威胁的,只有你们这些年轻的力量.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("祈求和平是好的,但不能被和平的环境冲昏头脑.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("如果有值得守护的东西,就应该保持勇气和力量.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("一切都结束了......", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("留乃......没能见到你......真遗憾......", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("我先走了,这是自然规律,不用难过.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("干掉了吗......", "大卫:", 4, Vector2.zero),
			new GameEvent_Dialogue("嗯......", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("真不容易呐.", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("我总觉得不对劲.", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("我说的没错吧?", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("我们始终没逃出对方手心.", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("命运这东西,多多少少有点是别人强加的.", "马丁:", 30, Vector2.zero),
			new GameEvent_Dialogue("忘了这些,人就会自以为是......", "马丁:", 30, Vector2.zero),
			new GameEvent_Dialogue("真的会变成那样吗?", "布克:", 15, Vector2.zero),
			new GameEvent_Dialogue("喂,你们能不能不谈这些烦心的事!", "希塔:", 33, Vector2.zero),
			new GameEvent_Dialogue("已经结束了吧?大家都等着呢!", "希塔:", 33, Vector2.zero),
			new GameEvent_Dialogue("是吗,回去找大家吧!", "龙:", 5, Vector2.zero),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(-1)
		};
		m_GameEvent.Add(-1, value);
		m_FighterEvent.Add(10, value);
		m_GameEvent.Add(0, new GameEvent[27]
		{
			new GameEvent_PlayBGM(4),
			new GameEvent_MapLock(),
			new GameEvent_AddFighter(0),
			new GameEvent_AddFighter(1),
			new GameEvent_AddFighter(2),
			new GameEvent_AddFighter(3),
			new GameEvent_AddFighter(4),
			new GameEvent_AddFighter(5),
			new GameEvent_AddFighter(6),
			new GameEvent_AddFighter(7),
			new GameEvent_AddFighter(8),
			new GameEvent_GetFlag("YiWa", new List<GameEvent>
			{
				new GameEvent_AddFighter(9)
			}, new List<GameEvent>()),
			new GameEvent_AddFighter(10),
			new GameEvent_AddFighter(11),
			new GameEvent_AddFighter(12),
			new GameEvent_AddFighter(13),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("到底来了,形势发展出人意料的快.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("只要我不死,DC就不会灭亡!", "贝克:", 36, Vector2.zero),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("呵!你也一起吗!", "安东:", 27, Vector2.zero),
			new GameEvent_LookFighter(11),
			new GameEvent_Dialogue("可能是冤家吧.", "休:", 57, Vector2.zero),
			new GameEvent_LookFighter(0),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
	}
}
