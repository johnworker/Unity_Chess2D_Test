using System.Collections.Generic;
using UnityEngine;

public class GameLevel_12 : Level
{
	public GameLevel_12()
	{
		m_Name = "第12篇: 拉萨之战";
		m_Task = "破坏比克,将快速助推器弄到手";
		m_Map = new Map(20, 30, new byte[600]
		{
			15, 15, 15, 15, 25, 25, 25, 25, 25, 25,
			25, 25, 25, 25, 25, 25, 25, 25, 25, 25,
			15, 15, 15, 15, 15, 26, 26, 25, 25, 25,
			25, 25, 25, 25, 25, 18, 25, 25, 25, 25,
			15, 15, 15, 15, 15, 25, 25, 19, 25, 25,
			25, 25, 25, 25, 25, 25, 25, 26, 25, 25,
			15, 15, 15, 15, 15, 25, 25, 25, 25, 25,
			25, 25, 25, 25, 25, 25, 25, 25, 25, 25,
			15, 15, 15, 15, 15, 25, 25, 26, 26, 25,
			25, 25, 25, 25, 25, 25, 25, 25, 25, 26,
			15, 15, 15, 15, 15, 25, 26, 25, 25, 25,
			25, 25, 25, 25, 25, 25, 25, 25, 25, 25,
			15, 15, 15, 15, 25, 25, 25, 25, 26, 26,
			25, 25, 25, 25, 25, 25, 18, 25, 26, 25,
			15, 15, 15, 15, 15, 15, 25, 25, 25, 25,
			25, 25, 25, 25, 25, 18, 18, 25, 26, 26,
			25, 15, 15, 15, 15, 15, 15, 25, 25, 26,
			25, 25, 25, 26, 25, 25, 18, 18, 26, 26,
			18, 25, 15, 15, 15, 15, 15, 25, 25, 25,
			15, 15, 25, 25, 25, 25, 25, 18, 26, 26,
			25, 18, 25, 15, 15, 15, 15, 18, 18, 18,
			18, 15, 15, 25, 25, 25, 25, 26, 26, 26,
			25, 9, 25, 25, 15, 15, 15, 15, 18, 18,
			18, 15, 15, 15, 25, 25, 25, 26, 26, 26,
			25, 25, 18, 15, 15, 15, 15, 18, 18, 18,
			18, 15, 15, 15, 25, 25, 25, 26, 26, 26,
			25, 18, 18, 15, 15, 15, 15, 15, 15, 18,
			15, 15, 15, 25, 25, 25, 26, 26, 26, 26,
			25, 18, 25, 25, 15, 15, 15, 25, 15, 15,
			15, 25, 15, 15, 15, 25, 25, 25, 15, 15,
			25, 25, 25, 15, 15, 15, 25, 18, 25, 25,
			25, 15, 15, 15, 25, 25, 25, 15, 15, 15,
			25, 25, 15, 15, 15, 25, 25, 25, 10, 11,
			25, 25, 15, 15, 15, 25, 25, 15, 15, 15,
			27, 27, 27, 15, 15, 15, 25, 25, 12, 13,
			25, 18, 25, 25, 15, 25, 25, 15, 15, 15,
			27, 27, 27, 27, 15, 15, 15, 18, 25, 25,
			25, 25, 15, 15, 15, 25, 25, 15, 15, 18,
			27, 27, 27, 27, 15, 15, 15, 15, 15, 15,
			15, 15, 15, 15, 15, 25, 25, 18, 18, 18,
			27, 27, 27, 27, 27, 6, 6, 15, 15, 15,
			15, 15, 15, 25, 25, 25, 25, 18, 18, 18,
			27, 27, 27, 27, 6, 6, 25, 25, 18, 18,
			18, 18, 25, 25, 25, 25, 25, 25, 18, 18,
			27, 27, 27, 6, 6, 6, 25, 18, 25, 18,
			18, 18, 25, 25, 25, 25, 18, 25, 16, 16,
			27, 27, 27, 6, 6, 6, 25, 25, 25, 25,
			25, 25, 18, 25, 25, 25, 25, 25, 16, 16,
			27, 27, 27, 27, 6, 6, 6, 25, 25, 18,
			25, 25, 25, 25, 25, 25, 25, 16, 16, 16,
			27, 27, 27, 27, 27, 6, 6, 25, 25, 25,
			25, 25, 25, 25, 25, 16, 16, 16, 16, 25,
			27, 27, 27, 27, 27, 27, 6, 6, 25, 25,
			25, 25, 25, 25, 18, 16, 16, 16, 16, 25,
			27, 27, 27, 27, 27, 27, 27, 27, 27, 27,
			25, 25, 25, 25, 25, 25, 16, 16, 16, 25,
			27, 27, 27, 27, 27, 27, 27, 27, 27, 27,
			27, 25, 25, 25, 25, 25, 16, 16, 16, 25,
			27, 27, 27, 27, 27, 27, 27, 27, 27, 27,
			27, 25, 25, 25, 25, 16, 16, 16, 25, 25
		});
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		m_Hospital.Add(new Define.Point(7, 2));
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(15, 4, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(14, 4, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(15, 5, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(18, 1, GameDataBase.Instance.GetActor(9), 3));
		m_FighterData.Add(4, new Fighter(15, 2, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(16, 1, GameDataBase.Instance.GetActor(12), 5));
		m_FighterData.Add(6, new Fighter(17, 4, GameDataBase.Instance.GetActor(13), 6));
		m_FighterData.Add(7, new Fighter(17, 2, GameDataBase.Instance.GetActor(16), 7));
		m_FighterData.Add(8, new Fighter(18, 3, GameDataBase.Instance.GetActor(15), 8));
		m_FighterData.Add(9, new Fighter(12, 27, GameDataBase.Instance.GetActor(0), 9));
		m_FighterData.Add(10, new Fighter(12, 26, GameDataBase.Instance.GetActor(7), 10));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("西马", Robot.EngineType.Land, 43, 36, 5, 500, 98, 65, 105, new int[2] { 26, 17 });
		Robot robot2 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 320, 90, 55, 70, new int[2] { 7, 29 });
		Robot robot3 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 320, 90, 55, 70, new int[2] { 7, 29 });
		Robot robot4 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 330, 93, 58, 73, new int[2] { 7, 29 });
		Robot robot5 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 330, 93, 58, 73, new int[2] { 7, 29 });
		Robot robot6 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 330, 93, 58, 73, new int[2] { 7, 29 });
		Robot robot7 = new Robot("达衣", Robot.EngineType.Land, 62, 54, 4, 1510, 180, 97, 80, new int[2] { 74, 50 });
		Robot robot8 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 335, 102, 52, 95, new int[2] { 7, 8 });
		Robot robot9 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 335, 102, 52, 95, new int[2] { 7, 8 });
		Robot robot10 = new Robot("麦卡", Robot.EngineType.Sky, 65, 58, 6, 710, 107, 70, 97, new int[1] { 79 }, new Define.UserTrait[1] { Define.UserTrait.MinZhongGanRao });
		Robot robot11 = new Robot("麦卡", Robot.EngineType.Sky, 65, 58, 6, 710, 107, 70, 97, new int[1] { 79 }, new Define.UserTrait[1] { Define.UserTrait.MinZhongGanRao });
		Robot robot12 = new Robot("切克", Robot.EngineType.Land, 20, 18, 6, 620, 103, 63, 73, new int[2] { 30, 31 });
		Robot robot13 = new Robot("切克", Robot.EngineType.Land, 20, 18, 6, 620, 103, 63, 73, new int[2] { 30, 31 });
		Robot robot14 = new Robot("邦巴", Robot.EngineType.Land, 66, 59, 5, 1120, 146, 83, 81, new int[2] { 33, 50 });
		Robot robot15 = new Robot("比克", Robot.EngineType.Land, 37, 31, 4, 1260, 182, 114, 94, new int[2] { 46, 47 });
		User user = new User("士兵", 6, null);
		User user2 = new User("亨利", 22, null);
		m_FighterData.Add(11, new Fighter(8, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot10)
		}, Define.AIType.Attack, 22, 0, 190, 100), 11));
		m_FighterData.Add(12, new Fighter(8, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot11)
		}, Define.AIType.Attack, 22, 0, 190, 100), 12));
		m_FighterData.Add(13, new Fighter(14, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot12)
		}, Define.AIType.Attack, 23, 0, 140, 100), 13));
		m_FighterData.Add(14, new Fighter(16, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot13)
		}, Define.AIType.Attack, 23, 0, 140, 100), 14));
		m_FighterData.Add(15, new Fighter(15, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot14)
		}, Define.AIType.Attack, 23, 0, 140, 100), 15));
		m_FighterData.Add(16, new Fighter(15, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot7)
		}, Define.AIType.Attack, 23, 0, 190, 100), 16));
		m_FighterData.Add(17, new Fighter(10, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Patrol, 22, 0, 90, 100), 17));
		m_FighterData.Add(18, new Fighter(10, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Patrol, 22, 0, 90, 100), 18));
		m_FighterData.Add(19, new Fighter(14, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot2)
		}, Define.AIType.Attack, 21, 0, 115, 100), 19));
		m_FighterData.Add(20, new Fighter(16, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot3)
		}, Define.AIType.Attack, 21, 0, 115, 100), 20));
		m_FighterData.Add(21, new Fighter(15, 20, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot)
		}, Define.AIType.Attack, 21, 0, 90, 80), 21));
		m_FighterData.Add(22, new Fighter(9, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot15)
		}, Define.AIType.Patrol, 27, 0, 200, 80), 22));
		m_FighterData.Add(23, new Fighter(14, 27, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot5)
		}, Define.AIType.Attack, 22, 0, 115, 100), 23));
		m_FighterData.Add(24, new Fighter(15, 28, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot6)
		}, Define.AIType.Attack, 22, 0, 115, 100), 24));
		m_FighterData.Add(25, new Fighter(13, 28, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot4)
		}, Define.AIType.Attack, 22, 0, 115, 100), 25));
	}

	private void LoadEventData()
	{
		GameEvent gameEvent = new GameEvent_InspectSwitch("GangDa", 1, new List<GameEvent>(), new List<GameEvent>
		{
			new GameEvent_SetSwitch("GangDa", value: true),
			new GameEvent_ChooseActor(0, new Actor.ActorData[1]
			{
				new Actor.ActorData(5, 30)
			})
		});
		GameEvent gameEvent2 = new GameEvent_InspectSwitch("GaiTa", 1, new List<GameEvent>(), new List<GameEvent>
		{
			new GameEvent_SetSwitch("GaiTa", value: true),
			new GameEvent_ChooseActor(1, new Actor.ActorData[3]
			{
				new Actor.ActorData(0, 32),
				new Actor.ActorData(1, 33),
				new Actor.ActorData(2, 34)
			})
		});
		GameEvent gameEvent3 = new GameEvent_InspectSwitch("Jin", 1, new List<GameEvent>(), new List<GameEvent>
		{
			new GameEvent_SetSwitch("Jin", value: true),
			new GameEvent_ChooseActor(2, new Actor.ActorData[1]
			{
				new Actor.ActorData(7, 31)
			})
		});
		GameEvent gameEvent4 = new GameEvent_ChooseActor(4, new Actor.ActorData[2]
		{
			new Actor.ActorData(4, 36),
			new Actor.ActorData(4, 37)
		});
		GameEvent gameEvent5 = new GameEvent_ChooseActor(6, new Actor.ActorData[2]
		{
			new Actor.ActorData(14, 38),
			new Actor.ActorData(14, 39)
		});
		GameEvent gameEvent6 = new GameEvent_ChooseActor(3, new Actor.ActorData[2]
		{
			new Actor.ActorData(11, 40),
			new Actor.ActorData(11, 41)
		});
		m_CarryEvent = new GameEvent[3]
		{
			new GameEvent_IsCarry(9, 0, new List<GameEvent> { gameEvent }),
			new GameEvent_IsCarry(9, 1, new List<GameEvent> { gameEvent2 }),
			new GameEvent_IsCarry(9, 2, new List<GameEvent> { gameEvent3 })
		};
		GameEvent[] value = new GameEvent[17]
		{
			new GameEvent_MapLock(),
			new GameEvent_PlayBGM(4),
			new GameEvent_Dialogue("向DC前进......!", "亨利:", 22, Vector2.zero),
			new GameEvent_Dialogue("有了快速助推器,就能去宇宙空间了!", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("好,马上攻入敌人大本营.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("给大家武器都加强火力.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("这样马上打起来要轻松一点.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("宇宙......", "大卫:", 4, Vector2.zero),
			gameEvent,
			gameEvent2,
			gameEvent3,
			gameEvent4,
			gameEvent5,
			gameEvent6,
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(12)
		};
		m_FighterEvent.Add(22, value);
		m_GameEvent.Add(-1, value);
		m_GameEvent.Add(0, new GameEvent[33]
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
			new GameEvent_LookFighter(22),
			new GameEvent_Dialogue("别满不在乎的!最近出了很多事故.", "亨利:", 22, Vector2.zero),
			new GameEvent_Dialogue("在这样可不行!", "亨利:", 22, Vector2.zero),
			new GameEvent_LookFighter(0),
			new GameEvent_Dialogue("比克吗!", "大卫:", 4, Vector2.zero),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("慢!这是第8回合了", "加代:", 3, Vector2.zero),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(5, new GameEvent[17]
		{
			new GameEvent_PlayBGM(2),
			new GameEvent_AddFighter(9),
			new GameEvent_ChooseActor(9, new Actor.ActorData[1]
			{
				new Actor.ActorData(3, 35)
			}),
			new GameEvent_LookFighter(9),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(10),
			new GameEvent_LookFighter(10),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Dialogue("喂!没关系吧!", "布克:", 15, Vector2.zero),
			new GameEvent_Dialogue("我带来了新型战舰和机器人!", "布克:", 15, Vector2.zero),
			new GameEvent_LookFighter(9),
			new GameEvent_Dialogue("大卫!加代!龙!欧文!路易!", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("落到战舰上来.", "乔:", 0, Vector2.zero),
			new GameEvent_LookFighter(3),
			new GameEvent_Dialogue("乔舰长!没事儿吧!", "发:", 21, Vector2.zero),
			new GameEvent_LookFighter(9),
			new GameEvent_Dialogue("没问题,布克已经过去了,快加速!", "乔:", 0, Vector2.zero)
		});
		m_GameEvent.Add(6, new GameEvent[10]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(23),
			new GameEvent_LookFighter(23),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(24),
			new GameEvent_LookFighter(24),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(25),
			new GameEvent_LookFighter(25),
			new GameEvent_WaitTime(0.5f)
		});
	}
}
