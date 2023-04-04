using System.Collections.Generic;
using UnityEngine;

public class GameLevel_3 : Level
{
	public GameLevel_3()
	{
		m_Name = "第3篇: 达卡尔之血";
		m_Task = "全歼敌人即胜利!";
		m_Map = new Map(16, 24, new byte[384]
		{
			15, 15, 15, 15, 26, 25, 25, 25, 17, 17,
			25, 25, 25, 25, 25, 25, 15, 15, 15, 26,
			26, 9, 25, 25, 17, 25, 25, 25, 25, 10,
			11, 25, 15, 15, 15, 15, 26, 26, 25, 25,
			17, 25, 25, 25, 25, 12, 13, 25, 15, 15,
			15, 15, 15, 16, 25, 25, 17, 26, 25, 25,
			25, 25, 25, 25, 15, 15, 15, 6, 16, 16,
			25, 25, 17, 25, 18, 26, 25, 25, 25, 25,
			15, 15, 6, 6, 6, 16, 25, 25, 17, 26,
			26, 25, 18, 18, 18, 25, 27, 27, 27, 6,
			6, 16, 16, 25, 17, 25, 25, 17, 17, 17,
			17, 17, 27, 27, 27, 27, 6, 6, 16, 25,
			25, 25, 18, 18, 18, 18, 26, 25, 27, 27,
			27, 27, 27, 6, 25, 18, 25, 25, 25, 26,
			18, 18, 18, 26, 27, 27, 27, 27, 27, 6,
			6, 25, 25, 25, 26, 18, 18, 18, 26, 26,
			27, 27, 27, 27, 27, 27, 6, 25, 25, 25,
			25, 26, 25, 18, 26, 26, 27, 27, 27, 27,
			27, 27, 6, 25, 25, 25, 26, 25, 25, 25,
			18, 25, 27, 27, 27, 27, 27, 27, 27, 27,
			25, 25, 25, 25, 25, 25, 26, 26, 27, 27,
			27, 27, 6, 6, 25, 27, 27, 27, 25, 25,
			26, 25, 25, 25, 27, 27, 27, 6, 6, 25,
			25, 18, 25, 27, 27, 27, 25, 25, 26, 15,
			27, 27, 27, 6, 25, 19, 18, 18, 25, 25,
			26, 27, 27, 27, 27, 27, 27, 27, 27, 6,
			25, 25, 26, 18, 25, 25, 25, 25, 25, 25,
			25, 15, 27, 27, 6, 6, 25, 25, 18, 25,
			25, 25, 25, 18, 25, 25, 15, 15, 27, 27,
			6, 25, 26, 25, 25, 25, 25, 25, 26, 25,
			25, 15, 15, 15, 27, 6, 6, 25, 18, 25,
			25, 25, 25, 25, 25, 25, 25, 15, 15, 15,
			6, 6, 26, 25, 25, 25, 25, 25, 18, 25,
			25, 25, 15, 15, 15, 15, 25, 25, 25, 25,
			25, 18, 25, 25, 26, 25, 16, 16, 15, 15,
			15, 15, 25, 26, 25, 25, 25, 26, 25, 25,
			25, 16, 16, 15, 15, 15, 15, 15, 26, 25,
			25, 25, 25, 25, 26, 25, 25, 16, 15, 15,
			15, 15, 15, 15
		});
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		m_Hospital.Add(new Define.Point(5, 15));
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(6, 18, GameDataBase.Instance.GetActor(0), 0));
		m_FighterData.Add(1, new Fighter(7, 17, GameDataBase.Instance.GetActor(4), 1));
		m_FighterData.Add(2, new Fighter(8, 16, GameDataBase.Instance.GetActor(5), 2));
		m_FighterData.Add(3, new Fighter(9, 17, GameDataBase.Instance.GetActor(3), 3));
		m_FighterData.Add(4, new Fighter(10, 18, GameDataBase.Instance.GetActor(2), 4));
		m_FighterData.Add(5, new Fighter(11, 19, GameDataBase.Instance.GetActor(6), 5));
		m_FighterData.Add(6, new Fighter(9, 23, GameDataBase.Instance.GetActor(7), 6));
		m_FighterData.Add(25, new Fighter(-1, -1, GameDataBase.Instance.GetActor(8), 25));
		m_CapitulateMap.Add(1, new Dictionary<int, GameEvent[]> { 
		{
			21,
			new GameEvent[33]
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(1),
				new GameEvent_Dialogue("你是,尼娜?", "大卫:", 4, Vector2.zero),
				new GameEvent_LookFighter(21),
				new GameEvent_Dialogue("大卫?为什么从来没见过面,却觉得很熟......?", "尼娜:", 16, Vector2.zero),
				new GameEvent_LookFighter(1),
				new GameEvent_Dialogue("尼娜也来打仗?", "大卫:", 4, Vector2.zero),
				new GameEvent_LookFighter(21),
				new GameEvent_Dialogue("我是为爱我的人们而战.", "尼娜:", 16, Vector2.zero),
				new GameEvent_LookFighter(1),
				new GameEvent_Dialogue("那太危险啦!", "大卫:", 4, Vector2.zero),
				new GameEvent_LookFighter(21),
				new GameEvent_Dialogue("人是不可能与世隔绝的", "尼娜:", 16, Vector2.zero),
				new GameEvent_LookFighter(1),
				new GameEvent_Dialogue("不是还有我吗?", "大卫:", 4, Vector2.zero),
				new GameEvent_LookFighter(21),
				new GameEvent_Dialogue("啊,大卫!", "尼娜:", 16, Vector2.zero),
				new GameEvent_LookFighter(17),
				new GameEvent_Dialogue("尼娜,别和那家伙开玩笑!", "凯:", 11, Vector2.zero),
				new GameEvent_LookFighter(1),
				new GameEvent_Dialogue("你是凯吗?", "大卫:", 4, Vector2.zero),
				new GameEvent_LookFighter(21),
				new GameEvent_Dialogue("不行!上校!", "尼娜:", 16, Vector2.zero),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(21, 25),
				new GameEvent_LookFighter(17),
				new GameEvent_Dialogue("怎么啦!?尼娜!", "凯:", 11, Vector2.zero),
				new GameEvent_LookFighter(25),
				new GameEvent_Dialogue("对不起,上校,我......", "尼娜:", 16, Vector2.zero),
				new GameEvent_LookFighter(17),
				new GameEvent_Dialogue("是么,我不拦你们了,你和尼娜随便吧!", "凯:", 11, Vector2.zero),
				new GameEvent_SetFlag("NiNa"),
				new GameEvent_MapUnlock()
			}
		} });
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("撞击器", Robot.EngineType.Land, 28, 23, 5, 330, 60, 50, 40, new int[2] { 8, 36 });
		Robot robot2 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 245, 68, 33, 48, new int[2] { 7, 29 });
		Robot robot3 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 245, 68, 33, 48, new int[2] { 7, 29 });
		Robot robot4 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 200, 46, 34, 61, new int[2] { 0, 1 });
		Robot robot5 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 200, 46, 34, 61, new int[2] { 0, 1 });
		Robot robot6 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 200, 46, 34, 61, new int[2] { 0, 1 });
		Robot robot7 = new Robot("哈衣", Robot.EngineType.Sea, 27, 24, 7, 225, 63, 46, 73, new int[1] { 33 });
		Robot robot8 = new Robot("哈衣", Robot.EngineType.Sea, 27, 24, 7, 225, 63, 46, 73, new int[1] { 33 });
		Robot robot9 = new Robot("哈衣", Robot.EngineType.Sea, 27, 24, 7, 225, 63, 46, 73, new int[1] { 33 });
		Robot robot10 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 250, 76, 26, 69, new int[2] { 7, 8 });
		Robot robot11 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 250, 76, 26, 69, new int[2] { 7, 8 });
		Robot robot12 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 250, 76, 26, 69, new int[2] { 7, 8 });
		Robot robot13 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 250, 76, 26, 69, new int[2] { 7, 8 });
		Robot robot14 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 8, 390, 80, 58, 90, new int[2] { 37, 38 });
		Robot robot15 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 8, 390, 80, 58, 90, new int[2] { 37, 38 });
		Robot robot16 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 8, 395, 85, 60, 92, new int[2] { 37, 38 });
		Robot robot17 = new Robot("扎克", Robot.EngineType.Land, 15, 7, 10, 500, 104, 66, 98, new int[2] { 0, 1 });
		Robot robot18 = new Robot("艾文", Robot.EngineType.Sky, 26, 22, 8, 410, 89, 60, 106, new int[2] { 34, 35 });
		User user = new User("士兵", 6, null);
		User user2 = new User("凯", 11, null);
		User user3 = new User("尼娜", 16, null);
		User user4 = new User("加纳", 17, null);
		User user5 = new User("麦克", 18, null);
		User user6 = new User("马斯", 19, null);
		m_FighterData.Add(7, new Fighter(2, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot4)
		}, Define.AIType.Attack, 5, 0, 90, 80), 7));
		m_FighterData.Add(8, new Fighter(3, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot5)
		}, Define.AIType.Attack, 5, 0, 90, 80), 8));
		m_FighterData.Add(9, new Fighter(4, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Attack, 5, 0, 90, 80), 9));
		m_FighterData.Add(10, new Fighter(2, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Passivity, 6, 0, 75, 100), 10));
		m_FighterData.Add(11, new Fighter(3, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Passivity, 6, 0, 75, 100), 11));
		m_FighterData.Add(12, new Fighter(4, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Passivity, 6, 0, 75, 100), 12));
		m_FighterData.Add(13, new Fighter(12, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot10)
		}, Define.AIType.Passivity, 5, 0, 90, 100), 13));
		m_FighterData.Add(14, new Fighter(13, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot11)
		}, Define.AIType.Passivity, 5, 0, 90, 100), 14));
		m_FighterData.Add(15, new Fighter(14, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot12)
		}, Define.AIType.Passivity, 5, 0, 90, 100), 15));
		m_FighterData.Add(16, new Fighter(15, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot13)
		}, Define.AIType.Passivity, 5, 0, 90, 100), 16));
		m_FighterData.Add(17, new Fighter(10, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot17)
		}, Define.AIType.Patrol, 13, 0, 110, 80), 17));
		m_FighterData.Add(18, new Fighter(12, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot2)
		}, Define.AIType.Attack, 6, 0, 115, 100), 18));
		m_FighterData.Add(19, new Fighter(14, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot3)
		}, Define.AIType.Attack, 6, 0, 115, 100), 19));
		m_FighterData.Add(20, new Fighter(13, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot)
		}, Define.AIType.Attack, 4, 0, 150, 100), 20));
		m_FighterData.Add(21, new Fighter(11, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot18)
		}, Define.AIType.Patrol, 10, 0, 80, 100), 21));
		m_FighterData.Add(22, new Fighter(2, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user5, robot14)
		}, Define.AIType.Attack, 13, 0, 105, 110), 22));
		m_FighterData.Add(23, new Fighter(4, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user6, robot15)
		}, Define.AIType.Attack, 13, 0, 105, 110), 23));
		m_FighterData.Add(24, new Fighter(3, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot16)
		}, Define.AIType.Attack, 14, 0, 105, 110), 24));
		m_FighterEvent.Add(21, new GameEvent[2]
		{
			new GameEvent_SetFlag("NiNa", value: false),
			new GameEvent_SetSuccess(7, 1)
		});
	}

	private void LoadEventData()
	{
		m_GameEvent.Add(-1, new GameEvent[13]
		{
			new GameEvent_PlayBGM(4),
			new GameEvent_MapLock(),
			new GameEvent_Dialogue("好,太利索了!", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("布克,你是怎么逃出来的......", "大卫:", 4, Vector2.zero),
			new GameEvent_Dialogue("我也不明白,囚禁我的基地受到攻击.", "布克:", 15, Vector2.zero),
			new GameEvent_Dialogue("我趁乱逃出来.", "布克:", 15, Vector2.zero),
			new GameEvent_Dialogue("真奇怪,除了我们居然还有人能攻击DC.", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("也许是敌人内乱......?", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("那么我们岂不是有了反击的机会?", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("总之不可大意,恐怕敌人会反扑,千万小心!", "乔:", 0, Vector2.zero),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(3)
		});
		m_GameEvent.Add(0, new GameEvent[41]
		{
			new GameEvent_PlayBGM(4),
			new GameEvent_MapLock(),
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
			new GameEvent_AddFighter(0),
			new GameEvent_AddFighter(1),
			new GameEvent_AddFighter(2),
			new GameEvent_AddFighter(3),
			new GameEvent_AddFighter(4),
			new GameEvent_AddFighter(5),
			new GameEvent_MapMove(7, 17),
			new GameEvent_Dialogue("......?", "大卫:", 4, Vector2.zero),
			new GameEvent_Dialogue("怎么啦,大卫?", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("你们没听见有人在叫我吗?", "大卫:", 4, Vector2.zero),
			new GameEvent_Dialogue("会是谁?", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("我们怎么没听见?", "路易:", 9, Vector2.zero),
			new GameEvent_Dialogue("像你这么粗心的人,怎么会听见呢.", "欧文:", 10, Vector2.zero),
			new GameEvent_Dialogue("尼娜?", "大卫:", 4, Vector2.zero),
			new GameEvent_MapMove(10, 1),
			new GameEvent_Dialogue("怎么,这种感觉?", "尼娜:", 16, Vector2.zero),
			new GameEvent_Dialogue("尼娜,你感觉到什么了?", "凯:", 11, Vector2.zero),
			new GameEvent_Dialogue("嗯,有一种心跳的感觉.", "尼娜:", 16, Vector2.zero),
			new GameEvent_Dialogue("......?", "凯:", 11, Vector2.zero),
			new GameEvent_Dialogue("......大卫?", "尼娜:", 16, Vector2.zero),
			new GameEvent_MapMove(6, 18),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(4, new GameEvent[22]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(22),
			new GameEvent_LookFighter(22),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(23),
			new GameEvent_LookFighter(23),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(24),
			new GameEvent_LookFighter(24),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Dialogue("哼,虎落平阳,你这种小人物也配和我交手.", "加纳:", 17, Vector2.zero),
			new GameEvent_Dialogue("完了,敌人的援军!", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("混蛋!在这种时候来!", "加代:", 3, Vector2.zero),
			new GameEvent_AddFighter(6),
			new GameEvent_LookFighter(6),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Dialogue("可没那么容易!", "布克:", 15, Vector2.zero),
			new GameEvent_MoveTo(6, 7, 17),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("终于追上了,大家没事吧!?", "布克:", 15, Vector2.zero),
			new GameEvent_Dialogue("布克!你是怎么逃回来的!?", "大卫:", 4, Vector2.zero),
			new GameEvent_Dialogue("这个以后再说,大卫!快把他们干掉!", "布克:", 15, Vector2.zero)
		});
		m_GameEvent.Add(8, new GameEvent[9]
		{
			new GameEvent_ChooseAI(13, Define.AIType.Attack),
			new GameEvent_ChooseAI(14, Define.AIType.Attack),
			new GameEvent_ChooseAI(15, Define.AIType.Attack),
			new GameEvent_ChooseAI(16, Define.AIType.Attack),
			new GameEvent_ChooseAI(10, Define.AIType.Attack),
			new GameEvent_ChooseAI(11, Define.AIType.Attack),
			new GameEvent_ChooseAI(12, Define.AIType.Attack),
			new GameEvent_ChooseAI(17, Define.AIType.Attack),
			new GameEvent_ChooseAI(21, Define.AIType.Attack)
		});
	}
}
