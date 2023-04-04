using System.Collections.Generic;
using UnityEngine;

public class GameLevel_4 : Level
{
	public GameLevel_4()
	{
		m_Name = "第4篇: S.巴库";
		m_Task = "全歼敌人即胜利!";
		m_Map = new Map(26, 23, new byte[598]
		{
			0, 0, 0, 0, 0, 3, 3, 7, 3, 3,
			3, 3, 3, 0, 3, 3, 3, 3, 0, 0,
			0, 0, 0, 2, 2, 2, 0, 0, 0, 0,
			0, 0, 0, 7, 3, 3, 3, 3, 3, 0,
			0, 3, 3, 3, 3, 0, 0, 0, 0, 0,
			2, 0, 0, 0, 2, 0, 0, 0, 0, 7,
			7, 3, 3, 3, 0, 0, 0, 0, 0, 3,
			3, 0, 3, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 4, 0, 0, 0, 7, 0, 0, 0,
			0, 0, 0, 0, 3, 3, 0, 0, 0, 3,
			0, 0, 0, 2, 0, 0, 0, 0, 0, 0,
			2, 0, 7, 0, 0, 0, 0, 0, 3, 0,
			2, 0, 3, 0, 0, 0, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 7, 7,
			0, 0, 0, 0, 2, 2, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 4, 0, 0, 0, 7, 0, 0, 0, 0,
			0, 0, 0, 0, 0, 0, 1, 1, 3, 0,
			0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			0, 7, 0, 3, 0, 0, 0, 0, 0, 0,
			0, 1, 1, 1, 1, 3, 0, 0, 0, 1,
			1, 1, 0, 0, 0, 0, 0, 7, 0, 0,
			0, 0, 0, 0, 0, 1, 1, 1, 1, 3,
			3, 3, 0, 0, 1, 1, 1, 1, 1, 0,
			0, 0, 0, 7, 7, 0, 0, 8, 10, 11,
			8, 1, 1, 1, 1, 1, 3, 3, 0, 0,
			1, 1, 1, 1, 1, 1, 1, 1, 0, 0,
			7, 0, 6, 6, 12, 13, 6, 6, 1, 1,
			1, 1, 1, 1, 0, 0, 1, 1, 1, 1,
			1, 1, 1, 1, 1, 0, 7, 7, 6, 7,
			7, 7, 7, 6, 6, 1, 1, 1, 3, 3,
			3, 0, 1, 1, 1, 3, 1, 1, 3, 3,
			3, 0, 6, 7, 7, 7, 7, 7, 7, 7,
			7, 1, 1, 1, 1, 1, 1, 0, 1, 1,
			3, 3, 3, 3, 3, 0, 6, 6, 6, 7,
			7, 7, 7, 7, 7, 7, 7, 6, 6, 6,
			1, 1, 1, 1, 3, 3, 3, 0, 0, 0,
			4, 0, 6, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 6, 6, 0, 1, 1, 1,
			3, 0, 0, 0, 0, 0, 0, 0, 6, 6,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 6, 6, 0, 0, 0, 0, 6, 6, 0,
			0, 0, 3, 3, 0, 6, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 6, 0,
			0, 0, 6, 6, 6, 6, 6, 0, 0, 3,
			3, 6, 6, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 6, 0, 0, 0, 6, 7,
			7, 7, 6, 0, 0, 0, 3, 0, 6, 6,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			6, 6, 0, 0, 7, 7, 7, 7, 6, 6,
			6, 0, 0, 0, 6, 6, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 6, 6, 6, 0,
			7, 7, 7, 7, 7, 7, 6, 0, 3, 0,
			6, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 6, 6, 6, 7, 7, 7, 7,
			7, 7, 6, 6, 6, 6, 6, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 6,
			6, 6, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 7, 7, 7, 7, 7, 7,
			7, 7, 7, 7, 6, 6, 6, 6
		});
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		m_Hospital.Add(new Define.Point(13, 9));
		m_Hospital.Add(new Define.Point(16, 9));
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(14, 7, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(15, 7, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(13, 8, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(16, 8, GameDataBase.Instance.GetActor(2), 3));
		m_FighterData.Add(4, new Fighter(14, 9, GameDataBase.Instance.GetActor(8), 4));
		m_FighterData.Add(5, new Fighter(15, 9, GameDataBase.Instance.GetActor(0), 5));
		m_FighterData.Add(6, new Fighter(13, 10, GameDataBase.Instance.GetActor(6), 6));
		m_FighterData.Add(7, new Fighter(16, 10, GameDataBase.Instance.GetActor(7), 7));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("马登", Robot.EngineType.Land, 21, 14, 7, 385, 83, 51, 97, new int[2] { 25, 26 });
		Robot robot2 = new Robot("马登", Robot.EngineType.Land, 21, 14, 9, 535, 93, 54, 97, new int[2] { 25, 26 });
		Robot robot3 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 8, 390, 80, 58, 90, new int[2] { 37, 38 });
		Robot robot4 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 8, 390, 80, 58, 90, new int[2] { 37, 38 });
		Robot robot5 = new Robot("德姆", Robot.EngineType.Land, 29, 21, 8, 395, 85, 60, 92, new int[2] { 37, 38 });
		Robot robot6 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 260, 72, 37, 52, new int[2] { 7, 29 });
		Robot robot7 = new Robot("巴得", Robot.EngineType.Sky, 19, 16, 5, 260, 72, 37, 52, new int[2] { 7, 29 });
		Robot robot8 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 245, 71, 46, 76, new int[2] { 25, 26 });
		Robot robot9 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 245, 71, 46, 76, new int[2] { 25, 26 });
		Robot robot10 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 245, 71, 46, 76, new int[2] { 25, 26 });
		Robot robot11 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 245, 71, 46, 76, new int[2] { 25, 26 });
		Robot robot12 = new Robot("斯特", Robot.EngineType.Sea, 30, 28, 7, 300, 67, 42, 77, new int[2] { 39, 40 });
		Robot robot13 = new Robot("斯特", Robot.EngineType.Sea, 30, 28, 7, 300, 67, 42, 77, new int[2] { 39, 40 });
		Robot robot14 = new Robot("斯特", Robot.EngineType.Sea, 30, 28, 7, 300, 67, 42, 77, new int[2] { 39, 40 });
		Robot robot15 = new Robot("雷克", Robot.EngineType.Sky, 31, 26, 7, 250, 60, 35, 85, new int[2] { 41, 14 });
		Robot robot16 = new Robot("雷克", Robot.EngineType.Sky, 31, 26, 7, 245, 59, 34, 84, new int[2] { 41, 14 });
		Robot robot17 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 250, 72, 47, 77, new int[2] { 25, 26 });
		Robot robot18 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 250, 72, 47, 77, new int[2] { 25, 26 });
		Robot robot19 = new Robot("卡扎C", Robot.EngineType.Land, 32, 27, 5, 250, 72, 47, 77, new int[2] { 25, 26 });
		Robot robot20 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 270, 82, 32, 75, new int[2] { 7, 8 });
		Robot robot21 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 270, 82, 32, 75, new int[2] { 7, 8 });
		Robot robot22 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 7, 305, 105, 49, 101, new int[2] { 7, 8 });
		User user = new User("士兵", 6, null);
		User user2 = new User("保罗", 12, null);
		User user3 = new User("里卡", 14, null);
		User user4 = new User("加纳", 17, null);
		User user5 = new User("麦克", 18, null);
		User user6 = new User("马斯", 19, null);
		User user7 = new User("马休", 20, null);
		m_FighterData.Add(8, new Fighter(3, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot)
		}, Define.AIType.Patrol, 8, 0, 120, 100), 8));
		m_FighterData.Add(9, new Fighter(2, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot2)
		}, Define.AIType.Patrol, 8, 0, 120, 100), 9));
		m_FighterData.Add(10, new Fighter(5, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user5, robot3)
		}, Define.AIType.Attack, 13, 0, 105, 110), 10));
		m_FighterData.Add(11, new Fighter(3, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user6, robot4)
		}, Define.AIType.Attack, 13, 0, 105, 110), 11));
		m_FighterData.Add(12, new Fighter(4, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot5)
		}, Define.AIType.Attack, 13, 0, 105, 110), 12));
		m_FighterData.Add(13, new Fighter(24, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot6)
		}, Define.AIType.Patrol, 9, 0, 115, 100), 13));
		m_FighterData.Add(14, new Fighter(25, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot7)
		}, Define.AIType.Patrol, 9, 0, 115, 100), 14));
		m_FighterData.Add(15, new Fighter(25, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Attack, 8, 0, 90, 100), 15));
		m_FighterData.Add(16, new Fighter(24, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Attack, 8, 0, 90, 100), 16));
		m_FighterData.Add(17, new Fighter(23, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot10)
		}, Define.AIType.Attack, 8, 0, 90, 100), 17));
		m_FighterData.Add(18, new Fighter(22, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot11)
		}, Define.AIType.Attack, 8, 0, 90, 100), 18));
		m_FighterData.Add(19, new Fighter(15, 20, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot12)
		}, Define.AIType.Attack, 8, 0, 75, 100), 19));
		m_FighterData.Add(20, new Fighter(16, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot13)
		}, Define.AIType.Attack, 8, 0, 75, 100), 20));
		m_FighterData.Add(21, new Fighter(17, 20, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot14)
		}, Define.AIType.Attack, 8, 0, 75, 100), 21));
		m_FighterData.Add(22, new Fighter(22, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot15)
		}, Define.AIType.Attack, 8, 0, 200, 100), 22));
		m_FighterData.Add(23, new Fighter(0, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot16)
		}, Define.AIType.Attack, 8, 0, 200, 100), 23));
		m_FighterData.Add(24, new Fighter(5, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot17)
		}, Define.AIType.Attack, 9, 0, 90, 100), 24));
		m_FighterData.Add(25, new Fighter(6, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot18)
		}, Define.AIType.Attack, 9, 0, 90, 100), 25));
		m_FighterData.Add(26, new Fighter(7, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot19)
		}, Define.AIType.Attack, 9, 0, 90, 100), 26));
		m_FighterData.Add(27, new Fighter(3, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot20)
		}, Define.AIType.Attack, 9, 0, 90, 100), 27));
		m_FighterData.Add(28, new Fighter(5, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot21)
		}, Define.AIType.Attack, 9, 0, 90, 100), 28));
		m_FighterData.Add(29, new Fighter(4, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user7, robot22)
		}, Define.AIType.Attack, 16, 0, 90, 100), 29));
		m_FighterEvent.Add(8, new GameEvent[1]
		{
			new GameEvent_HasFighter(9, new List<GameEvent>
			{
				new GameEvent_Dialogue("里卡!可恶,居然敢杀死里卡!", "保罗:", 12, Vector2.zero)
			}, new List<GameEvent>())
		});
	}

	private void LoadEventData()
	{
		m_GameEvent.Add(-1, new GameEvent[34]
		{
			new GameEvent_MapLock(),
			new GameEvent_PlayBGM(4),
			new GameEvent_LookFighter(5),
			new GameEvent_Dialogue("乔,有人呼叫,听信号是自己人.", "由美:", 2, Vector2.zero),
			new GameEvent_Dialogue("这是怀特,请回答!", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("怀特发生了什么事?", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("我们在伽洛基地被攻击,需要紧急救援.", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("发?是发吗?", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("卡姆!没事吧?", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("是的,我被大伙救了.", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("先别谈这些,你说加洛基地被攻击......", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("是的,加洛基地的防守很坚固,还能坚持一会儿......", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("加洛基地是我们最大据点,不能袖手旁观.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("去救援!", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("谢谢,这个阿格马是我从凯文舰长那里得到的.", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("它的性能要比怀特好得多,请用它", "发:", 21, Vector2.zero),
			new GameEvent_ChooseActor(5, new Actor.ActorData[1]
			{
				new Actor.ActorData(3, 12)
			}),
			new GameEvent_Dialogue("呦呵!太好了,快赶到加洛基地!", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("......", "由美:", 2, Vector2.zero),
			new GameEvent_Dialogue("怎么啦,由美?", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("我留在这里.", "由美:", 2, Vector2.zero),
			new GameEvent_Dialogue("什么?", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("以前我的阿波罗A总是你们的包袱......", "由美:", 2, Vector2.zero),
			new GameEvent_Dialogue("并且,这个达卡尔基地也不很安全.", "由美:", 2, Vector2.zero),
			new GameEvent_Dialogue("我留在这里守基地......加代,行吗?", "由美:", 2, Vector2.zero),
			new GameEvent_Dialogue("我只好用麦塔斯了.", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("幸好麦塔斯有修理装置.", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("发?你?", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("是的,我也接受过驾驶训练.", "发:", 21, Vector2.zero),
			new GameEvent_Dialogue("嗯......一起去吧,发.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("是......卡姆.", "发:", 21, Vector2.zero),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(4)
		});
		m_GameEvent.Add(0, new GameEvent[37]
		{
			new GameEvent_PlayBGM(4),
			new GameEvent_MapLock(),
			new GameEvent_GetFlag("NiNa", new List<GameEvent>
			{
				new GameEvent_AddFighter(4)
			}, new List<GameEvent>()),
			new GameEvent_AddFighter(0),
			new GameEvent_AddFighter(1),
			new GameEvent_AddFighter(2),
			new GameEvent_AddFighter(3),
			new GameEvent_AddFighter(5),
			new GameEvent_AddFighter(6),
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
			new GameEvent_AddFighter(22),
			new GameEvent_LookFighter(9),
			new GameEvent_Dialogue("好久不见啦!让我们来收拾你们吧!", "保罗:", 12, Vector2.zero),
			new GameEvent_Dialogue("保罗!别乱来!", "里卡:", 14, Vector2.zero),
			new GameEvent_LookFighter(12),
			new GameEvent_Dialogue("哼!保罗!里卡!不要来打扰我!", "加纳:", 17, Vector2.zero),
			new GameEvent_Dialogue("出击!马斯!麦克!", "加纳:", 17, Vector2.zero),
			new GameEvent_Dialogue("是!", "马斯:", 19, Vector2.zero),
			new GameEvent_Dialogue("是!让他们见识一下黑色三合体的厉害!", "麦克:", 18, Vector2.zero),
			new GameEvent_LookFighter(0),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(1, new GameEvent[4]
		{
			new GameEvent_LookFighter(5),
			new GameEvent_Dialogue("敌人把我们包围了.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("不等合围,便将他们各个击破!", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("真是加尔达之战吗......", "大卫:", 4, Vector2.zero)
		});
		m_GameEvent.Add(2, new GameEvent[2]
		{
			new GameEvent_ChooseAI(13, Define.AIType.Attack),
			new GameEvent_ChooseAI(14, Define.AIType.Attack)
		});
		m_GameEvent.Add(5, new GameEvent[5]
		{
			new GameEvent_PlayME(3),
			new GameEvent_ChooseAI(9, Define.AIType.Attack),
			new GameEvent_AddFighter(23),
			new GameEvent_LookFighter(23),
			new GameEvent_WaitTime(0.5f)
		});
		m_GameEvent.Add(6, new GameEvent[1]
		{
			new GameEvent_ChooseAI(8, Define.AIType.Attack)
		});
		m_GameEvent.Add(8, new GameEvent[20]
		{
			new GameEvent_PlayME(3),
			new GameEvent_AddFighter(24),
			new GameEvent_LookFighter(24),
			new GameEvent_WaitTime(0.5f),
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
			new GameEvent_WaitTime(0.5f),
			new GameEvent_Dialogue("芬妮命令我来帮忙!", "马修:", 20, Vector2.zero)
		});
	}
}
