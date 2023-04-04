using System.Collections.Generic;
using UnityEngine;

public class Define
{
	public struct Point
	{
		public int X;

		public int Y;

		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}
	}

	public struct MovePath
	{
		public int Drag;

		public List<Point> Path;

		public int Length => Path.Count;
	}

	public enum AIType
	{
		Null,
		Attack,
		Patrol,
		Passivity,
		Retreat,
		Counter
	}

	public enum UserTrait
	{
		GuangDunFangYu,
		FangYuTiXi,
		JianJieWuXiao,
		MinZhongGanRao,
		FanJiZuZhi,
		GongJiXiXue,
		BuKeYiDong,
		JiShaZaiDong,
		XiuFuXiTong,
		ShenMiJiTi,
		KuoNengZhuangZhi,
		ZhuangZaiJi,
		KuaiSuXueXi
	}

	public enum MenuType
	{
		Move,
		Deform,
		Spirit,
		State,
		Tool,
		Finish,
		Save,
		Troops,
		Attack,
		Suspend,
		Carry,
		Cancel,
		TakeOff,
		Capitulate
	}

	public enum EventType
	{
		Null = -1,
		Dialogue = 0,
		MapMove = 1,
		MapLock = 2,
		MapUnlock = 3,
		PlayBGM = 4,
		PlayME = 5,
		ChooseReprise = 6,
		AddFighter = 8,
		Victory = 9,
		ChooseAI = 10,
		NextFrame = 11,
		Damage = 12,
		SetAction = 13,
		ActorDie = 14,
		GameOver = 15,
		Replace = 16,
		LookFighter = 17,
		SetSwitch = 18,
		InspectSwitch = 19,
		MoveTo = 20,
		SetFlag = 21,
		ChooseActor = 22,
		GetFlag = 23,
		DoBattle = 24,
		WaitTime = 25,
		SwitchNHP = 26,
		DoVariant = 27,
		Repair = 28,
		PosSwitchSelf = 29,
		PosSwitchID = 30,
		IsCarry = 31,
		HasFighter = 32,
		SelfCount = 33,
		AddSwitch = 34,
		ShowEffect = 35,
		ShowShop = 36,
		SetSuccess = 37,
		AddAttr = 38,
		AlterItem = 39,
		AddExp = 40,
		SetStatus = 41,
		AddSP = 42,
		AddMoney = 43
	}

	public enum UserStatus
	{
		QiangGong,
		ReXue,
		MiaoZhun,
		BiSha,
		FangShou,
		GanRao,
		HuiBi,
		JiaSu,
		JiFeng
	}

	public enum GameState
	{
		Tittle,
		Wait,
		SelfAI,
		SelfAI_Move_Ready,
		SelfAI_Move,
		SelfAI_Attack_Ready,
		SelfAI_Attack,
		SelfAI_Move_Attack_Ready,
		SelfAI_Move_Attack,
		Enemy,
		Enemy_Move_Ready,
		Enemy_Move,
		Enemy_Attack_Ready,
		Enemy_Attack,
		Enemy_Move_Attack_Ready,
		Enemy_Move_Attack,
		Attack,
		Attack_Ready,
		DoEvent,
		DoEvent_Wait,
		DoEvent_Effect,
		DoEvent_Move,
		DoEvent_Time,
		TakeOff_Ready,
		TakeOffing,
		TakeOff_Over,
		TakeOff_Attack_Ready,
		TakeOff_Attack,
		Move_Ready,
		Moveing,
		Move_Over,
		Move_Attack_Ready,
		Move_Attack,
		Spirit_One,
		Spirit_Two,
		Tools_One
	}

	private static int[][] m_Affect = new int[3][]
	{
		new int[8] { 2, 1, 4, 3, 3, 2, 2, 2 },
		new int[8] { 1, 3, 3, 2, 2, 2, 1, 1 },
		new int[8] { 1, 1, 1, 1, 1, 1, 1, 1 }
	};

	private static int[] m_LevelUpExp = new int[51]
	{
		0, 30, 50, 90, 140, 290, 300, 400, 500, 600,
		600, 800, 780, 930, 1210, 960, 1020, 1080, 1140, 1200,
		1260, 1320, 1380, 1440, 1500, 1560, 1620, 1680, 1800, 1800,
		1860, 1800, 1980, 2040, 2100, 2220, 2220, 2280, 2340, 2400,
		2460, 2560, 1000, 1050, 1100, 1160, 1220, 1280, 1100, 1400,
		2245
	};

	public static int WindowWidth => Screen.width;

	public static int WindowHeight => Screen.height;

	public static float MapElementWidth => 125f;

	public static int GetAffect(Robot.EngineType engineType, Terrain.TerrainType terrainType)
	{
		return m_Affect[(int)engineType][(int)terrainType];
	}

	public static int GetLevelNextExp(int level)
	{
		if (level > 50 || level < 0)
		{
			return level * level;
		}
		return m_LevelUpExp[level];
	}

	public static int GetKillExp(int levela, int levelb, int expb)
	{
		int num = expb * levelb;
		int num2 = levelb - levela;
		int num3 = 0;
		if (num2 < 0)
		{
			num3 = ((-num2 >= 7) ? 1 : (num / (-num2 * 10)));
		}
		else
		{
			num3 = num * (num2 + 2) / 10;
			if (num3 > num)
			{
				num3 = num;
			}
		}
		return num3;
	}

	public static int GetTerrainHit(Terrain.TerrainType terrainType)
	{
		if (terrainType == Terrain.TerrainType.Forest || terrainType == Terrain.TerrainType.Mountain || terrainType == Terrain.TerrainType.Sea)
		{
			return 80;
		}
		return 100;
	}

	public static string TraitString(UserTrait trait)
	{
		return trait switch
		{
			UserTrait.GuangDunFangYu => "光盾防御", 
			UserTrait.FangYuTiXi => "防御体系", 
			UserTrait.JianJieWuXiao => "间接无效", 
			UserTrait.MinZhongGanRao => "命中干扰", 
			UserTrait.FanJiZuZhi => "反击阻止", 
			UserTrait.GongJiXiXue => "攻击吸血", 
			UserTrait.BuKeYiDong => "不可移动", 
			UserTrait.JiShaZaiDong => "击杀再动", 
			UserTrait.XiuFuXiTong => "修复系统", 
			UserTrait.ShenMiJiTi => "神秘机体", 
			UserTrait.KuoNengZhuangZhi => "扩能装置", 
			UserTrait.ZhuangZaiJi => "转载机", 
			UserTrait.KuaiSuXueXi => "快速学习", 
			_ => string.Empty, 
		};
	}
}
