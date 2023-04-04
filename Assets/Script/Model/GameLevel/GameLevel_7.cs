using System.Collections.Generic;
using UnityEngine;

public class GameLevel_7 : Level
{
	public GameLevel_7()
	{
		m_Name = "第7篇: 决斗";
		m_Task = "打败拉英X";
		m_Map = new Map(20, 20, new byte[400]
		{
			23, 23, 23, 24, 24, 24, 24, 23, 21, 21,
			21, 21, 24, 24, 24, 24, 24, 24, 24, 23,
			23, 23, 24, 21, 21, 21, 21, 23, 20, 20,
			20, 20, 21, 21, 21, 21, 21, 21, 21, 23,
			23, 24, 21, 20, 20, 22, 20, 23, 20, 22,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 23,
			23, 21, 20, 20, 23, 20, 20, 23, 20, 20,
			20, 20, 22, 20, 20, 20, 20, 20, 20, 23,
			23, 20, 20, 20, 23, 20, 20, 24, 24, 24,
			24, 24, 24, 24, 24, 24, 20, 20, 20, 23,
			23, 20, 20, 20, 23, 20, 22, 21, 21, 21,
			21, 21, 21, 21, 21, 21, 20, 22, 20, 23,
			23, 20, 20, 20, 23, 20, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 22, 20, 20, 20, 23,
			23, 22, 20, 20, 23, 20, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 23, 23,
			23, 22, 20, 20, 23, 23, 23, 23, 23, 23,
			23, 23, 23, 23, 23, 23, 23, 23, 23, 23,
			23, 22, 22, 20, 23, 23, 24, 24, 24, 24,
			24, 24, 24, 24, 24, 24, 24, 24, 24, 23,
			23, 22, 22, 20, 23, 24, 21, 21, 21, 21,
			21, 21, 21, 21, 21, 21, 21, 21, 21, 23,
			23, 22, 22, 20, 23, 21, 20, 20, 20, 20,
			23, 23, 23, 23, 23, 23, 20, 20, 20, 23,
			23, 22, 20, 20, 23, 20, 20, 20, 20, 20,
			23, 23, 24, 24, 24, 24, 20, 22, 20, 23,
			24, 20, 20, 20, 23, 23, 20, 20, 20, 23,
			23, 23, 21, 21, 21, 21, 22, 22, 22, 23,
			21, 20, 20, 20, 23, 23, 23, 23, 23, 23,
			23, 23, 20, 20, 20, 20, 20, 22, 22, 23,
			20, 20, 20, 20, 24, 24, 24, 24, 24, 24,
			24, 24, 20, 20, 23, 23, 23, 20, 22, 23,
			23, 20, 20, 20, 21, 21, 21, 21, 21, 21,
			21, 21, 20, 20, 24, 24, 24, 20, 20, 23,
			23, 20, 20, 22, 22, 22, 20, 20, 20, 20,
			20, 20, 22, 20, 21, 21, 21, 22, 20, 23,
			23, 22, 20, 20, 22, 20, 20, 20, 20, 20,
			22, 20, 20, 20, 20, 20, 20, 20, 20, 23,
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
		m_FighterData.Add(0, new Fighter(13, 3, GameDataBase.Instance.GetActor(10), 0));
		m_FighterData.Add(1, new Fighter(11, 1, GameDataBase.Instance.GetActor(4), 1));
		m_FighterData.Add(2, new Fighter(9, 3, GameDataBase.Instance.GetActor(5), 2));
		m_FighterData.Add(3, new Fighter(11, 3, GameDataBase.Instance.GetActor(3), 3));
		m_FighterData.Add(4, new Fighter(12, 2, GameDataBase.Instance.GetActor(9), 4));
		m_FighterData.Add(5, new Fighter(10, 2, GameDataBase.Instance.GetActor(6), 5));
		m_FighterData.Add(6, new Fighter(9, 1, GameDataBase.Instance.GetActor(7), 6));
		m_FighterData.Add(7, new Fighter(8, 2, GameDataBase.Instance.GetActor(8), 7));
		m_FighterData.Add(32, new Fighter(7, 12, GameDataBase.Instance.GetActor(12), 32));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("马登", Robot.EngineType.Land, 21, 14, 6, 415, 82, 55, 96, new int[2] { 25, 26 });
		Robot robot2 = new Robot("马登", Robot.EngineType.Land, 21, 14, 6, 415, 82, 55, 96, new int[2] { 25, 26 });
		Robot robot3 = new Robot("马登", Robot.EngineType.Land, 21, 14, 6, 415, 82, 55, 96, new int[2] { 25, 26 });
		Robot robot4 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 275, 80, 55, 85, new int[2] { 25, 26 });
		Robot robot5 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 275, 80, 55, 85, new int[2] { 25, 26 });
		Robot robot6 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 295, 90, 40, 83, new int[2] { 7, 8 });
		Robot robot7 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 295, 90, 40, 83, new int[2] { 7, 8 });
		Robot robot8 = new Robot("扎依", Robot.EngineType.Land, 45, 40, 4, 365, 98, 60, 50, new int[2] { 33, 36 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot9 = new Robot("扎依", Robot.EngineType.Land, 45, 40, 4, 365, 98, 60, 50, new int[2] { 33, 36 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot10 = new Robot("诺巴M9", Robot.EngineType.Land, 47, 39, 6, 360, 99, 56, 86, new int[2] { 54, 55 });
		Robot robot11 = new Robot("诺巴M9", Robot.EngineType.Land, 47, 39, 6, 360, 99, 56, 86, new int[2] { 54, 55 });
		Robot robot12 = new Robot("诺巴M9", Robot.EngineType.Land, 47, 39, 6, 360, 99, 56, 86, new int[2] { 54, 55 });
		Robot robot13 = new Robot("拉英X", Robot.EngineType.Land, 46, 41, 5, 930, 128, 75, 78, new int[1] { 56 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot14 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 265, 74, 39, 54, new int[2] { 7, 29 });
		Robot robot15 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 265, 74, 39, 54, new int[2] { 7, 29 });
		Robot robot16 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 265, 74, 39, 54, new int[2] { 7, 29 });
		Robot robot17 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 265, 74, 39, 54, new int[2] { 7, 29 });
		Robot robot18 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 265, 74, 39, 54, new int[2] { 7, 29 });
		Robot robot19 = new Robot("宰恩II", Robot.EngineType.Land, 4, 8, 5, 590, 102, 66, 70, new int[2] { 2, 3 });
		Robot robot20 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 295, 103, 49, 79, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot21 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 295, 103, 49, 79, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot22 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 295, 103, 49, 79, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot23 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 295, 103, 49, 79, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot24 = new Robot("巴斯塔", Robot.EngineType.Land, 44, 38, 10, 360, 120, 64, 105, new int[1] { 53 });
		User user = new User("士兵", 6, null);
		User user2 = new User("安东", 17, null);
		User user3 = new User("希拉", 28, null);
		m_FighterData.Add(8, new Fighter(1, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot)
		}, Define.AIType.Attack, 14, 0, 120, 100), 8));
		m_FighterData.Add(9, new Fighter(2, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot2)
		}, Define.AIType.Attack, 14, 0, 120, 100), 9));
		m_FighterData.Add(10, new Fighter(3, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot3)
		}, Define.AIType.Attack, 14, 0, 120, 100), 10));
		m_FighterData.Add(11, new Fighter(16, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot4)
		}, Define.AIType.Attack, 14, 0, 90, 100), 11));
		m_FighterData.Add(12, new Fighter(17, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot5)
		}, Define.AIType.Attack, 14, 0, 90, 100), 12));
		m_FighterData.Add(13, new Fighter(13, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Attack, 14, 0, 90, 100), 13));
		m_FighterData.Add(14, new Fighter(14, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Attack, 14, 0, 90, 100), 14));
		m_FighterData.Add(15, new Fighter(5, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot8)
		}, Define.AIType.Attack, 14, 0, 190, 100), 15));
		m_FighterData.Add(16, new Fighter(5, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot9)
		}, Define.AIType.Attack, 14, 0, 190, 100), 16));
		m_FighterData.Add(17, new Fighter(3, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot10)
		}, Define.AIType.Passivity, 15, 0, 110, 100), 17));
		m_FighterData.Add(18, new Fighter(2, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot11)
		}, Define.AIType.Passivity, 15, 0, 110, 100), 18));
		m_FighterData.Add(19, new Fighter(3, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot12)
		}, Define.AIType.Passivity, 15, 0, 110, 100), 19));
		m_FighterData.Add(20, new Fighter(13, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot13)
		}, Define.AIType.Counter, 21, 0, 175, 100), 20));
		m_FighterData.Add(21, new Fighter(1, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot14)
		}, Define.AIType.Attack, 10, 0, 90, 100), 21));
		m_FighterData.Add(22, new Fighter(1, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot15)
		}, Define.AIType.Attack, 10, 0, 90, 100), 22));
		m_FighterData.Add(23, new Fighter(1, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot16)
		}, Define.AIType.Attack, 10, 0, 90, 100), 23));
		m_FighterData.Add(24, new Fighter(2, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot17)
		}, Define.AIType.Attack, 10, 0, 90, 100), 24));
		m_FighterData.Add(25, new Fighter(3, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot18)
		}, Define.AIType.Attack, 10, 0, 90, 100), 25));
		m_FighterData.Add(26, new Fighter(17, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot19)
		}, Define.AIType.Attack, 18, 0, 90, 100), 26));
		m_FighterData.Add(27, new Fighter(18, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot20)
		}, Define.AIType.Attack, 16, 0, 100, 100), 27));
		m_FighterData.Add(28, new Fighter(16, 18, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot21)
		}, Define.AIType.Attack, 16, 0, 100, 100), 28));
		m_FighterData.Add(29, new Fighter(15, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot22)
		}, Define.AIType.Attack, 16, 0, 100, 100), 29));
		m_FighterData.Add(30, new Fighter(17, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot23)
		}, Define.AIType.Attack, 16, 0, 100, 100), 30));
		m_FighterData.Add(31, new Fighter(16, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot24)
		}, Define.AIType.Passivity, 16, 0, 90, 80, 2, isSelf: true), 31));
	}

	private void LoadEventData()
	{
		GameEvent[] value = new GameEvent[19]
		{
			new GameEvent_MapLock(),
			new GameEvent_PlayBGM(4),
			new GameEvent_Dialogue("我败了......为了表示敬意.", "希拉:", 28, Vector2.zero),
			new GameEvent_Dialogue("告诉你们个情报.", "希拉:", 28, Vector2.zero),
			new GameEvent_Dialogue("你们的同伴古莲被代沙抓住了.", "希拉:", 28, Vector2.zero),
			new GameEvent_Dialogue("小心肯特的诡计.", "希拉:", 28, Vector2.zero),
			new GameEvent_AddFighter(32),
			new GameEvent_LookFighter(32),
			new GameEvent_Dialogue("啊,谢谢,多亏你救了我!", "布西:", 32, Vector2.zero),
			new GameEvent_Dialogue("这不是布西吗!你怎么也在这？", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("哎呀!加代,我本来想帮忙,反而被抓了.", "布西:", 32, Vector2.zero),
			new GameEvent_Dialogue("真没办法!你不该到处乱跑!", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("我现在能帮什么忙吗?", "布西:", 32, Vector2.zero),
			new GameEvent_Dialogue("博思已经多余了,你就别添乱了,大家出发!", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("嗨!你和加代一样混蛋!让我干什么都行!", "布西:", 32, Vector2.zero),
			new GameEvent_GetFlag("NiNa", new List<GameEvent>
			{
				new GameEvent_Dialogue("我......留在加洛基地.", "尼娜:", 16, Vector2.zero),
				new GameEvent_Dialogue("为什么?", "大卫:", 4, Vector2.zero),
				new GameEvent_Dialogue("大家去敖德萨吧?", "尼娜:", 16, Vector2.zero),
				new GameEvent_Dialogue("那里有大佐......", "尼娜:", 16, Vector2.zero),
				new GameEvent_Dialogue("不,有个叫凯的.", "尼娜:", 16, Vector2.zero),
				new GameEvent_Dialogue("凯是我的救命恩人.", "尼娜:", 16, Vector2.zero),
				new GameEvent_Dialogue("怎么也不能和他正面相斗......", "尼娜:", 16, Vector2.zero),
				new GameEvent_Dialogue("是吗......", "大卫:", 4, Vector2.zero),
				new GameEvent_Dialogue("那尼娜留在这里保护凯文.", "大卫:", 4, Vector2.zero),
				new GameEvent_Dialogue("大卫真行......", "尼娜:", 16, Vector2.zero)
			}, new List<GameEvent>()),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(7)
		};
		m_FighterEvent.Add(20, value);
		m_GameEvent.Add(-1, value);
		m_GameEvent.Add(0, new GameEvent[46]
		{
			new GameEvent_PlayBGM(4),
			new GameEvent_MapLock(),
			new GameEvent_AddFighter(1),
			new GameEvent_AddFighter(2),
			new GameEvent_AddFighter(3),
			new GameEvent_AddFighter(5),
			new GameEvent_AddFighter(6),
			new GameEvent_AddFighter(4),
			new GameEvent_GetFlag("NiNa", new List<GameEvent>
			{
				new GameEvent_AddFighter(7)
			}, new List<GameEvent>()),
			new GameEvent_GetFlag("KaEr", new List<GameEvent>
			{
				new GameEvent_AddFighter(0)
			}, new List<GameEvent>()),
			new GameEvent_AddFighter(31),
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
			new GameEvent_LookFighter(31),
			new GameEvent_Dialogue("哼!跑了.丑八怪!", "安东:", 27, Vector2.zero),
			new GameEvent_LookFighter(4),
			new GameEvent_Dialogue("你到底是谁?", "发:", 21, Vector2.zero),
			new GameEvent_LookFighter(31),
			new GameEvent_Dialogue("我?我叫安东.", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("这是巴斯塔,是我的宝贝.", "安东:", 27, Vector2.zero),
			new GameEvent_LookFighter(3),
			new GameEvent_Dialogue("巴斯塔?没听说过.", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(31),
			new GameEvent_Dialogue("记住就行了,以后向你解释.", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("我还有事要办,再会!", "安东:", 27, Vector2.zero),
			new GameEvent_MoveTo(31, 11, 0),
			new GameEvent_LookFighter(31),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(31, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("那家伙到底是谁......", "布克:", 15, Vector2.zero),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(6, new GameEvent[16]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(21),
			new GameEvent_LookFighter(21),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(22),
			new GameEvent_LookFighter(22),
			new GameEvent_WaitTime(0.5f),
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
		m_GameEvent.Add(8, new GameEvent[19]
		{
			new GameEvent_PlayME(3),
			new GameEvent_ChooseAI(17, Define.AIType.Attack),
			new GameEvent_ChooseAI(18, Define.AIType.Attack),
			new GameEvent_ChooseAI(19, Define.AIType.Attack),
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
		m_GameEvent.Add(22, new GameEvent[7]
		{
			new GameEvent_LookFighter(20),
			new GameEvent_Dialogue("这样就算打完了吗......", "希拉:", 28, Vector2.zero),
			new GameEvent_Dialogue("你们这些可怜虫!", "希拉:", 28, Vector2.zero),
			new GameEvent_Dialogue("你们如果还算是战士的话.", "希拉:", 28, Vector2.zero),
			new GameEvent_Dialogue("就堂堂正正地和我决一胜负!", "希拉:", 28, Vector2.zero),
			new GameEvent_ChooseAI(20, Define.AIType.Attack),
			new GameEvent_HasFighter(6, new List<GameEvent>
			{
				new GameEvent_LookFighter(6),
				new GameEvent_Dialogue("真不要脸......", "布克:", 15, Vector2.zero)
			}, new List<GameEvent>())
		});
	}
}
