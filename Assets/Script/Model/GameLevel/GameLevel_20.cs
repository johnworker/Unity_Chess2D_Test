using System.Collections.Generic;
using UnityEngine;

public class GameLevel_20 : Level
{
	public GameLevel_20()
	{
		m_Name = "第20篇: 决战古拉";
		m_Task = "全歼敌人即胜利!";
		m_Map = new Map(32, 20, new byte[640]
		{
			28, 28, 28, 28, 29, 28, 28, 28, 28, 28,
			28, 28, 32, 32, 28, 28, 28, 28, 28, 28,
			28, 39, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 32, 32, 28, 28, 29,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			29, 28, 28, 28, 28, 28, 29, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 32, 32,
			32, 28, 28, 32, 32, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 29, 28, 28, 28, 28, 32, 32, 28, 28,
			28, 28, 32, 32, 28, 29, 32, 32, 28, 28,
			28, 29, 28, 28, 28, 28, 29, 29, 29, 29,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 32,
			32, 28, 28, 28, 28, 28, 28, 28, 28, 32,
			32, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 28, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 32, 32, 28, 28, 28, 28, 28, 28,
			28, 32, 32, 32, 28, 28, 28, 28, 28, 28,
			28, 28, 33, 33, 37, 37, 37, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 34, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 37, 37, 37, 37, 33, 33,
			34, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			37, 37, 33, 33, 33, 33, 37, 37, 37, 33,
			33, 33, 33, 33, 36, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 37, 37, 33, 33, 33, 33, 33,
			33, 37, 33, 33, 33, 36, 36, 36, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			34, 33, 33, 33, 33, 33, 37, 37, 33, 33,
			36, 36, 33, 33, 33, 33, 33, 33, 36, 36,
			36, 33, 33, 33, 33, 33, 36, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 37, 37,
			33, 33, 33, 33, 37, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 37, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 37, 33, 33, 33, 33, 33, 36, 36, 33,
			33, 33, 33, 33, 33, 36, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 34,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			36, 36, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 36,
			33, 33, 36, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 34, 33, 33, 33, 33, 33, 37,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 36, 33, 33, 33,
			33, 33, 33, 36, 33, 33, 33, 33, 33, 33,
			33, 33, 37, 33, 33, 33, 33, 37, 33, 33,
			33, 33, 33, 33, 33, 36, 36, 33, 33, 33,
			37, 33, 36, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 37, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 36, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 37, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 36, 33, 33, 33, 33, 37, 37, 33,
			33, 33, 33, 33, 33, 33, 37, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 36, 36, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 37, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33
		});
		m_SelfBGM = 11;
		m_EnemyBGM = 10;
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(9, 13, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(8, 12, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(8, 14, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(6, 7, GameDataBase.Instance.GetActor(14), 3));
		m_FighterData.Add(4, new Fighter(4, 9, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(5, 10, GameDataBase.Instance.GetActor(13), 5));
		m_FighterData.Add(6, new Fighter(6, 9, GameDataBase.Instance.GetActor(16), 6));
		m_FighterData.Add(7, new Fighter(5, 6, GameDataBase.Instance.GetActor(9), 7));
		m_FighterData.Add(8, new Fighter(4, 7, GameDataBase.Instance.GetActor(7), 8));
		m_FighterData.Add(9, new Fighter(5, 8, GameDataBase.Instance.GetActor(0), 9));
		m_FighterData.Add(10, new Fighter(2, 8, GameDataBase.Instance.GetActor(17), 10));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("秀伯", Robot.EngineType.Land, 77, 67, 10, 2360, 204, 103, 149, new int[2] { 69, 94 });
		Robot robot2 = new Robot("古兰森", Robot.EngineType.Land, 102, 88, 8, 3940, 225, 225, 175, new int[2] { 132, 133 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot3 = new Robot("盖马", Robot.EngineType.Land, 87, 77, 6, 1270, 180, 104, 144, new int[2] { 65, 104 });
		Robot robot4 = new Robot("盖马", Robot.EngineType.Land, 87, 77, 6, 1250, 214, 100, 151, new int[2] { 65, 104 });
		Robot robot5 = new Robot("诺巴M9", Robot.EngineType.Land, 47, 39, 6, 530, 125, 82, 112, new int[2] { 54, 55 });
		Robot robot6 = new Robot("诺巴M9", Robot.EngineType.Land, 47, 39, 6, 530, 125, 82, 112, new int[2] { 54, 55 });
		Robot robot7 = new Robot("加姆", Robot.EngineType.Sky, 86, 75, 10, 410, 148, 78, 128, new int[1] { 101 });
		Robot robot8 = new Robot("邦巴", Robot.EngineType.Land, 66, 59, 5, 1320, 164, 87, 95, new int[2] { 33, 50 });
		Robot robot9 = new Robot("邦巴", Robot.EngineType.Land, 66, 59, 5, 1320, 164, 87, 95, new int[2] { 33, 50 });
		Robot robot10 = new Robot("伯希", Robot.EngineType.Land, 97, 85, 6, 1260, 177, 90, 115, new int[2] { 111, 112 });
		Robot robot11 = new Robot("伯希", Robot.EngineType.Land, 97, 85, 6, 1260, 177, 90, 115, new int[2] { 111, 112 });
		Robot robot12 = new Robot("伯希", Robot.EngineType.Land, 97, 85, 6, 1260, 177, 90, 115, new int[2] { 111, 112 });
		Robot robot13 = new Robot("切克", Robot.EngineType.Land, 20, 18, 6, 680, 112, 72, 82, new int[2] { 30, 31 });
		Robot robot14 = new Robot("切克", Robot.EngineType.Land, 20, 18, 6, 680, 112, 72, 82, new int[2] { 30, 31 });
		Robot robot15 = new Robot("拉比", Robot.EngineType.Land, 81, 72, 8, 365, 100, 82, 136, new int[2] { 69, 71 });
		Robot robot16 = new Robot("拉比", Robot.EngineType.Land, 81, 72, 8, 365, 100, 82, 136, new int[2] { 69, 71 });
		Robot robot17 = new Robot("布x1", Robot.EngineType.Land, 98, 86, 5, 870, 206, 92, 100, new int[2] { 110, 49 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot18 = new Robot("布x1", Robot.EngineType.Land, 98, 86, 5, 870, 206, 92, 100, new int[2] { 110, 49 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot19 = new Robot("伯希", Robot.EngineType.Land, 97, 85, 6, 1330, 191, 100, 125, new int[2] { 111, 112 });
		Robot robot20 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 365, 124, 70, 100, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot21 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 365, 124, 70, 100, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		User user = new User("士兵", 6, null);
		User user2 = new User("芬妮", 38, null);
		User user3 = new User("休", 57, null);
		User user4 = new User("温妮", 58, null);
		User user5 = new User("马休", 20, null);
		m_FighterData.Add(11, new Fighter(26, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot)
		}, Define.AIType.Counter, 37, 0, 155, 100), 11));
		m_FighterData.Add(12, new Fighter(27, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user5, robot3)
		}, Define.AIType.Counter, 36, 0, 130, 100), 12));
		m_FighterData.Add(13, new Fighter(27, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot4)
		}, Define.AIType.Counter, 34, 0, 130, 100), 13));
		m_FighterData.Add(14, new Fighter(18, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot10)
		}, Define.AIType.Attack, 32, 0, 190, 100), 14));
		m_FighterData.Add(15, new Fighter(19, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot8)
		}, Define.AIType.Attack, 32, 0, 140, 100), 15));
		m_FighterData.Add(16, new Fighter(17, 18, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot9)
		}, Define.AIType.Attack, 32, 0, 140, 100), 16));
		m_FighterData.Add(17, new Fighter(15, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Attack, 33, 0, 135, 100), 17));
		m_FighterData.Add(18, new Fighter(16, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot11)
		}, Define.AIType.Attack, 32, 0, 190, 100), 18));
		m_FighterData.Add(19, new Fighter(14, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot12)
		}, Define.AIType.Attack, 32, 0, 190, 100), 19));
		m_FighterData.Add(20, new Fighter(2, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot13)
		}, Define.AIType.Attack, 29, 0, 140, 100), 20));
		m_FighterData.Add(21, new Fighter(3, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot14)
		}, Define.AIType.Attack, 29, 0, 140, 100), 21));
		m_FighterData.Add(22, new Fighter(8, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot15)
		}, Define.AIType.Attack, 26, 0, 100, 100), 22));
		m_FighterData.Add(23, new Fighter(9, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot16)
		}, Define.AIType.Attack, 26, 0, 100, 100), 23));
		m_FighterData.Add(24, new Fighter(17, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot5)
		}, Define.AIType.Counter, 32, 0, 110, 100), 24));
		m_FighterData.Add(25, new Fighter(18, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot6)
		}, Define.AIType.Counter, 32, 0, 110, 100), 25));
		m_FighterData.Add(26, new Fighter(19, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot2)
		}, Define.AIType.Attack, 41, 0, 400, 5000, 13), 26));
		m_FighterData.Add(27, new Fighter(0, 8, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot17)
		}, Define.AIType.Attack, 30, 0, 190, 100), 27));
		m_FighterData.Add(28, new Fighter(0, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot18)
		}, Define.AIType.Attack, 30, 0, 190, 100), 28));
		m_FighterData.Add(29, new Fighter(31, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot19)
		}, Define.AIType.Attack, 39, 0, 190, 100), 29));
		m_FighterData.Add(30, new Fighter(31, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot20)
		}, Define.AIType.Attack, 30, 0, 100, 100), 30));
		m_FighterData.Add(31, new Fighter(31, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot21)
		}, Define.AIType.Attack, 30, 0, 100, 100), 31));
	}

	private void LoadEventData()
	{
		m_GameEvent.Add(-1, new GameEvent[9]
		{
			new GameEvent_MapLock(),
			new GameEvent_PlayBGM(4),
			new GameEvent_Dialogue("卡姆,以前打败你的就是这个......", "大卫:", 4, Vector2.zero),
			new GameEvent_Dialogue("嗯,休确实了得.", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("尽管如此,用这种腔调干嘛?", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("故弄玄虚,那小子就爱吓唬人.", "安东:", 27, Vector2.zero),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(20)
		});
		m_GameEvent.Add(0, new GameEvent[32]
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
			new GameEvent_LookFighter(9),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(1, new GameEvent[28]
		{
			new GameEvent_PlayBGM(9),
			new GameEvent_AddFighter(26),
			new GameEvent_LookFighter(26),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(4),
			new GameEvent_Dialogue("蓝色的机器人!", "卡姆:", 7, Vector2.zero),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("休!你怎么在这儿!", "安东:", 27, Vector2.zero),
			new GameEvent_LookFighter(26),
			new GameEvent_Dialogue("噢,安东吗?真巧啊!", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("你怎么也爱扎堆啦?", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("这不是装成一只狼了吗?", "休:", 57, Vector2.zero),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("你在想什么呢?在帮DC吗!", "安东:", 27, Vector2.zero),
			new GameEvent_LookFighter(26),
			new GameEvent_Dialogue("我说过了,我的想法是你无法理解的.", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("请把我介绍给那边的各位.", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("好像来了不少新面孔.", "休:", 57, Vector2.zero),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("哼!自己干!", "安东:", 27, Vector2.zero),
			new GameEvent_LookFighter(26),
			new GameEvent_Dialogue("是呀,没办法,我叫休.西拉卡娃", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("在这种情况下不得不见面,真有点不幸......", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("希望你们能谅解双方的处境.", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("我久仰各位大名,幸的相见.", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("各位不要客气.", "休:", 57, Vector2.zero),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("没见过这么讨厌的人......", "龙:", 5, Vector2.zero)
		});
		m_GameEvent.Add(5, new GameEvent[16]
		{
			new GameEvent_PlayME(3),
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
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(31),
			new GameEvent_LookFighter(31),
			new GameEvent_WaitTime(0.5f)
		});
		m_FighterEvent.Add(26, new GameEvent[11]
		{
			new GameEvent_LookFighter(26),
			new GameEvent_Dialogue("真了不起,我就没想到这一步.", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("为了表示敬意,这次放你走.", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("对,我就要你们记住这个.", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("你们现在一直掌握在贝克司令的手中", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("今后困难多着呢,但如果能克服的话......", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("只要努力就行了.", "休:", 57, Vector2.zero),
			new GameEvent_SetSuccess(4, 1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(26, -1),
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(7, new GameEvent[1]
		{
			new GameEvent_HasFighter(26, new List<GameEvent>
			{
				new GameEvent_LookFighter(26),
				new GameEvent_Dialogue("真了不起,我就没想到这一步.", "休:", 57, Vector2.zero),
				new GameEvent_Dialogue("为了表示敬意,这次放你走.", "休:", 57, Vector2.zero),
				new GameEvent_Dialogue("对,我就要你们记住这个.", "休:", 57, Vector2.zero),
				new GameEvent_Dialogue("你们现在一直掌握在贝克司令的手中", "休:", 57, Vector2.zero),
				new GameEvent_Dialogue("今后困难多着呢,但如果能克服的话......", "休:", 57, Vector2.zero),
				new GameEvent_Dialogue("只要努力就行了.", "休:", 57, Vector2.zero),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(26, -1),
				new GameEvent_WaitTime(0.5f)
			}, new List<GameEvent>())
		});
		m_GameEvent.Add(8, new GameEvent[2]
		{
			new GameEvent_ChooseAI(24, Define.AIType.Attack),
			new GameEvent_ChooseAI(25, Define.AIType.Attack)
		});
	}
}
