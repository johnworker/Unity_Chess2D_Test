using UnityEngine;

public class GameLevel_15 : Level
{
	public GameLevel_15()
	{
		m_Name = "第15篇: 激战";
		m_Task = "全歼敌人即胜利!";
		m_Map = new Map(25, 32, new byte[800]
		{
			23, 23, 23, 23, 23, 23, 23, 23, 23, 23,
			23, 24, 24, 24, 23, 23, 23, 23, 23, 23,
			23, 23, 23, 23, 23, 23, 23, 23, 23, 23,
			23, 23, 23, 23, 23, 24, 21, 21, 21, 24,
			23, 23, 23, 23, 23, 23, 23, 23, 23, 23,
			23, 23, 23, 23, 23, 23, 23, 23, 23, 24,
			21, 20, 20, 20, 21, 24, 23, 23, 23, 23,
			23, 23, 23, 23, 23, 23, 23, 23, 23, 23,
			23, 23, 23, 24, 21, 20, 20, 20, 20, 20,
			21, 24, 23, 23, 23, 23, 23, 23, 23, 23,
			23, 23, 24, 24, 24, 24, 24, 23, 21, 20,
			20, 20, 20, 20, 20, 20, 21, 23, 24, 24,
			24, 24, 24, 23, 23, 23, 23, 21, 21, 21,
			21, 21, 24, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 24, 21, 21, 21, 21, 21, 23, 23,
			23, 23, 20, 20, 20, 20, 20, 21, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 21, 20, 20,
			20, 20, 20, 23, 23, 23, 23, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 23, 23,
			23, 23, 20, 20, 20, 23, 23, 23, 24, 24,
			23, 24, 24, 24, 23, 24, 24, 23, 23, 23,
			20, 20, 20, 23, 23, 23, 23, 20, 20, 20,
			23, 23, 24, 21, 21, 24, 21, 21, 21, 24,
			21, 21, 24, 23, 23, 20, 20, 20, 23, 23,
			23, 23, 20, 20, 20, 23, 24, 21, 20, 20,
			21, 20, 20, 20, 21, 20, 20, 21, 24, 23,
			20, 20, 20, 23, 23, 23, 23, 20, 20, 20,
			23, 21, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 21, 23, 20, 20, 20, 23, 23,
			23, 23, 20, 20, 20, 24, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 24,
			20, 20, 20, 23, 23, 23, 24, 20, 20, 20,
			21, 20, 23, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 23, 20, 21, 20, 20, 20, 24, 23,
			23, 21, 20, 20, 20, 20, 20, 24, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 24, 20, 20,
			20, 20, 20, 21, 23, 23, 20, 20, 20, 20,
			20, 20, 21, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 21, 20, 20, 20, 20, 20, 20, 23,
			23, 20, 20, 20, 20, 23, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 23,
			20, 20, 20, 20, 23, 23, 20, 20, 20, 20,
			23, 23, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 23, 23, 20, 20, 20, 20, 23,
			23, 23, 20, 20, 20, 24, 24, 24, 24, 23,
			20, 20, 20, 20, 20, 23, 24, 24, 24, 24,
			20, 20, 20, 23, 23, 23, 23, 23, 20, 20,
			21, 21, 21, 21, 24, 23, 20, 20, 20, 23,
			24, 21, 21, 21, 21, 20, 20, 23, 23, 23,
			23, 23, 23, 23, 20, 20, 20, 20, 20, 20,
			23, 20, 20, 20, 23, 21, 20, 20, 20, 20,
			20, 23, 23, 23, 23, 23, 23, 23, 23, 23,
			20, 20, 20, 20, 20, 23, 20, 20, 20, 23,
			20, 20, 20, 20, 20, 23, 23, 23, 23, 23,
			23, 24, 24, 24, 24, 24, 24, 23, 20, 20,
			23, 20, 20, 20, 23, 20, 20, 23, 24, 24,
			24, 24, 24, 24, 23, 23, 21, 21, 21, 21,
			21, 21, 23, 20, 20, 23, 20, 20, 20, 23,
			20, 20, 23, 21, 21, 21, 21, 21, 21, 23,
			23, 20, 20, 20, 20, 20, 20, 23, 20, 20,
			23, 20, 20, 20, 23, 20, 20, 23, 20, 20,
			20, 20, 20, 20, 23, 23, 20, 20, 24, 24,
			24, 24, 24, 20, 20, 24, 20, 20, 20, 24,
			24, 24, 24, 20, 20, 20, 20, 20, 23, 23,
			23, 20, 20, 21, 21, 21, 21, 21, 20, 20,
			21, 20, 20, 20, 21, 21, 21, 21, 20, 20,
			20, 20, 23, 23, 23, 23, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 23, 23, 23, 23,
			23, 20, 20, 24, 24, 24, 24, 23, 20, 20,
			23, 20, 20, 20, 23, 20, 20, 20, 20, 20,
			23, 23, 23, 23, 23, 23, 20, 20, 21, 21,
			21, 21, 23, 20, 20, 23, 20, 20, 20, 23,
			20, 20, 20, 20, 23, 23, 23, 23, 23, 23,
			23, 20, 20, 20, 20, 20, 20, 23, 20, 20,
			23, 20, 20, 20, 23, 20, 20, 20, 23, 23,
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
		m_FighterData.Add(0, new Fighter(13, 16, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(10, 17, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(12, 17, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(11, 16, GameDataBase.Instance.GetActor(14), 3));
		m_FighterData.Add(4, new Fighter(12, 14, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(13, 18, GameDataBase.Instance.GetActor(13), 5));
		m_FighterData.Add(6, new Fighter(12, 20, GameDataBase.Instance.GetActor(16), 6));
		m_FighterData.Add(7, new Fighter(14, 17, GameDataBase.Instance.GetActor(9), 7));
		m_FighterData.Add(8, new Fighter(11, 18, GameDataBase.Instance.GetActor(7), 8));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("刚达II", Robot.EngineType.Land, 84, 73, 4, 950, 180, 123, 93, new int[2] { 97, 100 });
		Robot robot2 = new Robot("盖马", Robot.EngineType.Land, 87, 77, 6, 1170, 148, 83, 114, new int[2] { 65, 104 });
		Robot robot3 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 310, 90, 65, 95, new int[2] { 25, 26 });
		Robot robot4 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 310, 90, 65, 95, new int[2] { 25, 26 });
		Robot robot5 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 580, 130, 79, 111, new int[2] { 73, 71 });
		Robot robot6 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 580, 130, 79, 111, new int[2] { 73, 71 });
		Robot robot7 = new Robot("刚克", Robot.EngineType.Land, 72, 69, 8, 1150, 162, 96, 126, new int[2] { 99, 26 });
		Robot robot8 = new Robot("刚克", Robot.EngineType.Land, 72, 69, 8, 1030, 154, 98, 136, new int[2] { 99, 26 });
		Robot robot9 = new Robot("刚克", Robot.EngineType.Land, 72, 69, 8, 930, 128, 78, 108, new int[2] { 99, 26 });
		Robot robot10 = new Robot("刚克", Robot.EngineType.Land, 72, 69, 8, 930, 128, 78, 108, new int[2] { 99, 26 });
		Robot robot11 = new Robot("刚克", Robot.EngineType.Land, 72, 69, 8, 930, 128, 78, 108, new int[2] { 99, 26 });
		Robot robot12 = new Robot("帕拉", Robot.EngineType.Land, 74, 70, 8, 800, 206, 91, 131, new int[2] { 97, 98 });
		Robot robot13 = new Robot("帕拉", Robot.EngineType.Land, 74, 70, 8, 890, 226, 102, 146, new int[2] { 97, 98 });
		Robot robot14 = new Robot("帕拉", Robot.EngineType.Land, 74, 70, 7, 850, 211, 91, 126, new int[2] { 97, 98 });
		Robot robot15 = new Robot("加姆", Robot.EngineType.Sky, 86, 75, 10, 370, 136, 66, 116, new int[1] { 101 });
		Robot robot16 = new Robot("加姆", Robot.EngineType.Sky, 86, 75, 10, 370, 136, 66, 116, new int[1] { 101 });
		Robot robot17 = new Robot("加姆", Robot.EngineType.Sky, 86, 75, 10, 370, 136, 66, 116, new int[1] { 101 });
		Robot robot18 = new Robot("加姆", Robot.EngineType.Sky, 86, 75, 10, 370, 136, 66, 116, new int[1] { 101 });
		User user = new User("士兵", 6, null);
		User user2 = new User("萨拉", 42, null);
		User user3 = new User("洛克", 41, null);
		User user4 = new User("梅尔", 40, null);
		User user5 = new User("保罗", 12, null);
		User user6 = new User("米亚", 44, null);
		User user7 = new User("芬奇", 46, null);
		m_FighterData.Add(9, new Fighter(11, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot12)
		}, Define.AIType.Counter, 37, 0, 150, 100), 9));
		m_FighterData.Add(10, new Fighter(12, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot13)
		}, Define.AIType.Counter, 41, 0, 150, 100), 10));
		m_FighterData.Add(11, new Fighter(13, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot14)
		}, Define.AIType.Counter, 37, 0, 150, 100), 11));
		m_FighterData.Add(12, new Fighter(15, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot2)
		}, Define.AIType.Attack, 26, 0, 130, 100), 12));
		m_FighterData.Add(13, new Fighter(12, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user6, robot)
		}, Define.AIType.Attack, 31, 0, 190, 100), 13));
		m_FighterData.Add(14, new Fighter(8, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot15)
		}, Define.AIType.Attack, 26, 0, 135, 100), 14));
		m_FighterData.Add(15, new Fighter(9, 20, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot16)
		}, Define.AIType.Attack, 26, 0, 135, 100), 15));
		m_FighterData.Add(16, new Fighter(15, 20, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot17)
		}, Define.AIType.Attack, 26, 0, 135, 100), 16));
		m_FighterData.Add(17, new Fighter(16, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot18)
		}, Define.AIType.Attack, 26, 0, 135, 100), 17));
		m_FighterData.Add(18, new Fighter(19, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot3)
		}, Define.AIType.Attack, 21, 0, 90, 100), 18));
		m_FighterData.Add(19, new Fighter(19, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot4)
		}, Define.AIType.Attack, 21, 0, 90, 100), 19));
		m_FighterData.Add(20, new Fighter(5, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot5)
		}, Define.AIType.Attack, 26, 0, 110, 100), 20));
		m_FighterData.Add(21, new Fighter(5, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Attack, 26, 0, 110, 100), 21));
		m_FighterData.Add(22, new Fighter(20, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user5, robot7)
		}, Define.AIType.Attack, 33, 0, 125, 100), 22));
		m_FighterData.Add(23, new Fighter(21, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user7, robot8)
		}, Define.AIType.Attack, 33, 0, 125, 100), 23));
		m_FighterData.Add(24, new Fighter(11, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Attack, 29, 0, 125, 100), 24));
		m_FighterData.Add(25, new Fighter(12, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot10)
		}, Define.AIType.Attack, 29, 0, 125, 100), 25));
		m_FighterData.Add(26, new Fighter(13, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot11)
		}, Define.AIType.Attack, 29, 0, 125, 100), 26));
		m_FighterEvent.Add(10, new GameEvent[8]
		{
			new GameEvent_MapLock(),
			new GameEvent_Dialogue("好厉害,我来耍耍他们.", "洛克:", 41, Vector2.zero),
			new GameEvent_Dialogue("诸位的基地正被激光盘扫描,再不出手,可要后悔啦.", "洛克:", 41, Vector2.zero),
			new GameEvent_Dialogue("激光盘在K6上空,加油干吧.", "洛克:", 41, Vector2.zero),
			new GameEvent_Dialogue("激光盘!那是真的?", "大卫:", 4, Vector2.zero),
			new GameEvent_Dialogue("自己去看吧,再会.", "洛克:", 41, Vector2.zero),
			new GameEvent_Dialogue("等一下!喂!走掉了......", "加代:", 3, Vector2.zero),
			new GameEvent_MapUnlock()
		});
	}

	private void LoadEventData()
	{
		m_GameEvent.Add(-1, new GameEvent[14]
		{
			new GameEvent_MapLock(),
			new GameEvent_PlayBGM(4),
			new GameEvent_Dialogue("洛克说的是真的吗?", "大卫:", 4, Vector2.zero),
			new GameEvent_Dialogue("好像不是假的,那小子好像在利用我们.", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("利用......什么意思?", "路易:", 9, Vector2.zero),
			new GameEvent_Dialogue("那家伙想让我们正面牵制DC,他好攻下DC", "欧文:", 10, Vector2.zero),
			new GameEvent_Dialogue("那么我们拼掉DC那家伙不是占便宜了吗.", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("怎么,生气了.", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("虽然这么说,也不能不同DC战斗呀.", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("总之,先回阿格马.", "马丁:", 30, Vector2.zero),
			new GameEvent_Dialogue("要好好想想今后的对策.", "马丁:", 30, Vector2.zero),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(15)
		});
		m_GameEvent.Add(0, new GameEvent[55]
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
			new GameEvent_AddFighter(22),
			new GameEvent_AddFighter(23),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("欢迎各位到托利斯来,我是洛克.", "洛克:", 41, Vector2.zero),
			new GameEvent_Dialogue("DC的宇宙军司令.", "洛克:", 41, Vector2.zero),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("你!别过来!", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("别慌,我有话和你们讲.", "洛克:", 41, Vector2.zero),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("你想说话,我们就该听吗?", "欧文:", 10, Vector2.zero),
			new GameEvent_Dialogue("我么可不想袒护你所干的坏事!", "龙:", 5, Vector2.zero),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("我也是DC的一员......", "洛克:", 41, Vector2.zero),
			new GameEvent_Dialogue("不是我请你们来,而是我的一位战友请的.", "洛克:", 41, Vector2.zero),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("什么?", "路易:", 9, Vector2.zero),
			new GameEvent_LookFighter(5),
			new GameEvent_Dialogue("总之,是你要谋反,还想把我们也拉进去?", "马丁:", 30, Vector2.zero),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("用词要恰当,不是谋反,是创造新的未来.", "洛克:", 41, Vector2.zero),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("哼!话说的漂亮,做的还不都一样!", "龙:", 5, Vector2.zero),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("这词也可用来回答我的问题.", "洛克:", 41, Vector2.zero),
			new GameEvent_Dialogue("是么,那我就不客气了!", "洛克:", 41, Vector2.zero),
			new GameEvent_LookFighter(13),
			new GameEvent_Dialogue("你们是敌人!我们势不两立!", "米亚:", 44, Vector2.zero),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(4, new GameEvent[10]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(24),
			new GameEvent_LookFighter(24),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(25),
			new GameEvent_LookFighter(25),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(26),
			new GameEvent_LookFighter(26),
			new GameEvent_WaitTime(0.5f)
		});
	}
}
