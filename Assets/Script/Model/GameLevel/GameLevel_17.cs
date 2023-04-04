using System.Collections.Generic;
using UnityEngine;

public class GameLevel_17 : Level
{
	public GameLevel_17()
	{
		m_Name = "第17篇: 起动";
		m_Task = "在11回合内击破所有发电镜!";
		m_Map = new Map(26, 32, new byte[832]
		{
			28, 28, 28, 28, 30, 30, 31, 30, 30, 31,
			31, 30, 28, 28, 30, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 30,
			30, 30, 30, 31, 31, 30, 30, 30, 31, 30,
			28, 30, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 29, 28, 30, 30, 30,
			30, 31, 31, 30, 30, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			40, 41, 28, 28, 28, 28, 30, 30, 30, 30,
			28, 28, 30, 28, 28, 28, 29, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			29, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 40, 41, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 39, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 29, 28, 28,
			28, 28, 28, 28, 31, 28, 28, 28, 28, 28,
			28, 28, 30, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 30,
			28, 28, 31, 28, 28, 30, 31, 28, 31, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 31, 28, 28, 28,
			28, 28, 31, 30, 28, 28, 29, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 31, 30, 28, 28, 28, 29, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 29, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 30, 31, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 31, 28, 30,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 32, 28, 28, 28, 28, 32, 32,
			32, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 32,
			28, 28, 28, 28, 28, 32, 32, 32, 28, 28,
			31, 28, 28, 28, 28, 28, 30, 28, 28, 28,
			30, 28, 28, 28, 32, 32, 28, 28, 28, 28,
			28, 28, 32, 32, 32, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 35, 28, 28, 28, 29,
			32, 28, 28, 28, 28, 28, 28, 28, 28, 32,
			32, 32, 32, 28, 28, 28, 28, 28, 28, 30,
			28, 28, 28, 28, 32, 32, 32, 28, 28, 28,
			28, 28, 28, 35, 28, 28, 28, 32, 32, 32,
			32, 28, 28, 28, 28, 28, 28, 32, 32, 32,
			32, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 32, 32, 32, 32, 32,
			32, 32, 32, 32, 31, 31, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 31, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			30, 31, 30, 28, 30, 28, 28, 28, 28, 28,
			30, 28, 28, 30, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 30, 28, 30, 30, 31, 30,
			30, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 30, 30, 30, 28, 31, 32, 32, 32, 32,
			32, 32, 28, 28, 30, 30, 28, 28, 28, 28,
			32, 32, 28, 28, 28, 28, 28, 28, 32, 32,
			32, 32, 32, 32, 32, 28, 28, 28, 28, 29,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			32, 32, 32, 32, 32, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 30, 30, 28, 28, 31, 30,
			28, 28, 28, 28, 28, 32, 32, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 30, 30, 28, 30, 28, 28, 32,
			32, 32, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 30, 30, 28,
			28, 28, 28, 32, 32, 32, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 30, 31, 30, 30, 30, 30, 32, 32,
			28, 28, 28, 30, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 30, 30,
			30, 30, 31, 30, 30, 28, 28, 30, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 29,
			28, 28, 28, 28, 28, 30, 31, 30, 30, 30,
			31, 30, 28, 28, 30, 28, 28, 28, 29, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 30, 30, 30, 31, 30, 30, 28, 30,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 29, 28, 28, 28, 28, 30, 30, 30,
			30, 30, 28, 28, 28, 30, 30, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28
		});
		AddShopEvent(new Define.Point(15, 15), new List<int> { 0, 1, 2, 3, 4, 5, 7, 8 });
		m_SelfBGM = 11;
		m_EnemyBGM = 10;
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(19, 26, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(20, 25, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(20, 27, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(21, 28, GameDataBase.Instance.GetActor(14), 3));
		m_FighterData.Add(4, new Fighter(21, 24, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(22, 24, GameDataBase.Instance.GetActor(13), 5));
		m_FighterData.Add(6, new Fighter(22, 26, GameDataBase.Instance.GetActor(9), 6));
		m_FighterData.Add(7, new Fighter(23, 26, GameDataBase.Instance.GetActor(7), 7));
		m_FighterData.Add(8, new Fighter(21, 26, GameDataBase.Instance.GetActor(0), 8));
		m_FighterData.Add(35, new Fighter(-1, -1, GameDataBase.Instance.GetActor(17), 35));
		m_CapitulateMap.Add(3, new Dictionary<int, GameEvent[]> { 
		{
			11,
			new GameEvent[3]
			{
				new GameEvent_MapLock(),
				new GameEvent_GetFlag("YiWa", new List<GameEvent>
				{
					new GameEvent_LookFighter(3),
					new GameEvent_Dialogue("这不是伊娃吗!?", "希塔:", 33, Vector2.zero),
					new GameEvent_LookFighter(11),
					new GameEvent_Dialogue("你是谁?", "伊娃:", 39, Vector2.zero),
					new GameEvent_LookFighter(3),
					new GameEvent_Dialogue("忘了?精神被控制了?", "希塔:", 33, Vector2.zero),
					new GameEvent_Dialogue("你不是答应和我玩吗?", "希塔:", 33, Vector2.zero),
					new GameEvent_Dialogue("是我,希塔!", "希塔:", 33, Vector2.zero),
					new GameEvent_LookFighter(11),
					new GameEvent_Dialogue("希塔?......玩.....啊,头......真疼.", "伊娃:", 39, Vector2.zero),
					new GameEvent_LookFighter(3),
					new GameEvent_Dialogue("你要挺住!", "希塔:", 33, Vector2.zero),
					new GameEvent_LookFighter(11),
					new GameEvent_Dialogue("头......这声音......希塔?", "伊娃:", 39, Vector2.zero),
					new GameEvent_LookFighter(3),
					new GameEvent_Dialogue("想起来了.", "希塔:", 33, Vector2.zero),
					new GameEvent_LookFighter(11),
					new GameEvent_Dialogue("是的!一起玩玩吧,希塔!", "伊娃:", 39, Vector2.zero),
					new GameEvent_Replace(11, 35),
					new GameEvent_WaitTime(0.5f),
					new GameEvent_LookFighter(10),
					new GameEvent_Dialogue("伊娃?精神控制应该没问题的!", "布托:", 54, Vector2.zero),
					new GameEvent_SetSwitch("YiWa", value: true)
				}, new List<GameEvent>
				{
					new GameEvent_LookFighter(11),
					new GameEvent_Dialogue("你是谁?", "伊娃:", 39, Vector2.zero)
				}),
				new GameEvent_MapUnlock()
			}
		} });
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("吉伯II", Robot.EngineType.Land, 73, 67, 9, 670, 147, 104, 139, new int[2] { 69, 94 });
		Robot robot2 = new Robot("加姆", Robot.EngineType.Sky, 86, 75, 10, 395, 144, 74, 124, new int[1] { 101 });
		Robot robot3 = new Robot("加姆", Robot.EngineType.Sky, 86, 75, 10, 395, 144, 74, 124, new int[1] { 101 });
		Robot robot4 = new Robot("加姆", Robot.EngineType.Sky, 86, 75, 10, 395, 144, 74, 124, new int[1] { 101 });
		Robot robot5 = new Robot("加姆", Robot.EngineType.Sky, 86, 75, 10, 370, 136, 66, 116, new int[1] { 101 });
		Robot robot6 = new Robot("加姆", Robot.EngineType.Sky, 86, 75, 10, 370, 136, 66, 116, new int[1] { 101 });
		Robot robot7 = new Robot("加姆", Robot.EngineType.Sky, 86, 75, 10, 370, 136, 66, 116, new int[1] { 101 });
		Robot robot8 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 360, 122, 68, 98, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot9 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 360, 122, 68, 98, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot10 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 360, 122, 68, 98, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot11 = new Robot("扎依", Robot.EngineType.Land, 45, 40, 4, 365, 98, 60, 50, new int[2] { 33, 36 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot12 = new Robot("切克", Robot.EngineType.Land, 20, 18, 6, 440, 76, 36, 46, new int[2] { 30, 31 });
		Robot robot13 = new Robot("巴乌", Robot.EngineType.Land, 96, 74, 10, 1920, 198, 121, 170, new int[2] { 103, 71 });
		Robot robot14 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 485, 151, 96, 156, new int[2] { 103, 71 });
		Robot robot15 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 485, 151, 96, 156, new int[2] { 103, 71 });
		Robot robot16 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 415, 130, 75, 125, new int[2] { 103, 71 });
		Robot robot17 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 415, 130, 75, 125, new int[2] { 103, 71 });
		Robot robot18 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 415, 130, 75, 125, new int[2] { 103, 71 });
		Robot robot19 = new Robot("发电镜", Robot.EngineType.Land, 95, 83, 0, 690, 54, 54, 54, new int[1] { 74 });
		Robot robot20 = new Robot("发电镜", Robot.EngineType.Land, 95, 83, 0, 690, 54, 54, 54, new int[1] { 74 });
		Robot robot21 = new Robot("发电镜", Robot.EngineType.Land, 95, 83, 0, 690, 54, 54, 54, new int[1] { 74 });
		Robot robot22 = new Robot("发电镜", Robot.EngineType.Land, 95, 83, 0, 690, 54, 54, 54, new int[1] { 74 });
		Robot robot23 = new Robot("邦巴", Robot.EngineType.Land, 66, 59, 5, 1120, 146, 83, 81, new int[2] { 33, 50 });
		Robot robot24 = new Robot("雷克", Robot.EngineType.Sky, 31, 26, 7, 250, 60, 35, 85, new int[2] { 41, 14 });
		Robot robot25 = new Robot("雷克", Robot.EngineType.Sky, 31, 26, 7, 250, 60, 35, 85, new int[2] { 41, 14 });
		Robot robot26 = new Robot("雷克", Robot.EngineType.Sky, 31, 26, 7, 250, 60, 35, 85, new int[2] { 41, 14 });
		User user = new User("士兵", 6, null);
		User user2 = new User("布托", 54, null);
		User user3 = new User("伊娃", 39, null);
		m_FighterData.Add(9, new Fighter(10, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot15)
		}, Define.AIType.Patrol, 28, 0, 140, 100), 9));
		m_FighterData.Add(10, new Fighter(9, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot13)
		}, Define.AIType.Patrol, 35, 0, 225, 100), 10));
		m_FighterData.Add(11, new Fighter(10, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot)
		}, Define.AIType.Attack, 30, 0, 110, 100), 11));
		m_FighterData.Add(12, new Fighter(7, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot19)
		}, Define.AIType.Patrol, 30, 0, 40, 100), 12));
		m_FighterData.Add(13, new Fighter(7, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot20)
		}, Define.AIType.Patrol, 30, 0, 40, 100), 13));
		m_FighterData.Add(14, new Fighter(5, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot21)
		}, Define.AIType.Patrol, 30, 0, 40, 100), 14));
		m_FighterData.Add(15, new Fighter(5, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot22)
		}, Define.AIType.Patrol, 30, 0, 40, 100), 15));
		m_FighterData.Add(16, new Fighter(11, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot2)
		}, Define.AIType.Patrol, 30, 0, 135, 100), 16));
		m_FighterData.Add(17, new Fighter(12, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot3)
		}, Define.AIType.Patrol, 30, 0, 135, 100), 17));
		m_FighterData.Add(18, new Fighter(11, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot4)
		}, Define.AIType.Patrol, 30, 0, 135, 100), 18));
		m_FighterData.Add(19, new Fighter(9, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot16)
		}, Define.AIType.Patrol, 29, 0, 140, 100), 19));
		m_FighterData.Add(20, new Fighter(5, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot17)
		}, Define.AIType.Attack, 29, 0, 140, 100), 20));
		m_FighterData.Add(21, new Fighter(5, 23, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot18)
		}, Define.AIType.Attack, 29, 0, 140, 100), 21));
		m_FighterData.Add(22, new Fighter(3, 22, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot11)
		}, Define.AIType.Attack, 29, 0, 190, 100), 22));
		m_FighterData.Add(23, new Fighter(3, 20, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot8)
		}, Define.AIType.Attack, 29, 0, 100, 100), 23));
		m_FighterData.Add(24, new Fighter(3, 24, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot12)
		}, Define.AIType.Attack, 29, 0, 140, 100), 24));
		m_FighterData.Add(25, new Fighter(0, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot24)
		}, Define.AIType.Attack, 30, 0, 200, 100), 25));
		m_FighterData.Add(26, new Fighter(0, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot25)
		}, Define.AIType.Attack, 30, 0, 200, 100), 26));
		m_FighterData.Add(27, new Fighter(0, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot26)
		}, Define.AIType.Attack, 30, 0, 200, 100), 27));
		m_FighterData.Add(28, new Fighter(25, 29, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot5)
		}, Define.AIType.Attack, 30, 0, 135, 100), 28));
		m_FighterData.Add(29, new Fighter(24, 30, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Attack, 30, 0, 135, 100), 29));
		m_FighterData.Add(30, new Fighter(23, 31, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Attack, 30, 0, 135, 100), 30));
		m_FighterData.Add(31, new Fighter(18, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot23)
		}, Define.AIType.Attack, 30, 0, 140, 100), 31));
		m_FighterData.Add(32, new Fighter(19, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot9)
		}, Define.AIType.Attack, 30, 0, 100, 100), 32));
		m_FighterData.Add(33, new Fighter(17, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot10)
		}, Define.AIType.Attack, 30, 0, 100, 100), 33));
		m_FighterData.Add(34, new Fighter(9, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot14)
		}, Define.AIType.Patrol, 28, 0, 140, 100), 34));
	}

	private void LoadEventData()
	{
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_MapLock());
		list.Add(new GameEvent_PlayBGM(4));
		list.Add(new GameEvent_InspectSwitch("YiWa", 1, new List<GameEvent>(), new List<GameEvent>
		{
			new GameEvent_SetFlag("YiWa", value: false)
		}));
		list.Add(new GameEvent_HasFighter(10, new List<GameEvent>
		{
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("完了!镜子全部打破了!", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("啊,失败了!快!撤退!", "布托:", 54, Vector2.zero)
		}, new List<GameEvent>()));
		list.Add(new GameEvent_Dialogue("好!终于解决了.", "龙:", 5, Vector2.zero));
		list.Add(new GameEvent_Dialogue("我们也受到一点损伤,先回帕托吧.", "欧文:", 10, Vector2.zero));
		list.Add(new GameEvent_Dialogue("恩,有必要来一次彻底维修,回帕托!", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Repair());
		list.Add(new GameEvent_MapUnlock());
		list.Add(new GameEvent_Victory(17));
		List<GameEvent> list2 = list;
		m_GameEvent.Add(-1, list2.ToArray());
		m_FighterEvent.Add(12, new GameEvent[2]
		{
			new GameEvent_AddSwitch("FaDianJing", 1),
			new GameEvent_InspectSwitch("FaDianJing", 4, list2, new List<GameEvent>())
		});
		m_FighterEvent.Add(13, new GameEvent[2]
		{
			new GameEvent_AddSwitch("FaDianJing", 1),
			new GameEvent_InspectSwitch("FaDianJing", 4, list2, new List<GameEvent>())
		});
		m_FighterEvent.Add(14, new GameEvent[2]
		{
			new GameEvent_AddSwitch("FaDianJing", 1),
			new GameEvent_InspectSwitch("FaDianJing", 4, list2, new List<GameEvent>())
		});
		m_FighterEvent.Add(15, new GameEvent[2]
		{
			new GameEvent_AddSwitch("FaDianJing", 1),
			new GameEvent_InspectSwitch("FaDianJing", 4, list2, new List<GameEvent>())
		});
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
			new GameEvent_AddFighter(24),
			new GameEvent_AddFighter(34),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("还慢吞吞的!离它发射只剩下11分钟了......", "布托:", 54, Vector2.zero),
			new GameEvent_Dialogue("伊娃,别让他们前进!", "布托:", 54, Vector2.zero),
			new GameEvent_LookFighter(11),
			new GameEvent_Dialogue("是!", "伊娃:", 39, Vector2.zero),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("狡猾!他们已经开始准备发射了!", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("大卫!怎么才能关掉激光盘?", "欧文:", 10, Vector2.zero),
			new GameEvent_LookFighter(0),
			new GameEvent_Dialogue("破坏它的发电镜!一旦失去能源,就发不出激光!", "大卫:", 4, Vector2.zero),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(4, new GameEvent[10]
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
		m_GameEvent.Add(7, new GameEvent[10]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(31),
			new GameEvent_LookFighter(31),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(32),
			new GameEvent_LookFighter(32),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(33),
			new GameEvent_LookFighter(33),
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(8, new GameEvent[4]
		{
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("还有3分钟,一定守住发电镜!", "布托:", 54, Vector2.zero),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("危险!只剩3分钟了!", "加代:", 3, Vector2.zero)
		});
		m_GameEvent.Add(9, new GameEvent[10]
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
		m_GameEvent.Add(11, new GameEvent[7]
		{
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("激光盘发射!", "布托:", 54, Vector2.zero),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("坏了!", "龙:", 5, Vector2.zero),
			new GameEvent_LookFighter(0),
			new GameEvent_Dialogue("来不及了!", "大卫:", 4, Vector2.zero),
			new GameEvent_GameOver()
		});
	}
}
