using System.Collections.Generic;
using UnityEngine;

public class GameLevel_25 : Level
{
	public GameLevel_25()
	{
		m_Name = "第25篇: 巴塔利二世";
		m_Task = "打败希亚!";
		m_Map = new Map(32, 22, new byte[704]
		{
			3, 3, 3, 3, 0, 0, 0, 0, 0, 0,
			0, 3, 3, 3, 3, 3, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 3, 0,
			0, 0, 3, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 3, 3, 3, 0, 0,
			1, 1, 1, 1, 1, 1, 1, 1, 0, 0,
			4, 4, 0, 0, 3, 3, 0, 0, 0, 3,
			0, 0, 3, 0, 0, 3, 3, 3, 3, 0,
			3, 0, 0, 0, 1, 1, 1, 1, 1, 1,
			3, 3, 0, 3, 4, 3, 3, 3, 3, 3,
			3, 0, 3, 3, 3, 4, 4, 0, 0, 3,
			3, 3, 3, 3, 0, 0, 0, 1, 1, 1,
			3, 3, 3, 3, 3, 3, 0, 3, 0, 3,
			0, 3, 0, 3, 3, 0, 0, 3, 3, 4,
			4, 4, 3, 3, 3, 3, 3, 3, 3, 3,
			0, 3, 3, 3, 4, 4, 4, 3, 4, 3,
			3, 0, 3, 3, 3, 3, 0, 3, 3, 3,
			3, 0, 3, 3, 3, 3, 0, 0, 3, 3,
			3, 3, 3, 3, 3, 4, 0, 0, 4, 4,
			3, 3, 0, 0, 0, 0, 0, 3, 3, 3,
			3, 4, 4, 3, 0, 3, 0, 3, 3, 0,
			0, 0, 0, 3, 3, 0, 4, 4, 4, 0,
			0, 3, 3, 3, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 4, 0, 3, 3,
			0, 0, 3, 0, 0, 3, 3, 3, 3, 3,
			3, 0, 0, 9, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 3, 3, 0, 0, 0, 0, 0,
			0, 3, 3, 0, 0, 3, 3, 3, 3, 3,
			0, 3, 3, 3, 3, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 3, 0,
			0, 0, 3, 3, 3, 3, 3, 3, 3, 3,
			3, 3, 3, 3, 3, 0, 0, 0, 7, 7,
			0, 0, 0, 0, 0, 0, 7, 0, 0, 0,
			0, 3, 4, 4, 3, 0, 0, 3, 3, 0,
			3, 3, 3, 3, 3, 0, 0, 0, 7, 7,
			7, 7, 0, 0, 0, 0, 0, 0, 7, 7,
			7, 7, 0, 0, 0, 3, 4, 3, 3, 0,
			3, 3, 3, 3, 3, 3, 0, 0, 7, 7,
			7, 7, 7, 7, 3, 0, 0, 0, 0, 0,
			0, 7, 7, 7, 7, 7, 0, 6, 6, 6,
			0, 0, 0, 0, 3, 3, 0, 3, 3, 7,
			7, 7, 7, 7, 7, 7, 3, 3, 3, 0,
			0, 0, 0, 0, 7, 7, 7, 7, 6, 6,
			6, 6, 6, 6, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 0, 0, 3, 3,
			3, 3, 3, 3, 0, 0, 0, 0, 7, 7,
			7, 6, 6, 6, 6, 6, 6, 6, 7, 7,
			7, 7, 7, 7, 7, 7, 0, 0, 0, 0,
			3, 0, 3, 0, 3, 3, 3, 0, 0, 0,
			0, 0, 0, 0, 6, 6, 6, 6, 6, 6,
			6, 7, 7, 7, 7, 7, 0, 0, 0, 4,
			4, 3, 0, 3, 4, 4, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			6, 6, 6, 6, 6, 6, 0, 0, 0, 4,
			4, 3, 3, 3, 1, 3, 0, 0, 0, 0,
			0, 0, 3, 3, 0, 0, 0, 0, 0, 3,
			3, 0, 0, 0, 0, 0, 0, 0, 4, 4,
			4, 3, 3, 3, 3, 3, 1, 1, 1, 0,
			0, 0, 4, 3, 3, 3, 3, 0, 0, 3,
			3, 3, 3, 3, 3, 3, 3, 3, 3, 4,
			4, 3, 3, 3, 3, 3, 1, 1, 1, 1,
			1, 1, 1, 3, 4, 3, 0, 0, 3, 3,
			0, 3, 3, 3, 3, 3, 3, 3, 3, 3,
			0, 3, 3, 3, 3, 3, 3, 1, 1, 1,
			1, 1, 1, 1, 1, 3, 3, 4, 3, 3,
			3, 3, 3, 3, 0, 0, 3, 3, 3, 3,
			3, 3, 3, 3, 3, 3, 3, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 3, 3, 1, 1, 3, 3, 3, 0, 0,
			0, 3, 3, 0, 3, 3, 3, 3, 1, 1,
			1, 1, 1, 1
		});
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		AddShopEvent(new Define.Point(29, 7), new List<int> { 0, 1, 2, 3, 4, 5, 7, 8, 9 });
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(17, 11, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(17, 15, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(15, 13, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(16, 14, GameDataBase.Instance.GetActor(14), 3));
		m_FighterData.Add(4, new Fighter(16, 13, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(18, 12, GameDataBase.Instance.GetActor(13), 5));
		m_FighterData.Add(6, new Fighter(18, 13, GameDataBase.Instance.GetActor(16), 6));
		m_FighterData.Add(7, new Fighter(18, 14, GameDataBase.Instance.GetActor(9), 7));
		m_FighterData.Add(8, new Fighter(16, 12, GameDataBase.Instance.GetActor(7), 8));
		m_FighterData.Add(9, new Fighter(17, 13, GameDataBase.Instance.GetActor(0), 9));
		m_FighterData.Add(10, new Fighter(19, 13, GameDataBase.Instance.GetActor(17), 10));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("盖马", Robot.EngineType.Land, 87, 77, 8, 1390, 242, 121, 174, new int[2] { 65, 104 });
		Robot robot2 = new Robot("希亚", Robot.EngineType.Sky, 93, 79, 10, 4450, 265, 128, 156, new int[2] { 109, 83 });
		Robot robot3 = new Robot("阿尔", Robot.EngineType.Sky, 108, 94, 6, 2400, 270, 143, 146, new int[2] { 153, 155 }, new Define.UserTrait[1] { Define.UserTrait.GongJiXiXue });
		Robot robot4 = new Robot("加姆", Robot.EngineType.Sky, 86, 75, 10, 435, 156, 86, 136, new int[1] { 101 });
		Robot robot5 = new Robot("古尔", Robot.EngineType.Sky, 38, 33, 6, 3110, 192, 122, 132, new int[2] { 48, 49 });
		Robot robot6 = new Robot("秀伯", Robot.EngineType.Land, 77, 67, 10, 2180, 177, 97, 132, new int[2] { 69, 94 });
		Robot robot7 = new Robot("秀伯", Robot.EngineType.Land, 77, 67, 10, 2470, 221, 120, 166, new int[2] { 69, 94 });
		Robot robot8 = new Robot("亚克托", Robot.EngineType.Land, 88, 78, 10, 1450, 244, 135, 163, new int[2] { 103, 108 });
		Robot robot9 = new Robot("亚克托", Robot.EngineType.Land, 88, 78, 10, 1460, 260, 136, 169, new int[2] { 103, 108 });
		Robot robot10 = new Robot("亚克托", Robot.EngineType.Land, 88, 78, 10, 1460, 225, 136, 170, new int[2] { 103, 108 });
		Robot robot11 = new Robot("亚克托", Robot.EngineType.Land, 88, 78, 10, 1510, 241, 144, 163, new int[2] { 103, 108 });
		Robot robot12 = new Robot("亚克托", Robot.EngineType.Land, 88, 78, 10, 1490, 236, 141, 159, new int[2] { 103, 108 });
		Robot robot13 = new Robot("基格", Robot.EngineType.Land, 92, 80, 7, 490, 145, 99, 131, new int[2] { 106, 107 });
		Robot robot14 = new Robot("基格", Robot.EngineType.Land, 92, 80, 7, 490, 145, 99, 131, new int[2] { 106, 107 });
		Robot robot15 = new Robot("比克", Robot.EngineType.Land, 37, 31, 4, 1390, 198, 129, 104, new int[2] { 46, 47 });
		Robot robot16 = new Robot("比克", Robot.EngineType.Land, 37, 31, 4, 1390, 198, 129, 104, new int[2] { 46, 47 });
		Robot robot17 = new Robot("扎克III", Robot.EngineType.Land, 82, 66, 8, 740, 184, 96, 130, new int[2] { 69, 102 });
		Robot robot18 = new Robot("扎克III", Robot.EngineType.Land, 82, 66, 8, 740, 184, 96, 130, new int[2] { 69, 102 });
		Robot robot19 = new Robot("扎克III", Robot.EngineType.Land, 82, 66, 8, 740, 184, 96, 130, new int[2] { 69, 102 });
		Robot robot20 = new Robot("比纳", Robot.EngineType.Land, 90, 82, 9, 850, 188, 129, 190, new int[2] { 65, 95 }, new Define.UserTrait[1]);
		User user = new User("士兵", 6, null);
		User user2 = new User("罗纳", 51, null);
		User user3 = new User("格恩", 49, null);
		User user4 = new User("帕亚", 50, null);
		User user5 = new User("海伦", 52, null);
		User user6 = new User("男爵", 24, null);
		User user7 = new User("诺恩", 43, null);
		User user8 = new User("温妮", 58, null);
		User user9 = new User("芬妮", 38, null);
		User user10 = new User("加纳", 17, null);
		User user11 = new User("拉尔", 13, null);
		User user12 = new User("珍妮", 47, null);
		m_FighterData.Add(11, new Fighter(3, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot2)
		}, Define.AIType.Counter, 46, 0, 240, 100), 11));
		m_FighterData.Add(12, new Fighter(27, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user6, robot5)
		}, Define.AIType.Attack, 42, 0, 160, 100), 12));
		m_FighterData.Add(13, new Fighter(3, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot3)
		}, Define.AIType.Counter, 43, 0, 210, 100), 13));
		m_FighterData.Add(14, new Fighter(3, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot8)
		}, Define.AIType.Counter, 42, 0, 150, 100), 14));
		m_FighterData.Add(15, new Fighter(2, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot4)
		}, Define.AIType.Counter, 38, 0, 135, 100), 15));
		m_FighterData.Add(16, new Fighter(4, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user7, robot9)
		}, Define.AIType.Counter, 43, 0, 150, 100), 16));
		m_FighterData.Add(17, new Fighter(23, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Attack, 39, 0, 155, 100), 17));
		m_FighterData.Add(18, new Fighter(17, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot16)
		}, Define.AIType.Attack, 40, 0, 200, 100), 18));
		m_FighterData.Add(19, new Fighter(11, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot17)
		}, Define.AIType.Attack, 38, 0, 110, 100), 19));
		m_FighterData.Add(20, new Fighter(12, 18, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot18)
		}, Define.AIType.Attack, 38, 0, 110, 100), 20));
		m_FighterData.Add(21, new Fighter(13, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot19)
		}, Define.AIType.Attack, 38, 0, 110, 100), 21));
		m_FighterData.Add(22, new Fighter(18, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user5, robot10)
		}, Define.AIType.Attack, 45, 0, 150, 100), 22));
		m_FighterData.Add(23, new Fighter(17, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot13)
		}, Define.AIType.Attack, 39, 0, 110, 100), 23));
		m_FighterData.Add(24, new Fighter(19, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot14)
		}, Define.AIType.Attack, 39, 0, 110, 100), 24));
		m_FighterData.Add(25, new Fighter(18, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot15)
		}, Define.AIType.Attack, 40, 0, 200, 100), 25));
		m_FighterData.Add(26, new Fighter(8, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user11, robot12)
		}, Define.AIType.Attack, 48, 0, 150, 100), 26));
		m_FighterData.Add(27, new Fighter(9, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user10, robot11)
		}, Define.AIType.Attack, 48, 0, 150, 100), 27));
		m_FighterData.Add(28, new Fighter(9, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user9, robot7)
		}, Define.AIType.Attack, 48, 0, 155, 100), 28));
		m_FighterData.Add(29, new Fighter(10, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user8, robot)
		}, Define.AIType.Attack, 48, 0, 130, 100), 29));
		m_FighterData.Add(30, new Fighter(31, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user12, robot20)
		}, Define.AIType.Attack, 46, 0, 140, 1000), 30));
	}

	private void LoadEventData()
	{
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_MapLock());
		list.Add(new GameEvent_Repair());
		list.Add(new GameEvent_MapUnlock());
		list.Add(new GameEvent_Victory(25));
		List<GameEvent> list2 = list;
		m_GameEvent.Add(-1, list2.ToArray());
		m_FighterEvent.Add(11, list2.ToArray());
		m_GameEvent.Add(0, new GameEvent[39]
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
			new GameEvent_AddFighter(25),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("那是什么!", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("塔利!", "欧文:", 10, Vector2.zero),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("这次别落后!打呀!", "安东:", 27, Vector2.zero),
			new GameEvent_LookFighter(11),
			new GameEvent_Dialogue("这帮家伙又来了,干掉他们!", "罗纳:", 51, Vector2.zero),
			new GameEvent_LookFighter(9),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(1, new GameEvent[1]
		{
			new GameEvent_GetFlag("KillZhenNi", new List<GameEvent>(), new List<GameEvent>
			{
				new GameEvent_PlayME(3),
				new GameEvent_AddFighter(30),
				new GameEvent_LookFighter(30),
				new GameEvent_WaitTime(0.5f)
			})
		});
		m_GameEvent.Add(3, new GameEvent[7]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(28),
			new GameEvent_LookFighter(28),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(29),
			new GameEvent_LookFighter(29),
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(4, new GameEvent[7]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(26),
			new GameEvent_LookFighter(26),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(27),
			new GameEvent_LookFighter(27),
			new GameEvent_WaitTime(0.5f)
		});
	}
}
