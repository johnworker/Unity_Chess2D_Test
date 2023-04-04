using System.Collections.Generic;
using UnityEngine;

public class GameLevel_8 : Level
{
	public GameLevel_8()
	{
		m_Name = "第8篇: 圈套";
		m_Task = "破坏加恩即胜利,古莲被杀死就会失败.";
		m_Map = new Map(28, 20, new byte[560]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 7, 0,
			0, 0, 1, 1, 1, 1, 1, 4, 4, 4,
			4, 4, 4, 0, 2, 0, 0, 0, 0, 3,
			0, 0, 0, 0, 0, 0, 7, 7, 0, 0,
			0, 1, 1, 1, 1, 1, 4, 4, 2, 0,
			4, 0, 0, 0, 3, 0, 0, 0, 0, 0,
			3, 0, 0, 0, 0, 7, 0, 0, 2, 0,
			0, 1, 1, 1, 0, 0, 9, 3, 0, 0,
			0, 0, 2, 0, 0, 0, 0, 3, 3, 3,
			0, 0, 0, 7, 0, 0, 0, 3, 0, 2,
			0, 0, 0, 0, 0, 0, 0, 0, 6, 6,
			0, 0, 0, 0, 0, 0, 3, 3, 3, 0,
			0, 7, 7, 0, 0, 0, 0, 0, 2, 0,
			0, 0, 6, 6, 6, 0, 6, 6, 6, 6,
			0, 3, 0, 0, 0, 0, 3, 0, 0, 6,
			7, 7, 6, 6, 0, 0, 0, 0, 0, 6,
			6, 7, 7, 0, 6, 7, 7, 6, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 6, 7, 7,
			7, 6, 0, 3, 0, 0, 6, 6, 7, 7,
			7, 6, 6, 6, 7, 7, 0, 6, 0, 0,
			0, 0, 0, 0, 6, 6, 7, 7, 0, 0,
			0, 0, 0, 6, 6, 7, 7, 7, 7, 0,
			7, 7, 7, 7, 6, 6, 0, 0, 0, 6,
			6, 6, 6, 7, 7, 7, 0, 6, 6, 6,
			6, 7, 7, 7, 7, 7, 6, 6, 7, 7,
			7, 7, 6, 6, 0, 0, 0, 6, 7, 7,
			7, 7, 7, 7, 0, 7, 7, 7, 7, 7,
			7, 7, 7, 6, 0, 0, 7, 7, 7, 7,
			6, 6, 0, 0, 0, 0, 7, 7, 7, 7,
			7, 0, 0, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 0, 7, 7, 7, 7, 7, 7,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 3,
			0, 0, 0, 0, 7, 7, 7, 7, 7, 7,
			0, 0, 0, 7, 7, 7, 7, 7, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			0, 0, 7, 7, 7, 7, 7, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 3,
			0, 0, 0, 0, 0, 0, 0, 1, 1, 1,
			0, 7, 7, 7, 7, 7, 7, 0, 0, 0,
			1, 1, 1, 0, 0, 0, 0, 0, 0, 0,
			3, 0, 0, 0, 0, 0, 1, 1, 1, 0,
			7, 7, 7, 0, 0, 0, 1, 1, 1, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 1, 1, 0, 7, 7,
			0, 0, 0, 0, 0, 1, 1, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 1, 1, 1, 7, 7, 7, 0,
			0, 0, 0, 1, 1, 1, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 1, 1, 7, 0, 0, 0, 0, 1,
			1, 1, 1, 0, 0, 0, 0, 0, 0, 8,
			0, 0, 0, 0, 0, 0, 0, 0, 3, 0,
			0, 1, 0, 0, 0, 0, 1, 1, 1, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 3, 3, 0
		});
		AddShopEvent(new Define.Point(20, 2), new List<int> { 0, 1, 2, 3, 4, 5, 7, 8 });
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		m_Hospital.Add(new Define.Point(15, 18));
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(3, 1, GameDataBase.Instance.GetActor(10), 0));
		m_FighterData.Add(1, new Fighter(3, 3, GameDataBase.Instance.GetActor(4), 1));
		m_FighterData.Add(2, new Fighter(2, 4, GameDataBase.Instance.GetActor(5), 2));
		m_FighterData.Add(3, new Fighter(17, 15, GameDataBase.Instance.GetActor(3), 3));
		m_FighterData.Add(4, new Fighter(1, 3, GameDataBase.Instance.GetActor(9), 4));
		m_FighterData.Add(5, new Fighter(4, 2, GameDataBase.Instance.GetActor(6), 5));
		m_FighterData.Add(6, new Fighter(2, 2, GameDataBase.Instance.GetActor(7), 6));
		m_FighterData.Add(23, new Fighter(1, 1, GameDataBase.Instance.GetActor(0), 23));
		m_FighterData.Add(27, new Fighter(27, 0, GameDataBase.Instance.GetActor(12), 27));
		m_FighterData.Add(28, new Fighter(23, 2, GameDataBase.Instance.GetActor(13), 28));
		m_FighterData.Add(29, new Fighter(-1, -1, GameDataBase.Instance.GetActor(11), 29));
		m_FighterEvent.Add(28, new GameEvent[1]
		{
			new GameEvent_GameOver()
		});
		m_FighterEvent.Add(29, new GameEvent[1]
		{
			new GameEvent_SetFlag("MiBaX", value: false)
		});
		m_CapitulateMap.Add(3, new Dictionary<int, GameEvent[]> { 
		{
			21,
			new GameEvent[18]
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(3),
				new GameEvent_Dialogue("想起来了!你是米巴!", "加代:", 3, Vector2.zero),
				new GameEvent_Dialogue("爷爷设计的金Z的帕特纳机器人!", "加代:", 3, Vector2.zero),
				new GameEvent_LookFighter(21),
				new GameEvent_Dialogue("......!", "米巴X:", -1, Vector2.zero),
				new GameEvent_LookFighter(3),
				new GameEvent_Dialogue("这家伙好像不想打了?", "加代:", 3, Vector2.zero),
				new GameEvent_LookFighter(21),
				new GameEvent_Dialogue("......!", "米巴X:", -1, Vector2.zero),
				new GameEvent_LookFighter(3),
				new GameEvent_Dialogue("肯定是.这家伙是为了帮金Z而造出来的.", "加代:", 3, Vector2.zero),
				new GameEvent_Dialogue("好像损坏的帕特纳电路修好了.", "加代:", 3, Vector2.zero),
				new GameEvent_Dialogue("好!米巴跟我们一起走吗?", "加代:", 3, Vector2.zero),
				new GameEvent_Dialogue("你默认了，我们是战友了!", "加代:", 3, Vector2.zero),
				new GameEvent_Replace(21, 29),
				new GameEvent_SetFlag("MiBaX"),
				new GameEvent_MapUnlock()
			}
		} });
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("马登", Robot.EngineType.Land, 21, 14, 6, 425, 85, 58, 99, new int[2] { 25, 26 });
		Robot robot2 = new Robot("马登", Robot.EngineType.Land, 21, 14, 6, 425, 85, 58, 99, new int[2] { 25, 26 });
		Robot robot3 = new Robot("马登", Robot.EngineType.Land, 21, 14, 6, 425, 85, 58, 99, new int[2] { 25, 26 });
		Robot robot4 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 275, 80, 55, 85, new int[2] { 25, 26 });
		Robot robot5 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 275, 80, 55, 85, new int[2] { 25, 26 });
		Robot robot6 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 275, 80, 55, 85, new int[2] { 25, 26 });
		Robot robot7 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 285, 83, 58, 88, new int[2] { 25, 26 });
		Robot robot8 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 285, 83, 58, 88, new int[2] { 25, 26 });
		Robot robot9 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 285, 83, 58, 88, new int[2] { 25, 26 });
		Robot robot10 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 305, 93, 43, 86, new int[2] { 7, 8 });
		Robot robot11 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 305, 93, 43, 86, new int[2] { 7, 8 });
		Robot robot12 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 305, 93, 43, 86, new int[2] { 7, 8 });
		Robot robot13 = new Robot("古莲", Robot.EngineType.Land, 52, 43, 5, 530, 85, 35, 78, new int[2] { 61, 62 });
		Robot robot14 = new Robot("假古莲", Robot.EngineType.Sky, 53, 44, 7, 520, 81, 56, 61, new int[2] { 63, 64 });
		Robot robot15 = new Robot("米巴X", Robot.EngineType.Land, 51, 45, 5, 470, 96, 81, 74, new int[2] { 15, 60 }, new Define.UserTrait[1] { Define.UserTrait.XiuFuXiTong });
		Robot robot16 = new Robot("加恩", Robot.EngineType.Land, 49, 46, 7, 1260, 176, 97, 122, new int[2] { 65, 66 });
		Robot robot17 = new Robot("扎依", Robot.EngineType.Land, 45, 40, 4, 375, 101, 63, 53, new int[2] { 33, 36 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot18 = new Robot("扎依", Robot.EngineType.Land, 45, 40, 4, 375, 101, 63, 53, new int[2] { 33, 36 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot19 = new Robot("诺巴M9", Robot.EngineType.Land, 47, 39, 6, 370, 101, 58, 88, new int[2] { 54, 55 });
		User user = new User("士兵", 6, null);
		User user2 = new User("马丁", 30, null);
		User user3 = new User("假马丁", 30, null);
		User user4 = new User("肯特", 31, null);
		m_FighterData.Add(7, new Fighter(13, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot)
		}, Define.AIType.Attack, 16, 0, 120, 100), 7));
		m_FighterData.Add(8, new Fighter(14, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot2)
		}, Define.AIType.Attack, 16, 0, 120, 100), 8));
		m_FighterData.Add(9, new Fighter(15, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot3)
		}, Define.AIType.Attack, 16, 0, 120, 100), 9));
		m_FighterData.Add(10, new Fighter(11, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot4)
		}, Define.AIType.Attack, 14, 0, 90, 100), 10));
		m_FighterData.Add(11, new Fighter(11, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot5)
		}, Define.AIType.Attack, 14, 0, 90, 100), 11));
		m_FighterData.Add(12, new Fighter(11, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Attack, 14, 0, 90, 100), 12));
		m_FighterData.Add(13, new Fighter(24, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Attack, 16, 0, 90, 100), 13));
		m_FighterData.Add(14, new Fighter(23, 18, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Attack, 16, 0, 90, 100), 14));
		m_FighterData.Add(15, new Fighter(22, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Attack, 16, 0, 90, 100), 15));
		m_FighterData.Add(16, new Fighter(21, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot10)
		}, Define.AIType.Passivity, 16, 0, 90, 100), 16));
		m_FighterData.Add(17, new Fighter(22, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot11)
		}, Define.AIType.Passivity, 16, 0, 90, 100), 17));
		m_FighterData.Add(18, new Fighter(23, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot12)
		}, Define.AIType.Passivity, 16, 0, 90, 100), 18));
		m_FighterData.Add(19, new Fighter(17, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot13)
		}, Define.AIType.Passivity, 15, 0, 90, 100, -1, isSelf: true), 19));
		m_FighterData.Add(20, new Fighter(-1, -1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot14)
		}, Define.AIType.Attack, 15, 0, 100, 100), 20));
		m_FighterData.Add(21, new Fighter(17, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot15)
		}, Define.AIType.Attack, 18, 0, 90, 100), 21));
		m_FighterData.Add(22, new Fighter(24, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot16)
		}, Define.AIType.Passivity, 29, 0, 190, 100), 22));
		m_FighterData.Add(24, new Fighter(26, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot17)
		}, Define.AIType.Attack, 16, 0, 90, 100), 24));
		m_FighterData.Add(25, new Fighter(27, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot18)
		}, Define.AIType.Attack, 16, 0, 90, 100), 25));
		m_FighterData.Add(26, new Fighter(27, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot19)
		}, Define.AIType.Attack, 16, 0, 90, 100), 26));
	}

	private void LoadEventData()
	{
		m_AttackEvent = new GameEvent[1]
		{
			new GameEvent_SwitchNHP(22, 1259, new List<GameEvent>
			{
				new GameEvent_InspectSwitch("KenTe", 1, new List<GameEvent>(), new List<GameEvent>
				{
					new GameEvent_SetSwitch("KenTe", value: true),
					new GameEvent_LookFighter(22),
					new GameEvent_Dialogue("哼,厉害吧?再看这个!", "肯特:", 31, Vector2.zero),
					new GameEvent_AddFighter(28),
					new GameEvent_LookFighter(28),
					new GameEvent_WaitTime(0.5f),
					new GameEvent_LookFighter(3),
					new GameEvent_Dialogue("大介!", "加代:", 3, Vector2.zero),
					new GameEvent_LookFighter(2),
					new GameEvent_Dialogue("哼!你太无耻了!", "龙:", 5, Vector2.zero),
					new GameEvent_LookFighter(22),
					new GameEvent_Dialogue("哼......谢谢你的夸奖!", "肯特:", 31, Vector2.zero),
					new GameEvent_Dialogue("你还是乖乖地从机器上下来吧.", "肯特:", 31, Vector2.zero),
					new GameEvent_LookFighter(28),
					new GameEvent_Dialogue("大家别管我!", "马丁:", 30, Vector2.zero),
					new GameEvent_AddFighter(27),
					new GameEvent_LookFighter(27),
					new GameEvent_WaitTime(0.5f),
					new GameEvent_Dialogue("快,博思出马啦!", "布西:", 32, Vector2.zero),
					new GameEvent_LookFighter(22),
					new GameEvent_Dialogue("什么?就这笨拙的机器人?!", "肯特:", 31, Vector2.zero),
					new GameEvent_LookFighter(27),
					new GameEvent_Dialogue("让你见识见识博思的厉害!", "布西:", 32, Vector2.zero),
					new GameEvent_MoveTo(27, 24, 1),
					new GameEvent_DoBattle(27, 0, 22),
					new GameEvent_LookFighter(28),
					new GameEvent_Dialogue("快跑!", "马丁:", 30, Vector2.zero),
					new GameEvent_MoveTo(28, 24, 1),
					new GameEvent_DoBattle(28, 0, 22),
					new GameEvent_LookFighter(22),
					new GameEvent_Dialogue("啊,完了!让那笨拙的机器人打了!", "肯特:", 31, Vector2.zero),
					new GameEvent_Dialogue("嗯,这样的话,你们都要和我做伴啦!", "肯特:", 31, Vector2.zero)
				})
			}, new List<GameEvent>())
		};
		GameEvent[] value = new GameEvent[17]
		{
			new GameEvent_MapLock(),
			new GameEvent_PlayBGM(4),
			new GameEvent_Dialogue("啊,我的宝贝瓶子......", "肯特:", 31, Vector2.zero),
			new GameEvent_Dialogue("小子!记着点!", "肯特:", 31, Vector2.zero),
			new GameEvent_Dialogue("我可没有那么好的记性,", "路易:", 9, Vector2.zero),
			new GameEvent_Dialogue("敌人的进攻也激烈起来了.", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("我们也要调整一下战斗力.", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("眼看就要发生残酷的战争了.", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("龙说得对,我们有必要提高战斗力", "马丁:", 30, Vector2.zero),
			new GameEvent_Dialogue("嗯......把敌人的香港基地夺过来怎么样?", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("那儿应该有提高战斗力的装备.", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("发,可不是那么简单,敌人的香港基地有严密的防备.", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("发说的也有一些道理......太危险了,没必要这么试.", "乔:", 0, Vector2.zero),
			new GameEvent_GetFlag("KaEr", new List<GameEvent>
			{
				new GameEvent_Dialogue("那么,想办法虚张声势一下.", "卡尔:", 25, Vector2.zero),
				new GameEvent_Dialogue("乘阿格马去太慢,容易被敌人发现.", "卡尔:", 25, Vector2.zero),
				new GameEvent_Dialogue("好是好,不过太危险了!", "乔:", 0, Vector2.zero),
				new GameEvent_Dialogue("嗯......我已经做好准备了,反正这条命是捡来的.", "卡尔:", 25, Vector2.zero),
				new GameEvent_Dialogue("卡尔,别说不吉利的话!", "龙:", 5, Vector2.zero),
				new GameEvent_Dialogue("明白,那么,我先去了!", "卡尔:", 25, Vector2.zero)
			}, new List<GameEvent>()),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(8)
		};
		m_FighterEvent.Add(22, value);
		m_GameEvent.Add(-1, value);
		m_GameEvent.Add(0, new GameEvent[31]
		{
			new GameEvent_PlayBGM(4),
			new GameEvent_MapLock(),
			new GameEvent_AddFighter(3),
			new GameEvent_ChooseActor(3, new Actor.ActorData[1]
			{
				new Actor.ActorData(7, 16)
			}),
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
			new GameEvent_AddFighter(21),
			new GameEvent_AddFighter(22),
			new GameEvent_LookFighter(22),
			new GameEvent_Dialogue("哈哈......欢迎你，加代.", "肯特:", 31, Vector2.zero),
			new GameEvent_LookFighter(3),
			new GameEvent_Dialogue("好,我跟你走!放了大介.", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(22),
			new GameEvent_Dialogue("好,古莲就在你的眼前.", "肯特:", 31, Vector2.zero),
			new GameEvent_Dialogue("再不快点就无法挽回了.", "肯特:", 31, Vector2.zero),
			new GameEvent_LookFighter(3),
			new GameEvent_Dialogue("大介,你没事吧!", "加代:", 3, Vector2.zero),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(1, new GameEvent[6]
		{
			new GameEvent_Replace(19, 20),
			new GameEvent_LookFighter(20),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Dialogue("啊,被发现了!", "假马丁:", 30, Vector2.zero),
			new GameEvent_LookFighter(3),
			new GameEvent_Dialogue("哼,我早就预料到了!", "加代:", 3, Vector2.zero)
		});
		m_GameEvent.Add(2, new GameEvent[7]
		{
			new GameEvent_LookFighter(3),
			new GameEvent_Dialogue("嗯？那机器人我在哪里见过.", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("那和我的金Z很像.", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(21),
			new GameEvent_Dialogue("......", "米巴X:", -1, Vector2.zero),
			new GameEvent_LookFighter(3),
			new GameEvent_Dialogue("确实见过，叫什么来着?", "加代:", 3, Vector2.zero)
		});
		m_GameEvent.Add(3, new GameEvent[24]
		{
			new GameEvent_PlayBGM(2),
			new GameEvent_AddFighter(1),
			new GameEvent_LookFighter(1),
			new GameEvent_ChooseActor(1, new Actor.ActorData[1]
			{
				new Actor.ActorData(5, 23)
			}),
			new GameEvent_Dialogue("来得及吗？", "大卫:", 4, Vector2.zero),
			new GameEvent_AddFighter(5),
			new GameEvent_LookFighter(5),
			new GameEvent_ChooseActor(5, new Actor.ActorData[2]
			{
				new Actor.ActorData(4, 21),
				new Actor.ActorData(4, 22)
			}),
			new GameEvent_Dialogue("没事吧？", "卡姆:", 7, Vector2.zero),
			new GameEvent_AddFighter(2),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("其他都交给我们吧!", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("干得不错!", "欧文:", 10, Vector2.zero),
			new GameEvent_Dialogue("我们一来，马到成功!", "路易:", 9, Vector2.zero),
			new GameEvent_AddFighter(4),
			new GameEvent_LookFighter(4),
			new GameEvent_Dialogue("没事吧？", "发:", 21, Vector2.zero),
			new GameEvent_AddFighter(6),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("反击开始了！", "布克:", 15, Vector2.zero),
			new GameEvent_AddFighter(23),
			new GameEvent_LookFighter(23),
			new GameEvent_Dialogue("挺能坚持的嘛,加代!", "乔:", 0, Vector2.zero),
			new GameEvent_GetFlag("KaEr", new List<GameEvent>
			{
				new GameEvent_AddFighter(0),
				new GameEvent_LookFighter(0),
				new GameEvent_WaitTime(0.5f)
			}, new List<GameEvent>())
		});
		m_GameEvent.Add(10, new GameEvent[12]
		{
			new GameEvent_LookFighter(22),
			new GameEvent_Dialogue("还有跟强大的战斗呢!.", "肯特:", 31, Vector2.zero),
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(26),
			new GameEvent_LookFighter(26),
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
