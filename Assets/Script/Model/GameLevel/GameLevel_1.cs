using System.Collections.Generic;
using UnityEngine;

public class GameLevel_1 : Level
{
	public GameLevel_1()
	{
		m_Name = "第1篇: 救出刚达Z";
		m_Task = "全歼敌人即胜利!";
		m_Map = new Map(16, 20, new byte[320]
		{
			1, 0, 0, 1, 1, 3, 3, 3, 2, 1,
			1, 1, 1, 1, 1, 1, 1, 0, 2, 0,
			1, 3, 3, 0, 0, 0, 0, 10, 11, 1,
			1, 1, 1, 2, 2, 3, 2, 2, 0, 0,
			0, 0, 2, 12, 13, 1, 1, 1, 1, 1,
			2, 0, 0, 0, 0, 0, 0, 0, 0, 5,
			5, 1, 1, 1, 1, 3, 2, 0, 0, 0,
			0, 0, 0, 0, 0, 2, 5, 5, 1, 1,
			4, 3, 3, 2, 0, 0, 0, 0, 0, 0,
			0, 0, 2, 5, 1, 1, 4, 3, 4, 2,
			0, 0, 3, 0, 0, 0, 0, 5, 5, 5,
			5, 5, 4, 4, 4, 2, 2, 1, 1, 0,
			0, 0, 0, 0, 5, 5, 6, 6, 4, 3,
			3, 3, 0, 3, 1, 1, 1, 1, 1, 0,
			0, 1, 1, 6, 3, 3, 3, 2, 2, 0,
			0, 1, 1, 1, 1, 1, 0, 0, 1, 6,
			1, 3, 2, 0, 0, 0, 0, 2, 1, 1,
			1, 1, 1, 1, 1, 1, 1, 1, 2, 0,
			0, 9, 0, 0, 0, 2, 2, 1, 1, 1,
			1, 1, 1, 1, 1, 1, 0, 2, 1, 1,
			0, 0, 8, 2, 1, 1, 1, 1, 7, 1,
			1, 1, 1, 1, 1, 1, 1, 0, 0, 0,
			2, 1, 1, 2, 7, 7, 1, 1, 1, 1,
			0, 0, 0, 0, 0, 2, 2, 1, 2, 2,
			7, 7, 7, 6, 0, 0, 0, 0, 0, 0,
			0, 0, 4, 2, 2, 0, 7, 7, 7, 6,
			6, 0, 0, 0, 0, 0, 0, 0, 0, 0,
			2, 0, 7, 7, 7, 7, 6, 0, 0, 0,
			3, 0, 0, 0, 0, 0, 0, 0, 7, 7,
			7, 7, 6, 6, 6, 0, 0, 0, 0, 4,
			0, 2, 4, 0, 7, 7, 7, 7, 7, 7,
			6, 0, 0, 0, 0, 0, 0, 0, 4, 4
		});
		m_SelfBGM = 0;
		m_EnemyBGM = 1;
		m_Hospital.Add(new Define.Point(10, 12));
		LoadEnemyData();
		LoadActorData();
		LoadEventData();
	}

	private void LoadActorData()
	{
		m_FighterData.Add(0, new Fighter(15, 19, GameDataBase.Instance.GetActor(0), 0));
		m_FighterData.Add(1, new Fighter(14, 18, GameDataBase.Instance.GetActor(1), 1));
		m_FighterData.Add(2, new Fighter(14, 16, GameDataBase.Instance.GetActor(2), 2));
		m_FighterData.Add(3, new Fighter(13, 17, GameDataBase.Instance.GetActor(3), 3));
		m_FighterData.Add(4, new Fighter(12, 16, GameDataBase.Instance.GetActor(4), 4));
		m_FighterData.Add(5, new Fighter(12, 18, GameDataBase.Instance.GetActor(5), 5));
		m_FighterData.Add(6, new Fighter(12, 1, GameDataBase.Instance.GetActor(6), 6));
	}

	private void LoadEnemyData()
	{
		Robot robot = new Robot("宰恩II", Robot.EngineType.Land, 4, 8, 5, 450, 81, 45, 49, new int[2] { 2, 3 });
		Robot robot2 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 190, 43, 31, 58, new int[2] { 0, 1 });
		Robot robot3 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 190, 43, 31, 58, new int[2] { 0, 1 });
		Robot robot4 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 190, 43, 31, 58, new int[2] { 0, 1 });
		Robot robot5 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 185, 42, 30, 57, new int[2] { 0, 1 });
		Robot robot6 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 185, 42, 30, 57, new int[2] { 0, 1 });
		Robot robot7 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 185, 42, 30, 57, new int[2] { 0, 1 });
		Robot robot8 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 180, 40, 28, 55, new int[2] { 0, 1 });
		Robot robot9 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 180, 40, 28, 55, new int[2] { 0, 1 });
		Robot robot10 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 180, 40, 28, 55, new int[2] { 0, 1 });
		Robot robot11 = new Robot("布达MZ", Robot.EngineType.Land, 6, 10, 4, 345, 64, 25, 35, new int[2] { 4, 5 });
		Robot robot12 = new Robot("拉达K7", Robot.EngineType.Land, 9, 11, 4, 350, 60, 25, 35, new int[2] { 6, 7 });
		Robot robot13 = new Robot("巴勒", Robot.EngineType.Land, 5, 9, 5, 240, 73, 23, 66, new int[2] { 7, 8 });
		Robot robot14 = new Robot("扎克", Robot.EngineType.Land, 15, 7, 10, 500, 104, 66, 98, new int[2] { 0, 1 });
		Robot robot15 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 200, 46, 34, 61, new int[2] { 0, 1 });
		Robot robot16 = new Robot("扎克", Robot.EngineType.Land, 8, 7, 4, 185, 42, 30, 57, new int[2] { 0, 1 });
		User user = new User("士兵", 6, null);
		User user2 = new User("凯", 11, null);
		User user3 = new User("莫尼", 6, null);
		User user4 = new User("邓肯", 6, null);
		m_FighterData.Add(7, new Fighter(12, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot)
		}, Define.AIType.Passivity, 4, 0, 100, 150), 7));
		m_FighterData.Add(8, new Fighter(9, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot2)
		}, Define.AIType.Patrol, 3, 0, 90, 80), 8));
		m_FighterData.Add(9, new Fighter(10, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot3)
		}, Define.AIType.Patrol, 3, 0, 90, 80), 9));
		m_FighterData.Add(10, new Fighter(11, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot4)
		}, Define.AIType.Patrol, 3, 0, 90, 80), 10));
		m_FighterData.Add(11, new Fighter(8, 3, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot5)
		}, Define.AIType.Patrol, 2, 0, 90, 80), 11));
		m_FighterData.Add(12, new Fighter(9, 4, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot6)
		}, Define.AIType.Patrol, 2, 0, 90, 80), 12));
		m_FighterData.Add(13, new Fighter(10, 5, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot7)
		}, Define.AIType.Patrol, 2, 0, 90, 80), 13));
		m_FighterData.Add(14, new Fighter(3, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot8)
		}, Define.AIType.Attack, 1, 0, 90, 80), 14));
		m_FighterData.Add(15, new Fighter(4, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot9)
		}, Define.AIType.Attack, 1, 0, 90, 80), 15));
		m_FighterData.Add(16, new Fighter(5, 10, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot10)
		}, Define.AIType.Attack, 1, 0, 90, 80), 16));
		m_FighterData.Add(17, new Fighter(7, 6, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot11)
		}, Define.AIType.Attack, 1, 0, 125, 100), 17));
		m_FighterData.Add(18, new Fighter(8, 7, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(null, robot12)
		}, Define.AIType.Attack, 1, 0, 110, 100), 18));
		m_FighterData.Add(19, new Fighter(10, 2, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user, robot13)
		}, Define.AIType.Patrol, 3, 0, 90, 100), 19));
		m_FighterData.Add(20, new Fighter(1, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user2, robot14)
		}, Define.AIType.Patrol, 13, 0, 110, 80), 20));
		m_FighterData.Add(21, new Fighter(2, 0, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user3, robot15)
		}, Define.AIType.Attack, 5, 0, 90, 80), 21));
		m_FighterData.Add(22, new Fighter(2, 1, new Actor(new Actor.ActorDataEx[1]
		{
			new Actor.ActorDataEx(user4, robot16)
		}, Define.AIType.Attack, 2, 0, 90, 80), 22));
		m_FighterEvent.Add(21, new GameEvent[1]
		{
			new GameEvent_HasFighter(22, new List<GameEvent>(), new List<GameEvent>
			{
				new GameEvent_ChooseAI(20, Define.AIType.Retreat)
			})
		});
		m_FighterEvent.Add(22, new GameEvent[1]
		{
			new GameEvent_HasFighter(21, new List<GameEvent>(), new List<GameEvent>
			{
				new GameEvent_ChooseAI(20, Define.AIType.Retreat)
			})
		});
	}

	private void LoadEventData()
	{
		HashSet<Define.Point> hashSet = new HashSet<Define.Point>();
		for (int i = 0; i < 16; i++)
		{
			for (int j = 0; j < 20; j++)
			{
				if (i == 0 || j == 0 || i == 15 || j == 19)
				{
					hashSet.Add(new Define.Point(i, j));
				}
			}
		}
		GameEvent gameEvent = new GameEvent_HasFighter(21, new List<GameEvent>(), new List<GameEvent>
		{
			new GameEvent_HasFighter(22, new List<GameEvent>(), new List<GameEvent>
			{
				new GameEvent_PosSwitchID(20, hashSet, new List<GameEvent>
				{
					new GameEvent_LookFighter(20),
					new GameEvent_Dialogue("我真不愿看年亲人犯错误......", "凯:", 11, Vector2.zero),
					new GameEvent_WaitTime(0.5f),
					new GameEvent_Replace(20, -1),
					new GameEvent_WaitTime(0.5f)
				})
			})
		});
		m_MoveOverEvent = new GameEvent[1] { gameEvent };
		m_GameEventEvery = new GameEvent[1] { gameEvent };
		m_GameEvent.Add(-1, new GameEvent[38]
		{
			new GameEvent_PlayBGM(4),
			new GameEvent_MapLock(),
			new GameEvent_AddFighter(6),
			new GameEvent_LookFighter(6),
			new GameEvent_Dialogue("谢谢大家救了我.", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("你太大意了,卡姆", "大卫:", 4, Vector2.zero),
			new GameEvent_Dialogue("是的,我确实太大意了.", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("但敌人的实力大大超出我的预想.", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("特别是那个蓝色机器人,非常厉害.", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("要是碰上了能否生还......", "卡姆:", 7, Vector2.zero),
			new GameEvent_Dialogue("嗯,敌人好像还有不少秘密武器.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("看来还得小心呐......", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("在这拖延也没用,快走吧", "杰克:", 1, Vector2.zero),
			new GameEvent_Dialogue("我们现在急需补充物资.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("有必要在这附近的某个基地补充一下.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("这附近的补给基地,玛利基地......", "由美:", 2, Vector2.zero),
			new GameEvent_Dialogue("我觉得那里应该有人......", "由美:", 2, Vector2.zero),
			new GameEvent_Dialogue("马利基地吗?米奇尔准在那.", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("就让他帮忙吧.", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("是嘛!快联系,由美,准备激光通讯机.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("是!...", "由美:", 2, Vector2.zero),
			new GameEvent_Dialogue("舰长,接通了.", "由美:", 2, Vector2.zero),
			new GameEvent_Dialogue("接到监视器上去.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("大家好,好久不见了,欧文,龙.路易", "米奇尔:", 8, Vector2.zero),
			new GameEvent_Dialogue("看上去都不错嘛!", "米奇尔:", 8, Vector2.zero),
			new GameEvent_Dialogue("米奇尔!", "路易:", 9, Vector2.zero),
			new GameEvent_Dialogue("米奇尔,你那还没被DC侵略吗?", "龙:", 5, Vector2.zero),
			new GameEvent_Dialogue("是的,你们很需要补给吧.", "米奇尔:", 8, Vector2.zero),
			new GameEvent_Dialogue("我已经准备好了,来取吧!", "米奇尔:", 8, Vector2.zero),
			new GameEvent_Dialogue("到底是米奇尔!太好了!", "路易:", 9, Vector2.zero),
			new GameEvent_Dialogue("OK!我先走一步,去马利道个谢.", "杰克:", 1, Vector2.zero),
			new GameEvent_Dialogue("杰克!你小子想抢先!", "路易:", 9, Vector2.zero),
			new GameEvent_Dialogue("不饶人的路易,这里交给杰克.", "欧文:", 10, Vector2.zero),
			new GameEvent_Dialogue("反正你不能去.", "欧文:", 10, Vector2.zero),
			new GameEvent_Dialogue("嗨,我知道.", "路易:", 9, Vector2.zero),
			new GameEvent_Repair(),
			new GameEvent_MapUnlock(),
			new GameEvent_Victory(1)
		});
		m_GameEvent.Add(0, new GameEvent[34]
		{
			new GameEvent_PlayBGM(4),
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
			new GameEvent_MapLock(),
			new GameEvent_MapMove(15, 19),
			new GameEvent_Dialogue("很好,正如情报所说,敌人防守较差.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("全歼他们!救出刚达Z.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("是!我去把他们全干掉!", "加代:", 3, Vector2.zero),
			new GameEvent_Dialogue("加代,可不能蛮干呀!", "由美:", 2, Vector2.zero),
			new GameEvent_Dialogue("HP减少的话,我给你修理.", "由美:", 2, Vector2.zero),
			new GameEvent_Dialogue("如果有人受伤,不要勉强.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("让阿波罗A给你们修理.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("或者回我这里.", "乔:", 0, Vector2.zero),
			new GameEvent_Dialogue("明白了,舰长", "大卫:", 4, Vector2.zero),
			new GameEvent_PlayBGM(m_SelfBGM),
			new GameEvent_ChooseReprise(1),
			new GameEvent_MapUnlock()
		});
		m_GameEvent.Add(8, new GameEvent[3]
		{
			new GameEvent_ChooseAI(8, Define.AIType.Attack),
			new GameEvent_ChooseAI(11, Define.AIType.Attack),
			new GameEvent_ChooseAI(12, Define.AIType.Attack)
		});
		m_GameEvent.Add(11, new GameEvent[21]
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
			new GameEvent_LookFighter(20),
			new GameEvent_Dialogue("真走运,居然在这儿碰上这么好的猎物......", "凯:", 11, Vector2.zero),
			new GameEvent_Dialogue("我们先去侦查一下.", "莫尼:", 6, Vector2.zero),
			new GameEvent_Dialogue("嗯,在了解敌情之前不可贸然进攻.", "凯:", 11, Vector2.zero),
			new GameEvent_Dialogue("是!金,出发!", "莫尼:", 6, Vector2.zero),
			new GameEvent_Dialogue("是!", "邓肯:", 6, Vector2.zero),
			new GameEvent_ChooseAI(7, Define.AIType.Attack),
			new GameEvent_ChooseAI(9, Define.AIType.Attack),
			new GameEvent_ChooseAI(10, Define.AIType.Attack),
			new GameEvent_ChooseAI(13, Define.AIType.Attack),
			new GameEvent_ChooseAI(19, Define.AIType.Attack)
		});
	}
}
