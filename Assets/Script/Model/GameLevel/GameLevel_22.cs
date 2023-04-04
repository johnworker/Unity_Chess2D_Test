using System.Collections.Generic;
using UnityEngine;

public class GameLevel_22 : Level
{
	public GameLevel_22()
	{
		m_Name = "第22篇: 突入大气层";
		m_Task = "一定要守住拉姆20回合.";
		m_Map = new Map(32, 18, new byte[576]
		{
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 31, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 30, 28, 28,
			28, 28, 28, 28, 28, 28, 29, 28, 28, 28,
			30, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 30, 28, 28, 28,
			29, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 29, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			29, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 29, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 29, 28, 28,
			30, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 29, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 31, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 29, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 29,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 29, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 30,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			29, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 29,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 29, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 29, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			29, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 29, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 29, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 29,
			28, 28, 28, 35, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 29,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28
		});
		AddShopEvent(new Define.Point(1, 16), new List<int> { 0, 1, 2, 3, 4, 5, 7, 8 });
		m_SelfBGM = 11;
		m_EnemyBGM = 10;
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(13, 8, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(21, 8, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(17, 6, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(19, 8, GameDataBase.Instance.GetActor(14), 3));
		m_FighterData.Add(4, new Fighter(16, 9, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(15, 8, GameDataBase.Instance.GetActor(13), 5));
		m_FighterData.Add(6, new Fighter(17, 10, GameDataBase.Instance.GetActor(16), 6));
		m_FighterData.Add(7, new Fighter(18, 9, GameDataBase.Instance.GetActor(9), 7));
		m_FighterData.Add(8, new Fighter(16, 7, GameDataBase.Instance.GetActor(7), 8));
		m_FighterData.Add(9, new Fighter(17, 8, GameDataBase.Instance.GetActor(0), 9));
		m_FighterData.Add(10, new Fighter(18, 7, GameDataBase.Instance.GetActor(17), 10));
		m_FighterEvent.Add(9, new GameEvent[1]
		{
			new GameEvent_GameOver()
		});
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("秀伯", Robot.EngineType.Land, 77, 67, 10, 2370, 206, 105, 151, new int[2] { 69, 94 });
		Robot robot2 = new Robot("盖马", Robot.EngineType.Land, 87, 77, 8, 1270, 218, 103, 154, new int[2] { 65, 104 });
		Robot robot3 = new Robot("希卡", Robot.EngineType.Land, 75, 66, 10, 730, 194, 100, 143, new int[2] { 65, 95 });
		Robot robot4 = new Robot("刚达II", Robot.EngineType.Land, 84, 73, 5, 980, 211, 137, 117, new int[2] { 97, 100 });
		Robot robot5 = new Robot("基格", Robot.EngineType.Land, 91, 80, 9, 555, 151, 100, 155, new int[2] { 106, 107 });
		Robot robot6 = new Robot("基格", Robot.EngineType.Land, 92, 80, 7, 465, 138, 92, 124, new int[2] { 106, 107 });
		Robot robot7 = new Robot("基格", Robot.EngineType.Land, 92, 80, 7, 465, 138, 92, 124, new int[2] { 106, 107 });
		Robot robot8 = new Robot("基格", Robot.EngineType.Land, 92, 80, 7, 465, 138, 92, 124, new int[2] { 106, 107 });
		Robot robot9 = new Robot("刚克", Robot.EngineType.Land, 72, 69, 8, 1020, 146, 91, 120, new int[2] { 99, 26 });
		Robot robot10 = new Robot("刚克", Robot.EngineType.Land, 72, 69, 8, 1020, 146, 91, 120, new int[2] { 99, 26 });
		Robot robot11 = new Robot("伯希", Robot.EngineType.Land, 97, 85, 6, 1280, 181, 93, 118, new int[2] { 111, 112 });
		Robot robot12 = new Robot("伯希", Robot.EngineType.Land, 97, 85, 6, 1460, 207, 105, 132, new int[2] { 111, 112 });
		Robot robot13 = new Robot("拉比", Robot.EngineType.Land, 81, 72, 8, 405, 112, 88, 144, new int[2] { 69, 71 });
		Robot robot14 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 465, 145, 90, 148, new int[2] { 103, 71 });
		Robot robot15 = new Robot("布x1", Robot.EngineType.Land, 98, 86, 5, 900, 212, 96, 106, new int[2] { 110, 49 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot16 = new Robot("布x1", Robot.EngineType.Land, 98, 86, 5, 900, 212, 96, 106, new int[2] { 110, 49 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot17 = new Robot("布x1", Robot.EngineType.Land, 98, 86, 5, 900, 212, 96, 106, new int[2] { 110, 49 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		User user = new User("士兵", 6, null);
		User user2 = new User("芬妮", 38, null);
		User user3 = new User("温妮", 58, null);
		User user4 = new User("马休", 20, null);
		User user5 = new User("普西", 56, null);
		User user6 = new User("保罗", 12, null);
		User user7 = new User("海伦", 52, null);
		m_FighterData.Add(11, new Fighter(29, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot)
		}, Define.AIType.Attack, 38, 0, 155, 100), 11));
		m_FighterData.Add(12, new Fighter(30, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot2)
		}, Define.AIType.Attack, 36, 0, 130, 100), 12));
		m_FighterData.Add(13, new Fighter(29, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot3)
		}, Define.AIType.Attack, 37, 0, 125, 100), 13));
		m_FighterData.Add(14, new Fighter(30, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user5, robot4)
		}, Define.AIType.Attack, 37, 0, 190, 100), 14));
		m_FighterData.Add(15, new Fighter(23, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user7, robot5)
		}, Define.AIType.Attack, 36, 0, 110, 100), 15));
		m_FighterData.Add(16, new Fighter(22, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Attack, 34, 0, 110, 100), 16));
		m_FighterData.Add(17, new Fighter(24, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Attack, 34, 0, 110, 100), 17));
		m_FighterData.Add(18, new Fighter(25, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Attack, 34, 0, 110, 100), 18));
		m_FighterData.Add(19, new Fighter(24, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot13)
		}, Define.AIType.Attack, 34, 0, 100, 100), 19));
		m_FighterData.Add(20, new Fighter(26, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot14)
		}, Define.AIType.Attack, 34, 0, 140, 100), 20));
		m_FighterData.Add(21, new Fighter(28, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot11)
		}, Define.AIType.Attack, 34, 0, 190, 100), 21));
		m_FighterData.Add(22, new Fighter(6, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user6, robot12)
		}, Define.AIType.Attack, 37, 0, 190, 100), 22));
		m_FighterData.Add(23, new Fighter(4, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Attack, 35, 0, 125, 100), 23));
		m_FighterData.Add(24, new Fighter(8, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot10)
		}, Define.AIType.Attack, 35, 0, 125, 100), 24));
		m_FighterData.Add(25, new Fighter(6, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot15)
		}, Define.AIType.Attack, 33, 0, 190, 100), 25));
		m_FighterData.Add(26, new Fighter(7, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot16)
		}, Define.AIType.Attack, 33, 0, 190, 100), 26));
		m_FighterData.Add(27, new Fighter(17, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot17)
		}, Define.AIType.Attack, 33, 0, 190, 100), 27));
	}

	private void LoadEventData()
	{
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_MapLock());
		list.Add(new GameEvent_PlayBGM(4));
		list.Add(new GameEvent_ChooseActor(9, new Actor.ActorData[1]
		{
			new Actor.ActorData(3, 59)
		}));
		list.Add(new GameEvent_Repair());
		list.Add(new GameEvent_MapUnlock());
		list.Add(new GameEvent_Victory(22));
		List<GameEvent> list2 = list;
		m_GameEvent.Add(-1, list2.ToArray());
		m_GameEvent.Add(0, new GameEvent[32]
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
			new GameEvent_AddFighter(9),
			new GameEvent_GetFlag("YiWa", new List<GameEvent>
			{
				new GameEvent_AddFighter(10)
			}, new List<GameEvent>()),
			new GameEvent_ChooseActor(9, new Actor.ActorData[1]
			{
				new Actor.ActorData(3, 58)
			}),
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
			new GameEvent_AddFighter(22),
			new GameEvent_AddFighter(23),
			new GameEvent_AddFighter(24),
			new GameEvent_LookFighter(9),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(3, new GameEvent[10]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(25),
			new GameEvent_LookFighter(25),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(26),
			new GameEvent_LookFighter(26),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(27),
			new GameEvent_LookFighter(27),
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(17, new GameEvent[3]
		{
			new GameEvent_LookFighter(9),
			new GameEvent_Dialogue("再过两分钟就要突破大气层了!", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("超过两分钟的话,着陆地点会偏离.太危险!", "乔:", 0, Vector2.zero)
		});
		m_GameEvent.Add(20, list2.ToArray());
	}
}
