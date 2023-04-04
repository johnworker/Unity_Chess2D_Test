using System.Collections.Generic;
using UnityEngine;

public class GameLevel_21 : Level
{
	public GameLevel_21()
	{
		m_Name = "第21篇: 停止吧,时间!";
		m_Task = "15回合内必须全部从下面的出口逃出.";
		m_TaskType = TaskTypeEnum.UnKillAll;
		m_Map = new Map(32, 32, new byte[1024]
		{
			23, 23, 23, 23, 23, 24, 44, 44, 44, 44,
			44, 44, 44, 23, 23, 23, 23, 23, 23, 23,
			23, 44, 44, 44, 44, 24, 24, 24, 23, 23,
			23, 23, 23, 23, 23, 23, 24, 21, 21, 21,
			21, 21, 21, 21, 21, 44, 23, 23, 23, 23,
			23, 23, 24, 21, 21, 21, 21, 21, 21, 21,
			24, 23, 23, 23, 23, 23, 23, 24, 21, 20,
			20, 20, 20, 20, 20, 20, 20, 21, 44, 23,
			23, 23, 23, 24, 21, 20, 20, 20, 20, 20,
			20, 20, 21, 24, 23, 23, 23, 23, 24, 21,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			21, 44, 23, 23, 24, 21, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 21, 24, 23, 23, 24,
			21, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 21, 44, 23, 21, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 21, 23,
			23, 21, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 21, 23, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 23, 23, 20, 20, 20, 20, 20, 23, 23,
			23, 23, 20, 20, 20, 20, 20, 20, 20, 23,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 23, 23, 20, 20, 20, 20, 23,
			23, 23, 23, 23, 23, 20, 20, 20, 20, 20,
			20, 23, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 23, 23, 20, 20, 20,
			20, 24, 23, 23, 23, 23, 23, 23, 20, 20,
			20, 20, 20, 23, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 23, 23, 20,
			20, 20, 20, 21, 24, 23, 23, 23, 23, 23,
			23, 20, 20, 20, 20, 24, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 23, 23,
			23, 23, 20, 20, 20, 20, 21, 24, 23, 23,
			23, 23, 23, 23, 20, 20, 20, 21, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 23,
			23, 23, 23, 23, 23, 20, 20, 20, 20, 21,
			23, 23, 23, 23, 23, 23, 23, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			23, 23, 23, 23, 23, 23, 23, 23, 20, 20,
			20, 20, 44, 44, 44, 24, 24, 24, 24, 24,
			24, 24, 24, 24, 24, 24, 24, 24, 24, 24,
			24, 23, 23, 23, 23, 23, 23, 24, 24, 24,
			20, 20, 20, 20, 21, 21, 21, 21, 21, 21,
			21, 21, 21, 21, 21, 21, 21, 21, 21, 21,
			21, 21, 21, 23, 23, 23, 23, 23, 23, 21,
			21, 21, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 23, 23, 23, 23, 23,
			23, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 20, 20, 20, 20, 20, 20, 23, 24, 24,
			24, 23, 23, 20, 20, 23, 23, 20, 20, 20,
			20, 20, 20, 20, 23, 23, 23, 23, 23, 23,
			23, 23, 23, 23, 23, 23, 23, 20, 20, 23,
			21, 21, 21, 23, 23, 20, 20, 23, 23, 20,
			20, 20, 23, 20, 20, 20, 23, 24, 24, 44,
			44, 44, 24, 24, 24, 24, 24, 23, 23, 20,
			20, 23, 20, 20, 20, 23, 23, 20, 20, 23,
			23, 20, 20, 20, 23, 20, 20, 20, 23, 21,
			21, 21, 21, 21, 21, 21, 21, 21, 21, 23,
			23, 20, 20, 23, 20, 20, 20, 23, 23, 20,
			20, 23, 23, 20, 20, 20, 24, 20, 20, 20,
			23, 20, 20, 20, 20, 20, 20, 20, 20, 20,
			20, 23, 23, 20, 20, 23, 20, 20, 20, 23,
			23, 20, 20, 23, 23, 20, 20, 20, 21, 20,
			20, 20, 23, 20, 20, 20, 20, 23, 20, 20,
			20, 20, 20, 23, 23, 20, 20, 23, 20, 20,
			20, 23, 23, 22, 20, 23, 23, 20, 20, 20,
			20, 20, 20, 20, 23, 20, 20, 20, 20, 23,
			20, 20, 20, 20, 20, 23, 23, 20, 20, 23,
			20, 20, 20, 23, 23, 20, 20, 23, 23, 23,
			23, 23, 23, 20, 20, 20, 23, 20, 20, 20,
			20, 23, 20, 20, 23, 23, 20, 23, 23, 20,
			20, 23, 20, 20, 20, 23, 23, 20, 20, 23,
			24, 24, 24, 24, 24, 20, 20, 20, 23, 20,
			20, 20, 20, 23, 20, 20, 44, 44, 20, 23,
			23, 20, 20, 23, 20, 20, 20, 23, 23, 20,
			20, 23, 21, 21, 21, 21, 21, 20, 20, 20,
			23, 20, 20, 20, 20, 23, 20, 20, 21, 21,
			20, 23, 23, 20, 20, 23, 20, 20, 20, 23,
			23, 20, 20, 23, 23, 23, 23, 23, 23, 20,
			20, 20, 23, 20, 20, 20, 20, 23, 20, 20,
			20, 20, 20, 23, 23, 20, 20, 23, 20, 20,
			20, 23, 23, 20, 22, 24, 24, 23, 23, 23,
			23, 20, 20, 20, 23, 20, 20, 20, 22, 23,
			23, 20, 20, 20, 20, 23, 23, 20, 20, 23,
			20, 20, 20, 23, 23, 20, 20, 21, 21, 24,
			24, 23, 24, 20, 20, 20, 23, 20, 20, 20,
			20, 23, 23, 23, 20, 20, 20, 24, 24, 20,
			22, 23, 20, 20, 20, 23, 23, 20, 20, 20,
			20, 21, 21, 24, 21, 20, 20, 23, 23, 20,
			20, 20, 20, 23, 23, 23, 23, 20, 20, 21,
			21, 20, 20, 24, 20, 20, 20, 23, 23, 23,
			20, 20, 20, 20, 20, 21, 20, 20, 23, 23,
			23, 20, 20, 20, 20, 23, 23, 23, 23, 23,
			20, 20, 20, 20, 20, 21, 20, 20, 20, 23,
			23, 23, 23, 20, 20, 20, 20, 20, 20, 23,
			23, 23, 23, 20, 20, 20, 20, 23, 23, 23,
			23, 23, 23, 20, 20, 20, 20, 22, 20, 20,
			20, 23, 23, 23, 23, 23, 23, 23, 23, 23,
			23, 23, 23, 23, 23, 43, 43, 43, 43, 23,
			23, 23, 23, 23, 23, 23, 23, 23, 23, 23,
			23, 23, 23, 23
		});
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(24, 5, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(25, 6, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(23, 6, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(25, 8, GameDataBase.Instance.GetActor(14), 3));
		m_FighterData.Add(4, new Fighter(23, 8, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(24, 9, GameDataBase.Instance.GetActor(13), 5));
		m_FighterData.Add(6, new Fighter(26, 9, GameDataBase.Instance.GetActor(16), 6));
		m_FighterData.Add(7, new Fighter(24, 7, GameDataBase.Instance.GetActor(9), 7));
		m_FighterData.Add(8, new Fighter(22, 9, GameDataBase.Instance.GetActor(7), 8));
		m_FighterData.Add(9, new Fighter(24, 11, GameDataBase.Instance.GetActor(17), 9));
		m_FighterData.Add(14, new Fighter(13, 31, GameDataBase.Instance.GetActor(15), 14));
		User user = new User("凯文", 55, null);
		Robot robot = new Robot("阿格马", Robot.EngineType.Sky, 33, 29, 6, 880, 168, 125, 120, new int[2] { 42, 43 });
		m_FighterData.Add(15, new Fighter(13, 31, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot)
		}, Define.AIType.Passivity, 41, 0, 0, 0, 4, isSelf: true), 15));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("瓦尔希昂", Robot.EngineType.Land, 11, 56, 7, 6290, 248, 144, 168, new int[2] { 76, 77 });
		Robot robot2 = new Robot("科顿", Robot.EngineType.Land, 79, 71, 5, 1040, 141, 122, 96, new int[2] { 57, 64 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot3 = new Robot("邦巴", Robot.EngineType.Land, 66, 59, 5, 1220, 166, 98, 96, new int[2] { 33, 50 });
		Robot robot4 = new Robot("布x1", Robot.EngineType.Land, 98, 86, 5, 900, 212, 96, 106, new int[2] { 110, 49 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		User user = new User("贝克", 36, null);
		m_FighterData.Add(10, new Fighter(24, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot)
		}, Define.AIType.Counter, 31, 0, 1, 0), 10));
		m_FighterData.Add(11, new Fighter(13, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot2)
		}, Define.AIType.Attack, 33, 0, 120, 100), 11));
		m_FighterData.Add(12, new Fighter(6, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot4)
		}, Define.AIType.Attack, 33, 0, 190, 100), 12));
		m_FighterData.Add(13, new Fighter(5, 13, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot3)
		}, Define.AIType.Attack, 33, 0, 140, 100), 13));
	}

	private void LoadEventData()
	{
		HashSet<Define.Point> hashSet = new HashSet<Define.Point>();
		hashSet.Add(new Define.Point(13, 31));
		hashSet.Add(new Define.Point(14, 31));
		hashSet.Add(new Define.Point(15, 31));
		hashSet.Add(new Define.Point(16, 31));
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_MapLock());
		list.Add(new GameEvent_PlayBGM(4));
		list.Add(new GameEvent_Dialogue("我们的行动已经被发现了......", "安东:", 27, Vector2.zero));
		list.Add(new GameEvent_Dialogue("对方的本领很高强吗......", "安东:", 27, Vector2.zero));
		list.Add(new GameEvent_Dialogue("别泄气,他们就是破坏了古拉,也很难打败我们......", "马丁:", 30, Vector2.zero));
		list.Add(new GameEvent_Dialogue("只因如此,就害怕我们吗?", "加代:", 3, Vector2.zero));
		list.Add(new GameEvent_Dialogue("不过已经刻不容缓了......", "凯文:", 55, Vector2.zero));
		list.Add(new GameEvent_Dialogue("特别命令中的情报还真准,这基地是个陷阱.", "凯文:", 55, Vector2.zero));
		list.Add(new GameEvent_Dialogue("我也在犯疑,调查结果却正如你所料.", "凯文:", 55, Vector2.zero));
		list.Add(new GameEvent_Dialogue("但是,这里全被放弃了,DC的基地到底是哪里...?", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("关于这点,情报上也有.", "凯文:", 55, Vector2.zero));
		list.Add(new GameEvent_Dialogue("大约他们的基地转移到加布洛处了.", "凯文:", 55, Vector2.zero));
		list.Add(new GameEvent_Dialogue("不过,这情报不会到哪里都准确吧.", "凯文:", 55, Vector2.zero));
		list.Add(new GameEvent_Dialogue("格赛乃塔尽瞎帮忙,我们的对手在加布洛.", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("嗯,等这里安排妥了,就去支援你们,坚持一下.", "凯文:", 55, Vector2.zero));
		list.Add(new GameEvent_Dialogue("那个新型战斗舰拉姆已带来了,请用吧.", "凯文:", 55, Vector2.zero));
		list.Add(new GameEvent_Dialogue("多谢凯文舰长.", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("祝你常胜.", "凯文:", 55, Vector2.zero));
		list.Add(new GameEvent_Repair());
		list.Add(new GameEvent_MapUnlock());
		list.Add(new GameEvent_Victory(21));
		List<GameEvent> trueEvent = list;
		m_MoveOverEvent = new GameEvent[10]
		{
			new GameEvent_PosSwitchID(0, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(0),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(0, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, trueEvent)
			}),
			new GameEvent_PosSwitchID(1, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(1),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(1, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, trueEvent)
			}),
			new GameEvent_PosSwitchID(2, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(2),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(2, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, trueEvent)
			}),
			new GameEvent_PosSwitchID(3, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(3),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(3, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, trueEvent)
			}),
			new GameEvent_PosSwitchID(4, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(4),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(4, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, trueEvent)
			}),
			new GameEvent_PosSwitchID(5, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(5),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(5, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, trueEvent)
			}),
			new GameEvent_PosSwitchID(6, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(6),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(6, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, trueEvent)
			}),
			new GameEvent_PosSwitchID(7, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(7),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(7, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, trueEvent)
			}),
			new GameEvent_PosSwitchID(8, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(8),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(8, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, trueEvent)
			}),
			new GameEvent_PosSwitchID(9, hashSet, new List<GameEvent>
			{
				new GameEvent_MapLock(),
				new GameEvent_LookFighter(9),
				new GameEvent_WaitTime(0.5f),
				new GameEvent_Replace(9, -1),
				new GameEvent_MapUnlock(),
				new GameEvent_SelfCount(0, trueEvent)
			})
		};
		m_GameEvent.Add(0, new GameEvent[50]
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
			new GameEvent_GetFlag("YiWa", new List<GameEvent>
			{
				new GameEvent_AddFighter(9)
			}, new List<GameEvent>()),
			new GameEvent_AddFighter(10),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("这不是空城计吗!", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(0),
			new GameEvent_Dialogue("是陷阱?", "大卫:", 4, Vector2.zero),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("很遗憾,各位.", "贝克:", 36, Vector2.zero),
			new GameEvent_LookFighter(4),
			new GameEvent_Dialogue("瓦尔!", "卡姆:", 7, Vector2.zero),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("这个基地一个人也没有.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("我就用它把你们引诱过来了.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("你们大约也知道.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("这基地15分钟后爆炸.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("嘿嘿,这一招虽然古老,但还是有效.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("你们现在不是过来了吗.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("我想不会没人发现吧?", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("你们的进展远远超出我的预想.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("居然能到这.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("这是你们最后的机会了,跟我干?", "贝克:", 36, Vector2.zero),
			new GameEvent_LookFighter(0),
			new GameEvent_Dialogue("......", "大卫:", 4, Vector2.zero),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("呸!", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(8),
			new GameEvent_Dialogue("真烦人!还要我说几遍!", "布克:", 15, Vector2.zero),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("即使目的正确,使用这种恶劣手段也不道德!", "龙:", 5, Vector2.zero),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("是么......太可惜了,我不得不眼看着你们死去.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("话已经说明白,劝你们赶快做出明智的选择.", "贝克:", 36, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(10, -1),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(0),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(1, new GameEvent[4]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(11),
			new GameEvent_LookFighter(11),
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(2, new GameEvent[5]
		{
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("为什么那家伙不马上引爆基地?", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("太小看我们了!畜牲!", "路易:", 9, Vector2.zero),
			new GameEvent_LookFighter(3),
			new GameEvent_Dialogue("只有13分钟了,赶快!", "希塔:", 33, Vector2.zero)
		});
		m_GameEvent.Add(3, new GameEvent[7]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(12),
			new GameEvent_LookFighter(12),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(13),
			new GameEvent_LookFighter(13),
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(4, new GameEvent[2]
		{
			new GameEvent_PlayBGM(2),
			new GameEvent_GetFlag("SaMi", new List<GameEvent>
			{
				new GameEvent_AddFighter(14),
				new GameEvent_LookFighter(14),
				new GameEvent_Dialogue("这边!快!", "萨米:", 23, Vector2.zero),
				new GameEvent_LookFighter(4),
				new GameEvent_Dialogue("萨米!", "卡姆:", 7, Vector2.zero),
				new GameEvent_LookFighter(14),
				new GameEvent_Dialogue("好,终于赶上了.", "萨米:", 23, Vector2.zero),
				new GameEvent_Dialogue("出口在这边,只有11分钟了!", "萨米:", 23, Vector2.zero),
				new GameEvent_ChooseAI(14, Define.AIType.Passivity)
			}, new List<GameEvent>
			{
				new GameEvent_AddFighter(15),
				new GameEvent_LookFighter(15),
				new GameEvent_Dialogue("喂,这边!快逃!离爆炸只有11分钟了!", "凯文:", 55, Vector2.zero)
			})
		});
		m_GameEvent.Add(10, new GameEvent[2]
		{
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("混蛋!只剩下5分钟了!", "加代:", 3, Vector2.zero)
		});
		m_GameEvent.Add(15, new GameEvent[1]
		{
			new GameEvent_GameOver()
		});
	}
}
