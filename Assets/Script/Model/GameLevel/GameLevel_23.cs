using System.Collections.Generic;
using UnityEngine;

public class GameLevel_23 : Level
{
	public GameLevel_23()
	{
		m_Name = "第23篇: 反击";
		m_Task = "打败基奥!";
		m_Map = new Map(28, 16, new byte[448]
		{
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 0, 0, 0, 3,
			3, 3, 3, 3, 3, 3, 3, 3, 7, 7,
			7, 7, 7, 7, 7, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 3,
			3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
			7, 7, 7, 0, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 0, 0, 0, 0, 4,
			3, 3, 3, 3, 3, 3, 3, 3, 3, 0,
			0, 0, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 0, 0, 0, 0, 4,
			3, 3, 3, 3, 0, 9, 0, 3, 3, 0,
			0, 0, 7, 7, 7, 7, 7, 7, 7, 7,
			0, 0, 0, 0, 0, 0, 0, 0, 4, 3,
			0, 0, 0, 0, 2, 0, 0, 0, 0, 0,
			0, 0, 0, 7, 7, 7, 7, 7, 7, 0,
			2, 0, 0, 0, 0, 0, 0, 3, 0, 0,
			0, 0, 3, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 7, 7, 7, 7, 0, 0, 0, 0,
			0, 0, 0, 9, 0, 3, 3, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			7, 7, 7, 7, 0, 0, 0, 3, 3, 0,
			0, 0, 0, 0, 0, 0, 3, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 7, 7,
			7, 7, 0, 3, 3, 3, 0, 0, 0, 0,
			1, 1, 0, 0, 0, 0, 0, 0, 4, 3,
			0, 0, 3, 0, 0, 7, 7, 7, 7, 0,
			0, 0, 3, 0, 1, 1, 0, 1, 1, 0,
			0, 0, 3, 3, 3, 3, 3, 0, 8, 0,
			0, 0, 0, 7, 7, 0, 0, 0, 0, 0,
			1, 1, 1, 1, 1, 1, 0, 0, 0, 3,
			3, 3, 4, 0, 0, 3, 3, 3, 0, 0,
			7, 7, 0, 0, 0, 0, 0, 1, 1, 1,
			1, 0, 0, 3, 3, 3, 3, 3, 3, 3,
			7, 7, 7, 7, 7, 3, 3, 7, 7, 0,
			0, 0, 0, 0, 0, 0, 1, 1, 1, 1,
			0, 3, 3, 0, 3, 3, 3, 3, 3, 7,
			7, 7, 3, 3, 0, 7, 0, 0, 0, 0,
			0, 0, 0, 1, 1, 1, 1, 1, 0, 0,
			4, 3, 3, 3, 3, 3, 7, 7, 7, 3,
			3, 0, 0, 7, 0, 0, 0, 0, 0, 1,
			1, 1, 1, 1, 1, 0, 3, 0, 0, 0,
			3, 3, 3, 3, 3, 3, 4, 0, 3, 0,
			0, 7, 0, 0, 0, 1, 1, 1, 1, 1,
			1, 1, 0, 0, 0, 0, 0, 4
		});
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		AddShopEvent(new Define.Point(3, 4), new List<int> { 0, 1, 2, 3, 4, 5, 7, 8 });
		m_Hospital.Add(new Define.Point(8, 10));
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(12, 6, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(11, 6, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(12, 7, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(9, 8, GameDataBase.Instance.GetActor(14), 3));
		m_FighterData.Add(4, new Fighter(10, 7, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(9, 9, GameDataBase.Instance.GetActor(13), 5));
		m_FighterData.Add(6, new Fighter(11, 10, GameDataBase.Instance.GetActor(16), 6));
		m_FighterData.Add(7, new Fighter(10, 9, GameDataBase.Instance.GetActor(9), 7));
		m_FighterData.Add(8, new Fighter(11, 8, GameDataBase.Instance.GetActor(7), 8));
		m_FighterData.Add(9, new Fighter(12, 8, GameDataBase.Instance.GetActor(0), 9));
		m_FighterData.Add(10, new Fighter(8, 7, GameDataBase.Instance.GetActor(17), 10));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("基奥", Robot.EngineType.Land, 104, 90, 11, 2610, 275, 160, 202, new int[2] { 134, 135 }, new Define.UserTrait[2]
		{
			Define.UserTrait.JianJieWuXiao,
			Define.UserTrait.JiShaZaiDong
		});
		Robot robot2 = new Robot("帕拉", Robot.EngineType.Land, 74, 70, 8, 870, 215, 94, 129, new int[2] { 97, 98 });
		Robot robot3 = new Robot("麦萨拉", Robot.EngineType.Land, 99, 87, 5, 1420, 154, 109, 131, new int[2] { 105, 65 });
		Robot robot4 = new Robot("亚克托", Robot.EngineType.Land, 88, 78, 10, 1290, 195, 116, 127, new int[2] { 103, 108 });
		Robot robot5 = new Robot("亚克托", Robot.EngineType.Land, 88, 78, 10, 1290, 195, 116, 127, new int[2] { 103, 108 });
		Robot robot6 = new Robot("亚克托", Robot.EngineType.Land, 88, 78, 10, 1290, 195, 116, 127, new int[2] { 103, 108 });
		Robot robot7 = new Robot("基格", Robot.EngineType.Land, 92, 80, 7, 470, 139, 93, 125, new int[2] { 106, 107 });
		Robot robot8 = new Robot("基格", Robot.EngineType.Land, 92, 80, 7, 470, 139, 93, 125, new int[2] { 106, 107 });
		Robot robot9 = new Robot("基格", Robot.EngineType.Land, 92, 80, 7, 470, 139, 93, 125, new int[2] { 106, 107 });
		Robot robot10 = new Robot("炮台", Robot.EngineType.Land, 39, 34, 0, 410, 161, 71, 81, new int[1] { 50 });
		Robot robot11 = new Robot("炮台", Robot.EngineType.Land, 39, 34, 0, 410, 161, 71, 81, new int[1] { 50 });
		Robot robot12 = new Robot("炮台", Robot.EngineType.Land, 39, 34, 0, 410, 161, 71, 81, new int[1] { 50 });
		Robot robot13 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 290, 10, 122, new int[1] { 57 });
		Robot robot14 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 290, 10, 122, new int[1] { 57 });
		Robot robot15 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 290, 10, 122, new int[1] { 57 });
		Robot robot16 = new Robot("布x1", Robot.EngineType.Land, 98, 86, 5, 930, 218, 101, 112, new int[2] { 110, 49 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot17 = new Robot("布x1", Robot.EngineType.Land, 98, 86, 5, 930, 218, 101, 112, new int[2] { 110, 49 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot18 = new Robot("古兰森", Robot.EngineType.Land, 102, 88, 8, 4020, 241, 237, 191, new int[2] { 132, 133 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot19 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 290, 10, 122, new int[1] { 57 });
		Robot robot20 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 290, 10, 122, new int[1] { 57 });
		Robot robot21 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 290, 10, 122, new int[1] { 57 });
		Robot robot22 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 290, 10, 122, new int[1] { 57 });
		Robot robot23 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 290, 10, 122, new int[1] { 57 });
		Robot robot24 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 290, 10, 122, new int[1] { 57 });
		Robot robot25 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 290, 10, 122, new int[1] { 57 });
		Robot robot26 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 290, 10, 122, new int[1] { 57 });
		User user = new User("士兵", 6, null);
		User user2 = new User("萨拉", 42, null);
		User user3 = new User("洛克", 41, null);
		User user4 = new User("梅尔", 40, null);
		User user5 = new User("休", 57, null);
		m_FighterData.Add(11, new Fighter(24, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot)
		}, Define.AIType.Attack, 41, 0, 250, 100), 11));
		m_FighterData.Add(12, new Fighter(23, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot2)
		}, Define.AIType.Attack, 39, 0, 150, 100), 12));
		m_FighterData.Add(13, new Fighter(23, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot3)
		}, Define.AIType.Attack, 38, 0, 150, 100), 13));
		m_FighterData.Add(14, new Fighter(20, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot4)
		}, Define.AIType.Attack, 35, 0, 150, 100), 14));
		m_FighterData.Add(15, new Fighter(19, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot5)
		}, Define.AIType.Attack, 35, 0, 150, 100), 15));
		m_FighterData.Add(16, new Fighter(20, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Attack, 35, 0, 150, 100), 16));
		m_FighterData.Add(17, new Fighter(18, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Attack, 35, 0, 110, 100), 17));
		m_FighterData.Add(18, new Fighter(17, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Attack, 35, 0, 110, 100), 18));
		m_FighterData.Add(19, new Fighter(18, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Attack, 35, 0, 110, 100), 19));
		m_FighterData.Add(20, new Fighter(12, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot13)
		}, Define.AIType.Attack, 35, 0, 25, 100), 20));
		m_FighterData.Add(21, new Fighter(13, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot14)
		}, Define.AIType.Attack, 35, 0, 25, 100), 21));
		m_FighterData.Add(22, new Fighter(14, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot15)
		}, Define.AIType.Attack, 35, 0, 25, 100), 22));
		m_FighterData.Add(23, new Fighter(1, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot16)
		}, Define.AIType.Attack, 36, 0, 190, 100), 23));
		m_FighterData.Add(24, new Fighter(2, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot17)
		}, Define.AIType.Attack, 36, 0, 190, 100), 24));
		m_FighterData.Add(25, new Fighter(13, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot10)
		}, Define.AIType.Attack, 35, 0, 100, 100), 25));
		m_FighterData.Add(26, new Fighter(14, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot11)
		}, Define.AIType.Attack, 35, 0, 100, 100), 26));
		m_FighterData.Add(27, new Fighter(15, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot12)
		}, Define.AIType.Attack, 35, 0, 100, 100), 27));
		m_FighterData.Add(28, new Fighter(23, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user5, robot18)
		}, Define.AIType.Attack, 45, 0, 400, 5000, 13), 28));
		m_FighterData.Add(29, new Fighter(21, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot19)
		}, Define.AIType.Attack, 35, 0, 25, 100), 29));
		m_FighterData.Add(30, new Fighter(22, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot20)
		}, Define.AIType.Attack, 35, 0, 25, 100), 30));
		m_FighterData.Add(31, new Fighter(21, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot21)
		}, Define.AIType.Attack, 35, 0, 25, 100), 31));
		m_FighterData.Add(32, new Fighter(22, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot22)
		}, Define.AIType.Attack, 35, 0, 25, 100), 32));
		m_FighterData.Add(33, new Fighter(21, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot23)
		}, Define.AIType.Attack, 35, 0, 25, 100), 33));
		m_FighterData.Add(34, new Fighter(22, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot24)
		}, Define.AIType.Attack, 35, 0, 25, 100), 34));
		m_FighterData.Add(35, new Fighter(21, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot25)
		}, Define.AIType.Attack, 35, 0, 25, 100), 35));
		m_FighterData.Add(36, new Fighter(22, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot26)
		}, Define.AIType.Attack, 35, 0, 25, 100), 36));
	}

	private void LoadEventData()
	{
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_MapLock());
		list.Add(new GameEvent_PlayBGM(4));
		list.Add(new GameEvent_Dialogue("什么!基奥为什么不动啦?喂喂喂!", "洛克:", 41, Vector2.zero));
		list.Add(new GameEvent_Dialogue("看来DC也不是纸糊的.", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("不管怎样,现在要乘胜追击!", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("乔舰长!凯文舰长紧急呼叫!", "发:", 21, Vector2.zero));
		list.Add(new GameEvent_Dialogue("对不起,本打算佯攻,却碰上了敌人的反攻.", "凯文:", 55, Vector2.zero));
		list.Add(new GameEvent_Dialogue("好不容易击退了.", "凯文:", 55, Vector2.zero));
		list.Add(new GameEvent_Dialogue("但我的部队已经支持不住了......", "凯文:", 55, Vector2.zero));
		list.Add(new GameEvent_GetFlag("SaMi", new List<GameEvent>
		{
			new GameEvent_Dialogue("萨米呢......她没事吧!?", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("她没事,刚打受了点损伤......", "凯文:", 55, Vector2.zero)
		}, new List<GameEvent>()));
		list.Add(new GameEvent_Dialogue("但是,那样敌人就都绕着我们转了......", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("好,全看你们的了!", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("我用拉姆去引诱敌人,给凯文舰长一个机会.", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("大家趁机攻入加布洛.", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("那太危险啦!", "大卫:", 4, Vector2.zero));
		list.Add(new GameEvent_Dialogue("这我知道,但这也是迫不得已.", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("明白了,一定要小心,乔.", "龙:", 5, Vector2.zero));
		list.Add(new GameEvent_Repair());
		list.Add(new GameEvent_MapUnlock());
		list.Add(new GameEvent_Victory(23));
		List<GameEvent> list2 = list;
		m_GameEvent.Add(-1, list2.ToArray());
		m_FighterEvent.Add(11, list2.ToArray());
		m_GameEvent.Add(0, new GameEvent[41]
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
			new GameEvent_ChooseActor(0, new Actor.ActorData[1]
			{
				new Actor.ActorData(5, 65)
			}),
			new GameEvent_ChooseActor(1, new Actor.ActorData[3]
			{
				new Actor.ActorData(0, 62),
				new Actor.ActorData(1, 63),
				new Actor.ActorData(2, 64)
			}),
			new GameEvent_ChooseActor(2, new Actor.ActorData[1]
			{
				new Actor.ActorData(7, 66)
			}),
			new GameEvent_ChooseActor(3, new Actor.ActorData[2]
			{
				new Actor.ActorData(15, 68),
				new Actor.ActorData(15, 69)
			}),
			new GameEvent_ChooseActor(4, new Actor.ActorData[2]
			{
				new Actor.ActorData(4, 60),
				new Actor.ActorData(4, 61)
			}),
			new GameEvent_ChooseActor(8, new Actor.ActorData[1]
			{
				new Actor.ActorData(9, 67)
			}),
			new GameEvent_ChooseActor(6, new Actor.ActorData[2]
			{
				new Actor.ActorData(17, 71),
				new Actor.ActorData(17, 73)
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
			new GameEvent_AddFighter(25),
			new GameEvent_AddFighter(26),
			new GameEvent_AddFighter(27),
			new GameEvent_LookFighter(9),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(5, new GameEvent[25]
		{
			new GameEvent_PlayBGM(9),
			new GameEvent_AddFighter(28),
			new GameEvent_LookFighter(28),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(11),
			new GameEvent_Dialogue("坎普......朗达,不要动手!", "洛克:", 41, Vector2.zero),
			new GameEvent_LookFighter(28),
			new GameEvent_Dialogue("洛克,你的政变计划失败了.", "休:", 57, Vector2.zero),
			new GameEvent_LookFighter(11),
			new GameEvent_Dialogue("什么?", "洛克:", 41, Vector2.zero),
			new GameEvent_LookFighter(28),
			new GameEvent_Dialogue("你的计划贝克司令全知道了.", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("你已经被赊销DC第二指挥官的职务.", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("挽回名誉的办法只有一个.", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("那就是把这些超级机器人全部干掉.", "休:", 57, Vector2.zero),
			new GameEvent_LookFighter(11),
			new GameEvent_Dialogue("哼!我在DC的地位已经无关紧要了.", "洛克:", 41, Vector2.zero),
			new GameEvent_Dialogue("贝克的瓦尔不是我基奥的对手!", "洛克:", 41, Vector2.zero),
			new GameEvent_Dialogue("请你转告司令,等我的好消息吧!", "洛克:", 41, Vector2.zero),
			new GameEvent_LookFighter(28),
			new GameEvent_Dialogue("好吧,我一定转告贝克司令.", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("那么祝你战斗胜利.", "休:", 57, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(28, -1),
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(7, new GameEvent[13]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(29),
			new GameEvent_LookFighter(29),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(30),
			new GameEvent_LookFighter(30),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(31),
			new GameEvent_LookFighter(31),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(32),
			new GameEvent_LookFighter(32),
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(8, new GameEvent[13]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(33),
			new GameEvent_LookFighter(33),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(34),
			new GameEvent_LookFighter(34),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(35),
			new GameEvent_LookFighter(35),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(36),
			new GameEvent_LookFighter(36),
			new GameEvent_WaitTime(0.5f)
		});
	}
}
