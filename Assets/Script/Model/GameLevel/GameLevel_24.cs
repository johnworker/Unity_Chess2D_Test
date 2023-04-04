using System.Collections.Generic;
using UnityEngine;

public class GameLevel_24 : Level
{
	public GameLevel_24()
	{
		m_Name = "第24篇: 亡灵";
		m_Task = "打败吉尔金刚就是胜利!";
		m_Map = new Map(26, 32, new byte[832]
		{
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 0, 2, 2,
			2, 2, 0, 0, 0, 0, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 0, 3, 0,
			7, 7, 7, 0, 3, 4, 0, 0, 2, 0,
			0, 0, 0, 0, 7, 2, 2, 2, 0, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 0, 3,
			3, 0, 7, 7, 0, 0, 0, 0, 0, 0,
			7, 7, 0, 0, 2, 2, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 0, 0, 7, 7, 0,
			0, 2, 0, 0, 0, 0, 0, 7, 0, 9,
			3, 0, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 0, 3, 3, 0, 4, 0,
			0, 0, 0, 7, 7, 0, 0, 0, 0, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 0, 0, 3, 3, 0, 0, 0, 0, 0,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 0, 3, 3, 3,
			4, 0, 4, 0, 0, 0, 7, 7, 7, 0,
			0, 0, 6, 6, 6, 7, 7, 7, 7, 7,
			7, 0, 0, 0, 0, 7, 0, 3, 3, 4,
			0, 0, 0, 7, 0, 0, 2, 2, 0, 6,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 0,
			0, 7, 0, 0, 4, 3, 3, 0, 0, 7,
			0, 0, 0, 0, 0, 6, 6, 6, 6, 6,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 0,
			3, 3, 3, 4, 0, 0, 0, 0, 3, 0,
			2, 2, 0, 0, 0, 6, 6, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 0, 3, 3, 4,
			0, 0, 0, 0, 0, 0, 0, 4, 2, 0,
			0, 0, 6, 6, 7, 7, 7, 7, 7, 7,
			7, 7, 0, 0, 3, 3, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 6, 6, 6,
			7, 7, 7, 7, 7, 7, 7, 7, 0, 3,
			3, 3, 0, 0, 3, 3, 0, 0, 0, 0,
			2, 0, 6, 6, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 0, 0, 3, 3, 4, 0, 3,
			3, 3, 4, 0, 0, 0, 0, 0, 6, 7,
			7, 0, 0, 0, 7, 7, 7, 7, 7, 7,
			0, 2, 0, 0, 0, 0, 4, 0, 0, 0,
			0, 0, 0, 0, 7, 7, 0, 0, 0, 0,
			0, 7, 7, 7, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 2, 0, 0, 0, 0, 0,
			7, 7, 0, 0, 0, 0, 0, 0, 0, 7,
			0, 0, 0, 7, 7, 7, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 7, 7, 0, 0, 1,
			1, 1, 0, 0, 0, 7, 7, 0, 0, 7,
			7, 0, 2, 2, 0, 0, 0, 0, 0, 0,
			7, 7, 0, 0, 0, 0, 1, 1, 1, 1,
			0, 0, 0, 0, 0, 7, 0, 0, 2, 2,
			2, 2, 0, 0, 0, 7, 7, 0, 0, 0,
			0, 0, 0, 1, 1, 0, 0, 0, 0, 1,
			7, 7, 7, 0, 0, 2, 2, 2, 0, 0,
			0, 7, 7, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 1, 1, 1, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 0, 7, 7, 0, 0,
			0, 0, 0, 1, 1, 1, 0, 0, 0, 0,
			1, 1, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 0, 0, 0, 1, 1, 1,
			1, 1, 1, 0, 0, 1, 1, 1, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 0, 2, 0, 1, 1, 0, 0, 0, 0,
			2, 0, 1, 1, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 0, 0, 0, 0,
			2, 2, 0, 0, 0, 0, 0, 4, 4, 1,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 0, 0, 0, 0, 0,
			7, 7, 0, 0, 4, 1, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 0, 0, 0, 7, 7, 7, 0, 0, 0,
			0, 4, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 0, 0, 7, 7, 7, 7,
			0, 0, 0, 0, 0, 2, 2, 0, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 0, 0,
			0, 0, 2, 2, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 0, 0, 0,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			0, 0, 0, 0, 0, 4, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 0, 0, 0, 2,
			2, 2
		});
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		AddShopEvent(new Define.Point(5, 4), new List<int> { 0, 1, 2, 3, 4, 5, 7, 8 });
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(15, 19, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(15, 18, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(14, 19, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(13, 14, GameDataBase.Instance.GetActor(14), 3));
		m_FighterData.Add(4, new Fighter(13, 15, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(11, 16, GameDataBase.Instance.GetActor(13), 5));
		m_FighterData.Add(6, new Fighter(11, 15, GameDataBase.Instance.GetActor(16), 6));
		m_FighterData.Add(7, new Fighter(12, 16, GameDataBase.Instance.GetActor(9), 7));
		m_FighterData.Add(8, new Fighter(12, 14, GameDataBase.Instance.GetActor(7), 8));
		m_FighterData.Add(9, new Fighter(13, 16, GameDataBase.Instance.GetActor(17), 9));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("秀伯", Robot.EngineType.Land, 77, 67, 10, 2470, 221, 120, 166, new int[2] { 69, 94 });
		Robot robot2 = new Robot("吉尔", Robot.EngineType.Sky, 105, 92, 5, 2530, 201, 130, 133, new int[2] { 151, 152 });
		Robot robot3 = new Robot("麦加金刚", Robot.EngineType.Sky, 106, 91, 5, 4250, 220, 158, 146, new int[2] { 151, 152 }, new Define.UserTrait[1] { Define.UserTrait.ShenMiJiTi });
		Robot robot4 = new Robot("盖马", Robot.EngineType.Land, 87, 77, 8, 1290, 172, 101, 132, new int[2] { 65, 104 });
		Robot robot5 = new Robot("盖马", Robot.EngineType.Land, 87, 77, 8, 1290, 172, 101, 132, new int[2] { 65, 104 });
		Robot robot6 = new Robot("盖马", Robot.EngineType.Land, 87, 77, 8, 1290, 172, 101, 132, new int[2] { 65, 104 });
		Robot robot7 = new Robot("伯希", Robot.EngineType.Land, 97, 85, 6, 1320, 189, 99, 124, new int[2] { 111, 112 });
		Robot robot8 = new Robot("伯希", Robot.EngineType.Land, 97, 85, 6, 1320, 189, 99, 124, new int[2] { 111, 112 });
		Robot robot9 = new Robot("基格", Robot.EngineType.Land, 92, 80, 7, 480, 142, 96, 130, new int[2] { 106, 107 });
		Robot robot10 = new Robot("基格", Robot.EngineType.Land, 92, 80, 7, 480, 142, 96, 130, new int[2] { 106, 107 });
		Robot robot11 = new Robot("哈衣", Robot.EngineType.Sea, 27, 24, 7, 380, 109, 92, 119, new int[1] { 33 });
		Robot robot12 = new Robot("哈衣", Robot.EngineType.Sea, 27, 24, 7, 380, 109, 92, 119, new int[1] { 33 });
		Robot robot13 = new Robot("布x1", Robot.EngineType.Land, 98, 86, 5, 940, 220, 102, 114, new int[2] { 110, 49 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot14 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 480, 149, 94, 154, new int[2] { 103, 71 });
		Robot robot15 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 480, 149, 94, 154, new int[2] { 103, 71 });
		Robot robot16 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 480, 149, 94, 154, new int[2] { 103, 71 });
		Robot robot17 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 300, 10, 126, new int[1] { 57 });
		Robot robot18 = new Robot("导弹", Robot.EngineType.Sky, 56, 49, 7, 100, 300, 10, 126, new int[1] { 57 });
		User user = new User("士兵", 6, null);
		User user2 = new User("芬妮", 38, null);
		m_FighterData.Add(10, new Fighter(23, 25, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot)
		}, Define.AIType.Counter, 48, 0, 155, 100), 10));
		m_FighterData.Add(11, new Fighter(8, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot2)
		}, Define.AIType.Passivity, 44, 0, 350, 100), 11));
		m_FighterData.Add(12, new Fighter(8, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot3)
		}, Define.AIType.Passivity, 46, 0, 400, 100, 12), 12));
		m_FighterData.Add(13, new Fighter(10, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot13)
		}, Define.AIType.Attack, 37, 0, 190, 100), 13));
		m_FighterData.Add(14, new Fighter(12, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot11)
		}, Define.AIType.Attack, 37, 0, 75, 100), 14));
		m_FighterData.Add(15, new Fighter(15, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot12)
		}, Define.AIType.Attack, 37, 0, 75, 100), 15));
		m_FighterData.Add(16, new Fighter(17, 18, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Attack, 38, 0, 190, 100), 16));
		m_FighterData.Add(17, new Fighter(16, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Attack, 38, 0, 190, 100), 17));
		m_FighterData.Add(18, new Fighter(13, 11, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Attack, 37, 0, 110, 100), 18));
		m_FighterData.Add(19, new Fighter(8, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot10)
		}, Define.AIType.Attack, 37, 0, 110, 100), 19));
		m_FighterData.Add(20, new Fighter(7, 9, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot4)
		}, Define.AIType.Attack, 38, 0, 130, 100), 20));
		m_FighterData.Add(21, new Fighter(9, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot5)
		}, Define.AIType.Attack, 38, 0, 130, 100), 21));
		m_FighterData.Add(22, new Fighter(19, 20, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Attack, 38, 0, 130, 100), 22));
		m_FighterData.Add(23, new Fighter(20, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot14)
		}, Define.AIType.Attack, 38, 0, 140, 100), 23));
		m_FighterData.Add(24, new Fighter(17, 26, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot15)
		}, Define.AIType.Attack, 38, 0, 140, 100), 24));
		m_FighterData.Add(25, new Fighter(7, 12, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot16)
		}, Define.AIType.Attack, 38, 0, 140, 100), 25));
		m_FighterData.Add(26, new Fighter(3, 18, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot17)
		}, Define.AIType.Attack, 37, 0, 25, 100), 26));
		m_FighterData.Add(27, new Fighter(20, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot18)
		}, Define.AIType.Attack, 37, 0, 25, 100), 27));
	}

	private void LoadEventData()
	{
		List<GameEvent> list = new List<GameEvent>();
		list.Add(new GameEvent_MapLock());
		list.Add(new GameEvent_PlayBGM(4));
		list.Add(new GameEvent_Dialogue("终于收拾完了.", "马丁:", 30, Vector2.zero));
		list.Add(new GameEvent_Dialogue("也没什么了不得的家伙.", "加代:", 3, Vector2.zero));
		list.Add(new GameEvent_Dialogue("全都平安吧?", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("乔舰长!能返回了吧.", "发:", 21, Vector2.zero));
		list.Add(new GameEvent_Dialogue("凯文舰长怎样了?", "卡姆:", 7, Vector2.zero));
		list.Add(new GameEvent_Dialogue("大概由于洛克的叛乱,DC也很混乱.", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("没想到残敌太少,很快就解决了.", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("是由于洛克叛乱的缘故......", "卡姆:", 7, Vector2.zero));
		list.Add(new GameEvent_Dialogue("即使那样,你们这里还是打了一场机战激战.", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("现在加布洛仍是DC的据点.", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_Dialogue("咱们向加布洛进军!", "乔:", 0, Vector2.zero));
		list.Add(new GameEvent_GetFlag("YiWa", new List<GameEvent>
		{
			new GameEvent_LookFighter(9),
			new GameEvent_Dialogue("看,我发现了什么!", "伊娃:", 39, Vector2.zero),
			new GameEvent_Dialogue("伯利!太好了!在哪儿弄来的.", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("我会操纵这个!", "伊娃:", 39, Vector2.zero),
			new GameEvent_Dialogue("站住!伊娃!", "希塔:", 33, Vector2.zero),
			new GameEvent_Dialogue("嗯?为什么?你真小气!", "伊娃:", 39, Vector2.zero),
			new GameEvent_Dialogue("希塔,就让她去试试吧.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("哎?乔,为什么!?", "希塔:", 33, Vector2.zero),
			new GameEvent_Dialogue("据我观察,伊娃有非凡的驾驶能力.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("为了战斗力,应该让伊娃驾驶性能更优越的机器.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("我认为这对于生存很重要......", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("说是这么说......", "希塔:", 33, Vector2.zero),
			new GameEvent_Dialogue("希塔,可以吗?", "伊娃:", 39, Vector2.zero),
			new GameEvent_Dialogue("没办法,伊娃,可不能勉强喔!", "希塔:", 33, Vector2.zero),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_ChooseActor(9, new Actor.ActorData[1]
			{
				new Actor.ActorData(18, 72)
			}),
			new GameEvent_WaitTime(0.5f)
		}, new List<GameEvent>()));
		list.Add(new GameEvent_Repair());
		list.Add(new GameEvent_MapUnlock());
		list.Add(new GameEvent_Victory(24));
		List<GameEvent> list2 = list;
		m_GameEvent.Add(-1, list2.ToArray());
		m_FighterEvent.Add(11, new GameEvent[8]
		{
			new GameEvent_MapLock(),
			new GameEvent_MapMove(8, 11),
			new GameEvent_PlayBGM(12),
			new GameEvent_PlayME(4),
			new GameEvent_WaitTime(2f),
			new GameEvent_Dialogue("哈哈!这样也算胜了吗?", "吉尔:", -1, Vector2.zero),
			new GameEvent_AddFighter(12),
			new GameEvent_MapUnlock()
		});
		m_FighterEvent.Add(12, list2.ToArray());
		m_GameEvent.Add(0, new GameEvent[42]
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
			new GameEvent_AddFighter(11),
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
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("马上你们就要服法了.", "芬妮:", 38, Vector2.zero),
			new GameEvent_Dialogue("让你们见识一下我们的终级武器吉尔的厉害!", "芬妮:", 38, Vector2.zero),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("吉尔?", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("混账东西!", "欧文:", 10, Vector2.zero),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("那家伙真该死了!", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("哼,你要拥有我们DC的科学技术,就都明白了.", "芬妮:", 38, Vector2.zero),
			new GameEvent_Dialogue("和吉尔这个战争狂人打,有什么意义呢?", "芬妮:", 38, Vector2.zero),
			new GameEvent_LookFighter(0),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(5, new GameEvent[7]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(26),
			new GameEvent_LookFighter(26),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(27),
			new GameEvent_LookFighter(27),
			new GameEvent_WaitTime(0.5f)
		});
	}
}
