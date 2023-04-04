using System.Collections.Generic;
using UnityEngine;

public class GameLevel_14 : Level
{
	public GameLevel_14()
	{
		m_Name = "第14篇: 向着宇宙......";
		m_Task = "全歼敌人即胜利!";
		m_Map = new Map(22, 30, new byte[660]
		{
			30, 30, 31, 30, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			29, 28, 31, 30, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 30, 28, 28, 28, 29, 28,
			33, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			29, 28, 28, 28, 28, 28, 28, 31, 28, 28,
			28, 36, 37, 33, 28, 29, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 33, 34, 33, 38, 36, 33, 33, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 36, 33, 33, 28, 28,
			28, 28, 28, 28, 28, 31, 28, 28, 28, 28,
			28, 28, 28, 35, 28, 28, 28, 28, 33, 28,
			28, 28, 32, 32, 32, 32, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 30, 28, 28,
			30, 31, 28, 28, 28, 28, 32, 32, 32, 32,
			32, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 29, 28, 30, 30,
			28, 32, 32, 32, 32, 32, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 30,
			31, 28, 28, 28, 31, 32, 32, 32, 32, 32,
			28, 28, 28, 28, 28, 30, 28, 28, 28, 28,
			30, 30, 30, 28, 28, 28, 28, 28, 32, 32,
			32, 32, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 31, 30, 30, 30, 30, 28, 28, 28, 28,
			28, 28, 32, 32, 32, 32, 32, 32, 28, 28,
			28, 30, 30, 30, 31, 30, 28, 28, 28, 29,
			28, 28, 28, 28, 28, 28, 32, 32, 32, 32,
			32, 32, 28, 29, 31, 30, 30, 30, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 32, 32,
			32, 32, 32, 32, 32, 32, 32, 31, 30, 28,
			28, 30, 28, 28, 28, 28, 28, 28, 28, 28,
			32, 32, 32, 32, 32, 32, 32, 32, 32, 32,
			32, 32, 28, 28, 28, 30, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 32, 32, 32, 32,
			32, 32, 32, 32, 32, 32, 28, 28, 28, 28,
			29, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 32, 32, 32, 32, 32, 32, 32,
			28, 28, 28, 28, 28, 28, 28, 31, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 32,
			32, 32, 32, 32, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 31, 28,
			30, 30, 28, 28, 28, 28, 28, 28, 28, 31,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 30, 30, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 29, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 30, 31, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 35, 28, 28, 28,
			28, 28, 28, 28, 31, 28, 28, 28, 29, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 30, 30, 30, 28,
			28, 30, 30, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			30, 30, 30, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 31, 28, 28, 28, 28, 28, 35, 28,
			28, 28, 28, 28, 29, 28, 28, 28, 28, 28,
			29, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 31,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28
		});
		m_SelfBGM = 11;
		m_EnemyBGM = 10;
		AddShopEvent(new Define.Point(14, 27), new List<int> { 0, 1, 2, 3, 4, 5, 7, 8 });
		m_Hospital.Add(new Define.Point(6, 4));
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(10, 22, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(12, 22, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(11, 23, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(14, 24, GameDataBase.Instance.GetActor(14), 3));
		m_FighterData.Add(4, new Fighter(9, 24, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(8, 24, GameDataBase.Instance.GetActor(13), 5));
		m_FighterData.Add(6, new Fighter(12, 26, GameDataBase.Instance.GetActor(16), 6));
		m_FighterData.Add(7, new Fighter(10, 26, GameDataBase.Instance.GetActor(9), 7));
		m_FighterData.Add(8, new Fighter(11, 25, GameDataBase.Instance.GetActor(0), 8));
		m_FighterData.Add(9, new Fighter(13, 24, GameDataBase.Instance.GetActor(7), 9));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("拉比", Robot.EngineType.Land, 81, 72, 8, 615, 137, 111, 163, new int[2] { 69, 71 });
		Robot robot2 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 415, 130, 75, 125, new int[2] { 103, 71 });
		Robot robot3 = new Robot("加姆", Robot.EngineType.Sky, 86, 75, 10, 370, 136, 66, 116, new int[1] { 101 });
		Robot robot4 = new Robot("刚达II", Robot.EngineType.Land, 84, 73, 4, 950, 180, 123, 93, new int[2] { 97, 100 });
		Robot robot5 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 540, 122, 71, 103, new int[2] { 73, 71 });
		Robot robot6 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 540, 122, 71, 103, new int[2] { 73, 71 });
		Robot robot7 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 540, 122, 71, 103, new int[2] { 73, 71 });
		Robot robot8 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 540, 122, 71, 103, new int[2] { 73, 71 });
		Robot robot9 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 540, 122, 71, 103, new int[2] { 73, 71 });
		Robot robot10 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 540, 122, 71, 103, new int[2] { 73, 71 });
		Robot robot11 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 570, 127, 76, 108, new int[2] { 73, 71 });
		Robot robot12 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 570, 127, 76, 108, new int[2] { 73, 71 });
		Robot robot13 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 570, 127, 76, 108, new int[2] { 73, 71 });
		Robot robot14 = new Robot("扎克III", Robot.EngineType.Land, 82, 66, 10, 820, 230, 101, 157, new int[2] { 69, 102 });
		Robot robot15 = new Robot("扎克III", Robot.EngineType.Land, 82, 66, 8, 600, 156, 75, 109, new int[2] { 69, 102 });
		Robot robot16 = new Robot("扎克III", Robot.EngineType.Land, 82, 66, 8, 600, 156, 75, 109, new int[2] { 69, 102 });
		Robot robot17 = new Robot("扎克III", Robot.EngineType.Land, 82, 66, 8, 600, 156, 75, 109, new int[2] { 69, 102 });
		Robot robot18 = new Robot("扎克III", Robot.EngineType.Land, 82, 66, 8, 600, 156, 75, 109, new int[2] { 69, 102 });
		Robot robot19 = new Robot("扎克III", Robot.EngineType.Land, 82, 66, 8, 610, 158, 76, 110, new int[2] { 69, 102 });
		Robot robot20 = new Robot("扎克III", Robot.EngineType.Land, 82, 66, 8, 610, 158, 76, 110, new int[2] { 69, 102 });
		Robot robot21 = new Robot("扎克III", Robot.EngineType.Land, 82, 66, 8, 610, 158, 76, 110, new int[2] { 69, 102 });
		Robot robot22 = new Robot("雷克", Robot.EngineType.Sky, 31, 26, 7, 320, 81, 56, 106, new int[2] { 41, 14 });
		Robot robot23 = new Robot("雷克", Robot.EngineType.Sky, 31, 26, 7, 320, 81, 56, 106, new int[2] { 41, 14 });
		User user = new User("士兵", 6, null);
		User user2 = new User("诺恩", 43, null);
		User user3 = new User("米亚", 44, null);
		User user4 = new User("琼", 45, null);
		m_FighterData.Add(10, new Fighter(6, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot)
		}, Define.AIType.Counter, 36, 0, 100, 100), 10));
		m_FighterData.Add(11, new Fighter(13, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot2)
		}, Define.AIType.Attack, 24, 0, 140, 100), 11));
		m_FighterData.Add(12, new Fighter(21, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot3)
		}, Define.AIType.Attack, 25, 0, 135, 100), 12));
		m_FighterData.Add(13, new Fighter(10, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot4)
		}, Define.AIType.Attack, 36, 0, 190, 100), 13));
		m_FighterData.Add(14, new Fighter(13, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot5)
		}, Define.AIType.Attack, 21, 0, 110, 100), 14));
		m_FighterData.Add(15, new Fighter(12, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Attack, 21, 0, 110, 100), 15));
		m_FighterData.Add(16, new Fighter(13, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Attack, 21, 0, 110, 100), 16));
		m_FighterData.Add(17, new Fighter(1, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Attack, 21, 0, 110, 100), 17));
		m_FighterData.Add(18, new Fighter(2, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Attack, 21, 0, 110, 100), 18));
		m_FighterData.Add(19, new Fighter(3, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot10)
		}, Define.AIType.Attack, 21, 0, 110, 100), 19));
		m_FighterData.Add(20, new Fighter(0, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot11)
		}, Define.AIType.Attack, 24, 0, 110, 100), 20));
		m_FighterData.Add(21, new Fighter(1, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot12)
		}, Define.AIType.Attack, 24, 0, 110, 100), 21));
		m_FighterData.Add(22, new Fighter(0, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot13)
		}, Define.AIType.Attack, 24, 0, 110, 100), 22));
		m_FighterData.Add(23, new Fighter(10, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot14)
		}, Define.AIType.Attack, 36, 0, 110, 100), 23));
		m_FighterData.Add(24, new Fighter(17, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot15)
		}, Define.AIType.Attack, 24, 0, 110, 100), 24));
		m_FighterData.Add(25, new Fighter(18, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot16)
		}, Define.AIType.Attack, 24, 0, 110, 100), 25));
		m_FighterData.Add(26, new Fighter(19, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot17)
		}, Define.AIType.Attack, 24, 0, 110, 100), 26));
		m_FighterData.Add(27, new Fighter(20, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot18)
		}, Define.AIType.Attack, 24, 0, 110, 100), 27));
		m_FighterData.Add(28, new Fighter(6, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot19)
		}, Define.AIType.Attack, 24, 0, 110, 100), 28));
		m_FighterData.Add(29, new Fighter(5, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot20)
		}, Define.AIType.Attack, 24, 0, 110, 100), 29));
		m_FighterData.Add(30, new Fighter(4, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot21)
		}, Define.AIType.Attack, 24, 0, 110, 100), 30));
		m_FighterData.Add(31, new Fighter(21, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot22)
		}, Define.AIType.Attack, 25, 0, 200, 100), 31));
		m_FighterData.Add(32, new Fighter(21, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot23)
		}, Define.AIType.Attack, 25, 0, 200, 100), 32));
	}

	private void LoadEventData()
	{
		m_GameEvent.Add(-1, new GameEvent[15]
		{
			new GameEvent_MapLock(),
			new GameEvent_PlayBGM(4),
			new GameEvent_Dialogue("已经没有残敌了.", "大卫:", 4, Vector2.zero),
			new GameEvent_Dialogue("所罗门里也没看见敌人,好像都扯撤走了", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("所罗门?这名字我不太喜欢.", "希塔:", 33, Vector2.zero),
			new GameEvent_Dialogue("能不能叫别的名字?", "希塔:", 33, Vector2.zero),
			new GameEvent_Dialogue("那么叫帕托?", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("过去有一种像星星一样的糕点,也叫帕托.", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("感觉不好.", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("那你给起一个名字!", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("好了,别再争论了.", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("小心点,那帮家伙肯定要来反击的.", "乔:", 0, Vector2.zero),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(14)
		});
		m_GameEvent.Add(0, new GameEvent[42]
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
			new GameEvent_AddFighter(13),
			new GameEvent_AddFighter(14),
			new GameEvent_AddFighter(15),
			new GameEvent_AddFighter(16),
			new GameEvent_AddFighter(17),
			new GameEvent_AddFighter(18),
			new GameEvent_AddFighter(19),
			new GameEvent_AddFighter(23),
			new GameEvent_AddFighter(24),
			new GameEvent_AddFighter(25),
			new GameEvent_AddFighter(26),
			new GameEvent_AddFighter(27),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("来了!洛克的情报是对的.", "琼:", 45, Vector2.zero),
			new GameEvent_Dialogue("那么叫他们滚回去!喂,米亚,好好打!", "琼:", 45, Vector2.zero),
			new GameEvent_LookFighter(13),
			new GameEvent_Dialogue("天空......在下沉......", "米亚:", 44, Vector2.zero),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("嘿,这强化人一点也没用!", "琼:", 45, Vector2.zero),
			new GameEvent_Dialogue("洛克,把多余的东西全收起来.", "琼:", 45, Vector2.zero),
			new GameEvent_Dialogue("你们到底有何打算?", "琼:", 45, Vector2.zero),
			new GameEvent_LookFighter(4),
			new GameEvent_Dialogue("怎么了,萨米?", "卡姆:", 7, Vector2.zero),
			new GameEvent_LookFighter(13),
			new GameEvent_Dialogue("谁在叫我?是大哥吗?", "米亚:", 44, Vector2.zero),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(2, new GameEvent[10]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(20),
			new GameEvent_LookFighter(20),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(21),
			new GameEvent_LookFighter(21),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(22),
			new GameEvent_LookFighter(22),
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(8, new GameEvent[10]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(12),
			new GameEvent_LookFighter(12),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(31),
			new GameEvent_LookFighter(31),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(32),
			new GameEvent_LookFighter(32),
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(9, new GameEvent[10]
		{
			new GameEvent_PlayME(3),
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
