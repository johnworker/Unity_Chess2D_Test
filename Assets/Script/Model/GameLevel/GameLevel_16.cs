using System.Collections.Generic;
using UnityEngine;

public class GameLevel_16 : Level
{
	public GameLevel_16()
	{
		m_Name = "第16篇: 逃脱";
		m_Task = "全部安全撤离.";
		m_Map = new Map(32, 16, new byte[512]
		{
			28, 28, 28, 28, 28, 28, 31, 28, 31, 30,
			30, 30, 28, 31, 32, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 30, 30, 31, 31, 31, 31,
			31, 31, 28, 29, 28, 28, 28, 28, 28, 31,
			28, 30, 31, 28, 31, 32, 32, 28, 28, 29,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			31, 31, 29, 31, 28, 28, 28, 28, 28, 28,
			29, 31, 31, 30, 30, 30, 30, 28, 32, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			30, 31, 28, 30, 30, 30, 28, 28, 28, 28,
			28, 28, 28, 28, 30, 31, 30, 31, 31, 28,
			28, 32, 28, 28, 28, 29, 28, 28, 35, 28,
			28, 28, 28, 28, 28, 28, 30, 30, 28, 28,
			28, 28, 28, 28, 28, 35, 28, 30, 30, 31,
			30, 28, 28, 32, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 30, 32, 32, 32,
			28, 28, 28, 28, 28, 28, 28, 28, 31, 28,
			30, 30, 30, 28, 28, 28, 32, 28, 28, 28,
			28, 28, 28, 28, 31, 28, 28, 32, 32, 32,
			32, 32, 28, 28, 28, 28, 28, 28, 28, 28,
			30, 28, 31, 31, 28, 28, 28, 28, 32, 28,
			28, 28, 28, 28, 28, 28, 32, 28, 28, 28,
			32, 32, 32, 32, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 30, 30, 30, 28, 28, 28,
			28, 32, 28, 28, 28, 28, 28, 28, 28, 32,
			28, 28, 28, 32, 32, 32, 28, 28, 28, 29,
			28, 28, 28, 28, 28, 30, 30, 31, 28, 28,
			28, 28, 28, 32, 28, 28, 28, 28, 28, 28,
			28, 28, 32, 32, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 30, 31, 30,
			30, 28, 28, 28, 28, 28, 32, 28, 28, 28,
			28, 28, 28, 28, 28, 32, 32, 32, 32, 32,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 31,
			28, 28, 29, 30, 30, 28, 28, 28, 32, 28,
			28, 28, 28, 28, 28, 30, 28, 28, 28, 28,
			32, 32, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 31, 30, 30, 28, 28, 28, 28,
			28, 32, 29, 28, 28, 28, 28, 28, 28, 28,
			31, 31, 28, 32, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 30, 30, 31, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 31, 28, 28,
			28, 28, 30, 30, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 29, 30, 31, 31, 28, 31,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 31, 31, 30, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 30, 30, 31,
			31, 30, 28, 28, 29, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 31, 31, 30, 30, 31, 31,
			28, 28, 28, 28, 28, 28, 28, 30, 28, 31,
			31, 31, 31, 28, 28, 31, 28, 28, 28, 28,
			28, 28, 28, 28, 31, 31, 28, 29, 31, 31,
			31, 31
		});
		AddShopEvent(new Define.Point(7, 4), new List<int> { 0, 1, 2, 3, 4, 5, 7, 8, 9 });
		m_SelfBGM = 11;
		m_EnemyBGM = 10;
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(16, 13, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(17, 12, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(15, 12, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(15, 8, GameDataBase.Instance.GetActor(14), 3));
		m_FighterData.Add(4, new Fighter(17, 10, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(9, 14, GameDataBase.Instance.GetActor(13), 5));
		m_FighterData.Add(6, new Fighter(14, 11, GameDataBase.Instance.GetActor(16), 6));
		m_FighterData.Add(7, new Fighter(15, 10, GameDataBase.Instance.GetActor(9), 7));
		m_FighterData.Add(8, new Fighter(14, 9, GameDataBase.Instance.GetActor(7), 8));
		m_FighterData.Add(9, new Fighter(16, 11, GameDataBase.Instance.GetActor(0), 9));
		m_CapitulateMap.Add(8, new Dictionary<int, GameEvent[]> { 
		{
			25,
			new GameEvent[5]
			{
				new GameEvent_MapLock(),
				new GameEvent_GetFlag("ZhenNi", new List<GameEvent>(), new List<GameEvent>
				{
					new GameEvent_LookFighter(8),
					new GameEvent_Dialogue("这不是珍妮吗?", "布克:", 15, Vector2.zero),
					new GameEvent_LookFighter(25),
					new GameEvent_Dialogue("布克?你还活着!?", "珍妮:", 47, Vector2.zero),
					new GameEvent_LookFighter(8),
					new GameEvent_Dialogue("珍妮!你怎么在这!?", "布克:", 15, Vector2.zero),
					new GameEvent_LookFighter(25),
					new GameEvent_Dialogue("这......我......", "珍妮:", 47, Vector2.zero),
					new GameEvent_LookFighter(21),
					new GameEvent_Dialogue("你在干嘛!杀了他!拜拉!", "罗纳:", 51, Vector2.zero),
					new GameEvent_LookFighter(8),
					new GameEvent_Dialogue("你是拜拉?", "布克:", 15, Vector2.zero),
					new GameEvent_LookFighter(25),
					new GameEvent_Dialogue("布克!快逃吧!", "珍妮:", 47, Vector2.zero),
					new GameEvent_LookFighter(8),
					new GameEvent_Dialogue("但珍妮你?", "布克:", 15, Vector2.zero),
					new GameEvent_LookFighter(25),
					new GameEvent_Dialogue("我没事儿,你快逃!", "珍妮:", 47, Vector2.zero),
					new GameEvent_LookFighter(8),
					new GameEvent_Dialogue("我一定来救你!等着我!珍妮!", "布克:", 15, Vector2.zero),
					new GameEvent_LookFighter(25),
					new GameEvent_Dialogue("布克......", "珍妮:", 47, Vector2.zero),
					new GameEvent_ChooseAI(25, Define.AIType.Null),
					new GameEvent_SetFlag("ZhenNi")
				}),
				new GameEvent_LookFighter(25),
				new GameEvent_Dialogue("布克!快逃!", "珍妮:", 47, Vector2.zero),
				new GameEvent_MapUnlock()
			}
		} });
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 710, 148, 97, 129, new int[2] { 73, 71 });
		Robot robot2 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 710, 148, 97, 129, new int[2] { 73, 71 });
		Robot robot3 = new Robot("吉米", Robot.EngineType.Land, 60, 52, 7, 710, 148, 97, 129, new int[2] { 73, 71 });
		Robot robot4 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 485, 151, 96, 156, new int[2] { 103, 71 });
		Robot robot5 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 485, 151, 96, 156, new int[2] { 103, 71 });
		Robot robot6 = new Robot("麦卡", Robot.EngineType.Sky, 65, 58, 6, 890, 134, 97, 124, new int[1] { 79 }, new Define.UserTrait[1] { Define.UserTrait.MinZhongGanRao });
		Robot robot7 = new Robot("基格", Robot.EngineType.Land, 91, 80, 9, 600, 164, 113, 168, new int[2] { 106, 107 });
		Robot robot8 = new Robot("基格", Robot.EngineType.Land, 92, 80, 7, 480, 144, 98, 130, new int[2] { 106, 107 });
		Robot robot9 = new Robot("基格", Robot.EngineType.Land, 92, 80, 7, 480, 144, 98, 130, new int[2] { 106, 107 });
		Robot robot10 = new Robot("基格", Robot.EngineType.Land, 92, 80, 7, 495, 147, 101, 133, new int[2] { 106, 107 });
		Robot robot11 = new Robot("基格", Robot.EngineType.Land, 92, 80, 7, 495, 147, 101, 133, new int[2] { 106, 107 });
		Robot robot12 = new Robot("比纳", Robot.EngineType.Land, 90, 82, 9, 820, 182, 124, 184, new int[2] { 65, 95 }, new Define.UserTrait[1]);
		Robot robot13 = new Robot("希古", Robot.EngineType.Sky, 94, 81, 8, 1610, 237, 110, 152, new int[2] { 64, 49 }, new Define.UserTrait[2]
		{
			Define.UserTrait.JianJieWuXiao,
			Define.UserTrait.ShenMiJiTi
		});
		Robot robot14 = new Robot("亚克托", Robot.EngineType.Land, 88, 78, 10, 1480, 250, 139, 167, new int[2] { 103, 108 });
		Robot robot15 = new Robot("亚克托", Robot.EngineType.Land, 89, 78, 9, 1380, 260, 136, 160, new int[2] { 103, 108 });
		Robot robot16 = new Robot("希亚", Robot.EngineType.Sky, 93, 79, 10, 4450, 255, 128, 156, new int[2] { 109, 83 });
		User user = new User("士兵", 6, null);
		User user2 = new User("罗纳", 51, null);
		User user3 = new User("格恩", 49, null);
		User user4 = new User("帕亚", 50, null);
		User user5 = new User("海伦", 52, null);
		User user6 = new User("珍妮", 47, null);
		User user7 = new User("拉多", 48, null);
		m_FighterData.Add(10, new Fighter(16, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot)
		}, Define.AIType.Attack, 38, 0, 110, 100), 10));
		m_FighterData.Add(11, new Fighter(17, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot2)
		}, Define.AIType.Attack, 38, 0, 110, 100), 11));
		m_FighterData.Add(12, new Fighter(18, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot3)
		}, Define.AIType.Attack, 38, 0, 110, 100), 12));
		m_FighterData.Add(13, new Fighter(26, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot4)
		}, Define.AIType.Attack, 38, 0, 140, 100), 13));
		m_FighterData.Add(14, new Fighter(26, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot5)
		}, Define.AIType.Attack, 38, 0, 140, 100), 14));
		m_FighterData.Add(15, new Fighter(25, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Attack, 38, 0, 110, 100), 15));
		m_FighterData.Add(16, new Fighter(25, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Attack, 38, 0, 110, 100), 16));
		m_FighterData.Add(17, new Fighter(4, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot10)
		}, Define.AIType.Counter, 40, 0, 110, 100), 17));
		m_FighterData.Add(18, new Fighter(4, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot11)
		}, Define.AIType.Counter, 40, 0, 110, 100), 18));
		m_FighterData.Add(19, new Fighter(26, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot6)
		}, Define.AIType.Attack, 40, 0, 130, 100), 19));
		m_FighterData.Add(20, new Fighter(5, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user5, robot7)
		}, Define.AIType.Counter, 45, 0, 110, 100), 20));
		m_FighterData.Add(21, new Fighter(2, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot16)
		}, Define.AIType.Counter, 46, 0, 240, 1100), 21));
		m_FighterData.Add(22, new Fighter(1, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot14)
		}, Define.AIType.Counter, 45, 0, 150, 200), 22));
		m_FighterData.Add(23, new Fighter(1, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot15)
		}, Define.AIType.Counter, 45, 0, 150, 200), 23));
		m_FighterData.Add(24, new Fighter(27, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user7, robot13)
		}, Define.AIType.Attack, 42, 0, 140, 100), 24));
		m_FighterData.Add(25, new Fighter(25, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user6, robot12)
		}, Define.AIType.Attack, 43, 0, 140, 1000), 25));
		m_FighterEvent.Add(25, new GameEvent[5]
		{
			new GameEvent_MapLock(),
			new GameEvent_HasFighter(21, new List<GameEvent>
			{
				new GameEvent_LookFighter(21),
				new GameEvent_Dialogue("拜拉!怎么了!?稍会点技巧你就骄傲了!", "罗纳:", 51, Vector2.zero),
				new GameEvent_Dialogue("不可饶恕!调回主力部队,一举消灭他们!", "罗纳:", 51, Vector2.zero)
			}, new List<GameEvent>
			{
				new GameEvent_Dialogue("珍妮......对不起......", "布克:", 15, Vector2.zero)
			}),
			new GameEvent_SetFlag("KillZhenNi"),
			new GameEvent_SetFlag("ZhenNi", value: false),
			new GameEvent_MapUnlock()
		});
	}

	private void LoadEventData()
	{
		HashSet<Define.Point> hashSet = new HashSet<Define.Point>();
		hashSet.Add(new Define.Point(31, 8));
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_MapLock());
		list.Add(new GameEvent_PlayBGM(4));
		list.Add(new GameEvent_HasFighter(25, new List<GameEvent>
		{
			new GameEvent_Dialogue("珍妮,我答应一定救你......", "布克:", 15, Vector2.zero)
		}, new List<GameEvent>
		{
			new GameEvent_Dialogue("珍妮......", "布克:", 15, Vector2.zero)
		}));
		list.Add(new GameEvent_Repair());
		list.Add(new GameEvent_MapUnlock());
		list.Add(new GameEvent_Victory(16));
		List<GameEvent> list2 = list;
		m_MoveOverEvent = new GameEvent[10]
		{
			new GameEvent_PosSwitchID(0, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(0),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(0, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, list2)
			}),
			new GameEvent_PosSwitchID(1, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(1),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(1, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, list2)
			}),
			new GameEvent_PosSwitchID(2, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(2),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(2, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, list2)
			}),
			new GameEvent_PosSwitchID(3, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(3),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(3, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, list2)
			}),
			new GameEvent_PosSwitchID(4, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(4),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(4, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, list2)
			}),
			new GameEvent_PosSwitchID(5, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(5),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(5, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, list2)
			}),
			new GameEvent_PosSwitchID(6, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(6),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(6, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, list2)
			}),
			new GameEvent_PosSwitchID(7, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(7),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(7, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, list2)
			}),
			new GameEvent_PosSwitchID(8, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(8),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(8, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, list2)
			}),
			new GameEvent_PosSwitchID(9, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(9),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(9, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, list2)
			})
		};
		m_GameEvent.Add(-1, list2.ToArray());
		m_GameEvent.Add(0, new GameEvent[60]
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
			new GameEvent_AddFighter(25),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("哇......!这帮家伙不简单!", "安东:", 27, Vector2.zero),
			new GameEvent_LookFighter(21),
			new GameEvent_Dialogue("哈哈......训练中碰上这么好的猎物.", "罗纳:", 51, Vector2.zero),
			new GameEvent_Dialogue("我们是塔利,DC的最精锐部队.", "罗纳:", 51, Vector2.zero),
			new GameEvent_Dialogue("西拉本来算不上对手,但作为训练工具还可以.", "罗纳:", 51, Vector2.zero),
			new GameEvent_LookFighter(5),
			new GameEvent_Dialogue("塔利?不好!大家快逃!", "马丁:", 30, Vector2.zero),
			new GameEvent_Dialogue("现在和他们打,我们绝无胜望!", "马丁:", 30, Vector2.zero),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("真这么厉害吗?", "龙:", 5, Vector2.zero),
			new GameEvent_LookFighter(5),
			new GameEvent_Dialogue("是的......以前也较量过,从没胜过.", "马丁:", 30, Vector2.zero),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("嗯!不就是塔利吗.他们算什么,我们已经今非昔比了!", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("打!", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(0),
			new GameEvent_Dialogue("站住!对手确实厉害!而且这里压强不对!", "大卫:", 4, Vector2.zero),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("但是逃往哪儿呢?", "路易:", 9, Vector2.zero),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("交给我吧!用巴斯塔的普拉电脑制定一条逃脱路线!", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("前方有个宇宙气旋,气流中有气旋涡.", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("进入气旋涡,那帮家伙就追不上了!", "安东:", 27, Vector2.zero),
			new GameEvent_MapMove(31, 8),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Dialogue("就是这里,记住了!", "安东:", 27, Vector2.zero),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("我真不高兴让敌人看着我们逃走,快走吧!", "龙:", 5, Vector2.zero),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(1, new GameEvent[2]
		{
			new GameEvent_LookFighter(25),
			new GameEvent_Dialogue("布克......真的死了吗......?", "珍妮:", 47, Vector2.zero)
		});
	}
}
