using System.Collections.Generic;
using UnityEngine;

public class GameLevel_6 : Level
{
	public GameLevel_6()
	{
		m_Name = "第6篇: 破坏敌要塞";
		m_Task = "攻克敌要塞!";
		m_Map = new Map(24, 24, new byte[576]
		{
			1, 1, 1, 0, 3, 0, 0, 1, 1, 1,
			1, 0, 0, 6, 7, 7, 7, 7, 7, 7,
			7, 6, 6, 0, 1, 1, 1, 1, 1, 0,
			0, 3, 1, 1, 1, 1, 0, 6, 6, 7,
			7, 7, 7, 7, 6, 6, 0, 0, 1, 10,
			11, 1, 0, 3, 0, 0, 3, 1, 1, 1,
			0, 0, 6, 3, 9, 3, 3, 6, 6, 2,
			2, 0, 1, 12, 13, 0, 0, 0, 0, 3,
			3, 0, 1, 1, 0, 0, 0, 0, 3, 3,
			0, 0, 0, 0, 0, 0, 1, 1, 1, 0,
			0, 0, 0, 0, 0, 3, 0, 1, 1, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 2,
			3, 1, 1, 3, 0, 0, 0, 0, 0, 2,
			2, 1, 1, 0, 0, 0, 0, 0, 0, 2,
			2, 0, 0, 0, 0, 3, 1, 0, 0, 0,
			0, 3, 0, 0, 0, 4, 1, 0, 0, 0,
			3, 2, 0, 0, 0, 0, 2, 0, 0, 3,
			1, 0, 3, 0, 0, 0, 0, 0, 4, 4,
			0, 0, 0, 0, 0, 0, 0, 3, 0, 0,
			0, 0, 0, 0, 0, 3, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 2, 0, 0, 0, 0, 7, 7, 7, 7,
			0, 0, 3, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 4,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			0, 3, 0, 0, 3, 2, 0, 0, 0, 0,
			0, 0, 4, 4, 1, 1, 1, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			0, 0, 0, 0, 0, 4, 4, 4, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 7, 7, 7,
			7, 7, 7, 7, 7, 0, 3, 0, 0, 0,
			4, 4, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 7, 7, 7,
			0, 0, 0, 0, 4, 4, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 7, 7, 7, 7, 7, 0, 0, 0,
			0, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 7, 7, 7,
			7, 7, 0, 0, 0, 0, 0, 0, 0, 3,
			3, 3, 0, 0, 0, 1, 1, 1, 1, 1,
			1, 1, 0, 0, 7, 7, 7, 7, 0, 2,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 1, 1, 0, 0, 0, 0, 7,
			7, 7, 0, 0, 0, 2, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 3, 0,
			0, 0, 0, 0, 1, 1, 1, 1, 1, 1,
			3, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 3, 1, 1, 1,
			1, 1, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 4, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 1, 1, 1, 1, 1, 2, 2,
			0, 0, 3, 0, 0, 0, 4, 4, 0, 0,
			0, 0, 0, 0, 0, 3, 0, 1, 1, 1,
			1, 1, 2, 2, 2, 0, 0, 0, 0, 0,
			3, 4, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 1, 1, 1, 1, 2, 2,
			0, 0, 4, 4, 4, 4
		});
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(3, 19, GameDataBase.Instance.GetActor(0), 0));
		m_FighterData.Add(1, new Fighter(3, 21, GameDataBase.Instance.GetActor(4), 1));
		m_FighterData.Add(2, new Fighter(4, 18, GameDataBase.Instance.GetActor(5), 2));
		m_FighterData.Add(3, new Fighter(4, 20, GameDataBase.Instance.GetActor(3), 3));
		m_FighterData.Add(4, new Fighter(4, 22, GameDataBase.Instance.GetActor(9), 4));
		m_FighterData.Add(5, new Fighter(5, 19, GameDataBase.Instance.GetActor(6), 5));
		m_FighterData.Add(6, new Fighter(5, 21, GameDataBase.Instance.GetActor(7), 6));
		m_FighterData.Add(7, new Fighter(2, 20, GameDataBase.Instance.GetActor(8), 7));
		m_FighterData.Add(24, new Fighter(-1, -1, GameDataBase.Instance.GetActor(10), 24));
		m_CapitulateMap.Add(2, new Dictionary<int, GameEvent[]> { 
		{
			23,
			new GameEvent[3]
			{
				new GameEvent_MapLock(),
				new GameEvent_SwitchNHP(23, 150, new List<GameEvent>
				{
					new GameEvent_LookFighter(23),
					new GameEvent_Dialogue("我输了,你刺死我吧......", "卡尔:", 25, Vector2.zero),
					new GameEvent_LookFighter(2),
					new GameEvent_Dialogue("......", "龙:", 5, Vector2.zero),
					new GameEvent_LookFighter(23),
					new GameEvent_Dialogue("怎么还不杀我!", "卡尔:", 25, Vector2.zero),
					new GameEvent_Dialogue("弱肉强食是天经地义的!", "卡尔:", 25, Vector2.zero),
					new GameEvent_LookFighter(2),
					new GameEvent_Dialogue("为什么那么在乎胜负?", "龙:", 5, Vector2.zero),
					new GameEvent_Dialogue("不愿和我走?你太冷酷了.", "龙:", 5, Vector2.zero),
					new GameEvent_LookFighter(23),
					new GameEvent_Dialogue("是啊.但在DC要生存就不得不这样.", "卡尔:", 25, Vector2.zero),
					new GameEvent_LookFighter(2),
					new GameEvent_Dialogue("那么和我们一起战斗吧!", "龙:", 5, Vector2.zero),
					new GameEvent_LookFighter(23),
					new GameEvent_Dialogue("要我做叛徒?但......我......", "卡尔:", 25, Vector2.zero),
					new GameEvent_LookFighter(2),
					new GameEvent_Dialogue("你已经恢复理智了,不是原来的你了......", "龙:", 5, Vector2.zero),
					new GameEvent_Dialogue("一个全新的你!", "龙:", 5, Vector2.zero),
					new GameEvent_LookFighter(23),
					new GameEvent_Dialogue("啊,谢谢.", "卡尔:", 25, Vector2.zero),
					new GameEvent_Replace(23, 24),
					new GameEvent_WaitTime(0.5f),
					new GameEvent_SetFlag("KaEr")
				}, new List<GameEvent>
				{
					new GameEvent_LookFighter(2),
					new GameEvent_Dialogue("站住!你绝不是那种人!", "龙:", 5, Vector2.zero),
					new GameEvent_LookFighter(23),
					new GameEvent_Dialogue("你再说什么呢!", "卡尔:", 25, Vector2.zero)
				}),
				new GameEvent_MapUnlock()
			}
		} });
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("马登", Robot.EngineType.Land, 21, 14, 6, 400, 77, 50, 91, new int[2] { 25, 26 });
		Robot robot2 = new Robot("马登", Robot.EngineType.Land, 21, 14, 6, 400, 77, 50, 91, new int[2] { 25, 26 });
		Robot robot3 = new Robot("炮台", Robot.EngineType.Land, 39, 34, 0, 190, 128, 38, 48, new int[1] { 50 });
		Robot robot4 = new Robot("炮台", Robot.EngineType.Land, 39, 34, 0, 190, 128, 38, 48, new int[1] { 50 });
		Robot robot5 = new Robot("炮台", Robot.EngineType.Land, 39, 34, 0, 190, 128, 38, 48, new int[1] { 50 });
		Robot robot6 = new Robot("炮台", Robot.EngineType.Land, 39, 34, 0, 190, 128, 38, 48, new int[1] { 50 });
		Robot robot7 = new Robot("炮台", Robot.EngineType.Land, 39, 34, 0, 190, 128, 38, 48, new int[1] { 50 });
		Robot robot8 = new Robot("炮台", Robot.EngineType.Land, 39, 34, 0, 180, 127, 37, 47, new int[1] { 50 });
		Robot robot9 = new Robot("炮台", Robot.EngineType.Land, 39, 34, 0, 180, 127, 37, 47, new int[1] { 50 });
		Robot robot10 = new Robot("炮台", Robot.EngineType.Land, 39, 34, 0, 180, 127, 37, 47, new int[1] { 50 });
		Robot robot11 = new Robot("炮台", Robot.EngineType.Land, 39, 34, 0, 180, 127, 37, 47, new int[1] { 50 });
		Robot robot12 = new Robot("炮台", Robot.EngineType.Land, 39, 34, 0, 180, 127, 37, 47, new int[1] { 50 });
		Robot robot13 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 7, 305, 67, 52, 77, new int[2] { 37, 38 });
		Robot robot14 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 7, 305, 67, 52, 77, new int[2] { 37, 38 });
		Robot robot15 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 7, 305, 67, 52, 77, new int[2] { 37, 38 });
		Robot robot16 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 8, 390, 80, 58, 90, new int[2] { 37, 38 });
		Robot robot17 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 8, 390, 80, 58, 90, new int[2] { 37, 38 });
		Robot robot18 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 8, 395, 85, 60, 92, new int[2] { 37, 38 });
		Robot robot19 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 8, 395, 85, 60, 92, new int[2] { 37, 38 });
		Robot robot20 = new Robot("麦乔", Robot.EngineType.Sky, 40, 35, 9, 490, 111, 76, 97, new int[2] { 51, 52 });
		Robot robot21 = new Robot("西马", Robot.EngineType.Sky, 42, 36, 9, 600, 108, 68, 113, new int[1] { 26 });
		Robot robot22 = new Robot("西马", Robot.EngineType.Land, 43, 36, 6, 600, 116, 63, 113, new int[2] { 26, 17 });
		Robot robot23 = new Robot("巴斯塔", Robot.EngineType.Land, 44, 38, 10, 360, 120, 64, 105, new int[1] { 53 });
		User user = new User("士兵", 6, null);
		User user2 = new User("卡尔", 25, null);
		User user3 = new User("布朗", 26, null);
		User user4 = new User("加纳", 17, null);
		User user5 = new User("安东", 27, null);
		m_FighterData.Add(8, new Fighter(18, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot)
		}, Define.AIType.Attack, 11, 0, 120, 100), 8));
		m_FighterData.Add(9, new Fighter(18, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot2)
		}, Define.AIType.Attack, 11, 0, 120, 100), 9));
		m_FighterData.Add(10, new Fighter(16, 18, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot13)
		}, Define.AIType.Attack, 12, 0, 105, 110), 10));
		m_FighterData.Add(11, new Fighter(15, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot14)
		}, Define.AIType.Attack, 12, 0, 105, 110), 11));
		m_FighterData.Add(12, new Fighter(16, 20, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot15)
		}, Define.AIType.Attack, 12, 0, 105, 110), 12));
		m_FighterData.Add(13, new Fighter(1, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot3)
		}, Define.AIType.Passivity, 13, 0, 100, 100), 13));
		m_FighterData.Add(14, new Fighter(1, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot4)
		}, Define.AIType.Passivity, 13, 0, 100, 100), 14));
		m_FighterData.Add(15, new Fighter(2, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot5)
		}, Define.AIType.Passivity, 13, 0, 100, 100), 15));
		m_FighterData.Add(16, new Fighter(2, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot6)
		}, Define.AIType.Passivity, 13, 0, 100, 100), 16));
		m_FighterData.Add(17, new Fighter(1, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot7)
		}, Define.AIType.Passivity, 13, 0, 100, 100), 17));
		m_FighterData.Add(18, new Fighter(1, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot8)
		}, Define.AIType.Passivity, 12, 0, 100, 100), 18));
		m_FighterData.Add(19, new Fighter(3, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot9)
		}, Define.AIType.Passivity, 12, 0, 100, 100), 19));
		m_FighterData.Add(20, new Fighter(3, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot10)
		}, Define.AIType.Passivity, 12, 0, 100, 100), 20));
		m_FighterData.Add(21, new Fighter(5, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot11)
		}, Define.AIType.Passivity, 12, 0, 100, 100), 21));
		m_FighterData.Add(22, new Fighter(5, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot12)
		}, Define.AIType.Passivity, 12, 0, 100, 100), 22));
		m_FighterData.Add(23, new Fighter(19, 18, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot20)
		}, Define.AIType.Attack, 16, 0, 90, 100), 23));
		m_FighterEvent.Add(23, new GameEvent[1]
		{
			new GameEvent_SetFlag("KaEr", value: false)
		});
		m_FighterData.Add(25, new Fighter(23, 20, new Actor(new Actor.ActorDataEx[2]
		{
			new Actor.ActorDataEx(user3, robot21),
			new Actor.ActorDataEx(user3, robot22)
		}, Define.AIType.Attack, 16, 0, 90, 80), 25));
		m_FighterData.Add(26, new Fighter(23, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot16)
		}, Define.AIType.Attack, 16, 0, 105, 110), 26));
		m_FighterData.Add(27, new Fighter(22, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot17)
		}, Define.AIType.Attack, 16, 0, 105, 110), 27));
		m_FighterData.Add(28, new Fighter(21, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot18)
		}, Define.AIType.Attack, 16, 0, 105, 110), 28));
		m_FighterData.Add(29, new Fighter(23, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot19)
		}, Define.AIType.Attack, 16, 0, 105, 110), 29));
		m_FighterData.Add(30, new Fighter(12, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user5, robot23)
		}, Define.AIType.Passivity, 16, 0, 90, 80, 2, isSelf: true), 30));
	}

	private void LoadEventData()
	{
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_MapLock());
		list.Add(new GameEvent_PlayBGM(4));
		list.Add(new GameEvent_Dialogue("好,下面就剩破坏要塞动力部了,快!", "龙:", 5, Vector2.zero));
		list.Add(new GameEvent_Repair());
		list.Add(new GameEvent_MapUnlock());
		list.Add(new GameEvent_Victory(6));
		List<GameEvent> list2 = list;
		HashSet<Define.Point> hashSet = new HashSet<Define.Point>();
		hashSet.Add(new Define.Point(1, 2));
		hashSet.Add(new Define.Point(1, 3));
		hashSet.Add(new Define.Point(2, 2));
		hashSet.Add(new Define.Point(2, 3));
		HashSet<Define.Point> hashSet2 = new HashSet<Define.Point>();
		for (int i = 0; i < 24; i++)
		{
			for (int j = 0; j < 24; j++)
			{
				if (i == 0 || j == 0 || i == 23 || j == 23)
				{
					hashSet2.Add(new Define.Point(i, j));
				}
			}
		}
		GameEvent gameEvent = new GameEvent_InspectSwitch("BuLang", 1, new List<GameEvent>
		{
			new GameEvent_PosSwitchID(25, hashSet2, new List<GameEvent>
			{
				new GameEvent_LookFighter(25),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(25, -1),
				new GameEvent_WaitTime(0.5f)
			})
		}, new List<GameEvent>());
		m_MoveOverEvent = new GameEvent[2]
		{
			new GameEvent_PosSwitchSelf(self: true, hashSet, list2),
			gameEvent
		};
		m_GameEventEvery = new GameEvent[2]
		{
			new GameEvent_InspectSwitch("BuLang", 1, new List<GameEvent>(), new List<GameEvent>
			{
				new GameEvent_SwitchNHP(25, 200, new List<GameEvent>
				{
					new GameEvent_LookFighter(25),
					new GameEvent_Dialogue("啊!完蛋了!没办法,逃吧!", "布朗:", 26, Vector2.zero),
					new GameEvent_DoVariant(25, 0),
					new GameEvent_ChooseAI(25, Define.AIType.Retreat),
					new GameEvent_SetSwitch("BuLang", value: true)
				}, new List<GameEvent>())
			}),
			gameEvent
		};
		m_GameEvent.Add(-1, list2.ToArray());
		m_GameEvent.Add(0, new GameEvent[37]
		{
			new GameEvent_PlayBGM(4),
			new GameEvent_MapLock(),
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
			new GameEvent_AddFighter(0),
			new GameEvent_AddFighter(1),
			new GameEvent_AddFighter(2),
			new GameEvent_AddFighter(3),
			new GameEvent_AddFighter(4),
			new GameEvent_AddFighter(5),
			new GameEvent_AddFighter(6),
			new GameEvent_GetFlag("NiNa", new List<GameEvent>
			{
				new GameEvent_AddFighter(7)
			}, new List<GameEvent>()),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("哇!的确不好对付,居然有所罗门基地那么大.", "路易:", 9, Vector2.zero),
			new GameEvent_Dialogue("敌人的炮火射程很远,不要轻易接近!", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("那个白色怪物很不好对付.", "布克:", 15, Vector2.zero),
			new GameEvent_LookFighter(23),
			new GameEvent_Dialogue("来的就是传说中的盖塔吗?", "卡尔:", 25, Vector2.zero),
			new GameEvent_Dialogue("哼,不过是个小东西.", "卡尔:", 25, Vector2.zero),
			new GameEvent_LookFighter(0),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(1, new GameEvent[2]
		{
			new GameEvent_LookFighter(23),
			new GameEvent_Dialogue("他就在那儿!盖塔!", "卡尔:", 25, Vector2.zero)
		});
		m_GameEvent.Add(2, new GameEvent[8]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(25),
			new GameEvent_LookFighter(25),
			new GameEvent_Dialogue("来得好,正好试试我们的新式武器.", "布朗:", 26, Vector2.zero),
			new GameEvent_MoveTo(25, 14, 20),
			new GameEvent_LookFighter(25),
			new GameEvent_Dialogue("嗯,不错,西马的起动性能比想象的还好!", "布朗:", 26, Vector2.zero),
			new GameEvent_SetAction(25, action: true)
		});
		m_GameEvent.Add(3, new GameEvent[1]
		{
			new GameEvent_InspectSwitch("BuLang", 1, new List<GameEvent>(), new List<GameEvent>
			{
				new GameEvent_LookFighter(25),
				new GameEvent_DoVariant(25, 1),
				new GameEvent_Dialogue("要不要变形为机器人?", "布朗:", 26, Vector2.zero)
			})
		});
		m_GameEvent.Add(6, new GameEvent[14]
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
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Dialogue("把马斯和麦克的仇敌给我抓来!", "加纳:", 17, Vector2.zero)
		});
		m_GameEvent.Add(7, new GameEvent[25]
		{
			new GameEvent_PlayBGM(2),
			new GameEvent_AddFighter(30),
			new GameEvent_LookFighter(30),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Dialogue("真难办呐!这样的要塞都攻不下来.", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("更别说DC了.", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("你干什么?帮助这帮家伙?", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("不要乱猜,我说过要给你派个帮手.", "安东:", 27, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_MoveTo(30, 5, 3),
			new GameEvent_LookFighter(30),
			new GameEvent_Dialogue("拉秀,退下!别受伤!", "安东:", 27, Vector2.zero),
			new GameEvent_DoBattle(30, 0, -1),
			new GameEvent_LookFighter(30),
			new GameEvent_SetAction(30, action: false),
			new GameEvent_Dialogue("快跟上!", "安东:", 27, Vector2.zero),
			new GameEvent_MoveTo(30, 2, 3),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(30, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("那是什么?", "大卫:", 4, Vector2.zero),
			new GameEvent_Dialogue("不像是敌人,是友军码?", "欧文:", 10, Vector2.zero),
			new GameEvent_Dialogue("怎么回事?", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("总之,攻入要塞的事待会再说.", "龙:", 5, Vector2.zero)
		});
	}
}
