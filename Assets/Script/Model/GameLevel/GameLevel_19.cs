using System.Collections.Generic;
using UnityEngine;

public class GameLevel_19 : Level
{
	public GameLevel_19()
	{
		m_Name = "第19篇: 决战月球";
		m_Task = "全歼敌人即胜利!";
		m_Map = new Map(26, 26, new byte[676]
		{
			28, 29, 30, 31, 28, 28, 28, 29, 28, 28,
			28, 29, 28, 28, 28, 29, 29, 32, 28, 28,
			28, 29, 29, 28, 28, 28, 29, 28, 29, 29,
			29, 28, 28, 29, 28, 28, 28, 28, 29, 29,
			28, 28, 32, 32, 29, 29, 28, 28, 35, 29,
			28, 28, 28, 28, 28, 28, 28, 29, 29, 28,
			28, 28, 29, 28, 28, 28, 30, 28, 29, 32,
			32, 29, 30, 28, 29, 28, 32, 32, 28, 31,
			29, 30, 28, 28, 28, 28, 29, 28, 28, 28,
			28, 31, 28, 29, 28, 28, 32, 28, 28, 28,
			32, 32, 32, 28, 29, 28, 28, 29, 28, 28,
			28, 28, 29, 28, 28, 28, 28, 28, 28, 28,
			28, 28, 29, 28, 28, 28, 29, 28, 31, 28,
			28, 29, 28, 28, 29, 28, 28, 29, 28, 33,
			33, 33, 33, 33, 33, 33, 33, 28, 28, 28,
			28, 28, 28, 28, 29, 28, 29, 29, 28, 28,
			28, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 28, 28, 28,
			28, 28, 28, 28, 33, 33, 36, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 36, 33, 33,
			33, 33, 33, 33, 33, 33, 28, 28, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			36, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 37, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 36, 33, 33, 33, 33, 36, 33, 33,
			33, 33, 33, 37, 33, 36, 33, 33, 37, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 36, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 37, 33, 33, 33, 33, 33, 36, 33,
			33, 36, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 37, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 37, 33, 33, 33,
			33, 37, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 36, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 36, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 34, 34, 33, 33, 33, 33,
			37, 33, 33, 33, 33, 36, 33, 34, 33, 33,
			33, 33, 37, 37, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 37, 33, 33, 33, 34, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			36, 36, 33, 33, 33, 33, 33, 33, 33, 33,
			34, 36, 33, 37, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 34, 34, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 37, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 36, 36, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 37, 33,
			33, 33, 33, 33, 37, 36, 33, 33, 33, 33,
			37, 33, 33, 33, 36, 36, 33, 33, 33, 33,
			34, 34, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 36, 33, 33,
			34, 33, 33, 36, 33, 33, 33, 36, 36, 33,
			33, 33, 33, 33, 37, 33, 33, 37, 33, 33,
			37, 38, 33, 37, 33, 34, 34, 34, 33, 33,
			33, 34, 33, 33, 33, 33, 33, 33, 33, 33,
			33, 33, 33, 33, 33, 33, 33, 33, 33, 33,
			34, 34, 34, 34, 36, 33, 33, 33, 33, 33,
			33, 33, 34, 34, 33, 33, 33, 37, 33, 33,
			37, 37, 37, 33, 37, 33
		});
		m_SelfBGM = 11;
		m_EnemyBGM = 10;
		AddShopEvent(new Define.Point(22, 1), new List<int> { 0, 1, 2, 3, 4, 5, 7, 8 });
		m_Hospital.Add(new Define.Point(23, 23));
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(7, 11, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(7, 12, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(7, 13, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(6, 14, GameDataBase.Instance.GetActor(14), 3));
		m_FighterData.Add(4, new Fighter(5, 13, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(5, 9, GameDataBase.Instance.GetActor(13), 5));
		m_FighterData.Add(6, new Fighter(5, 15, GameDataBase.Instance.GetActor(16), 6));
		m_FighterData.Add(7, new Fighter(5, 11, GameDataBase.Instance.GetActor(9), 7));
		m_FighterData.Add(8, new Fighter(7, 14, GameDataBase.Instance.GetActor(7), 8));
		m_FighterData.Add(9, new Fighter(6, 12, GameDataBase.Instance.GetActor(0), 9));
		m_FighterData.Add(10, new Fighter(6, 10, GameDataBase.Instance.GetActor(17), 10));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("秀伯", Robot.EngineType.Land, 77, 67, 10, 2450, 218, 117, 163, new int[2] { 69, 94 });
		Robot robot2 = new Robot("刚克", Robot.EngineType.Land, 72, 69, 5, 980, 138, 85, 113, new int[2] { 99, 26 });
		Robot robot3 = new Robot("刚达II", Robot.EngineType.Land, 84, 73, 5, 980, 211, 137, 117, new int[2] { 97, 100 });
		Robot robot4 = new Robot("布x1", Robot.EngineType.Land, 98, 86, 5, 870, 206, 92, 100, new int[2] { 110, 49 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot5 = new Robot("布x1", Robot.EngineType.Land, 98, 86, 5, 870, 206, 92, 100, new int[2] { 110, 49 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot6 = new Robot("布x1", Robot.EngineType.Land, 98, 86, 5, 870, 206, 92, 100, new int[2] { 110, 49 }, new Define.UserTrait[1] { Define.UserTrait.JianJieWuXiao });
		Robot robot7 = new Robot("加姆", Robot.EngineType.Sky, 86, 75, 10, 395, 144, 74, 124, new int[1] { 101 });
		Robot robot8 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 445, 139, 84, 140, new int[2] { 103, 71 });
		Robot robot9 = new Robot("巴乌", Robot.EngineType.Land, 80, 74, 8, 445, 139, 84, 140, new int[2] { 103, 71 });
		Robot robot10 = new Robot("扎依", Robot.EngineType.Land, 45, 40, 4, 445, 122, 84, 74, new int[2] { 33, 36 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot11 = new Robot("扎依", Robot.EngineType.Land, 45, 40, 4, 445, 122, 84, 74, new int[2] { 33, 36 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		Robot robot12 = new Robot("扎依", Robot.EngineType.Land, 45, 40, 4, 445, 122, 84, 74, new int[2] { 33, 36 }, new Define.UserTrait[1] { Define.UserTrait.FangYuTiXi });
		User user = new User("士兵", 6, null);
		User user2 = new User("芬妮", 38, null);
		User user3 = new User("普西", 56, null);
		m_FighterData.Add(11, new Fighter(24, 20, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot)
		}, Define.AIType.Counter, 46, 0, 155, 100), 11));
		m_FighterData.Add(12, new Fighter(23, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot3)
		}, Define.AIType.Counter, 39, 0, 190, 100), 12));
		m_FighterData.Add(13, new Fighter(15, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot2)
		}, Define.AIType.Attack, 31, 0, 125, 100), 13));
		m_FighterData.Add(14, new Fighter(15, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Attack, 30, 0, 140, 100), 14));
		m_FighterData.Add(15, new Fighter(14, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Attack, 30, 0, 140, 100), 15));
		m_FighterData.Add(16, new Fighter(23, 17, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Attack, 30, 0, 135, 100), 16));
		m_FighterData.Add(17, new Fighter(17, 19, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot4)
		}, Define.AIType.Attack, 30, 0, 190, 100), 17));
		m_FighterData.Add(18, new Fighter(16, 20, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot5)
		}, Define.AIType.Attack, 30, 0, 190, 100), 18));
		m_FighterData.Add(19, new Fighter(17, 21, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot6)
		}, Define.AIType.Attack, 30, 0, 190, 100), 19));
		m_FighterData.Add(20, new Fighter(18, 16, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot10)
		}, Define.AIType.Attack, 30, 0, 190, 100), 20));
		m_FighterData.Add(21, new Fighter(19, 15, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot11)
		}, Define.AIType.Attack, 30, 0, 190, 100), 21));
		m_FighterData.Add(22, new Fighter(20, 14, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot12)
		}, Define.AIType.Attack, 30, 0, 190, 100), 22));
	}

	private void LoadEventData()
	{
		m_GameEvent.Add(-1, new GameEvent[4]
		{
			new GameEvent_MapLock(),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(19)
		});
		m_GameEvent.Add(0, new GameEvent[37]
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
			new GameEvent_ChooseActor(0, new Actor.ActorData[1]
			{
				new Actor.ActorData(5, 52)
			}),
			new GameEvent_ChooseActor(1, new Actor.ActorData[3]
			{
				new Actor.ActorData(0, 49),
				new Actor.ActorData(1, 50),
				new Actor.ActorData(2, 51)
			}),
			new GameEvent_ChooseActor(2, new Actor.ActorData[1]
			{
				new Actor.ActorData(7, 53)
			}),
			new GameEvent_ChooseActor(4, new Actor.ActorData[2]
			{
				new Actor.ActorData(4, 47),
				new Actor.ActorData(4, 48)
			}),
			new GameEvent_ChooseActor(5, new Actor.ActorData[4]
			{
				new Actor.ActorData(14, 43),
				new Actor.ActorData(14, 44),
				new Actor.ActorData(14, 45),
				new Actor.ActorData(14, 46)
			}),
			new GameEvent_ChooseActor(7, new Actor.ActorData[2]
			{
				new Actor.ActorData(11, 55),
				new Actor.ActorData(11, 56)
			}),
			new GameEvent_ChooseActor(8, new Actor.ActorData[1]
			{
				new Actor.ActorData(9, 54)
			}),
			new GameEvent_ChooseActor(6, new Actor.ActorData[2]
			{
				new Actor.ActorData(17, 70),
				new Actor.ActorData(17, 73)
			}),
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
			new GameEvent_GetFlag("YiWa", new List<GameEvent>
			{
				new GameEvent_LookFighter(10),
				new GameEvent_Dialogue("......?什么?这?真恶心......", "伊娃:", 39, Vector2.zero),
				new GameEvent_LookFighter(3),
				new GameEvent_Dialogue("伊娃,怎么啦?", "希塔:", 33, Vector2.zero),
				new GameEvent_LookFighter(10),
				new GameEvent_Dialogue("不知道,但这是什么......", "伊娃:", 39, Vector2.zero),
				new GameEvent_LookFighter(12),
				new GameEvent_Dialogue("感觉不好,伊娃怎么啦?", "普西:", 56, Vector2.zero),
				new GameEvent_LookFighter(11),
				new GameEvent_Dialogue("我总觉得伊娃在那里面.", "芬妮:", 38, Vector2.zero),
				new GameEvent_Dialogue("普西,你这个叛徒,杀了伊娃!", "芬妮:", 38, Vector2.zero),
				new GameEvent_LookFighter(9)
			}, new List<GameEvent>
			{
				new GameEvent_LookFighter(2),
				new GameEvent_Dialogue("什么,这样啊真带劲!", "加代:", 3, Vector2.zero),
				new GameEvent_LookFighter(5),
				new GameEvent_Dialogue("加代,轻视敌人会吃亏的!", "马丁:", 30, Vector2.zero)
			}),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(1, new GameEvent[2]
		{
			new GameEvent_LookFighter(12),
			new GameEvent_Dialogue("......有点难受......", "普西:", 56, Vector2.zero)
		});
		m_GameEvent.Add(5, new GameEvent[2]
		{
			new GameEvent_ChooseAI(11, Define.AIType.Attack),
			new GameEvent_ChooseAI(12, Define.AIType.Attack)
		});
	}
}
