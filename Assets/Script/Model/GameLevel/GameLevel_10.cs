using System.Collections.Generic;
using UnityEngine;

public class GameLevel_10 : Level
{
	public GameLevel_10()
	{
		m_Name = "第10篇: 夫奥";
		m_Task = "全歼敌人即胜利!";
		m_Map = new Map(28, 30, new byte[840]
		{
			1, 1, 1, 1, 1, 0, 0, 0, 3, 0,
			0, 0, 0, 3, 0, 0, 0, 1, 1, 1,
			0, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 0, 0, 0, 0, 0, 0, 10, 11, 0,
			0, 2, 0, 0, 2, 0, 1, 1, 1, 1,
			0, 1, 1, 1, 1, 1, 1, 0, 0, 0,
			0, 0, 0, 0, 0, 12, 13, 0, 0, 0,
			0, 0, 0, 0, 0, 3, 3, 3, 0, 0,
			1, 1, 1, 1, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 3, 0, 3, 3, 3, 0,
			0, 1, 0, 0, 1, 0, 1, 1, 1, 1,
			1, 1, 6, 6, 6, 6, 6, 0, 0, 0,
			0, 0, 0, 3, 0, 0, 3, 3, 0, 0,
			0, 2, 3, 1, 1, 1, 1, 1, 1, 1,
			7, 7, 7, 7, 6, 6, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 3, 1, 1, 1, 1, 1, 1, 0, 0,
			0, 7, 7, 6, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 3, 0, 0, 0, 0, 9,
			1, 1, 1, 1, 1, 1, 7, 7, 7, 7,
			7, 6, 6, 6, 5, 5, 0, 0, 3, 0,
			0, 0, 0, 0, 0, 0, 2, 2, 3, 1,
			1, 1, 1, 1, 7, 7, 7, 7, 7, 7,
			6, 6, 5, 5, 0, 0, 0, 0, 2, 0,
			0, 0, 0, 4, 0, 0, 4, 1, 1, 1,
			1, 1, 7, 7, 7, 7, 7, 7, 7, 6,
			6, 5, 4, 0, 0, 0, 0, 0, 0, 0,
			4, 4, 4, 0, 0, 4, 1, 1, 1, 1,
			3, 3, 7, 7, 7, 7, 7, 7, 6, 6,
			0, 0, 0, 0, 2, 0, 0, 7, 7, 7,
			4, 0, 2, 2, 4, 4, 4, 4, 7, 3,
			3, 3, 7, 7, 7, 7, 7, 6, 0, 2,
			0, 0, 0, 7, 0, 7, 7, 7, 7, 0,
			0, 2, 2, 0, 4, 4, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 0, 0, 3, 0,
			0, 7, 0, 0, 0, 0, 7, 7, 7, 2,
			2, 0, 0, 2, 3, 3, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 0, 7, 7, 7, 7, 7, 7,
			7, 7, 0, 3, 3, 3, 3, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 0, 7, 7, 7, 0, 1, 1, 1, 1,
			0, 0, 3, 3, 0, 0, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 6, 6,
			0, 0, 0, 4, 0, 1, 1, 1, 3, 0,
			0, 0, 4, 0, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 6, 6, 6, 0, 0, 0,
			0, 0, 0, 1, 1, 1, 0, 0, 2, 0,
			0, 3, 0, 0, 7, 7, 7, 7, 7, 7,
			0, 9, 0, 0, 0, 0, 0, 0, 0, 0,
			3, 0, 1, 1, 0, 0, 0, 3, 0, 0,
			0, 0, 0, 7, 7, 7, 7, 7, 7, 0,
			0, 3, 0, 0, 3, 0, 0, 0, 0, 0,
			1, 1, 2, 2, 0, 0, 0, 3, 0, 0,
			0, 7, 7, 7, 7, 7, 7, 7, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 1,
			0, 0, 2, 0, 0, 0, 3, 0, 0, 0,
			7, 7, 7, 7, 7, 7, 0, 0, 3, 0,
			4, 0, 3, 0, 0, 0, 0, 1, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 3,
			3, 3, 3, 0, 0, 4, 0, 0, 0, 0,
			2, 0, 0, 0, 0, 0, 7, 7, 7, 7,
			7, 7, 0, 0, 2, 0, 3, 3, 3, 3,
			0, 3, 3, 4, 3, 0, 0, 0, 2, 0,
			0, 0, 0, 0, 7, 7, 7, 7, 7, 7,
			4, 0, 0, 3, 3, 3, 3, 0, 0, 3,
			3, 4, 3, 3, 0, 4, 0, 0, 0, 0,
			0, 7, 7, 7, 7, 7, 7, 7, 7, 0,
			4, 4, 3, 3, 7, 0, 0, 0, 0, 4,
			3, 3, 0, 0, 0, 3, 3, 0, 0, 7,
			7, 7, 7, 7, 7, 7, 7, 0, 0, 0,
			0, 0, 7, 7, 0, 0, 0, 0, 3, 0,
			7, 0, 3, 3, 0, 0, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 0, 0, 0, 0, 7,
			7, 7, 0, 0, 0, 3, 0, 7, 7, 0,
			0, 3, 3, 0, 0, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 0, 7, 7, 7, 7,
			7, 3, 3, 7, 7, 7, 7, 7, 0, 0,
			0, 0, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 0, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7
		});
		AddShopEvent(new Define.Point(15, 17), new List<int> { 0, 1, 2, 3, 4, 5, 7, 8 });
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(3, 22, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(2, 19, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(1, 20, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(2, 21, GameDataBase.Instance.GetActor(9), 3));
		m_FighterData.Add(4, new Fighter(25, 5, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(3, 20, GameDataBase.Instance.GetActor(7), 5));
		m_FighterData.Add(6, new Fighter(2, 23, GameDataBase.Instance.GetActor(0), 6));
		m_FighterData.Add(7, new Fighter(4, 21, GameDataBase.Instance.GetActor(12), 7));
		m_FighterData.Add(8, new Fighter(24, 6, GameDataBase.Instance.GetActor(13), 8));
		m_FighterData.Add(9, new Fighter(25, 6, GameDataBase.Instance.GetActor(14), 9));
		m_FighterData.Add(10, new Fighter(-1, -1, GameDataBase.Instance.GetActor(15), 10));
		m_FighterEvent.Add(26, new GameEvent[1]
		{
			new GameEvent_SetFlag("SaMi", value: false)
		});
		m_CapitulateMap.Add(4, new Dictionary<int, GameEvent[]> { 
		{
			26,
			new GameEvent[3]
			{
				new GameEvent_MapLock(),
				new GameEvent_InspectSwitch("SaMi", 1, new List<GameEvent>
				{
					new GameEvent_LookFighter(4),
					new GameEvent_Dialogue("萨米!要挺住!看看,是我啊,卡姆!", "卡姆:", 7, Vector2.zero),
					new GameEvent_LookFighter(26),
					new GameEvent_Dialogue("卡......姆?卡姆,是你吗?", "萨米:", 23, Vector2.zero),
					new GameEvent_LookFighter(4),
					new GameEvent_Dialogue("太好了,恢复正常了.", "卡姆:", 7, Vector2.zero),
					new GameEvent_LookFighter(26),
					new GameEvent_Dialogue("我刚才怎么了?", "萨米:", 23, Vector2.zero),
					new GameEvent_LookFighter(4),
					new GameEvent_Dialogue("你刚才被敌人控制了.现在好了,一起走吧!", "卡姆:", 7, Vector2.zero),
					new GameEvent_Replace(26, 10),
					new GameEvent_WaitTime(0.5f),
					new GameEvent_SetFlag("SaMi")
				}, new List<GameEvent>
				{
					new GameEvent_LookFighter(4),
					new GameEvent_Dialogue("萨米!", "卡姆:", 7, Vector2.zero),
					new GameEvent_LookFighter(26),
					new GameEvent_Dialogue("是谁,是敌人!", "萨米:", 23, Vector2.zero),
					new GameEvent_LookFighter(0),
					new GameEvent_Dialogue("卡姆!站住!", "大卫:", 4, Vector2.zero)
				}),
				new GameEvent_MapUnlock()
			}
		} });
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("马登", Robot.EngineType.Land, 21, 14, 6, 410, 80, 53, 94, new int[2] { 25, 26 });
		Robot robot2 = new Robot("马登", Robot.EngineType.Land, 21, 14, 6, 410, 80, 53, 94, new int[2] { 25, 26 });
		Robot robot3 = new Robot("马登", Robot.EngineType.Land, 21, 14, 6, 410, 80, 53, 94, new int[2] { 25, 26 });
		Robot robot4 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 310, 107, 53, 83, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot5 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 310, 107, 53, 83, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot6 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 290, 81, 46, 61, new int[2] { 7, 29 });
		Robot robot7 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 290, 81, 46, 61, new int[2] { 7, 29 });
		Robot robot8 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 290, 81, 46, 61, new int[2] { 7, 29 });
		Robot robot9 = new Robot("达衣", Robot.EngineType.Land, 62, 54, 4, 1500, 178, 95, 78, new int[2] { 74, 50 });
		Robot robot10 = new Robot("达衣", Robot.EngineType.Land, 62, 54, 4, 1500, 178, 95, 78, new int[2] { 74, 50 });
		Robot robot11 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 510, 118, 67, 99, new int[2] { 73, 71 });
		Robot robot12 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 510, 118, 67, 99, new int[2] { 73, 71 });
		Robot robot13 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 510, 118, 67, 99, new int[2] { 73, 71 });
		Robot robot14 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 520, 119, 68, 100, new int[2] { 73, 71 });
		Robot robot15 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 520, 119, 68, 100, new int[2] { 73, 71 });
		Robot robot16 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 520, 119, 68, 100, new int[2] { 73, 71 });
		Robot robot17 = new Robot("巴依", Robot.EngineType.Sky, 61, 53, 10, 810, 165, 95, 138, new int[2] { 69, 71 });
		Robot robot18 = new Robot("巴依", Robot.EngineType.Sky, 61, 53, 8, 690, 160, 97, 148, new int[2] { 69, 71 });
		Robot robot19 = new Robot("刚达", Robot.EngineType.Land, 36, 55, 5, 790, 161, 110, 85, new int[2] { 45, 72 });
		Robot robot20 = new Robot("古塔", Robot.EngineType.Sky, 59, 51, 5, 600, 104, 67, 77, new int[1] { 75 });
		Robot robot21 = new Robot("古塔", Robot.EngineType.Sky, 59, 51, 5, 600, 104, 67, 77, new int[1] { 75 });
		Robot robot22 = new Robot("雷克", Robot.EngineType.Sky, 31, 26, 7, 300, 75, 50, 100, new int[2] { 41, 14 });
		User user = new User("士兵", 6, null);
		User user2 = new User("罗依", 34, null);
		User user3 = new User("保罗", 12, null);
		User user4 = new User("萨米", 23, null);
		m_FighterData.Add(11, new Fighter(9, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot)
		}, Define.AIType.Attack, 13, 0, 120, 100), 11));
		m_FighterData.Add(12, new Fighter(11, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot2)
		}, Define.AIType.Attack, 13, 0, 120, 100), 12));
		m_FighterData.Add(13, new Fighter(13, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot3)
		}, Define.AIType.Attack, 13, 0, 120, 100), 13));
		m_FighterData.Add(14, new Fighter(19, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot6)
		}, Define.AIType.Attack, 15, 0, 90, 100), 14));
		m_FighterData.Add(15, new Fighter(20, 18, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot7)
		}, Define.AIType.Attack, 15, 0, 90, 100), 15));
		m_FighterData.Add(16, new Fighter(21, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot8)
		}, Define.AIType.Attack, 15, 0, 90, 100), 16));
		m_FighterData.Add(17, new Fighter(14, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot4)
		}, Define.AIType.Attack, 19, 0, 100, 100), 17));
		m_FighterData.Add(18, new Fighter(15, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot5)
		}, Define.AIType.Attack, 19, 0, 100, 100), 18));
		m_FighterData.Add(19, new Fighter(7, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot11)
		}, Define.AIType.Passivity, 19, 0, 110, 100), 19));
		m_FighterData.Add(20, new Fighter(8, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot12)
		}, Define.AIType.Passivity, 19, 0, 110, 100), 20));
		m_FighterData.Add(21, new Fighter(9, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot13)
		}, Define.AIType.Passivity, 19, 0, 110, 100), 21));
		m_FighterData.Add(22, new Fighter(10, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot14)
		}, Define.AIType.Passivity, 18, 0, 110, 100), 22));
		m_FighterData.Add(23, new Fighter(11, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot15)
		}, Define.AIType.Passivity, 18, 0, 110, 100), 23));
		m_FighterData.Add(24, new Fighter(12, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot16)
		}, Define.AIType.Passivity, 18, 0, 110, 100), 24));
		m_FighterData.Add(25, new Fighter(8, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot9)
		}, Define.AIType.Attack, 23, 0, 190, 100), 25));
		m_FighterData.Add(26, new Fighter(10, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot19)
		}, Define.AIType.Counter, 24, 0, 100, 100), 26));
		m_FighterData.Add(27, new Fighter(9, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot17)
		}, Define.AIType.Passivity, 31, 0, 150, 100), 27));
		m_FighterData.Add(28, new Fighter(10, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot18)
		}, Define.AIType.Passivity, 31, 0, 150, 100), 28));
		m_FighterData.Add(29, new Fighter(1, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot10)
		}, Define.AIType.Attack, 23, 0, 190, 100), 29));
		m_FighterData.Add(30, new Fighter(2, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot20)
		}, Define.AIType.Attack, 20, 0, 110, 100), 30));
		m_FighterData.Add(31, new Fighter(2, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot21)
		}, Define.AIType.Attack, 20, 0, 110, 100), 31));
		m_FighterData.Add(32, new Fighter(12, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot22)
		}, Define.AIType.Attack, 21, 0, 200, 100), 32));
		m_GameEventEvery = new GameEvent[8]
		{
			new GameEvent_SwitchNHP(19, 509, new List<GameEvent>
			{
				new GameEvent_InspectSwitch("JiMi", 1, new List<GameEvent>(), new List<GameEvent>
				{
					new GameEvent_SetSwitch("JiMi", value: true),
					new GameEvent_ChooseAI(19, Define.AIType.Attack),
					new GameEvent_ChooseAI(20, Define.AIType.Attack),
					new GameEvent_ChooseAI(21, Define.AIType.Attack),
					new GameEvent_ChooseAI(22, Define.AIType.Attack),
					new GameEvent_ChooseAI(23, Define.AIType.Attack),
					new GameEvent_ChooseAI(24, Define.AIType.Attack)
				})
			}, new List<GameEvent>()),
			new GameEvent_SwitchNHP(20, 509, new List<GameEvent>
			{
				new GameEvent_InspectSwitch("JiMi", 1, new List<GameEvent>(), new List<GameEvent>
				{
					new GameEvent_SetSwitch("JiMi", value: true),
					new GameEvent_ChooseAI(19, Define.AIType.Attack),
					new GameEvent_ChooseAI(20, Define.AIType.Attack),
					new GameEvent_ChooseAI(21, Define.AIType.Attack),
					new GameEvent_ChooseAI(22, Define.AIType.Attack),
					new GameEvent_ChooseAI(23, Define.AIType.Attack),
					new GameEvent_ChooseAI(24, Define.AIType.Attack)
				})
			}, new List<GameEvent>()),
			new GameEvent_SwitchNHP(21, 509, new List<GameEvent>
			{
				new GameEvent_InspectSwitch("JiMi", 1, new List<GameEvent>(), new List<GameEvent>
				{
					new GameEvent_SetSwitch("JiMi", value: true),
					new GameEvent_ChooseAI(19, Define.AIType.Attack),
					new GameEvent_ChooseAI(20, Define.AIType.Attack),
					new GameEvent_ChooseAI(21, Define.AIType.Attack),
					new GameEvent_ChooseAI(22, Define.AIType.Attack),
					new GameEvent_ChooseAI(23, Define.AIType.Attack),
					new GameEvent_ChooseAI(24, Define.AIType.Attack)
				})
			}, new List<GameEvent>()),
			new GameEvent_SwitchNHP(22, 519, new List<GameEvent>
			{
				new GameEvent_InspectSwitch("JiMi", 1, new List<GameEvent>(), new List<GameEvent>
				{
					new GameEvent_SetSwitch("JiMi", value: true),
					new GameEvent_ChooseAI(19, Define.AIType.Attack),
					new GameEvent_ChooseAI(20, Define.AIType.Attack),
					new GameEvent_ChooseAI(21, Define.AIType.Attack),
					new GameEvent_ChooseAI(22, Define.AIType.Attack),
					new GameEvent_ChooseAI(23, Define.AIType.Attack),
					new GameEvent_ChooseAI(24, Define.AIType.Attack)
				})
			}, new List<GameEvent>()),
			new GameEvent_SwitchNHP(23, 519, new List<GameEvent>
			{
				new GameEvent_InspectSwitch("JiMi", 1, new List<GameEvent>(), new List<GameEvent>
				{
					new GameEvent_SetSwitch("JiMi", value: true),
					new GameEvent_ChooseAI(19, Define.AIType.Attack),
					new GameEvent_ChooseAI(20, Define.AIType.Attack),
					new GameEvent_ChooseAI(21, Define.AIType.Attack),
					new GameEvent_ChooseAI(22, Define.AIType.Attack),
					new GameEvent_ChooseAI(23, Define.AIType.Attack),
					new GameEvent_ChooseAI(24, Define.AIType.Attack)
				})
			}, new List<GameEvent>()),
			new GameEvent_SwitchNHP(24, 519, new List<GameEvent>
			{
				new GameEvent_InspectSwitch("JiMi", 1, new List<GameEvent>(), new List<GameEvent>
				{
					new GameEvent_SetSwitch("JiMi", value: true),
					new GameEvent_ChooseAI(19, Define.AIType.Attack),
					new GameEvent_ChooseAI(20, Define.AIType.Attack),
					new GameEvent_ChooseAI(21, Define.AIType.Attack),
					new GameEvent_ChooseAI(22, Define.AIType.Attack),
					new GameEvent_ChooseAI(23, Define.AIType.Attack),
					new GameEvent_ChooseAI(24, Define.AIType.Attack)
				})
			}, new List<GameEvent>()),
			new GameEvent_SwitchNHP(27, 809, new List<GameEvent>
			{
				new GameEvent_InspectSwitch("BaYi", 1, new List<GameEvent>(), new List<GameEvent>
				{
					new GameEvent_SetSwitch("BaYi", value: true),
					new GameEvent_ChooseAI(27, Define.AIType.Attack),
					new GameEvent_ChooseAI(28, Define.AIType.Attack)
				})
			}, new List<GameEvent>()),
			new GameEvent_SwitchNHP(28, 689, new List<GameEvent>
			{
				new GameEvent_InspectSwitch("BaYi", 1, new List<GameEvent>(), new List<GameEvent>
				{
					new GameEvent_SetSwitch("BaYi", value: true),
					new GameEvent_ChooseAI(27, Define.AIType.Attack),
					new GameEvent_ChooseAI(28, Define.AIType.Attack)
				})
			}, new List<GameEvent>())
		};
	}

	private void LoadEventData()
	{
		m_GameEvent.Add(-1, new GameEvent[20]
		{
			new GameEvent_MapLock(),
			new GameEvent_PlayBGM(4),
			new GameEvent_Dialogue("到底是香港基地,设备很强大啊.", "布克:", 15, Vector2.zero),
			new GameEvent_Dialogue("哎!这不是卡姆和希塔吗!好久不见啊了!", "汤姆:", 35, Vector2.zero),
			new GameEvent_Dialogue("汤姆?你也被抓起来了啊!", "希塔:", 33, Vector2.zero),
			new GameEvent_Dialogue("没办法.据说袭击这里是为了开发新武器?", "汤姆:", 35, Vector2.zero),
			new GameEvent_Dialogue("交给我吧,这里养养齐全.", "汤姆:", 35, Vector2.zero),
			new GameEvent_Dialogue("我一定造个厉害的家伙出来!", "汤姆:", 35, Vector2.zero),
			new GameEvent_Dialogue("对不起,给你添麻烦了.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("没什么.乔,还有希塔,这个F91的......", "汤姆:", 35, Vector2.zero),
			new GameEvent_Dialogue("我叫布克,请多关照.", "布克:", 15, Vector2.zero),
			new GameEvent_Dialogue("我是汤姆,请多关照.", "汤姆:", 35, Vector2.zero),
			new GameEvent_Dialogue("我这里F91和ZZ的资料不全.", "汤姆:", 35, Vector2.zero),
			new GameEvent_Dialogue("所以你们两人暂时留下来补充资料.", "汤姆:", 35, Vector2.zero),
			new GameEvent_Dialogue("那......战斗力会减弱......", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("用不了多长时间.", "汤姆:", 35, Vector2.zero),
			new GameEvent_Dialogue("那么希塔和布克暂时留这儿帮汤姆.", "乔:", 0, Vector2.zero),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(10)
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
			new GameEvent_AddFighter(28),
			new GameEvent_LookFighter(0),
			new GameEvent_Dialogue("那是什么?", "大卫:", 4, Vector2.zero),
			new GameEvent_LookFighter(4),
			new GameEvent_Dialogue("刚达?萨米?是萨米?我是卡姆!", "卡姆:", 7, Vector2.zero),
			new GameEvent_LookFighter(26),
			new GameEvent_Dialogue("......你是谁......你是敌人!", "萨米:", 23, Vector2.zero),
			new GameEvent_LookFighter(4),
			new GameEvent_Dialogue("萨米!", "卡姆:", 7, Vector2.zero),
			new GameEvent_LookFighter(0),
			new GameEvent_Dialogue("站住!卡姆!她大脑被控制了!", "大卫:", 4, Vector2.zero),
			new GameEvent_LookFighter(4),
			new GameEvent_Dialogue("不可能!", "卡姆:", 7, Vector2.zero),
			new GameEvent_LookFighter(26),
			new GameEvent_Dialogue("头......好痛......你们这些坏蛋,让我头好痛!", "萨米:", 23, Vector2.zero),
			new GameEvent_LookFighter(27),
			new GameEvent_Dialogue("的确像洛克所说的那样,精神控制......很可怕.", "保罗:", 12, Vector2.zero),
			new GameEvent_Dialogue("让我们了解所有恩怨吧!", "保罗:", 12, Vector2.zero),
			new GameEvent_Dialogue("保罗,怒火冲昏了你的头脑,别再打了,要冷静.", "罗依:", 34, Vector2.zero),
			new GameEvent_Dialogue("是罗依吧,说的有道理.", "保罗:", 12, Vector2.zero),
			new GameEvent_Dialogue("好孩子......到天上去,我教你在宇宙中怎样作战.", "罗依:", 34, Vector2.zero),
			new GameEvent_Dialogue("谢谢!", "保罗:", 12, Vector2.zero),
			new GameEvent_Dialogue("哈哈,那就好.", "罗依:", 34, Vector2.zero),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(4, new GameEvent[5]
		{
			new GameEvent_LookFighter(26),
			new GameEvent_Dialogue("啊......头......头疼的厉害!", "萨米:", 23, Vector2.zero),
			new GameEvent_LookFighter(27),
			new GameEvent_Dialogue("萨米!怎么啦!关键时刻别倒下啊!", "保罗:", 12, Vector2.zero),
			new GameEvent_SetSwitch("SaMi", value: true)
		});
		m_GameEvent.Add(5, new GameEvent[10]
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
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(10, new GameEvent[4]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(32),
			new GameEvent_LookFighter(32),
			new GameEvent_WaitTime(0.5f)
		});
	}
}
