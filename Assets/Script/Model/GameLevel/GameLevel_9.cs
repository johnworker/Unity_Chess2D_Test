using System.Collections.Generic;
using UnityEngine;

public class GameLevel_9 : Level
{
	public GameLevel_9()
	{
		m_Name = "第9篇: 复仇";
		m_Task = "一定要破坏加恩!";
		m_Map = new Map(22, 32, new byte[704]
		{
			1, 1, 1, 0, 0, 0, 7, 7, 7, 7,
			7, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 1, 1, 1, 1, 0, 0, 4, 4,
			0, 0, 7, 7, 7, 0, 0, 0, 0, 0,
			0, 1, 1, 1, 1, 1, 1, 1, 0, 0,
			0, 0, 4, 4, 7, 7, 7, 7, 0, 0,
			0, 0, 0, 0, 0, 1, 0, 1, 1, 1,
			1, 0, 0, 0, 7, 7, 7, 7, 7, 7,
			0, 0, 0, 7, 7, 0, 0, 0, 0, 0,
			0, 1, 1, 0, 0, 7, 7, 7, 7, 7,
			7, 7, 7, 0, 3, 0, 7, 7, 7, 0,
			6, 6, 6, 6, 0, 1, 0, 0, 0, 7,
			7, 7, 7, 7, 7, 7, 0, 7, 7, 7,
			0, 0, 7, 7, 6, 6, 0, 0, 0, 0,
			3, 0, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 0, 0, 7, 7, 7, 6, 6, 6,
			0, 0, 0, 0, 0, 0, 7, 7, 7, 7,
			7, 7, 7, 0, 0, 0, 7, 7, 7, 7,
			7, 6, 6, 6, 0, 3, 3, 0, 0, 7,
			7, 7, 7, 7, 0, 0, 0, 0, 7, 7,
			7, 7, 7, 0, 0, 0, 0, 0, 0, 0,
			0, 6, 7, 7, 7, 7, 0, 0, 0, 3,
			7, 7, 7, 7, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			3, 3, 7, 7, 0, 0, 0, 0, 7, 7,
			6, 6, 4, 4, 0, 0, 0, 0, 0, 0,
			0, 0, 3, 3, 0, 0, 0, 7, 7, 7,
			7, 7, 7, 6, 0, 4, 3, 0, 6, 6,
			7, 7, 7, 7, 0, 0, 7, 0, 0, 0,
			0, 7, 7, 7, 7, 6, 0, 0, 2, 2,
			0, 6, 6, 7, 7, 7, 7, 7, 7, 7,
			0, 0, 0, 0, 7, 7, 7, 7, 7, 0,
			0, 2, 0, 0, 6, 7, 7, 7, 7, 7,
			7, 7, 7, 6, 6, 0, 0, 7, 7, 7,
			7, 7, 7, 0, 3, 6, 6, 7, 7, 7,
			7, 7, 7, 7, 6, 6, 1, 1, 2, 7,
			7, 7, 7, 7, 0, 0, 0, 0, 6, 6,
			7, 7, 7, 7, 7, 7, 6, 0, 1, 1,
			1, 0, 7, 7, 7, 7, 7, 7, 7, 0,
			0, 0, 7, 7, 7, 7, 7, 7, 7, 0,
			0, 0, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 8, 0, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 0, 0, 0, 0, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 2, 0, 0, 7,
			7, 7, 7, 7, 0, 0, 9, 0, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 0, 3,
			0, 2, 7, 7, 7, 7, 7, 0, 2, 0,
			0, 0, 7, 7, 7, 7, 7, 7, 7, 0,
			1, 1, 0, 7, 7, 7, 7, 7, 0, 0,
			0, 0, 0, 7, 7, 7, 7, 7, 7, 0,
			0, 1, 1, 0, 2, 0, 0, 0, 7, 7,
			0, 3, 2, 0, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 0, 0, 0,
			0, 0, 0, 2, 2, 0, 0, 0, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			0, 0, 0, 2, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 7, 7, 7, 7, 0, 0,
			0, 0, 0, 7, 0, 0, 0, 0, 4, 4,
			0, 0, 0, 0, 0, 0, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 0, 0, 0,
			4, 0, 0, 0, 0, 0, 0, 0, 7, 7,
			7, 7, 7, 7, 7, 7, 1, 0, 0, 0,
			0, 0, 0, 4, 0, 0, 0, 0, 0, 1,
			7, 7, 7, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 4, 0, 0, 0, 0, 0, 0,
			1, 1, 7, 7, 7, 7, 7, 0, 0, 0,
			0, 1, 1, 1, 0, 4, 4, 0, 0, 0,
			1, 1, 1, 1
		});
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		m_Hospital.Add(new Define.Point(15, 18));
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(12, 14, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(14, 14, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(14, 12, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(12, 12, GameDataBase.Instance.GetActor(9), 3));
		m_FighterData.Add(4, new Fighter(13, 11, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(11, 13, GameDataBase.Instance.GetActor(7), 5));
		m_FighterData.Add(6, new Fighter(13, 13, GameDataBase.Instance.GetActor(0), 6));
		m_FighterData.Add(7, new Fighter(12, 10, GameDataBase.Instance.GetActor(12), 7));
		m_FighterData.Add(8, new Fighter(11, 11, GameDataBase.Instance.GetActor(13), 8));
		m_FighterData.Add(9, new Fighter(12, 13, GameDataBase.Instance.GetActor(11), 9));
		m_FighterData.Add(10, new Fighter(0, 12, GameDataBase.Instance.GetActor(14), 10));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 295, 86, 61, 91, new int[2] { 25, 26 });
		Robot robot2 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 295, 86, 61, 91, new int[2] { 25, 26 });
		Robot robot3 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 295, 86, 61, 91, new int[2] { 25, 26 });
		Robot robot4 = new Robot("扎依", Robot.EngineType.Land, 45, 40, 4, 385, 104, 66, 56, new int[2] { 33, 36 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot5 = new Robot("扎依", Robot.EngineType.Land, 45, 40, 4, 385, 104, 66, 56, new int[2] { 33, 36 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot6 = new Robot("扎依", Robot.EngineType.Land, 45, 40, 4, 385, 104, 66, 56, new int[2] { 33, 36 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot7 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 305, 93, 43, 86, new int[2] { 7, 8 });
		Robot robot8 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 305, 93, 43, 86, new int[2] { 7, 8 });
		Robot robot9 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 305, 93, 43, 86, new int[2] { 7, 8 });
		Robot robot10 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 305, 76, 51, 66, new int[2] { 7, 29 });
		Robot robot11 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 305, 76, 51, 66, new int[2] { 7, 29 });
		Robot robot12 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 305, 76, 51, 66, new int[2] { 7, 29 });
		Robot robot13 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 236, 10, 90, new int[1] { 57 });
		Robot robot14 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 236, 10, 90, new int[1] { 57 });
		Robot robot15 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 236, 10, 90, new int[1] { 57 });
		Robot robot16 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 236, 10, 90, new int[1] { 57 });
		Robot robot17 = new Robot("加恩", Robot.EngineType.Land, 49, 46, 7, 1260, 176, 97, 122, new int[2] { 65, 66 });
		User user = new User("士兵", 6, null);
		User user2 = new User("肯特", 31, null);
		m_FighterData.Add(11, new Fighter(7, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot)
		}, Define.AIType.Attack, 18, 0, 90, 100), 11));
		m_FighterData.Add(12, new Fighter(7, 22, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot2)
		}, Define.AIType.Attack, 18, 0, 90, 100), 12));
		m_FighterData.Add(13, new Fighter(7, 23, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot3)
		}, Define.AIType.Attack, 18, 0, 90, 100), 13));
		m_FighterData.Add(14, new Fighter(8, 24, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot4)
		}, Define.AIType.Attack, 18, 0, 190, 100), 14));
		m_FighterData.Add(15, new Fighter(9, 24, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot5)
		}, Define.AIType.Attack, 18, 0, 190, 100), 15));
		m_FighterData.Add(16, new Fighter(10, 24, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot6)
		}, Define.AIType.Attack, 18, 0, 190, 100), 16));
		m_FighterData.Add(17, new Fighter(9, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot10)
		}, Define.AIType.Attack, 18, 0, 90, 100), 17));
		m_FighterData.Add(18, new Fighter(10, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot11)
		}, Define.AIType.Attack, 18, 0, 90, 100), 18));
		m_FighterData.Add(19, new Fighter(11, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot12)
		}, Define.AIType.Attack, 18, 0, 90, 100), 19));
		m_FighterData.Add(20, new Fighter(6, 24, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Passivity, 16, 0, 90, 100), 20));
		m_FighterData.Add(21, new Fighter(7, 25, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Passivity, 16, 0, 90, 100), 21));
		m_FighterData.Add(22, new Fighter(8, 26, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Passivity, 16, 0, 90, 100), 22));
		m_FighterData.Add(23, new Fighter(7, 23, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot13)
		}, Define.AIType.Attack, 19, 0, 25, 100), 23));
		m_FighterData.Add(24, new Fighter(7, 24, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot14)
		}, Define.AIType.Attack, 19, 0, 25, 100), 24));
		m_FighterData.Add(25, new Fighter(8, 24, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot15)
		}, Define.AIType.Attack, 19, 0, 25, 100), 25));
		m_FighterData.Add(26, new Fighter(8, 25, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot16)
		}, Define.AIType.Attack, 19, 0, 25, 100), 26));
		m_FighterData.Add(27, new Fighter(6, 25, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot17)
		}, Define.AIType.Passivity, 29, 0, 190, 100), 27));
	}

	private void LoadEventData()
	{
		GameEvent[] value = new GameEvent[9]
		{
			new GameEvent_MapLock(),
			new GameEvent_PlayBGM(4),
			new GameEvent_Dialogue("好像已经收拾掉了!", "马丁:", 30, Vector2.zero),
			new GameEvent_Dialogue("快去香港吧.", "乔:", 0, Vector2.zero),
			new GameEvent_GetFlag("MiBaX", new List<GameEvent>
			{
				new GameEvent_Dialogue("稍等一会!", "加代:", 3, Vector2.zero),
				new GameEvent_Dialogue("米巴的状态不正常!", "加代:", 3, Vector2.zero),
				new GameEvent_Dialogue("在哪......嗯......喂!这是......", "尤里:", 29, Vector2.zero),
				new GameEvent_Dialogue("瓦西博士,你是怎么想的.", "尤里:", 29, Vector2.zero),
				new GameEvent_Dialogue("是呀......的确如此......这可不行啊......", "瓦西:", 29, Vector2.zero),
				new GameEvent_Dialogue("怎么回事!博士,请说明白点!", "加代:", 3, Vector2.zero),
				new GameEvent_Dialogue("好像对方电路的一部分正超载呢!", "瓦西:", 29, Vector2.zero),
				new GameEvent_Dialogue("这个没有必要进行详细检查......", "莫里:", 53, Vector2.zero),
				new GameEvent_Dialogue("阿格马的装备没毛病可挑.", "莫里:", 53, Vector2.zero),
				new GameEvent_Dialogue("过一会米巴要在加洛基地加载吧.", "尤里:", 29, Vector2.zero),
				new GameEvent_Dialogue("要坎普的齐尔达帮助吗,加代君?", "瓦西:", 29, Vector2.zero),
				new GameEvent_Dialogue("......没办法,喂,米巴!稳当地取胜回来哦!", "加代:", 3, Vector2.zero)
			}, new List<GameEvent>()),
			new GameEvent_GetFlag("KaEr", new List<GameEvent>
			{
				new GameEvent_Dialogue("乔舰长!卡尔发来紧急呼叫!", "发:", 21, Vector2.zero),
				new GameEvent_Dialogue("怎么样了?", "乔:", 0, Vector2.zero),
				new GameEvent_Dialogue("对,对不起......我干的事......", "卡尔:", 25, Vector2.zero),
				new GameEvent_Dialogue("疏忽了......", "卡尔:", 25, Vector2.zero),
				new GameEvent_Dialogue("说明白点!到底怎么搞的!?", "龙:", 5, Vector2.zero),
				new GameEvent_Dialogue("在接近香......香港的途中和敌人......", "卡尔:", 25, Vector2.zero),
				new GameEvent_Dialogue("等着!马上去增援!你们在哪里!?", "龙:", 5, Vector2.zero),
				new GameEvent_Dialogue("蓝......蓝色机器人......高......", "卡尔:", 25, Vector2.zero),
				new GameEvent_Dialogue("卡尔!", "龙:", 5, Vector2.zero),
				new GameEvent_Dialogue("通讯......中断了......", "发:", 21, Vector2.zero),
				new GameEvent_Dialogue("蓝色机器人......是不是和我较量过的那种家伙?", "卡姆:", 7, Vector2.zero)
			}, new List<GameEvent>()),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(9)
		};
		m_FighterEvent.Add(27, value);
		m_GameEvent.Add(-1, value);
		m_GameEvent.Add(0, new GameEvent[27]
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
			new GameEvent_GetFlag("MiBaX", new List<GameEvent>
			{
				new GameEvent_AddFighter(9)
			}, new List<GameEvent>()),
			new GameEvent_AddFighter(27),
			new GameEvent_LookFighter(27),
			new GameEvent_Dialogue("各位来的正好,我正想一叙别情呢!", "肯特:", 31, Vector2.zero),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("讨厌的家伙!", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("居然敢一个人来,胆子还挺大.", "龙:", 5, Vector2.zero),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("小看我!我要让你体无完肤!", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(27),
			new GameEvent_Dialogue("嘿嘿......", "肯特:", 31, Vector2.zero),
			new GameEvent_LookFighter(2),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(1, new GameEvent[39]
		{
			new GameEvent_LookFighter(27),
			new GameEvent_Dialogue("送上门来了,我会好好收拾你们的!", "肯特:", 31, Vector2.zero),
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(11),
			new GameEvent_LookFighter(11),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(12),
			new GameEvent_LookFighter(12),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(13),
			new GameEvent_LookFighter(13),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(14),
			new GameEvent_LookFighter(14),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(15),
			new GameEvent_LookFighter(15),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(16),
			new GameEvent_LookFighter(16),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(17),
			new GameEvent_LookFighter(17),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(18),
			new GameEvent_LookFighter(18),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(19),
			new GameEvent_LookFighter(19),
			new GameEvent_WaitTime(0.5f),
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
		m_GameEvent.Add(2, new GameEvent[17]
		{
			new GameEvent_LookFighter(27),
			new GameEvent_Dialogue("哈......好戏还在后头呢!", "肯特:", 31, Vector2.zero),
			new GameEvent_Dialogue("我要让他知道我不是好惹的.", "肯特:", 31, Vector2.zero),
			new GameEvent_Dialogue("发射导弹!", "肯特:", 31, Vector2.zero),
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(23),
			new GameEvent_LookFighter(23),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(24),
			new GameEvent_LookFighter(24),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(25),
			new GameEvent_LookFighter(25),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(26),
			new GameEvent_LookFighter(26),
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(3, new GameEvent[12]
		{
			new GameEvent_AddFighter(10),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("久等了!刚才拜访了刚达Z!", "希塔:", 33, Vector2.zero),
			new GameEvent_LookFighter(0),
			new GameEvent_Dialogue("希塔?你不是被抓走了吗!?", "大卫:", 4, Vector2.zero),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("哈!虽说有点失误,但还是脱身了.", "希塔:", 33, Vector2.zero),
			new GameEvent_Dialogue("你好像有麻烦,要帮忙吗?", "希塔:", 33, Vector2.zero),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("希塔!请不要开玩笑,赶快去!", "乔:", 0, Vector2.zero),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("啊!乔依旧那么严厉呀.", "希塔:", 33, Vector2.zero)
		});
	}
}
