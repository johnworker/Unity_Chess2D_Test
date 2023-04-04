using System.Collections.Generic;
using UnityEngine;

public class GameLevel_27 : Level
{
	public GameLevel_27()
	{
		m_Name = "第27篇: 决战时刻";
		m_Task = "打败古兰森!";
		m_Map = new Map(20, 23, new byte[460]
		{
			23, 23, 23, 23, 23, 23, 23, 23, 23, 23,
			23, 23, 23, 23, 23, 23, 23, 23, 23, 23,
			23, 24, 24, 24, 24, 24, 23, 23, 23, 23,
			23, 23, 23, 23, 24, 24, 24, 24, 24, 23,
			23, 21, 21, 21, 21, 23, 24, 24, 24, 24,
			24, 24, 24, 24, 23, 21, 21, 21, 21, 23,
			23, 20, 20, 20, 23, 24, 42, 42, 42, 42,
			42, 42, 42, 42, 24, 23, 20, 20, 20, 23,
			23, 20, 20, 23, 24, 42, 43, 43, 43, 43,
			43, 43, 43, 43, 42, 24, 23, 20, 20, 23,
			23, 20, 20, 23, 42, 43, 43, 43, 43, 43,
			43, 43, 43, 43, 43, 42, 23, 20, 20, 23,
			23, 20, 20, 23, 43, 43, 43, 43, 43, 43,
			43, 43, 43, 43, 43, 43, 23, 20, 20, 23,
			23, 20, 20, 23, 43, 43, 43, 43, 43, 43,
			43, 43, 43, 43, 43, 43, 23, 20, 20, 23,
			23, 20, 20, 23, 43, 43, 43, 43, 43, 43,
			43, 43, 43, 43, 43, 43, 23, 20, 20, 23,
			23, 20, 20, 24, 23, 43, 43, 43, 43, 43,
			43, 43, 43, 43, 43, 23, 24, 20, 20, 23,
			23, 20, 20, 21, 24, 23, 43, 43, 43, 43,
			43, 43, 43, 43, 23, 24, 21, 20, 20, 23,
			23, 20, 20, 20, 21, 24, 24, 23, 43, 43,
			43, 43, 23, 24, 24, 21, 20, 20, 20, 23,
			23, 20, 23, 20, 20, 21, 21, 23, 20, 43,
			43, 20, 23, 21, 21, 20, 20, 23, 20, 23,
			23, 23, 23, 23, 20, 20, 20, 23, 20, 43,
			43, 20, 23, 20, 20, 20, 23, 23, 23, 23,
			23, 23, 23, 23, 20, 20, 20, 23, 20, 43,
			43, 20, 23, 20, 20, 20, 23, 23, 23, 23,
			23, 23, 23, 23, 20, 20, 20, 23, 20, 43,
			43, 20, 23, 20, 20, 20, 23, 23, 23, 23,
			23, 23, 23, 23, 20, 20, 20, 23, 20, 43,
			43, 20, 23, 20, 20, 20, 23, 23, 23, 23,
			23, 24, 23, 24, 20, 20, 20, 23, 20, 43,
			43, 20, 23, 20, 20, 20, 24, 23, 24, 23,
			23, 21, 24, 21, 20, 20, 23, 23, 20, 43,
			43, 20, 23, 23, 20, 20, 21, 24, 21, 23,
			23, 20, 21, 20, 20, 23, 23, 23, 20, 43,
			43, 20, 23, 23, 23, 20, 20, 21, 20, 23,
			23, 20, 20, 20, 20, 24, 24, 24, 24, 43,
			43, 24, 24, 24, 24, 20, 20, 20, 20, 23,
			23, 20, 20, 20, 20, 21, 21, 21, 21, 43,
			43, 21, 21, 21, 21, 20, 20, 20, 20, 23,
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
		m_FighterData.Add(0, new Fighter(9, 16, GameDataBase.Instance.GetActor(4), 0));
		m_FighterData.Add(1, new Fighter(10, 16, GameDataBase.Instance.GetActor(5), 1));
		m_FighterData.Add(2, new Fighter(8, 17, GameDataBase.Instance.GetActor(3), 2));
		m_FighterData.Add(3, new Fighter(11, 17, GameDataBase.Instance.GetActor(14), 3));
		m_FighterData.Add(4, new Fighter(10, 17, GameDataBase.Instance.GetActor(6), 4));
		m_FighterData.Add(5, new Fighter(9, 18, GameDataBase.Instance.GetActor(13), 5));
		m_FighterData.Add(6, new Fighter(9, 17, GameDataBase.Instance.GetActor(16), 6));
		m_FighterData.Add(7, new Fighter(10, 18, GameDataBase.Instance.GetActor(9), 7));
		m_FighterData.Add(8, new Fighter(8, 18, GameDataBase.Instance.GetActor(7), 8));
		m_FighterData.Add(9, new Fighter(11, 18, GameDataBase.Instance.GetActor(17), 9));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("古兰森", Robot.EngineType.Land, 102, 88, 8, 4500, 275, 220, 235, new int[2] { 132, 133 }, new Define.UserTrait[3]
		{
			Define.UserTrait.JianJieWuXiao,
			Define.UserTrait.GongJiXiXue,
			Define.UserTrait.JiShaZaiDong
		});
		User user = new User("休", 57, null);
		m_FighterData.Add(10, new Fighter(10, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot)
		}, Define.AIType.Attack, 39, 0, 400, 5000, 13), 10));
	}

	private void LoadEventData()
	{
		GameEvent[] value = new GameEvent[11]
		{
			new GameEvent_MapLock(),
			new GameEvent_PlayBGM(4),
			new GameEvent_Dialogue("是我输了...再见了,各位!", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("蓝色机器人......", "大卫:", 4, Vector2.zero),
			new GameEvent_Dialogue("不得不说,真的是强大的对手呢.", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("真不容易呐.", "安东:", 27, Vector2.zero),
			new GameEvent_Dialogue("不过总算是解决了.", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("结束了,准备返航.......", "马丁:", 30, Vector2.zero),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(-1)
		};
		m_GameEvent.Add(-1, value);
		m_FighterEvent.Add(10, value);
		m_GameEvent.Add(0, new GameEvent[24]
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
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("战斗结束了吗?", "休:", 57, Vector2.zero),
			new GameEvent_Dialogue("我还有点意犹未尽呢!", "休:", 57, Vector2.zero),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("呵!你也有点太自大了吧.", "安东:", 27, Vector2.zero),
			new GameEvent_LookFighter(10),
			new GameEvent_Dialogue("哼!来吧,见识见识古兰森的恐怖", "休:", 57, Vector2.zero),
			new GameEvent_LookFighter(0),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
	}
}
