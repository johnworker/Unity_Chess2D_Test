using System.Collections.Generic;
using UnityEngine;

public class GameLevel_18 : Level
{
	public GameLevel_18()
	{
		m_Name = "第18篇: 潜入帕托";
		m_Task = "全歼敌人即胜利!";
		m_Map = new Map(32, 20, new byte[640]
		{
			23, 23, 23, 23, 23, 24, 24, 24, 24, 24,
			24, 24, 24, 24, 24, 23, 23, 24, 24, 24,
			24, 24, 24, 24, 24, 24, 24, 24, 24, 23,
			23, 23, 23, 23, 23, 23, 24, 21, 21, 21,
			21, 21, 21, 21, 21, 21, 21, 23, 23, 21,
			21, 21, 21, 21, 21, 21, 21, 21, 21, 21,
			21, 24, 23, 23, 23, 23, 23, 24, 21, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 23,
			23, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 21, 24, 23, 23, 23, 24, 21,
			20, 20, 20, 23, 24, 24, 24, 24, 24, 24,
			24, 24, 24, 24, 24, 24, 24, 24, 24, 23,
			20, 20, 20, 20, 22, 20, 21, 24, 23, 24,
			21, 20, 20, 20, 23, 24, 21, 21, 21, 21,
			21, 21, 21, 21, 21, 21, 21, 21, 21, 21,
			21, 24, 23, 20, 20, 20, 20, 22, 20, 21,
			23, 21, 20, 20, 20, 23, 24, 21, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 21, 23, 23, 20, 20, 20, 22,
			22, 20, 23, 20, 22, 20, 20, 23, 21, 20,
			20, 20, 20, 20, 20, 20, 20, 23, 23, 20,
			20, 20, 20, 20, 23, 24, 24, 24, 20, 20,
			22, 20, 20, 22, 24, 20, 20, 20, 20, 23,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 23,
			23, 20, 20, 20, 23, 23, 24, 21, 21, 21,
			20, 20, 20, 20, 22, 23, 21, 22, 20, 22,
			20, 23, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 23, 23, 20, 20, 20, 23, 24, 21, 20,
			20, 20, 20, 20, 20, 22, 20, 23, 20, 20,
			22, 20, 20, 24, 23, 20, 20, 20, 20, 20,
			20, 20, 20, 23, 23, 20, 20, 20, 23, 21,
			20, 20, 23, 23, 20, 20, 20, 20, 22, 23,
			23, 22, 22, 22, 20, 21, 24, 23, 20, 20,
			20, 20, 20, 20, 20, 23, 23, 20, 20, 20,
			23, 20, 20, 20, 23, 23, 20, 20, 22, 20,
			20, 23, 23, 20, 22, 22, 20, 20, 21, 24,
			23, 20, 20, 20, 20, 20, 20, 23, 23, 20,
			20, 20, 23, 20, 20, 20, 23, 23, 20, 20,
			20, 20, 20, 23, 23, 23, 20, 22, 20, 20,
			20, 21, 24, 24, 23, 23, 23, 20, 20, 23,
			23, 20, 20, 20, 24, 20, 20, 20, 23, 23,
			23, 20, 20, 20, 20, 23, 23, 23, 23, 20,
			20, 20, 20, 20, 21, 21, 24, 23, 23, 20,
			20, 23, 23, 20, 20, 20, 21, 20, 20, 20,
			24, 24, 23, 23, 20, 20, 20, 23, 23, 23,
			23, 23, 20, 20, 20, 20, 20, 20, 21, 23,
			23, 20, 20, 24, 24, 20, 20, 20, 20, 20,
			20, 20, 21, 21, 23, 23, 20, 20, 20, 23,
			23, 23, 23, 23, 23, 20, 20, 20, 20, 20,
			20, 24, 24, 20, 20, 21, 21, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 23, 23, 20, 20,
			20, 23, 24, 24, 24, 24, 24, 20, 20, 20,
			20, 20, 20, 21, 21, 20, 20, 20, 20, 20,
			20, 20, 23, 23, 23, 20, 20, 20, 24, 24,
			20, 20, 20, 23, 21, 21, 21, 21, 21, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 23, 23, 23, 23, 23, 20, 20,
			21, 21, 20, 20, 23, 23, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 20, 23, 23, 23, 23, 23, 23,
			23, 20, 20, 20, 20, 23, 23, 23, 23, 23,
			23, 23, 23, 23, 23, 23, 23, 23, 23, 23,
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
		m_FighterData.Add(0, new Fighter(12, 7, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(15, 5, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(19, 7, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(14, 7, GameDataBase.Instance.GetActor(6), 3));
		m_FighterData.Add(4, new Fighter(13, 6, GameDataBase.Instance.GetActor(9), 4));
		m_FighterData.Add(5, new Fighter(17, 7, GameDataBase.Instance.GetActor(7), 5));
		m_FighterData.Add(6, new Fighter(13, 8, GameDataBase.Instance.GetActor(17), 6));
		m_FighterData.Add(7, new Fighter(16, 5, GameDataBase.Instance.GetActor(12), 7));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("巴乌", Robot.EngineType.Land, 96, 74, 10, 1940, 202, 125, 174, new int[2] { 103, 71 });
		Robot robot2 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 445, 139, 84, 140, new int[2] { 103, 71 });
		Robot robot3 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 445, 139, 84, 140, new int[2] { 103, 71 });
		Robot robot4 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 445, 139, 84, 140, new int[2] { 103, 71 });
		Robot robot5 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 445, 139, 84, 140, new int[2] { 103, 71 });
		Robot robot6 = new Robot("拉比", Robot.EngineType.Land, 81, 72, 8, 385, 106, 82, 136, new int[2] { 69, 71 });
		Robot robot7 = new Robot("拉比", Robot.EngineType.Land, 81, 72, 8, 385, 106, 82, 136, new int[2] { 69, 71 });
		Robot robot8 = new Robot("拉比", Robot.EngineType.Land, 81, 72, 8, 385, 106, 82, 136, new int[2] { 69, 71 });
		Robot robot9 = new Robot("拉比", Robot.EngineType.Land, 81, 72, 8, 385, 106, 82, 136, new int[2] { 69, 71 });
		Robot robot10 = new Robot("拉比", Robot.EngineType.Land, 81, 72, 8, 385, 106, 82, 136, new int[2] { 69, 71 });
		Robot robot11 = new Robot("拉比", Robot.EngineType.Land, 81, 72, 8, 385, 106, 82, 136, new int[2] { 69, 71 });
		Robot robot12 = new Robot("布x1", Robot.EngineType.Land, 98, 86, 5, 860, 204, 90, 98, new int[2] { 110, 49 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot13 = new Robot("布x1", Robot.EngineType.Land, 98, 86, 5, 860, 204, 90, 98, new int[2] { 110, 49 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot14 = new Robot("伯希", Robot.EngineType.Land, 97, 85, 6, 1300, 185, 96, 121, new int[2] { 111, 112 });
		Robot robot15 = new Robot("伯希", Robot.EngineType.Land, 97, 85, 8, 1430, 241, 108, 155, new int[2] { 111, 112 });
		Robot robot16 = new Robot("扎克III", Robot.EngineType.Land, 82, 66, 8, 660, 168, 85, 118, new int[2] { 69, 102 });
		Robot robot17 = new Robot("扎克III", Robot.EngineType.Land, 82, 66, 8, 660, 168, 85, 118, new int[2] { 69, 102 });
		Robot robot18 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 365, 124, 70, 100, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot19 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 365, 124, 70, 100, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot20 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 445, 139, 84, 140, new int[2] { 103, 71 });
		Robot robot21 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 445, 139, 84, 140, new int[2] { 103, 71 });
		Robot robot22 = new Robot("拉比", Robot.EngineType.Land, 81, 72, 8, 385, 106, 82, 136, new int[2] { 69, 71 });
		Robot robot23 = new Robot("麦萨拉", Robot.EngineType.Land, 99, 87, 5, 1240, 132, 92, 104, new int[2] { 105, 65 });
		User user = new User("士兵", 6, null);
		User user2 = new User("布托", 54, null);
		User user3 = new User("诺恩", 43, null);
		m_FighterData.Add(8, new Fighter(1, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot)
		}, Define.AIType.Counter, 37, 0, 225, 100), 8));
		m_FighterData.Add(9, new Fighter(28, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot2)
		}, Define.AIType.Attack, 30, 0, 140, 100), 9));
		m_FighterData.Add(10, new Fighter(29, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot3)
		}, Define.AIType.Attack, 30, 0, 140, 100), 10));
		m_FighterData.Add(11, new Fighter(27, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot4)
		}, Define.AIType.Attack, 30, 0, 140, 100), 11));
		m_FighterData.Add(12, new Fighter(28, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot5)
		}, Define.AIType.Attack, 30, 0, 140, 100), 12));
		m_FighterData.Add(13, new Fighter(4, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Attack, 30, 0, 100, 100), 13));
		m_FighterData.Add(14, new Fighter(3, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Attack, 30, 0, 100, 100), 14));
		m_FighterData.Add(15, new Fighter(2, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Attack, 30, 0, 100, 100), 15));
		m_FighterData.Add(16, new Fighter(1, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Attack, 30, 0, 100, 100), 16));
		m_FighterData.Add(17, new Fighter(8, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot10)
		}, Define.AIType.Counter, 30, 0, 100, 100), 17));
		m_FighterData.Add(18, new Fighter(24, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot11)
		}, Define.AIType.Counter, 30, 0, 100, 100), 18));
		m_FighterData.Add(19, new Fighter(27, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot12)
		}, Define.AIType.Attack, 29, 0, 190, 100), 19));
		m_FighterData.Add(20, new Fighter(28, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot13)
		}, Define.AIType.Attack, 29, 0, 190, 100), 20));
		m_FighterData.Add(21, new Fighter(3, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot14)
		}, Define.AIType.Counter, 36, 0, 130, 100), 21));
		m_FighterData.Add(22, new Fighter(31, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot15)
		}, Define.AIType.Attack, 39, 0, 135, 100), 22));
		m_FighterData.Add(23, new Fighter(0, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot16)
		}, Define.AIType.Attack, 30, 0, 110, 100), 23));
		m_FighterData.Add(24, new Fighter(0, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot17)
		}, Define.AIType.Attack, 30, 0, 110, 100), 24));
		m_FighterData.Add(25, new Fighter(31, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot18)
		}, Define.AIType.Attack, 30, 0, 100, 100), 25));
		m_FighterData.Add(26, new Fighter(29, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot20)
		}, Define.AIType.Attack, 30, 0, 140, 100), 26));
		m_FighterData.Add(27, new Fighter(29, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot21)
		}, Define.AIType.Attack, 30, 0, 140, 100), 27));
		m_FighterData.Add(28, new Fighter(30, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot22)
		}, Define.AIType.Attack, 30, 0, 100, 100), 28));
		m_FighterData.Add(29, new Fighter(30, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot23)
		}, Define.AIType.Attack, 30, 0, 150, 100), 29));
		m_FighterData.Add(30, new Fighter(31, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot19)
		}, Define.AIType.Attack, 30, 0, 100, 100), 30));
	}

	private void LoadEventData()
	{
		m_GameEvent.Add(-1, new GameEvent[20]
		{
			new GameEvent_MapLock(),
			new GameEvent_PlayBGM(4),
			new GameEvent_Dialogue("乔舰长,有人呼叫.", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("喂,久违了!我们赶来救你们!", "凯文:", 55, Vector2.zero),
			new GameEvent_Dialogue("凯文舰长!你是什么时候来的......", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("多亏了你们,才是地球上的战争暂时中止了!", "凯文:", 55, Vector2.zero),
			new GameEvent_Dialogue("要不,我们还不能来.", "凯文:", 55, Vector2.zero),
			new GameEvent_Dialogue("就算那样,你能找到我们也不简单", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("多亏了他.", "凯文:", 55, Vector2.zero),
			new GameEvent_Dialogue("他?", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("哎,我又回来了!在途中遇到这个大叔.就带他来了.", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("安东!", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("别叫我大叔!我才30岁.", "凯文:", 55, Vector2.zero),
			new GameEvent_Dialogue("凯文舰长,进攻DC的古拉基地采用什么线路最有效呢?", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("情报上说,北边的防守比较虚弱.", "凯文:", 55, Vector2.zero),
			new GameEvent_Dialogue("我们从南边佯攻,然后突袭北边.", "凯文:", 55, Vector2.zero),
			new GameEvent_Dialogue("明白了,大家行动吧!", "乔:", 0, Vector2.zero),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(18)
		});
		m_GameEvent.Add(0, new GameEvent[28]
		{
			new GameEvent_PlayBGM(4),
			new GameEvent_MapLock(),
			new GameEvent_AddFighter(0),
			new GameEvent_AddFighter(1),
			new GameEvent_AddFighter(2),
			new GameEvent_AddFighter(3),
			new GameEvent_AddFighter(4),
			new GameEvent_AddFighter(5),
			new GameEvent_GetFlag("YiWa", new List<GameEvent>
			{
				new GameEvent_AddFighter(6)
			}, new List<GameEvent>()),
			new GameEvent_AddFighter(7),
			new GameEvent_AddFighter(8),
			new GameEvent_AddFighter(9),
			new GameEvent_AddFighter(10),
			new GameEvent_AddFighter(11),
			new GameEvent_AddFighter(12),
			new GameEvent_AddFighter(13),
			new GameEvent_AddFighter(14),
			new GameEvent_AddFighter(15),
			new GameEvent_AddFighter(16),
			new GameEvent_AddFighter(17),
			new GameEvent_AddFighter(18),
			new GameEvent_AddFighter(19),
			new GameEvent_AddFighter(20),
			new GameEvent_AddFighter(21),
			new GameEvent_LookFighter(0),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(5, new GameEvent[22]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(22),
			new GameEvent_LookFighter(22),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(23),
			new GameEvent_LookFighter(23),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(24),
			new GameEvent_LookFighter(24),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(25),
			new GameEvent_LookFighter(25),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(30),
			new GameEvent_LookFighter(30),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(8),
			new GameEvent_Dialogue("来了?", "布托:", 54, Vector2.zero),
			new GameEvent_LookFighter(22),
			new GameEvent_Dialogue("布托!到火星了!", "诺恩:", 43, Vector2.zero),
			new GameEvent_LookFighter(8),
			new GameEvent_Dialogue("诺恩!谢谢!", "布托:", 54, Vector2.zero)
		});
		m_GameEvent.Add(8, new GameEvent[2]
		{
			new GameEvent_ChooseAI(17, Define.AIType.Attack),
			new GameEvent_ChooseAI(18, Define.AIType.Attack)
		});
		m_GameEvent.Add(10, new GameEvent[13]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(26),
			new GameEvent_LookFighter(26),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(27),
			new GameEvent_LookFighter(27),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(28),
			new GameEvent_LookFighter(28),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(29),
			new GameEvent_LookFighter(29),
			new GameEvent_WaitTime(0.5f)
		});
	}
}
