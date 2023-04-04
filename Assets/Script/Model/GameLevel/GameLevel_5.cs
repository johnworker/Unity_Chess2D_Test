using System.Collections.Generic;
using UnityEngine;

public class GameLevel_5 : Level
{
	public GameLevel_5()
	{
		m_Name = "第5篇: 背叛的荒野";
		m_Task = "全歼敌人即胜利!";
		m_Map = new Map(32, 15, new byte[480]
		{
			6, 6, 6, 6, 6, 1, 1, 1, 5, 5,
			5, 5, 5, 5, 5, 5, 5, 5, 5, 0,
			0, 6, 6, 6, 6, 6, 0, 0, 0, 3,
			3, 0, 6, 6, 6, 6, 1, 1, 1, 1,
			1, 5, 5, 5, 5, 5, 5, 5, 5, 5,
			0, 0, 6, 6, 6, 6, 6, 6, 6, 0,
			0, 9, 3, 0, 6, 6, 6, 6, 6, 1,
			1, 1, 1, 6, 6, 6, 5, 6, 6, 6,
			6, 6, 0, 0, 0, 0, 6, 6, 6, 6,
			6, 0, 0, 0, 0, 0, 6, 6, 6, 6,
			6, 6, 1, 1, 6, 6, 6, 6, 6, 0,
			0, 0, 0, 0, 0, 1, 1, 1, 6, 6,
			6, 6, 6, 6, 6, 0, 0, 0, 6, 6,
			6, 6, 6, 0, 0, 1, 1, 1, 1, 0,
			0, 0, 0, 0, 0, 0, 0, 4, 1, 1,
			1, 1, 1, 0, 6, 6, 6, 6, 6, 6,
			6, 6, 6, 6, 6, 6, 0, 0, 0, 1,
			1, 1, 0, 0, 0, 0, 0, 4, 4, 4,
			4, 1, 1, 1, 1, 0, 0, 0, 6, 6,
			6, 6, 6, 6, 6, 6, 0, 0, 0, 0,
			0, 0, 1, 1, 0, 0, 0, 0, 4, 4,
			0, 0, 0, 0, 1, 1, 3, 3, 3, 0,
			0, 6, 6, 6, 6, 6, 6, 6, 6, 0,
			0, 0, 0, 3, 1, 1, 1, 6, 6, 0,
			0, 0, 0, 6, 6, 6, 1, 1, 1, 3,
			3, 0, 0, 6, 6, 6, 6, 0, 0, 6,
			6, 6, 0, 0, 0, 9, 3, 1, 1, 5,
			6, 6, 6, 6, 6, 6, 6, 6, 1, 1,
			1, 1, 1, 1, 0, 0, 6, 6, 0, 0,
			0, 1, 6, 6, 6, 0, 0, 3, 0, 1,
			1, 5, 5, 6, 6, 6, 6, 6, 6, 6,
			6, 1, 1, 1, 1, 1, 1, 0, 6, 6,
			0, 0, 0, 1, 1, 6, 6, 6, 0, 0,
			1, 1, 5, 5, 5, 5, 6, 6, 6, 6,
			6, 6, 6, 6, 0, 0, 1, 1, 1, 1,
			6, 6, 0, 0, 0, 1, 1, 1, 6, 6,
			0, 1, 1, 1, 1, 5, 5, 6, 6, 6,
			6, 6, 6, 0, 0, 0, 0, 0, 0, 1,
			1, 0, 0, 6, 0, 0, 0, 0, 1, 1,
			6, 6, 6, 0, 0, 1, 1, 1, 5, 6,
			6, 6, 6, 6, 0, 0, 0, 0, 0, 0,
			1, 1, 1, 1, 1, 6, 0, 0, 0, 0,
			1, 1, 6, 6, 6, 6, 8, 0, 5, 5,
			5, 6, 6, 0, 4, 0, 0, 1, 1, 0,
			0, 1, 1, 1, 1, 1, 1, 1, 0, 0,
			0, 0, 0, 1, 1, 1, 6, 6, 0, 0,
			0, 5, 5, 0, 4, 0, 0, 0, 3, 1,
			1, 1, 0, 0, 1, 1, 1, 1, 1, 6
		});
		AddShopEvent(new Define.Point(9, 8), new List<int> { 0, 1, 2, 3, 4, 5, 7, 8 });
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		m_Hospital.Add(new Define.Point(10, 13));
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(2, 3, GameDataBase.Instance.GetActor(0), 0));
		m_FighterData.Add(1, new Fighter(3, 4, GameDataBase.Instance.GetActor(4), 1));
		m_FighterData.Add(2, new Fighter(2, 5, GameDataBase.Instance.GetActor(5), 2));
		m_FighterData.Add(3, new Fighter(4, 5, GameDataBase.Instance.GetActor(3), 3));
		m_FighterData.Add(4, new Fighter(3, 6, GameDataBase.Instance.GetActor(9), 4));
		m_FighterData.Add(5, new Fighter(2, 7, GameDataBase.Instance.GetActor(6), 5));
		m_FighterData.Add(6, new Fighter(1, 6, GameDataBase.Instance.GetActor(7), 6));
		m_FighterData.Add(7, new Fighter(1, 5, GameDataBase.Instance.GetActor(8), 7));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 265, 74, 39, 54, new int[2] { 7, 29 });
		Robot robot2 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 265, 74, 39, 54, new int[2] { 7, 29 });
		Robot robot3 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 265, 74, 39, 54, new int[2] { 7, 29 });
		Robot robot4 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 265, 74, 39, 54, new int[2] { 7, 29 });
		Robot robot5 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 265, 74, 39, 54, new int[2] { 7, 29 });
		Robot robot6 = new Robot("马登", Robot.EngineType.Land, 21, 14, 6, 410, 80, 53, 94, new int[2] { 25, 26 });
		Robot robot7 = new Robot("马登", Robot.EngineType.Land, 21, 14, 6, 410, 80, 53, 94, new int[2] { 25, 26 });
		Robot robot8 = new Robot("马登", Robot.EngineType.Land, 21, 14, 6, 410, 80, 53, 94, new int[2] { 25, 26 });
		Robot robot9 = new Robot("撞击器", Robot.EngineType.Land, 28, 23, 5, 410, 72, 62, 52, new int[2] { 8, 36 });
		Robot robot10 = new Robot("撞击器", Robot.EngineType.Land, 28, 23, 5, 410, 72, 62, 52, new int[2] { 8, 36 });
		Robot robot11 = new Robot("撞击器", Robot.EngineType.Land, 28, 23, 5, 410, 72, 62, 52, new int[2] { 8, 36 });
		Robot robot12 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 280, 85, 35, 78, new int[2] { 7, 8 });
		Robot robot13 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 280, 85, 35, 78, new int[2] { 7, 8 });
		Robot robot14 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 280, 85, 35, 78, new int[2] { 7, 8 });
		Robot robot15 = new Robot("比克", Robot.EngineType.Land, 37, 31, 4, 1200, 170, 100, 85, new int[2] { 46, 47 });
		Robot robot16 = new Robot("刚达", Robot.EngineType.Land, 36, 32, 5, 810, 165, 118, 88, new int[1] { 45 });
		Robot robot17 = new Robot("古尔", Robot.EngineType.Sky, 38, 33, 6, 3110, 192, 122, 132, new int[2] { 48, 49 });
		Robot robot18 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 7, 310, 68, 53, 78, new int[2] { 37, 38 });
		Robot robot19 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 7, 310, 68, 53, 78, new int[2] { 37, 38 });
		Robot robot20 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 7, 310, 68, 53, 78, new int[2] { 37, 38 });
		Robot robot21 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 7, 305, 67, 52, 77, new int[2] { 37, 38 });
		Robot robot22 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 7, 305, 67, 52, 77, new int[2] { 37, 38 });
		Robot robot23 = new Robot("古夫", Robot.EngineType.Land, 22, 17, 7, 405, 88, 66, 99, new int[2] { 27, 28 });
		User user = new User("士兵", 6, null);
		User user2 = new User("亨利", 22, null);
		User user3 = new User("萨米", 23, null);
		User user4 = new User("男爵", 24, null);
		User user5 = new User("拉尔", 13, null);
		m_FighterData.Add(8, new Fighter(26, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot)
		}, Define.AIType.Attack, 10, 0, 90, 100), 8));
		m_FighterData.Add(9, new Fighter(27, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot2)
		}, Define.AIType.Attack, 10, 0, 90, 100), 9));
		m_FighterData.Add(10, new Fighter(26, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot3)
		}, Define.AIType.Attack, 10, 0, 90, 100), 10));
		m_FighterData.Add(11, new Fighter(27, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot4)
		}, Define.AIType.Attack, 10, 0, 90, 100), 11));
		m_FighterData.Add(12, new Fighter(26, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot5)
		}, Define.AIType.Attack, 10, 0, 90, 100), 12));
		m_FighterData.Add(13, new Fighter(15, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Attack, 13, 0, 90, 80), 13));
		m_FighterData.Add(14, new Fighter(16, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Attack, 13, 0, 100, 10), 14));
		m_FighterData.Add(15, new Fighter(17, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Attack, 13, 0, 100, 10), 15));
		m_FighterData.Add(16, new Fighter(19, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot9)
		}, Define.AIType.Attack, 12, 0, 140, 100), 16));
		m_FighterData.Add(17, new Fighter(18, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot10)
		}, Define.AIType.Attack, 12, 0, 115, 100), 17));
		m_FighterData.Add(18, new Fighter(19, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot11)
		}, Define.AIType.Attack, 12, 0, 120, 100), 18));
		m_FighterData.Add(19, new Fighter(13, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot12)
		}, Define.AIType.Attack, 11, 0, 120, 100), 19));
		m_FighterData.Add(20, new Fighter(14, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot13)
		}, Define.AIType.Attack, 11, 0, 90, 80), 20));
		m_FighterData.Add(21, new Fighter(15, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot14)
		}, Define.AIType.Attack, 11, 0, 90, 80), 21));
		m_FighterData.Add(22, new Fighter(17, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot15)
		}, Define.AIType.Passivity, 21, 0, 200, 80), 22));
		m_FighterData.Add(23, new Fighter(2, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot16)
		}, Define.AIType.Patrol, 26, 0, 90, 80, 5, isSelf: true), 23));
		m_FighterData.Add(24, new Fighter(24, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot17)
		}, Define.AIType.Patrol, 42, 0, 160, 100), 24));
		m_FighterData.Add(25, new Fighter(19, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot18)
		}, Define.AIType.Attack, 13, 0, 90, 80), 25));
		m_FighterData.Add(26, new Fighter(20, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot19)
		}, Define.AIType.Attack, 13, 0, 90, 80), 26));
		m_FighterData.Add(27, new Fighter(21, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot20)
		}, Define.AIType.Attack, 13, 0, 90, 80), 27));
		m_FighterData.Add(28, new Fighter(21, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot21)
		}, Define.AIType.Attack, 12, 0, 90, 80), 28));
		m_FighterData.Add(29, new Fighter(22, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot22)
		}, Define.AIType.Attack, 12, 0, 90, 80), 29));
		m_FighterData.Add(30, new Fighter(24, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user5, robot23)
		}, Define.AIType.Attack, 18, 0, 90, 80), 30));
	}

	private void LoadEventData()
	{
		m_GameEvent.Add(-1, new GameEvent[7]
		{
			new GameEvent_PlayBGM(4),
			new GameEvent_MapLock(),
			new GameEvent_Dialogue("萨米......掩护我......别轻举妄动......", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("卡姆......", "发:", 21, Vector2.zero),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(5)
		});
		m_GameEvent.Add(0, new GameEvent[35]
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
			new GameEvent_LookFighter(22),
			new GameEvent_Dialogue("哈哈,追叛徒是居然碰上这些家伙.", "亨利:", 22, Vector2.zero),
			new GameEvent_Dialogue("没事!用萨米的刚达干掉他们!", "亨利:", 22, Vector2.zero),
			new GameEvent_LookFighter(23),
			new GameEvent_Dialogue("比克!卡姆,小心!那家伙很厉害!", "萨米:", 23, Vector2.zero),
			new GameEvent_SetAction(23, action: true),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(2, new GameEvent[35]
		{
			new GameEvent_LookFighter(23),
			new GameEvent_Dialogue("卡姆,没事吧?我来教训他!", "萨米:", 23, Vector2.zero),
			new GameEvent_LookFighter(5),
			new GameEvent_Dialogue("萨米,别走!", "卡姆:", 7, Vector2.zero),
			new GameEvent_MoveTo(23, 17, 9),
			new GameEvent_LookFighter(22),
			new GameEvent_Dialogue("哼!是萨米吗?你这个叛徒!", "亨利:", 22, Vector2.zero),
			new GameEvent_LookFighter(23),
			new GameEvent_Dialogue("卡姆不让我打你!", "萨米:", 23, Vector2.zero),
			new GameEvent_DoBattle(23, 0, 22),
			new GameEvent_AddFighter(24),
			new GameEvent_LookFighter(24),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_MoveTo(24, 17, 9),
			new GameEvent_LookFighter(24),
			new GameEvent_Dialogue("萨米,你在这儿?找你半天了!", "男爵:", 24, Vector2.zero),
			new GameEvent_Dialogue("亨利,抓紧了,马上要回航啦!", "男爵:", 24, Vector2.zero),
			new GameEvent_LookFighter(22),
			new GameEvent_Dialogue("是男爵吗?让你费心了!", "亨利:", 22, Vector2.zero),
			new GameEvent_LookFighter(23),
			new GameEvent_Dialogue("卡姆!快走开!", "萨米:", 23, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(23, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(22, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(24),
			new GameEvent_MoveTo(24, 20, 0),
			new GameEvent_LookFighter(3),
			new GameEvent_Dialogue("你!给我等着", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(24),
			new GameEvent_Dialogue("哼,我可没功夫和你们玩.", "男爵:", 24, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(24, -1),
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(9, new GameEvent[16]
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
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(11, new GameEvent[4]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(30),
			new GameEvent_LookFighter(30),
			new GameEvent_WaitTime(0.5f)
		});
	}
}
