using System.Collections.Generic;
using UnityEngine;

public class GameLevel_11 : Level
{
	public GameLevel_11()
	{
		m_Name = "第11篇: 终极机器人";
		m_Task = "守住坎普,全歼敌人";
		m_Map = new Map(26, 32, new byte[832]
		{
			6, 6, 6, 6, 6, 0, 0, 0, 0, 0,
			0, 3, 3, 3, 3, 3, 3, 3, 3, 3,
			3, 1, 1, 1, 1, 1, 6, 6, 6, 6,
			0, 0, 0, 0, 0, 0, 0, 3, 3, 3,
			3, 3, 3, 3, 3, 3, 3, 3, 1, 1,
			1, 1, 6, 6, 6, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 3, 3, 3, 3, 3,
			3, 3, 3, 3, 3, 3, 1, 1, 6, 6,
			6, 0, 0, 0, 0, 0, 0, 0, 2, 0,
			0, 0, 3, 3, 3, 3, 3, 3, 3, 3,
			3, 3, 3, 1, 6, 6, 6, 6, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 3,
			3, 3, 3, 3, 3, 3, 3, 3, 3, 1,
			6, 6, 6, 6, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 2, 3, 3, 3, 3, 3,
			3, 3, 3, 3, 3, 1, 7, 7, 6, 6,
			0, 0, 0, 2, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 4, 0, 3, 3, 3, 3, 3,
			1, 1, 7, 7, 7, 6, 6, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			3, 3, 3, 3, 3, 3, 1, 1, 7, 7,
			7, 7, 6, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 2, 0, 0, 0, 4, 3, 3,
			3, 3, 3, 1, 7, 7, 7, 7, 6, 2,
			0, 0, 0, 0, 0, 0, 0, 4, 4, 0,
			0, 0, 3, 3, 3, 3, 3, 3, 3, 3,
			7, 7, 7, 7, 7, 0, 0, 0, 0, 0,
			4, 3, 3, 3, 3, 3, 3, 3, 3, 3,
			3, 3, 3, 4, 4, 0, 7, 7, 7, 7,
			7, 0, 0, 0, 0, 0, 0, 4, 3, 3,
			3, 3, 4, 0, 0, 3, 3, 3, 3, 3,
			0, 0, 7, 7, 7, 7, 7, 0, 0, 3,
			3, 3, 3, 3, 3, 3, 3, 3, 0, 0,
			2, 0, 3, 3, 3, 4, 0, 0, 7, 7,
			7, 7, 7, 3, 3, 3, 0, 0, 0, 0,
			3, 3, 3, 0, 0, 0, 0, 0, 0, 3,
			3, 0, 0, 0, 7, 7, 7, 7, 0, 0,
			0, 0, 0, 3, 3, 3, 0, 4, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 3, 0,
			7, 7, 7, 0, 0, 3, 3, 3, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 3, 3, 0, 7, 7, 7, 0,
			0, 0, 0, 0, 3, 3, 3, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 2, 3, 3, 3,
			3, 4, 7, 7, 0, 0, 3, 3, 3, 3,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 1,
			1, 0, 0, 0, 3, 3, 3, 3, 7, 7,
			0, 0, 0, 0, 3, 3, 3, 0, 0, 0,
			0, 0, 0, 0, 1, 1, 1, 1, 0, 0,
			2, 3, 3, 3, 7, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 4, 0, 0, 0, 0, 3, 3, 0,
			7, 0, 0, 0, 0, 0, 0, 0, 0, 1,
			1, 1, 1, 4, 1, 1, 1, 1, 1, 1,
			0, 0, 0, 0, 0, 0, 0, 0, 2, 0,
			0, 0, 0, 0, 0, 1, 1, 0, 1, 1,
			1, 1, 1, 1, 0, 0, 0, 0, 2, 0,
			0, 0, 0, 1, 1, 0, 0, 0, 0, 0,
			0, 0, 0, 1, 1, 1, 1, 1, 1, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			1, 2, 0, 0, 0, 0, 0, 1, 1, 1,
			1, 1, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 1, 1, 1, 0, 0,
			3, 0, 0, 0, 1, 1, 0, 0, 0, 0,
			0, 0, 0, 0, 2, 0, 0, 0, 0, 0,
			1, 1, 1, 1, 1, 0, 0, 0, 1, 1,
			1, 0, 1, 1, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 1, 1, 1, 1,
			1, 0, 0, 1, 1, 1, 1, 1, 0, 1,
			1, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 0, 0, 1, 1, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 0, 0, 0,
			0, 0, 0, 0, 0, 3, 0, 0, 0, 0,
			0, 0, 0, 0, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 2, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 1, 1, 1, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
			1, 0, 0, 0, 0, 3, 0, 0, 0, 0,
			0, 0
		});
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(8, 6, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(9, 5, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(10, 4, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(8, 8, GameDataBase.Instance.GetActor(9), 3));
		m_FighterData.Add(4, new Fighter(11, 5, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(9, 9, GameDataBase.Instance.GetActor(12), 5));
		m_FighterData.Add(6, new Fighter(11, 7, GameDataBase.Instance.GetActor(13), 6));
		m_FighterData.Add(7, new Fighter(10, 6, GameDataBase.Instance.GetActor(15), 7));
		m_FighterData.Add(8, new Fighter(14, 24, GameDataBase.Instance.GetActor(16), 8));
		m_FighterEvent.Add(9, new GameEvent[1]
		{
			new GameEvent_GameOver()
		});
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("西马", Robot.EngineType.Land, 43, 36, 5, 490, 97, 64, 104, new int[2] { 26, 17 });
		Robot robot2 = new Robot("西马", Robot.EngineType.Land, 43, 36, 5, 490, 97, 64, 104, new int[2] { 26, 17 });
		Robot robot3 = new Robot("西马", Robot.EngineType.Land, 43, 36, 5, 490, 97, 64, 104, new int[2] { 26, 17 });
		Robot robot4 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 330, 113, 59, 89, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot5 = new Robot("基尔", Robot.EngineType.Sky, 48, 42, 6, 330, 113, 59, 89, new int[2] { 57, 58 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot6 = new Robot("诺巴M9", Robot.EngineType.Land, 47, 39, 6, 420, 108, 65, 95, new int[2] { 54, 55 });
		Robot robot7 = new Robot("诺巴M9", Robot.EngineType.Land, 47, 39, 6, 420, 108, 65, 95, new int[2] { 54, 55 });
		Robot robot8 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 320, 90, 55, 70, new int[2] { 7, 29 });
		Robot robot9 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 320, 90, 55, 70, new int[2] { 7, 29 });
		Robot robot10 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 320, 90, 55, 70, new int[2] { 7, 29 });
		Robot robot11 = new Robot("达衣", Robot.EngineType.Land, 62, 54, 4, 1510, 180, 97, 80, new int[2] { 74, 50 });
		Robot robot12 = new Robot("巴依", Robot.EngineType.Sky, 61, 53, 7, 570, 132, 74, 115, new int[2] { 69, 71 });
		Robot robot13 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 335, 102, 52, 95, new int[2] { 7, 8 });
		Robot robot14 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 335, 102, 52, 95, new int[2] { 7, 8 });
		Robot robot15 = new Robot("古塔", Robot.EngineType.Sky, 59, 51, 5, 600, 104, 67, 77, new int[1] { 75 });
		Robot robot16 = new Robot("古塔", Robot.EngineType.Sky, 59, 51, 5, 600, 104, 67, 77, new int[1] { 75 });
		Robot robot17 = new Robot("古塔", Robot.EngineType.Sky, 59, 51, 5, 600, 104, 67, 77, new int[1] { 75 });
		Robot robot18 = new Robot("瓦尔希昂", Robot.EngineType.Land, 11, 56, 7, 6100, 210, 115, 130, new int[2] { 76, 77 });
		Robot robot19 = new Robot("坎普", Robot.EngineType.Sky, 64, 57, 4, 570, 93, 56, 83, new int[2] { 10, 14 });
		Robot robot20 = new Robot("麦卡", Robot.EngineType.Sky, 65, 58, 6, 710, 107, 70, 97, new int[1] { 79 }, new Define.UserTrait[1] { Define.UserTrait.MinZhongGanRao });
		User user = new User("士兵", 6, null);
		User user2 = new User("贝克", 36, null);
		User user3 = new User("乔治", 37, null);
		m_FighterData.Add(9, new Fighter(9, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot19)
		}, Define.AIType.Passivity, 13, 0, 90, 100, 5, isSelf: true), 9));
		m_FighterData.Add(10, new Fighter(16, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot15)
		}, Define.AIType.Attack, 19, 0, 110, 100), 10));
		m_FighterData.Add(11, new Fighter(17, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot16)
		}, Define.AIType.Attack, 20, 0, 110, 100), 11));
		m_FighterData.Add(12, new Fighter(17, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot17)
		}, Define.AIType.Attack, 19, 0, 110, 100), 12));
		m_FighterData.Add(13, new Fighter(8, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot)
		}, Define.AIType.Attack, 20, 0, 90, 80), 13));
		m_FighterData.Add(14, new Fighter(7, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot2)
		}, Define.AIType.Attack, 20, 0, 90, 80), 14));
		m_FighterData.Add(15, new Fighter(9, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot3)
		}, Define.AIType.Attack, 20, 0, 90, 80), 15));
		m_FighterData.Add(16, new Fighter(13, 23, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot8)
		}, Define.AIType.Attack, 21, 0, 115, 100), 16));
		m_FighterData.Add(17, new Fighter(14, 23, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot9)
		}, Define.AIType.Attack, 21, 0, 115, 100), 17));
		m_FighterData.Add(18, new Fighter(15, 23, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot10)
		}, Define.AIType.Attack, 21, 0, 115, 100), 18));
		m_FighterData.Add(19, new Fighter(19, 25, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot4)
		}, Define.AIType.Attack, 23, 0, 100, 100), 19));
		m_FighterData.Add(20, new Fighter(17, 27, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot5)
		}, Define.AIType.Attack, 23, 0, 100, 100), 20));
		m_FighterData.Add(21, new Fighter(3, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot20)
		}, Define.AIType.Attack, 22, 0, 190, 100), 21));
		m_FighterData.Add(22, new Fighter(20, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot6)
		}, Define.AIType.Attack, 23, 0, 110, 100), 22));
		m_FighterData.Add(23, new Fighter(21, 18, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot7)
		}, Define.AIType.Attack, 23, 0, 110, 100), 23));
		m_FighterData.Add(24, new Fighter(18, 26, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot11)
		}, Define.AIType.Attack, 22, 0, 190, 100), 24));
		m_FighterData.Add(25, new Fighter(2, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot18)
		}, Define.AIType.Patrol, 31, 0, 1, 0, 9), 25));
		m_FighterData.Add(26, new Fighter(5, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot12)
		}, Define.AIType.Attack, 22, 0, 150, 100), 26));
		m_FighterData.Add(27, new Fighter(4, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot13)
		}, Define.AIType.Attack, 22, 0, 90, 100), 27));
		m_FighterData.Add(28, new Fighter(6, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot14)
		}, Define.AIType.Attack, 22, 0, 90, 100), 28));
	}

	private void LoadEventData()
	{
		m_GameEvent.Add(-1, new GameEvent[10]
		{
			new GameEvent_MapLock(),
			new GameEvent_PlayBGM(4),
			new GameEvent_Dialogue("谢谢,终于得救了.", "乔治:", 37, Vector2.zero),
			new GameEvent_Dialogue("DC的根据地在月球上,准备去月球!", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("到宇宙需要快速助推器......", "大卫:", 4, Vector2.zero),
			new GameEvent_Dialogue("去敌人的拉萨基地吧!", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("那里是个大发射场.", "安东:", 27, Vector2.zero),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(11)
		});
		m_GameEvent.Add(0, new GameEvent[35]
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
			new GameEvent_GetFlag("SaMi", new List<GameEvent>
			{
				new GameEvent_AddFighter(7)
			}, new List<GameEvent>()),
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
			new GameEvent_AddFighter(24),
			new GameEvent_LookFighter(0),
			new GameEvent_Dialogue("乔治!不要紧吧!", "大卫:", 4, Vector2.zero),
			new GameEvent_LookFighter(9),
			new GameEvent_Dialogue("嗯,没什么......", "乔治:", 37, Vector2.zero),
			new GameEvent_Dialogue("第二批就要上来了,小心!", "乔治:", 37, Vector2.zero),
			new GameEvent_SetAction(9, action: true),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(5, new GameEvent[25]
		{
			new GameEvent_PlayBGM(9),
			new GameEvent_AddFighter(25),
			new GameEvent_LookFighter(25),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("那......是?", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("是......瓦尔?", "马丁:", 30, Vector2.zero),
			new GameEvent_LookFighter(25),
			new GameEvent_Dialogue("初次见面,各位......", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("不,还有些人已经见过了.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("我是DC的总司令贝克.", "贝克:", 36, Vector2.zero),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("总司令亲自出马了.", "欧文:", 10, Vector2.zero),
			new GameEvent_LookFighter(25),
			new GameEvent_Dialogue("我亲自出马可能这是最后一次了.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("你们有两种选择,死或者投降.做决定把!", "贝克:", 36, Vector2.zero),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("住口,老家伙!别以为什么都可以用武力解决!", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(1),
			new GameEvent_Dialogue("没有人会去支持你的野心!", "龙:", 5, Vector2.zero),
			new GameEvent_LookFighter(25),
			new GameEvent_Dialogue("像个孩子,不懂礼貌!", "贝克:", 36, Vector2.zero),
			new GameEvent_MoveTo(25, 4, 14),
			new GameEvent_SetAction(25, action: true)
		});
		m_GameEvent.Add(6, new GameEvent[5]
		{
			new GameEvent_LookFighter(25),
			new GameEvent_MoveTo(25, 10, 13),
			new GameEvent_SetAction(25, action: true),
			new GameEvent_Dialogue("你在干什么?", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("就你这样还想和我打?", "贝克:", 36, Vector2.zero)
		});
		m_GameEvent.Add(7, new GameEvent[31]
		{
			new GameEvent_PlayBGM(2),
			new GameEvent_AddFighter(8),
			new GameEvent_LookFighter(8),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Dialogue("你在干什么!", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("老实待一会儿!", "安东:", 27, Vector2.zero),
			new GameEvent_LookFighter(2),
			new GameEvent_Dialogue("是巴斯塔?", "加代:", 3, Vector2.zero),
			new GameEvent_LookFighter(25),
			new GameEvent_Dialogue("那是什么?", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("这机器从没见过.", "贝克:", 36, Vector2.zero),
			new GameEvent_LookFighter(8),
			new GameEvent_Dialogue("回去后去问问休吧!", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("那家伙挺了解我的情况!", "安东:", 27, Vector2.zero),
			new GameEvent_LookFighter(25),
			new GameEvent_Dialogue("休?呵,你认识那家伙......", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("这倒不重要,重要的是他有多大实力.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("但你还是个娃娃,", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("不是我的对手.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("我就在这里,把你们打发走吧.", "贝克:", 36, Vector2.zero),
			new GameEvent_LookFighter(8),
			new GameEvent_Dialogue("慢着!以多打少,我们也不太光彩!", "安东:", 27, Vector2.zero),
			new GameEvent_LookFighter(25),
			new GameEvent_Dialogue("哎......年轻人还讲面子.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("要打败我简直是白日做梦.", "贝克:", 36, Vector2.zero),
			new GameEvent_Dialogue("我可不想浪费时间,再见.", "贝克:", 36, Vector2.zero),
			new GameEvent_MoveTo(25, 25, 10),
			new GameEvent_LookFighter(25),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Replace(25, -1),
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(8, new GameEvent[10]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(26),
			new GameEvent_LookFighter(26),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(27),
			new GameEvent_LookFighter(27),
			new GameEvent_WaitTime(0.5f),
			new GameEvent_AddFighter(28),
			new GameEvent_LookFighter(28),
			new GameEvent_WaitTime(0.5f)
		});
	}
}
