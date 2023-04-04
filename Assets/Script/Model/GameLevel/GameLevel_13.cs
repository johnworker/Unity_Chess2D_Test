using System.Collections.Generic;
using UnityEngine;

public class GameLevel_13 : Level
{
	public GameLevel_13()
	{
		m_Name = "第13篇: 影子";
		m_Task = "保护奈尔,全歼敌人";
		m_Map = new Map(24, 24, new byte[576]
		{
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 3, 3, 3, 3, 3, 0, 0, 3,
			3, 3, 3, 3, 4, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 3, 3, 3, 3, 3, 0,
			0, 2, 0, 0, 3, 3, 3, 3, 4, 4,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 3,
			3, 3, 0, 0, 0, 0, 0, 0, 0, 3,
			3, 3, 3, 4, 4, 2, 0, 1, 1, 1,
			1, 1, 1, 3, 3, 4, 0, 0, 2, 0,
			0, 0, 0, 3, 3, 3, 3, 3, 0, 0,
			2, 4, 0, 1, 1, 1, 1, 1, 3, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 3, 3,
			3, 3, 3, 0, 0, 0, 0, 1, 1, 1,
			1, 1, 1, 3, 0, 0, 0, 0, 0, 0,
			0, 0, 3, 3, 0, 3, 3, 0, 0, 1,
			1, 1, 1, 1, 1, 1, 1, 3, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 3, 0, 0,
			3, 0, 0, 0, 1, 1, 1, 1, 1, 1,
			1, 1, 3, 3, 0, 0, 0, 3, 0, 2,
			0, 3, 0, 0, 0, 0, 0, 0, 0, 0,
			1, 1, 1, 1, 1, 1, 1, 1, 3, 0,
			0, 0, 3, 3, 7, 7, 0, 0, 0, 3,
			0, 0, 0, 0, 0, 0, 0, 1, 1, 1,
			1, 1, 1, 1, 0, 0, 0, 3, 7, 7,
			7, 0, 0, 0, 0, 0, 0, 1, 0, 0,
			0, 0, 0, 1, 1, 1, 1, 3, 0, 0,
			0, 0, 7, 7, 7, 7, 0, 0, 0, 0,
			1, 1, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 1, 0, 0, 0, 0, 7, 7, 7,
			0, 0, 0, 2, 1, 1, 2, 0, 0, 0,
			0, 0, 2, 1, 1, 1, 1, 0, 0, 0,
			0, 2, 7, 7, 0, 0, 0, 1, 1, 1,
			1, 0, 0, 0, 0, 0, 0, 1, 1, 0,
			0, 0, 0, 0, 0, 0, 7, 3, 0, 0,
			0, 0, 1, 1, 1, 1, 2, 0, 0, 0,
			0, 1, 0, 0, 0, 0, 0, 0, 2, 0,
			7, 0, 0, 0, 0, 0, 0, 1, 1, 1,
			1, 2, 2, 1, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 2, 0, 0,
			0, 1, 1, 1, 1, 1, 1, 1, 0, 0,
			0, 0, 0, 0, 3, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 3, 3, 3, 3, 1, 1,
			1, 1, 1, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 2, 0, 3, 3, 3, 3,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			0, 0, 0, 0, 0, 0, 3, 0, 0, 0,
			0, 0, 3, 3, 3, 3, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 2, 0, 0, 0,
			3, 3, 0, 0, 0, 0, 0, 0, 4, 4,
			3, 1, 1, 1, 1, 1, 1, 1, 1, 2,
			2, 0, 0, 0, 3, 3, 3, 3, 3, 0,
			0, 0, 4, 3, 3, 3, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 2, 4, 4, 3, 3,
			3, 3, 3, 3, 3, 3, 3, 3, 3, 3,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 3, 3, 3, 3, 3, 3, 3, 3,
			3, 3, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1
		});
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(13, 14, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(9, 10, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(9, 12, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(11, 14, GameDataBase.Instance.GetActor(14), 3));
		m_FighterData.Add(4, new Fighter(11, 10, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(10, 13, GameDataBase.Instance.GetActor(12), 5));
		m_FighterData.Add(6, new Fighter(13, 12, GameDataBase.Instance.GetActor(13), 6));
		m_FighterData.Add(7, new Fighter(12, 11, GameDataBase.Instance.GetActor(16), 7));
		m_FighterData.Add(8, new Fighter(10, 11, GameDataBase.Instance.GetActor(15), 8));
		m_FighterData.Add(9, new Fighter(11, 12, GameDataBase.Instance.GetActor(0), 9));
		m_FighterData.Add(10, new Fighter(12, 13, GameDataBase.Instance.GetActor(7), 10));
		m_FighterEvent.Add(9, new GameEvent[1]
		{
			new GameEvent_GameOver()
		});
		m_CapitulateMap.Add(3, new Dictionary<int, GameEvent[]> { 
		{
			12,
			new GameEvent[38]
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(3),
				new GameEvent_Dialogue("这不是个孩子吗?", "希塔:", 33, Vector2.zero),
				new GameEvent_LookFighter(12),
				new GameEvent_Dialogue("大叔,你是谁?", "伊娃:", 39, Vector2.zero),
				new GameEvent_LookFighter(3),
				new GameEvent_Dialogue("大叔?混蛋!我有这么老吗!我叫希塔!记住了!", "希塔:", 33, Vector2.zero),
				new GameEvent_LookFighter(12),
				new GameEvent_Dialogue("是,希塔,和我一起玩行吗?我叫伊娃.", "伊娃:", 39, Vector2.zero),
				new GameEvent_LookFighter(3),
				new GameEvent_Dialogue("玩?开玩笑......", "希塔:", 33, Vector2.zero),
				new GameEvent_LookFighter(11),
				new GameEvent_Dialogue("伊娃!快收拾那家伙!", "芬妮:", 38, Vector2.zero),
				new GameEvent_LookFighter(12),
				new GameEvent_Dialogue("不!我要和他玩玩!大娘你别吵!", "伊娃:", 39, Vector2.zero),
				new GameEvent_LookFighter(11),
				new GameEvent_Dialogue("大娘......!心理被控制了吗?那是敌人!", "芬妮:", 38, Vector2.zero),
				new GameEvent_LookFighter(12),
				new GameEvent_Dialogue("不是敌人,是希塔.", "伊娃:", 39, Vector2.zero),
				new GameEvent_LookFighter(3),
				new GameEvent_Dialogue("你别听大娘的,想和我玩玩吗?伊娃.", "希塔:", 33, Vector2.zero),
				new GameEvent_LookFighter(12),
				new GameEvent_Dialogue("嗯!", "伊娃:", 39, Vector2.zero),
				new GameEvent_LookFighter(11),
				new GameEvent_Dialogue("伊娃!......没办法,让他打开自动驾驶系统.", "芬妮:", 38, Vector2.zero),
				new GameEvent_Dialogue("伊娃,你下来!", "芬妮:", 38, Vector2.zero),
				new GameEvent_LookFighter(12),
				new GameEvent_Dialogue("哎?怎么不动了?动!动!", "伊娃:", 39, Vector2.zero),
				new GameEvent_Dialogue("动了!......啊,不是那边!", "伊娃:", 39, Vector2.zero),
				new GameEvent_MoveTo(12, 18, 0),
				new GameEvent_SetAction(12, action: true),
				new GameEvent_LookFighter(12),
				new GameEvent_Dialogue("希塔!", "伊娃:", 39, Vector2.zero),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(12, -1),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_SetFlag("YiWa"),
				new GameEvent_MapUnlock()
			}
		} });
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("秀伯", Robot.EngineType.Land, 77, 67, 10, 2370, 206, 105, 151, new int[2] { 69, 94 });
		Robot robot2 = new Robot("吉伯II", Robot.EngineType.Land, 73, 67, 9, 630, 141, 98, 133, new int[2] { 69, 94 });
		Robot robot3 = new Robot("刚克", Robot.EngineType.Land, 72, 69, 8, 1110, 154, 90, 120, new int[2] { 99, 26 });
		Robot robot4 = new Robot("希卡", Robot.EngineType.Land, 75, 66, 10, 650, 178, 88, 131, new int[2] { 65, 95 });
		Robot robot5 = new Robot("格尔", Robot.EngineType.Sky, 76, 68, 10, 410, 113, 82, 90, new int[1] { 96 }, new Define.UserTrait[1] { Define.UserTrait.MinZhongGanRao });
		Robot robot6 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 300, 87, 62, 92, new int[2] { 25, 26 });
		Robot robot7 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 300, 87, 62, 92, new int[2] { 25, 26 });
		Robot robot8 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 560, 125, 74, 106, new int[2] { 73, 71 });
		Robot robot9 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 560, 125, 74, 106, new int[2] { 73, 71 });
		Robot robot10 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 560, 125, 74, 106, new int[2] { 73, 71 });
		Robot robot11 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 560, 125, 74, 106, new int[2] { 73, 71 });
		Robot robot12 = new Robot("帕拉", Robot.EngineType.Land, 74, 70, 8, 710, 183, 70, 105, new int[2] { 97, 98 });
		Robot robot13 = new Robot("帕拉", Robot.EngineType.Land, 74, 70, 8, 840, 216, 75, 139, new int[2] { 97, 98 });
		Robot robot14 = new Robot("帕拉", Robot.EngineType.Land, 74, 70, 7, 640, 174, 67, 107, new int[2] { 97, 98 });
		Robot robot15 = new Robot("科顿", Robot.EngineType.Land, 79, 71, 5, 950, 128, 109, 93, new int[2] { 57, 64 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot16 = new Robot("科顿", Robot.EngineType.Land, 79, 71, 5, 950, 128, 109, 93, new int[2] { 57, 64 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot17 = new Robot("科顿", Robot.EngineType.Land, 79, 71, 5, 950, 128, 109, 93, new int[2] { 57, 64 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot18 = new Robot("切克", Robot.EngineType.Land, 20, 18, 6, 630, 105, 65, 75, new int[2] { 30, 31 });
		Robot robot19 = new Robot("切克", Robot.EngineType.Land, 20, 18, 6, 630, 105, 65, 75, new int[2] { 30, 31 });
		Robot robot20 = new Robot("切克", Robot.EngineType.Land, 20, 18, 6, 630, 105, 65, 75, new int[2] { 30, 31 });
		Robot robot21 = new Robot("拉比", Robot.EngineType.Land, 81, 72, 10, 2370, 206, 105, 151, new int[2] { 69, 71 });
		User user = new User("士兵", 6, null);
		User user2 = new User("保罗", 12, null);
		User user3 = new User("马休", 20, null);
		User user4 = new User("芬妮", 38, null);
		User user5 = new User("伊娃", 39, null);
		User user6 = new User("萨拉", 42, null);
		User user7 = new User("洛克", 41, null);
		User user8 = new User("梅尔", 40, null);
		m_FighterData.Add(11, new Fighter(18, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot)
		}, Define.AIType.Patrol, 38, 0, 155, 100), 11));
		m_FighterData.Add(12, new Fighter(18, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user5, robot2)
		}, Define.AIType.Attack, 26, 0, 100, 100), 12));
		m_FighterData.Add(13, new Fighter(17, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot4)
		}, Define.AIType.Patrol, 29, 0, 125, 100), 13));
		m_FighterData.Add(14, new Fighter(2, 18, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot3)
		}, Define.AIType.Attack, 29, 0, 125, 100), 14));
		m_FighterData.Add(15, new Fighter(0, 18, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user8, robot12)
		}, Define.AIType.Patrol, 23, 0, 150, 100), 15));
		m_FighterData.Add(16, new Fighter(1, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user7, robot13)
		}, Define.AIType.Patrol, 36, 0, 150, 100), 16));
		m_FighterData.Add(17, new Fighter(2, 20, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user6, robot14)
		}, Define.AIType.Patrol, 21, 0, 150, 100), 17));
		m_FighterData.Add(18, new Fighter(19, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Attack, 23, 0, 110, 100), 18));
		m_FighterData.Add(19, new Fighter(18, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Attack, 23, 0, 110, 100), 19));
		m_FighterData.Add(20, new Fighter(18, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot10)
		}, Define.AIType.Attack, 23, 0, 110, 100), 20));
		m_FighterData.Add(21, new Fighter(17, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot11)
		}, Define.AIType.Attack, 23, 0, 110, 100), 21));
		m_FighterData.Add(22, new Fighter(1, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Attack, 19, 0, 90, 100), 22));
		m_FighterData.Add(23, new Fighter(1, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Attack, 19, 0, 90, 100), 23));
		m_FighterData.Add(24, new Fighter(0, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot5)
		}, Define.AIType.Attack, 24, 0, 110, 100), 24));
		m_FighterData.Add(25, new Fighter(20, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot15)
		}, Define.AIType.Attack, 24, 0, 120, 100), 25));
		m_FighterData.Add(26, new Fighter(20, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot16)
		}, Define.AIType.Attack, 24, 0, 120, 100), 26));
		m_FighterData.Add(27, new Fighter(21, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot17)
		}, Define.AIType.Attack, 24, 0, 120, 100), 27));
		m_FighterData.Add(28, new Fighter(4, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot18)
		}, Define.AIType.Attack, 24, 0, 140, 100), 28));
		m_FighterData.Add(29, new Fighter(5, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot19)
		}, Define.AIType.Attack, 24, 0, 140, 100), 29));
		m_FighterData.Add(30, new Fighter(6, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot20)
		}, Define.AIType.Attack, 24, 0, 140, 100), 30));
		m_FighterData.Add(31, new Fighter(22, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot3)
		}, Define.AIType.Attack, 29, 0, 125, 100), 31));
		m_FighterData.Add(32, new Fighter(23, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot21)
		}, Define.AIType.Attack, 29, 0, 125, 100), 32));
		m_FighterData.Add(33, new Fighter(23, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot21)
		}, Define.AIType.Attack, 29, 0, 125, 100), 33));
	}

	private void LoadEventData()
	{
		m_GameEvent.Add(-1, new GameEvent[57]
		{
			new GameEvent_MapLock(),
			new GameEvent_PlayBGM(4),
			new GameEvent_LookFighter(9),
			new GameEvent_Dialogue("好像将他们击退了,大家回阿格马去!", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("进入发射准备!", "乔:", 0, Vector2.zero),
			new GameEvent_LookFighter(0),
			new GameEvent_Dialogue("明白.", "大卫:", 4, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(0, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("明白.", "加代:", 3, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(2, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("是.", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("啊!", "欧文:", 10, Vector2.zero),
			new GameEvent_Dialogue("同意!", "路易:", 9, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(1, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(4),
			new GameEvent_Dialogue("明白了.", "卡姆:", 7, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(4, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(3),
			new GameEvent_Dialogue("知道啦.", "希塔:", 33, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(3, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("是.", "布克:", 15, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(10, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("明白了.", "马丁:", 30, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(6, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(5),
			new GameEvent_Dialogue("哎!", "布西:", 32, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(5, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(7),
			new GameEvent_Dialogue("行!", "安东:", 27, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(7, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_GetFlag("SaMi", new List<GameEvent>
			{
				new GameEvent_PlayME(3),
				new GameEvent_AddFighter(32),
				new GameEvent_LookFighter(32),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_AddFighter(33),
				new GameEvent_LookFighter(33),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_AddFighter(31),
				new GameEvent_LookFighter(31),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Dialogue("我是不会轻易逃走的!", "保罗:", 12, Vector2.zero),
				new GameEvent_Dialogue("这次不能落后了,拼了!", "保罗:", 12, Vector2.zero),
				new GameEvent_LookFighter(9),
				new GameEvent_Dialogue("啊!完了!已经开始读秒了!", "乔:", 0, Vector2.zero),
				new GameEvent_LookFighter(8),
				new GameEvent_Dialogue("我拖住他们!大家快起飞!", "萨米:", 23, Vector2.zero),
				new GameEvent_LookFighter(9),
				new GameEvent_Dialogue("!!", "乔:", 0, Vector2.zero),
				new GameEvent_Dialogue("萨米!站住!", "卡姆:", 7, Vector2.zero),
				new GameEvent_Dialogue("卡姆!已经迟了,现在出去的话,发射之前就回不来了!", "乔:", 0, Vector2.zero),
				new GameEvent_Dialogue("那......萨米......萨米怎么办?", "卡姆:", 7, Vector2.zero),
				new GameEvent_Dialogue("刚才已经和凯文联络过了,他马上来救援.", "大卫:", 4, Vector2.zero),
				new GameEvent_Dialogue("萨米为让我们能进入宇宙,出生入死,我们能袖手旁观吗?", "大卫:", 4, Vector2.zero),
				new GameEvent_Dialogue("我们不能知恩不报!", "大卫:", 4, Vector2.zero),
				new GameEvent_Dialogue("明白了.", "卡姆:", 7, Vector2.zero),
				new GameEvent_Dialogue("倒计时!", "乔:", 0, Vector2.zero),
				new GameEvent_Dialogue("5", "乔:", 0, Vector2.zero),
				new GameEvent_Dialogue("4", "乔:", 0, Vector2.zero),
				new GameEvent_Dialogue("3", "乔:", 0, Vector2.zero),
				new GameEvent_Dialogue("2", "乔:", 0, Vector2.zero),
				new GameEvent_Dialogue("1", "乔:", 0, Vector2.zero),
				new GameEvent_Dialogue("发射!", "乔:", 0, Vector2.zero),
				new GameEvent_Dialogue("哎呦......", "卡姆:", 7, Vector2.zero)
			}, new List<GameEvent>()),
			new GameEvent_ChooseActor(9, new Actor.ActorData[1]
			{
				new Actor.ActorData(3, 35)
			}),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(13)
		});
		m_GameEvent.Add(0, new GameEvent[43]
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
			new GameEvent_GetFlag("SaMi", new List<GameEvent>
			{
				new GameEvent_AddFighter(8)
			}, new List<GameEvent>()),
			new GameEvent_AddFighter(9),
			new GameEvent_AddFighter(10),
			new GameEvent_ChooseActor(9, new Actor.ActorData[1]
			{
				new Actor.ActorData(3, 57)
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
			new GameEvent_LookFighter(11),
			new GameEvent_Dialogue("好了吗!瞄准阿格马,只要破坏了阿格马,他们就完了!", "芬妮:", 38, Vector2.zero),
			new GameEvent_Dialogue("伊娃!给他们点厉害看看!", "芬妮:", 38, Vector2.zero),
			new GameEvent_Dialogue("是!阁下!", "伊娃:", 39, Vector2.zero),
			new GameEvent_LookFighter(3),
			new GameEvent_Dialogue("谁再叫我?", "希塔:", 33, Vector2.zero),
			new GameEvent_Dialogue("我也听到了......卡姆!", "大卫:", 4, Vector2.zero),
			new GameEvent_Dialogue("大卫,我也听到了,希塔,你呢?", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("嗯......好像有人在叫我,到底怎么回事?", "希塔:", 33, Vector2.zero),
			new GameEvent_Dialogue("好像是同步调节希塔的波长......", "大卫:", 4, Vector2.zero),
			new GameEvent_LookFighter(12),
			new GameEvent_Dialogue("我感觉不对.", "伊娃:", 39, Vector2.zero),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(1, new GameEvent[1]
		{
			new GameEvent_HasFighter(14, new List<GameEvent>
			{
				new GameEvent_LookFighter(14),
				new GameEvent_Dialogue("卡姆,你在那里吗!", "保罗:", 12, Vector2.zero)
			}, new List<GameEvent>())
		});
		m_GameEvent.Add(2, new GameEvent[42]
		{
			new GameEvent_LookFighter(11),
			new GameEvent_Dialogue("怎么啦!洛克!快点!", "芬妮:", 38, Vector2.zero),
			new GameEvent_LookFighter(16),
			new GameEvent_Dialogue("我改变主意,不干了.", "洛克:", 41, Vector2.zero),
			new GameEvent_LookFighter(11),
			new GameEvent_Dialogue("你发昏了,洛克?", "芬妮:", 38, Vector2.zero),
			new GameEvent_LookFighter(16),
			new GameEvent_Dialogue("怎么办?", "洛克:", 41, Vector2.zero),
			new GameEvent_LookFighter(14),
			new GameEvent_Dialogue("洛克,一起干吧!他们是有缺陷的!", "保罗:", 12, Vector2.zero),
			new GameEvent_LookFighter(16),
			new GameEvent_Dialogue("萨拉!梅尔!撤退!", "洛克:", 41, Vector2.zero),
			new GameEvent_LookFighter(15),
			new GameEvent_Dialogue("知道了!", "梅尔:", 40, Vector2.zero),
			new GameEvent_LookFighter(17),
			new GameEvent_Dialogue("是,洛克.", "萨拉:", 42, Vector2.zero),
			new GameEvent_LookFighter(15),
			new GameEvent_MoveTo(15, 0, 20),
			new GameEvent_SetAction(15, action: true),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(15, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(16),
			new GameEvent_MoveTo(16, 0, 20),
			new GameEvent_SetAction(16, action: true),
			new GameEvent_Dialogue("那么,让我来欣赏战斗场面吧.", "洛克:", 41, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(16, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(17),
			new GameEvent_MoveTo(17, 0, 20),
			new GameEvent_SetAction(17, action: true),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(17, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(11),
			new GameEvent_Dialogue("洛克之流从开始就靠不住,滚!我掐死你!", "芬妮:", 38, Vector2.zero),
			new GameEvent_LookFighter(13),
			new GameEvent_Dialogue("芬妮......都交给我吧.", "马修:", 20, Vector2.zero),
			new GameEvent_Dialogue("你看吧,我一定打败敌人.", "马修:", 20, Vector2.zero),
			new GameEvent_LookFighter(9),
			new GameEvent_Dialogue("敌人动向如何?", "乔:", 0, Vector2.zero)
		});
		m_GameEvent.Add(3, new GameEvent[2]
		{
			new GameEvent_HasFighter(14, new List<GameEvent>
			{
				new GameEvent_LookFighter(14),
				new GameEvent_Dialogue("从前的恩怨,就此了结吧!", "保罗:", 12, Vector2.zero),
				new GameEvent_LookFighter(4),
				new GameEvent_Dialogue("干什么呐!", "卡姆:", 7, Vector2.zero),
				new GameEvent_LookFighter(14),
				new GameEvent_Dialogue("住口!我不会放过你的!", "保罗:", 12, Vector2.zero)
			}, new List<GameEvent>()),
			new GameEvent_HasFighter(13, new List<GameEvent>
			{
				new GameEvent_LookFighter(13),
				new GameEvent_Dialogue("赛洛到了!", "马修:", 20, Vector2.zero),
				new GameEvent_ChooseAI(13, Define.AIType.Attack)
			}, new List<GameEvent>())
		});
		m_GameEvent.Add(5, new GameEvent[19]
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
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(28),
			new GameEvent_LookFighter(28),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(29),
			new GameEvent_LookFighter(29),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(30),
			new GameEvent_LookFighter(30),
			new GameEvent_WaitTime(0.5f)
		});
	}
}
