using System.Collections.Generic;
using UnityEngine;

public class GameLevel_2 : Level
{
	public GameLevel_2()
	{
		m_Name = "第2篇: 凶街";
		m_Task = "全歼敌人即胜利!";
		m_Map = new Map(32, 15, new byte[480]
		{
			1, 1, 1, 1, 3, 3, 3, 3, 3, 1,
			1, 1, 1, 1, 1, 1, 3, 3, 0, 0,
			0, 0, 0, 0, 0, 0, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 3,
			3, 3, 1, 1, 1, 1, 1, 3, 3, 3,
			3, 0, 0, 0, 3, 3, 0, 2, 2, 10,
			11, 1, 1, 1, 1, 1, 1, 1, 1, 2,
			9, 3, 3, 3, 3, 1, 1, 1, 1, 1,
			3, 8, 3, 0, 0, 3, 3, 0, 0, 0,
			2, 12, 13, 1, 1, 1, 0, 0, 1, 1,
			2, 0, 0, 0, 2, 3, 0, 0, 1, 1,
			1, 3, 3, 0, 0, 0, 0, 0, 0, 0,
			3, 0, 0, 3, 3, 1, 1, 1, 0, 0,
			0, 0, 0, 2, 2, 0, 0, 0, 1, 1,
			1, 1, 1, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 3, 2, 3, 3, 1, 1,
			0, 0, 0, 0, 0, 0, 0, 2, 2, 1,
			1, 1, 1, 1, 1, 1, 0, 0, 0, 0,
			0, 0, 0, 0, 3, 0, 0, 3, 3, 3,
			1, 1, 0, 0, 4, 0, 0, 0, 3, 0,
			0, 0, 0, 1, 1, 1, 1, 0, 0, 0,
			3, 0, 0, 0, 3, 0, 0, 3, 3, 3,
			3, 3, 3, 3, 0, 0, 0, 2, 0, 0,
			2, 0, 0, 0, 0, 0, 1, 1, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 3, 3, 1, 1, 0, 0, 0, 0,
			0, 0, 0, 0, 2, 0, 0, 0, 0, 0,
			3, 0, 0, 0, 6, 6, 6, 0, 0, 0,
			0, 0, 1, 1, 1, 1, 1, 1, 3, 0,
			0, 2, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 6, 6, 7, 6, 6,
			6, 1, 1, 1, 1, 1, 7, 7, 7, 7,
			0, 3, 0, 0, 2, 2, 3, 0, 0, 0,
			0, 1, 1, 1, 0, 6, 6, 6, 7, 7,
			7, 7, 6, 6, 1, 6, 7, 7, 7, 1,
			1, 1, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 1, 1, 1, 1, 1, 1, 6, 7, 7,
			7, 7, 7, 7, 7, 6, 6, 6, 7, 6,
			1, 3, 3, 1, 3, 3, 3, 0, 0, 2,
			0, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 6, 6, 6, 9, 3, 3, 3, 3, 3,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 6, 6, 6, 3, 3,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 6
		});
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		AddShopEvent(new Define.Point(6, 2), new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 });
		m_Hospital.Add(new Define.Point(17, 2));
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(1, 6, GameDataBase.Instance.GetActor(0), 0));
		m_FighterData.Add(1, new Fighter(1, 8, GameDataBase.Instance.GetActor(4), 1));
		m_FighterData.Add(2, new Fighter(1, 10, GameDataBase.Instance.GetActor(5), 2));
		m_FighterData.Add(3, new Fighter(2, 5, GameDataBase.Instance.GetActor(3), 3));
		m_FighterData.Add(4, new Fighter(2, 7, GameDataBase.Instance.GetActor(2), 4));
		m_FighterData.Add(5, new Fighter(2, 9, GameDataBase.Instance.GetActor(6), 5));
		m_FighterData.Add(6, new Fighter(8, 0, GameDataBase.Instance.GetActor(1), 6));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 190, 43, 31, 58, new int[2] { 0, 1 });
		Robot robot2 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 190, 43, 31, 58, new int[2] { 0, 1 });
		Robot robot3 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 190, 43, 31, 58, new int[2] { 0, 1 });
		Robot robot4 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 195, 45, 33, 60, new int[2] { 0, 1 });
		Robot robot5 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 195, 45, 33, 60, new int[2] { 0, 1 });
		Robot robot6 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 195, 45, 33, 60, new int[2] { 0, 1 });
		Robot robot7 = new Robot("古夫", Robot.EngineType.Land, 22, 17, 4, 235, 47, 37, 63, new int[2] { 27, 28 });
		Robot robot8 = new Robot("古夫", Robot.EngineType.Land, 22, 17, 4, 235, 47, 37, 63, new int[2] { 27, 28 });
		Robot robot9 = new Robot("马登", Robot.EngineType.Land, 21, 14, 7, 375, 80, 48, 94, new int[2] { 25, 26 });
		Robot robot10 = new Robot("马登", Robot.EngineType.Land, 21, 14, 9, 530, 91, 52, 95, new int[2] { 25, 26 });
		Robot robot11 = new Robot("切克", Robot.EngineType.Land, 20, 18, 6, 440, 76, 36, 46, new int[2] { 30, 31 });
		Robot robot12 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 235, 65, 30, 45, new int[2] { 7, 29 });
		Robot robot13 = new Robot("盖塔Q", Robot.EngineType.Land, 23, 15, 5, 340, 81, 51, 71, new int[2] { 32, 20 }, new Define.UserTrait[1] { Define.UserTrait.KuoNengZhuangZhi });
		Robot robot14 = new Robot("盖塔Q", Robot.EngineType.Land, 24, 19, 5, 340, 81, 51, 71, new int[2] { 32, 20 }, new Define.UserTrait[1] { Define.UserTrait.KuoNengZhuangZhi });
		Robot robot15 = new Robot("古夫", Robot.EngineType.Land, 22, 17, 7, 365, 76, 54, 87, new int[2] { 27, 28 });
		Robot robot16 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 190, 43, 31, 58, new int[2] { 0, 1 });
		Robot robot17 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 195, 45, 33, 60, new int[2] { 0, 1 });
		User user = new User("士兵", 6, null);
		User user2 = new User("修斯", 6, null);
		User user3 = new User("杰夫", 6, null);
		User user4 = new User("保罗", 12, null);
		User user5 = new User("里卡", 14, null);
		User user6 = new User("米奇尔", 8, null);
		User user7 = new User("拉尔", 13, null);
		m_FighterData.Add(7, new Fighter(9, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user6, robot13)
		}, Define.AIType.Attack, 5, 0, 50, 100), 7));
		m_FighterData.Add(8, new Fighter(16, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot)
		}, Define.AIType.Attack, 3, 0, 90, 80), 8));
		m_FighterData.Add(9, new Fighter(16, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot2)
		}, Define.AIType.Attack, 3, 0, 90, 80), 9));
		m_FighterData.Add(10, new Fighter(16, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot3)
		}, Define.AIType.Attack, 3, 0, 90, 80), 10));
		m_FighterData.Add(11, new Fighter(20, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot4)
		}, Define.AIType.Attack, 4, 0, 90, 80), 11));
		m_FighterData.Add(12, new Fighter(20, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot5)
		}, Define.AIType.Attack, 4, 0, 90, 80), 12));
		m_FighterData.Add(13, new Fighter(20, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Attack, 4, 0, 90, 80), 13));
		m_FighterData.Add(14, new Fighter(23, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Patrol, 4, 0, 100, 10), 14));
		m_FighterData.Add(15, new Fighter(23, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Patrol, 4, 0, 100, 10), 15));
		m_FighterData.Add(16, new Fighter(18, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot11)
		}, Define.AIType.Attack, 5, 0, 140, 100), 16));
		m_FighterData.Add(17, new Fighter(23, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot12)
		}, Define.AIType.Attack, 4, 0, 115, 100), 17));
		m_FighterData.Add(18, new Fighter(26, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user5, robot9)
		}, Define.AIType.Passivity, 6, 0, 120, 100), 18));
		m_FighterData.Add(19, new Fighter(26, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot10)
		}, Define.AIType.Passivity, 7, 0, 120, 100), 19));
		m_FighterData.Add(20, new Fighter(19, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot16)
		}, Define.AIType.Attack, 3, 0, 90, 80), 20));
		m_FighterData.Add(21, new Fighter(21, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot17)
		}, Define.AIType.Attack, 4, 0, 90, 80), 21));
		m_FighterData.Add(22, new Fighter(20, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user7, robot15)
		}, Define.AIType.Attack, 10, 0, 100, 10), 22));
		m_FighterData.Add(23, new Fighter(-1, -1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user6, robot14)
		}, Define.AIType.Attack, 5, 0, 50, 100, 3, isSelf: true), 23));
	}

	private void LoadEventData()
	{
		HashSet<Define.Point> hashSet = new HashSet<Define.Point>();
		for (int i = 0; i < 32; i++)
		{
			for (int j = 0; j < 15; j++)
			{
				if (i == 0 || j == 0 || i == 31 || j == 14)
				{
					hashSet.Add(new Define.Point(i, j));
				}
			}
		}
		GameEvent gameEvent = new GameEvent_InspectSwitch("BaoLuo", 1, new List<GameEvent>
		{
			new GameEvent_PosSwitchID(19, hashSet, new List<GameEvent>
			{
				new GameEvent_LookFighter(19),
				new GameEvent_Dialogue("下次相遇,我绝对不会客气", "保罗:", 12, Vector2.zero),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(19, -1),
				new GameEvent_WaitTime(0.5f)
			})
		}, new List<GameEvent>());
		m_MoveOverEvent = new GameEvent[1] { gameEvent };
		m_GameEventEvery = new GameEvent[2]
		{
			new GameEvent_InspectSwitch("BaoLuo", 1, new List<GameEvent>(), new List<GameEvent>
			{
				new GameEvent_SwitchNHP(19, 200, new List<GameEvent>
				{
					new GameEvent_LookFighter(19),
					new GameEvent_Dialogue("啊!敌人太厉害了!没办法!", "保罗:", 12, Vector2.zero),
					new GameEvent_ChooseAI(19, Define.AIType.Retreat),
					new GameEvent_SetSwitch("BaoLuo", value: true)
				}, new List<GameEvent>())
			}),
			gameEvent
		};
		m_GameEvent.Add(-1, new GameEvent[18]
		{
			new GameEvent_PlayBGM(4),
			new GameEvent_MapLock(),
			new GameEvent_Dialogue("请原谅,做了人质,让大家冒了那么大风险......", "米奇尔:", 8, Vector2.zero),
			new GameEvent_Dialogue("没办法,我要是你的话也会这么做的.", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("是啊,不能怪米奇尔,那些家伙太无耻了.", "路易:", 9, Vector2.zero),
			new GameEvent_Dialogue("米奇尔,像以前那样和我们一起战斗吧!", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("为了粉碎DC的野心.", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("不...我在这只能是个包袱,要是守不住这座城市...", "米奇尔:", 8, Vector2.zero),
			new GameEvent_Dialogue("是吗?敌人可能还要来袭击这城市.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("如果还是这样的话......", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("不用担心,我留在这里.", "杰克:", 1, Vector2.zero),
			new GameEvent_Dialogue("噢,杰克!", "路易:", 9, Vector2.zero),
			new GameEvent_Dialogue("不只是我一个人,卡姆的宰塔也在,没问题.", "杰克:", 1, Vector2.zero),
			new GameEvent_Dialogue("对不起,杰克.", "欧文:", 10, Vector2.zero),
			new GameEvent_Dialogue("杰克,谢谢你!龙,欧文,路易,加油啊!", "米奇尔:", 8, Vector2.zero),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(2)
		});
		m_GameEvent.Add(0, new GameEvent[47]
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
			new GameEvent_AddFighter(0),
			new GameEvent_AddFighter(1),
			new GameEvent_AddFighter(2),
			new GameEvent_AddFighter(3),
			new GameEvent_AddFighter(4),
			new GameEvent_AddFighter(5),
			new GameEvent_MapMove(2, 5),
			new GameEvent_Dialogue("好像有什么过来了!", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("那是盖塔Q?米奇尔?", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("大家别过来,这是诡计!快逃!", "米奇尔:", 8, Vector2.zero),
			new GameEvent_Dialogue("米奇尔,到底怎么回事?", "欧文:", 10, Vector2.zero),
			new GameEvent_Dialogue("待会儿再解释吧!快逃!这是敌人的诡计!", "米奇尔:", 8, Vector2.zero),
			new GameEvent_MapMove(26, 3),
			new GameEvent_Dialogue("叛徒!做人质难道就什么都干吗!", "保罗:", 12, Vector2.zero),
			new GameEvent_MapMove(9, 7),
			new GameEvent_Dialogue("!", "米奇尔:", 8, Vector2.zero),
			new GameEvent_MapMove(26, 3),
			new GameEvent_Dialogue("等一下,好的.", "保罗:", 12, Vector2.zero),
			new GameEvent_Dialogue("我要用你的手杀了他们", "保罗:", 12, Vector2.zero),
			new GameEvent_MapMove(9, 7),
			new GameEvent_Dialogue("什么!", "米奇尔:", 8, Vector2.zero),
			new GameEvent_MapMove(26, 3),
			new GameEvent_Dialogue("我不勉强你,但......", "保罗:", 12, Vector2.zero),
			new GameEvent_MapMove(9, 7),
			new GameEvent_Dialogue("这我明白,大家还是......", "米奇尔:", 8, Vector2.zero),
			new GameEvent_MapMove(26, 3),
			new GameEvent_Dialogue("你还是不要做无效的反抗,我不想无谓流血.", "保罗:", 12, Vector2.zero),
			new GameEvent_MapMove(1, 10),
			new GameEvent_Dialogue("哼,真无耻!", "龙:", 5, Vector2.zero),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(3, new GameEvent[2]
		{
			new GameEvent_HasFighter(7, new List<GameEvent>
			{
				new GameEvent_AddFighter(6),
				new GameEvent_LookFighter(6),
				new GameEvent_Dialogue("喂!我把全部居民救出来了,没问题了!", "杰克:", 1, Vector2.zero),
				new GameEvent_LookFighter(3),
				new GameEvent_Dialogue("杰克!干得好!", "加代:", 3, Vector2.zero),
				new GameEvent_Dialogue("你刚才上哪玩儿去了?", "由美:", 2, Vector2.zero),
				new GameEvent_LookFighter(7),
				new GameEvent_Dialogue("谢谢,杰克!", "米奇尔:", 8, Vector2.zero),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(7, 23),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_LookFighter(19),
				new GameEvent_Dialogue("哦!有伏兵!", "保罗:", 12, Vector2.zero)
			}, new List<GameEvent>
			{
				new GameEvent_AddFighter(6),
				new GameEvent_LookFighter(6),
				new GameEvent_Dialogue("......", "杰克:", 1, Vector2.zero),
				new GameEvent_LookFighter(19),
				new GameEvent_Dialogue("哼!来吧,别客气!", "保罗:", 12, Vector2.zero),
				new GameEvent_Dialogue("但我劝你们还是退走吧,不然人质要完蛋了!", "保罗:", 12, Vector2.zero),
				new GameEvent_LookFighter(6),
				new GameEvent_Dialogue("不用怕!人质全部被我就出来了!", "杰克:", 1, Vector2.zero),
				new GameEvent_LookFighter(3),
				new GameEvent_Dialogue("杰克!干得好!", "加代:", 3, Vector2.zero),
				new GameEvent_LookFighter(19),
				new GameEvent_Dialogue("噢!又是伏兵?", "保罗:", 12, Vector2.zero)
			}),
			new GameEvent_Dialogue("就算没有人质我也不会输给你们!来吧!", "保罗:", 12, Vector2.zero)
		});
		m_GameEvent.Add(6, new GameEvent[16]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(20),
			new GameEvent_LookFighter(20),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(21),
			new GameEvent_LookFighter(21),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(22),
			new GameEvent_LookFighter(22),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Dialogue("刚达,金Z,盖塔吗.......", "拉尔:", 13, Vector2.zero),
			new GameEvent_Dialogue("保罗已经失败了.......", "拉尔:", 13, Vector2.zero),
			new GameEvent_Dialogue("打他个措手不及!", "拉尔:", 13, Vector2.zero),
			new GameEvent_Dialogue("都准备好了吗!", "拉尔:", 13, Vector2.zero),
			new GameEvent_Dialogue("是!", "杰夫:", 6, Vector2.zero),
			new GameEvent_Dialogue("准备战斗!", "修斯:", 6, Vector2.zero)
		});
		m_GameEvent.Add(7, new GameEvent[1]
		{
			new GameEvent_ChooseAI(19, Define.AIType.Attack)
		});
		m_GameEvent.Add(8, new GameEvent[4]
		{
			new GameEvent_ChooseAI(19, Define.AIType.Patrol),
			new GameEvent_ChooseAI(14, Define.AIType.Attack),
			new GameEvent_ChooseAI(15, Define.AIType.Attack),
			new GameEvent_ChooseAI(18, Define.AIType.Attack)
		});
	}
}
