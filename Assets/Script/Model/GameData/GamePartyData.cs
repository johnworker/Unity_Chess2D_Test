using System.Collections.Generic;

public class GamePartyData
{
	private List<Actor> m_ActorData = new List<Actor>();

	private int m_NowLevel;

	private int m_GamePlus = 1;

	private int m_NowMoney = 1000;

	private Dictionary<string, int> m_Flag = new Dictionary<string, int>();

	private List<Robot> m_Robot = new List<Robot>();

	private List<User> m_User = new List<User>();

	private Dictionary<int, int> m_Items = new Dictionary<int, int>();

	public Dictionary<int, int> Items => m_Items;

	public int NowLevel
	{
		get
		{
			return m_NowLevel;
		}
		set
		{
			m_NowLevel = value;
		}
	}

	public int GamePlus
	{
		get
		{
			return m_GamePlus;
		}
		set
		{
			m_GamePlus = value;
		}
	}

	public int NowMoney
	{
		get
		{
			return m_NowMoney;
		}
		set
		{
			m_NowMoney = value;
		}
	}

	public Actor this[int id] => m_ActorData[id];

	public GamePartyData()
	{
		m_Robot.Add(new Robot("怀特", Robot.EngineType.Sky, 7, 0, 5, 400, 80, 40, 35, new int[2] { 9, 10 }, new Define.UserTrait[1] { Define.UserTrait.ZhuangZaiJi }));
		m_Robot.Add(new Robot("刚达", Robot.EngineType.Land, 0, 6, 6, 320, 70, 55, 72, new int[2] { 17, 18 }));
		m_Robot.Add(new Robot("金Z", Robot.EngineType.Land, 16, 3, 5, 360, 85, 70, 45, new int[2] { 15, 16 }));
		m_Robot.Add(new Robot("阿波罗A", Robot.EngineType.Land, 17, 4, 5, 280, 68, 55, 50, new int[2] { 13, 14 }, new Define.UserTrait[1] { Define.UserTrait.XiuFuXiTong }));
		m_Robot.Add(new Robot("泰勒", Robot.EngineType.Sky, 10, 1, 6, 290, 70, 45, 52, new int[2] { 11, 12 }));
		m_Robot.Add(new Robot("刚达Z", Robot.EngineType.Land, 2, 5, 6, 360, 77, 59, 79, new int[2] { 17, 18 }));
		m_Robot.Add(new Robot("韦尔", Robot.EngineType.Sky, 18, 5, 9, 360, 79, 59, 78, new int[1] { 9 }));
		m_Robot.Add(new Robot("盖塔1", Robot.EngineType.Sky, 12, 2, 7, 310, 90, 55, 55, new int[2] { 19, 20 }));
		m_Robot.Add(new Robot("盖塔2", Robot.EngineType.Land, 13, 12, 8, 310, 85, 55, 73, new int[2] { 21, 22 }));
		m_Robot.Add(new Robot("盖塔3", Robot.EngineType.Sea, 14, 13, 8, 310, 95, 60, 48, new int[2] { 23, 24 }));
		m_Robot.Add(new Robot("F91", Robot.EngineType.Land, 25, 20, 8, 470, 102, 77, 96, new int[2] { 25, 26 }, new Define.UserTrait[1]));
		m_Robot.Add(new Robot("艾文", Robot.EngineType.Sky, 26, 25, 8, 410, 89, 60, 106, new int[2] { 34, 35 }));
		m_Robot.Add(new Robot("阿格马", Robot.EngineType.Sky, 33, 29, 6, 480, 80, 40, 35, new int[2] { 42, 43 }, new Define.UserTrait[1] { Define.UserTrait.ZhuangZaiJi }));
		m_Robot.Add(new Robot("麦塔斯", Robot.EngineType.Land, 35, 30, 6, 390, 78, 63, 78, new int[2] { 44, 14 }, new Define.UserTrait[2]
		{
			Define.UserTrait.JiShaZaiDong,
			Define.UserTrait.KuaiSuXueXi
		}));
		m_Robot.Add(new Robot("麦塔斯", Robot.EngineType.Sky, 34, 30, 8, 390, 68, 58, 78, new int[2] { 44, 14 }, new Define.UserTrait[2]
		{
			Define.UserTrait.JiShaZaiDong,
			Define.UserTrait.KuaiSuXueXi
		}));
		m_Robot.Add(new Robot("麦乔", Robot.EngineType.Sky, 41, 37, 9, 530, 111, 76, 97, new int[2] { 51, 52 }, new Define.UserTrait[1] { Define.UserTrait.FanJiZuZhi }));
		m_Robot.Add(new Robot("金Z", Robot.EngineType.Land, 16, 3, 5, 360, 85, 70, 45, new int[2] { 59, 60 }));
		m_Robot.Add(new Robot("米巴X", Robot.EngineType.Land, 50, 48, 5, 470, 109, 76, 74, new int[2] { 15, 60 }, new Define.UserTrait[1] { Define.UserTrait.XiuFuXiTong }));
		m_Robot.Add(new Robot("博思", Robot.EngineType.Land, 55, 47, 5, 525, 127, 83, 78, new int[1] { 15 }));
		m_Robot.Add(new Robot("古莲", Robot.EngineType.Land, 52, 43, 5, 590, 135, 108, 95, new int[2] { 61, 62 }));
		m_Robot.Add(new Robot("斯帕", Robot.EngineType.Sky, 54, 43, 7, 590, 135, 108, 95, new int[2] { 67, 68 }));
		m_Robot.Add(new Robot("刚达Z", Robot.EngineType.Land, 2, 5, 6, 360, 77, 59, 79, new int[2] { 25, 26 }));
		m_Robot.Add(new Robot("韦尔", Robot.EngineType.Sky, 18, 5, 9, 360, 79, 59, 78, new int[1] { 42 }));
		m_Robot.Add(new Robot("刚达", Robot.EngineType.Land, 0, 6, 6, 320, 70, 55, 72, new int[2] { 25, 26 }));
		m_Robot.Add(new Robot("刚达ZZ", Robot.EngineType.Land, 3, 50, 6, 570, 138, 97, 100, new int[2] { 69, 70 }));
		m_Robot.Add(new Robot("齐托", Robot.EngineType.Sky, 57, 50, 8, 570, 138, 97, 102, new int[2] { 7, 71 }));
		m_Robot.Add(new Robot("刚达", Robot.EngineType.Land, 36, 32, 5, 790, 161, 115, 85, new int[1] { 45 }));
		m_Robot.Add(new Robot("刚达", Robot.EngineType.Sky, 58, 32, 6, 790, 161, 115, 85, new int[2] { 45, 72 }));
		m_Robot.Add(new Robot("巴斯塔", Robot.EngineType.Land, 63, 38, 8, 400, 118, 86, 111, new int[2] { 78, 53 }));
		m_Robot.Add(new Robot("巴得", Robot.EngineType.Sky, 44, 38, 10, 400, 118, 81, 111, new int[1] { 53 }));
		m_Robot.Add(new Robot("刚达R", Robot.EngineType.Land, 1, 61, 7, 420, 100, 70, 92, new int[2] { 69, 80 }));
		m_Robot.Add(new Robot("金", Robot.EngineType.Sky, 67, 65, 7, 450, 105, 85, 50, new int[2] { 84, 85 }));
		m_Robot.Add(new Robot("盖塔龙", Robot.EngineType.Sky, 68, 62, 8, 400, 132, 54, 60, new int[2] { 81, 82 }));
		m_Robot.Add(new Robot("盖塔虎", Robot.EngineType.Land, 69, 63, 11, 400, 120, 50, 79, new int[2] { 86, 87 }));
		m_Robot.Add(new Robot("盖塔海神", Robot.EngineType.Sea, 70, 64, 7, 400, 133, 55, 52, new int[2] { 88, 89 }));
		m_Robot.Add(new Robot("奈尔", Robot.EngineType.Sky, 71, 60, 7, 530, 100, 44, 39, new int[2] { 74, 83 }, new Define.UserTrait[1] { Define.UserTrait.ZhuangZaiJi }));
		m_Robot.Add(new Robot("刚达Z", Robot.EngineType.Land, 2, 5, 6, 360, 77, 59, 79, new int[2] { 69, 71 }));
		m_Robot.Add(new Robot("韦尔", Robot.EngineType.Sky, 18, 5, 9, 360, 79, 59, 78, new int[1] { 105 }));
		m_Robot.Add(new Robot("古莲", Robot.EngineType.Land, 52, 43, 5, 590, 135, 108, 95, new int[2] { 92, 93 }));
		m_Robot.Add(new Robot("双帕", Robot.EngineType.Sky, 78, 43, 7, 590, 135, 108, 95, new int[2] { 90, 91 }));
		m_Robot.Add(new Robot("麦塔斯", Robot.EngineType.Land, 35, 30, 6, 390, 78, 63, 78, new int[2] { 69, 14 }, new Define.UserTrait[2]
		{
			Define.UserTrait.JiShaZaiDong,
			Define.UserTrait.KuaiSuXueXi
		}));
		m_Robot.Add(new Robot("麦塔斯", Robot.EngineType.Sky, 34, 30, 8, 390, 68, 58, 78, new int[2] { 9, 14 }, new Define.UserTrait[2]
		{
			Define.UserTrait.JiShaZaiDong,
			Define.UserTrait.KuaiSuXueXi
		}));
		m_Robot.Add(new Robot("吉伯II", Robot.EngineType.Land, 73, 84, 9, 670, 139, 109, 153, new int[2] { 69, 94 }));
		m_Robot.Add(new Robot("古莲", Robot.EngineType.Land, 52, 43, 5, 590, 135, 108, 95, new int[2] { 120, 121 }));
		m_Robot.Add(new Robot("双帕", Robot.EngineType.Sky, 78, 43, 7, 590, 135, 108, 95, new int[2] { 130, 131 }));
		m_Robot.Add(new Robot("钻帕", Robot.EngineType.Sky, 100, 43, 7, 590, 135, 108, 95, new int[2] { 122, 123 }));
		m_Robot.Add(new Robot("德帕", Robot.EngineType.Sky, 101, 43, 7, 590, 135, 108, 95, new int[2] { 124, 125 }));
		m_Robot.Add(new Robot("刚达Z", Robot.EngineType.Land, 2, 5, 6, 360, 77, 59, 79, new int[2] { 103, 118 }));
		m_Robot.Add(new Robot("韦尔", Robot.EngineType.Sky, 18, 5, 9, 360, 79, 59, 78, new int[1] { 118 }));
		m_Robot.Add(new Robot("盖塔龙", Robot.EngineType.Sky, 68, 62, 8, 400, 132, 54, 60, new int[2] { 114, 115 }));
		m_Robot.Add(new Robot("盖塔虎", Robot.EngineType.Land, 69, 63, 11, 400, 120, 50, 79, new int[2] { 126, 127 }));
		m_Robot.Add(new Robot("盖塔海神", Robot.EngineType.Sea, 70, 64, 7, 400, 133, 55, 52, new int[2] { 128, 129 }));
		m_Robot.Add(new Robot("刚达R", Robot.EngineType.Land, 1, 61, 7, 420, 100, 70, 92, new int[2] { 103, 113 }));
		m_Robot.Add(new Robot("金", Robot.EngineType.Sky, 67, 65, 7, 450, 105, 85, 50, new int[2] { 116, 117 }));
		m_Robot.Add(new Robot("F91", Robot.EngineType.Land, 25, 20, 8, 470, 102, 77, 96, new int[2] { 103, 119 }, new Define.UserTrait[1]));
		m_Robot.Add(new Robot("麦塔斯", Robot.EngineType.Land, 35, 30, 6, 390, 78, 63, 78, new int[2] { 103, 14 }, new Define.UserTrait[2]
		{
			Define.UserTrait.JiShaZaiDong,
			Define.UserTrait.KuaiSuXueXi
		}));
		m_Robot.Add(new Robot("麦塔斯", Robot.EngineType.Sky, 34, 30, 8, 390, 68, 58, 78, new int[2] { 42, 14 }, new Define.UserTrait[2]
		{
			Define.UserTrait.JiShaZaiDong,
			Define.UserTrait.KuaiSuXueXi
		}));
		m_Robot.Add(new Robot("奈尔", Robot.EngineType.Sky, 71, 60, 8, 530, 100, 44, 39, new int[2] { 74, 83 }, new Define.UserTrait[2]
		{
			Define.UserTrait.BuKeYiDong,
			Define.UserTrait.ZhuangZaiJi
		}));
		m_Robot.Add(new Robot("拉姆", Robot.EngineType.Sky, 103, 89, 8, 700, 120, 60, 50, new int[2] { 48, 83 }, new Define.UserTrait[2]
		{
			Define.UserTrait.BuKeYiDong,
			Define.UserTrait.ZhuangZaiJi
		}));
		m_Robot.Add(new Robot("拉姆", Robot.EngineType.Sky, 103, 89, 8, 700, 120, 60, 50, new int[2] { 48, 83 }, new Define.UserTrait[1] { Define.UserTrait.ZhuangZaiJi }));
		m_Robot.Add(new Robot("刚达Z", Robot.EngineType.Land, 2, 5, 6, 360, 77, 59, 79, new int[2] { 65, 141 }));
		m_Robot.Add(new Robot("韦尔", Robot.EngineType.Sky, 18, 5, 9, 360, 79, 59, 78, new int[1] { 141 }));
		m_Robot.Add(new Robot("盖塔龙", Robot.EngineType.Sky, 68, 62, 8, 400, 132, 54, 60, new int[2] { 142, 143 }));
		m_Robot.Add(new Robot("盖塔虎", Robot.EngineType.Land, 69, 63, 11, 400, 120, 50, 79, new int[2] { 144, 145 }));
		m_Robot.Add(new Robot("盖塔海神", Robot.EngineType.Sea, 70, 64, 7, 400, 133, 55, 52, new int[2] { 146, 147 }));
		m_Robot.Add(new Robot("刚达R", Robot.EngineType.Land, 1, 61, 7, 420, 100, 70, 92, new int[2] { 65, 148 }));
		m_Robot.Add(new Robot("金", Robot.EngineType.Sky, 67, 65, 7, 450, 105, 85, 50, new int[2] { 138, 139 }));
		m_Robot.Add(new Robot("F91", Robot.EngineType.Land, 25, 20, 8, 470, 102, 77, 96, new int[2] { 65, 149 }, new Define.UserTrait[1]));
		m_Robot.Add(new Robot("刚达ZZ", Robot.EngineType.Land, 3, 50, 6, 570, 138, 97, 100, new int[2] { 136, 137 }));
		m_Robot.Add(new Robot("齐托", Robot.EngineType.Sky, 57, 50, 8, 570, 138, 97, 102, new int[2] { 66, 70 }));
		m_Robot.Add(new Robot("巴斯塔", Robot.EngineType.Land, 63, 38, 8, 400, 118, 86, 111, new int[2] { 140, 156 }));
		m_Robot.Add(new Robot("巴斯塔", Robot.EngineType.Land, 63, 38, 8, 400, 118, 86, 111, new int[2] { 150, 156 }));
		m_Robot.Add(new Robot("伯利", Robot.EngineType.Land, 107, 93, 9, 970, 200, 115, 110, new int[2] { 153, 154 }, new Define.UserTrait[1] { Define.UserTrait.GongJiXiXue }));
		m_Robot.Add(new Robot("巴得", Robot.EngineType.Sky, 44, 38, 10, 400, 118, 81, 111, new int[1] { 156 }));
		m_User.Add(new User("龙", 5, new int[6] { 0, 1, 7, 8, 9, 11 }));
		m_User.Add(new User("欧文", 10, new int[6] { 1, 6, 7, 8, 11, 16 }));
		m_User.Add(new User("路易", 9, new int[6] { 0, 1, 4, 7, 8, 9 }));
		m_User.Add(new User("乔", 0, new int[2] { 2, 7 }));
		m_User.Add(new User("卡姆", 7, new int[6] { 1, 2, 5, 6, 7, 17 }));
		m_User.Add(new User("大卫", 4, new int[6] { 0, 1, 3, 6, 7, 17 }));
		m_User.Add(new User("由美", 2, new int[6] { 7, 9, 10, 11, 12, 18 }));
		m_User.Add(new User("加代", 3, new int[5] { 1, 3, 4, 7, 8 }));
		m_User.Add(new User("杰克", 1, new int[2] { 16, 4 }));
		m_User.Add(new User("布克", 15, new int[6] { 1, 2, 5, 6, 7, 17 }));
		m_User.Add(new User("尼娜", 16, new int[3] { 2, 3, 6 }));
		m_User.Add(new User("发", 21, new int[7] { 2, 9, 10, 11, 12, 13, 18 }));
		m_User.Add(new User("卡尔", 25, new int[2] { 0, 4 }));
		m_User.Add(new User("布西", 32, new int[4] { 0, 4, 14, 15 }));
		m_User.Add(new User("马丁", 30, new int[6] { 0, 7, 8, 9, 14, 18 }));
		m_User.Add(new User("希塔", 33, new int[6] { 0, 1, 5, 6, 7, 17 }));
		m_User.Add(new User("萨米", 23, new int[3] { 2, 3, 6 }));
		m_User.Add(new User("安东", 27, new int[5] { 3, 7, 8, 13, 17 }));
		m_User.Add(new User("伊娃", 39, new int[3] { 7, 13, 15 }));
		m_ActorData.Add(new Actor(new Actor.ActorData[1]
		{
			new Actor.ActorData(3, 0)
		}, Define.AIType.Null, 1, 30, 0, 400, 5, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[1]
		{
			new Actor.ActorData(8, 4)
		}, Define.AIType.Null, 1, 40, 0, 100, 3, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[1]
		{
			new Actor.ActorData(6, 3)
		}, Define.AIType.Null, 1, 70, 0, 100, 6, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[1]
		{
			new Actor.ActorData(7, 2)
		}, Define.AIType.Null, 1, 50, 0, 300, 6, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[1]
		{
			new Actor.ActorData(5, 1)
		}, Define.AIType.Null, 1, 40, 0, 200, 5, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[3]
		{
			new Actor.ActorData(0, 7),
			new Actor.ActorData(1, 8),
			new Actor.ActorData(2, 9)
		}, Define.AIType.Null, 1, 50, 0, 300, 3, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[2]
		{
			new Actor.ActorData(4, 5),
			new Actor.ActorData(4, 6)
		}, Define.AIType.Null, 3, 46, 0, 400, 5, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[1]
		{
			new Actor.ActorData(9, 10)
		}, Define.AIType.Null, 8, 66, 0, 500, 5, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[1]
		{
			new Actor.ActorData(10, 11)
		}, Define.AIType.Null, 10, 54, 0, 500, 5, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[2]
		{
			new Actor.ActorData(11, 13),
			new Actor.ActorData(11, 14)
		}, Define.AIType.Null, 10, 115, 0, 500, 5, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[1]
		{
			new Actor.ActorData(12, 15)
		}, Define.AIType.Null, 16, 115, 0, 500, 5, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[1]
		{
			new Actor.ActorData(-1, 17)
		}, Define.AIType.Null, 18, 26, 0, 500, 6, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[1]
		{
			new Actor.ActorData(13, 18)
		}, Define.AIType.Null, 20, 160, 0, 500, 6, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[2]
		{
			new Actor.ActorData(14, 19),
			new Actor.ActorData(14, 20)
		}, Define.AIType.Null, 21, 115, 0, 500, 8, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[2]
		{
			new Actor.ActorData(15, 24),
			new Actor.ActorData(15, 25)
		}, Define.AIType.Null, 21, 105, 0, 500, 5, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[2]
		{
			new Actor.ActorData(16, 26),
			new Actor.ActorData(16, 27)
		}, Define.AIType.Null, 24, 75, 0, 500, 5, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[2]
		{
			new Actor.ActorData(17, 28),
			new Actor.ActorData(17, 29)
		}, Define.AIType.Null, 24, 129, 0, 500, 2, isSelf: true));
		m_ActorData.Add(new Actor(new Actor.ActorData[1]
		{
			new Actor.ActorData(18, 42)
		}, Define.AIType.Null, 30, 127, 0, 500, 5, isSelf: true));
	}

	public int GetItemCount(int id)
	{
		if (!m_Items.ContainsKey(id))
		{
			return 0;
		}
		return m_Items[id];
	}

	public void AddItem(int id, int number)
	{
		if (!m_Items.ContainsKey(id))
		{
			m_Items.Add(id, number);
		}
		else
		{
			m_Items[id] += number;
		}
	}

	public void UseItem(int id, int number)
	{
		if (m_Items.ContainsKey(id) && m_Items[id] >= number)
		{
			m_Items[id] -= number;
			if (m_Items[id] <= 0)
			{
				m_Items.Remove(id);
			}
		}
	}

	public bool GetFlag(string flag)
	{
		if (!m_Flag.ContainsKey(flag))
		{
			return false;
		}
		return m_Flag[flag] > 0;
	}

	public void SetFlag(string flag, int state)
	{
		if (!m_Flag.ContainsKey(flag))
		{
			m_Flag.Add(flag, state);
		}
		else
		{
			m_Flag[flag] = state;
		}
	}

	public void Load(string saveStr)
	{
		string[] array = saveStr.Split(';');
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (text == string.Empty)
			{
				continue;
			}
			string[] array3 = text.Split(':');
			switch (array3[0])
			{
			case "Level":
				m_NowLevel = int.Parse(array3[1]);
				break;
			case "Money":
				m_NowMoney = int.Parse(array3[1]);
				break;
			case "Plus":
				m_GamePlus = int.Parse(array3[1]);
				break;
			case "Actor":
			{
				string[] array7 = array3[1].Split(',');
				int[] baseInfo = new int[7]
				{
					int.Parse(array7[1]),
					int.Parse(array7[2]),
					int.Parse(array7[3]),
					int.Parse(array7[4]),
					int.Parse(array7[5]),
					int.Parse(array7[6]),
					int.Parse(array7[7])
				};
				m_ActorData[int.Parse(array7[0])].BaseInfo = baseInfo;
				break;
			}
			case "ActorData":
			{
				string[] array6 = array3[1].Split(',');
				List<Actor.ActorData> list = new List<Actor.ActorData>();
				for (int j = 0; j < (array6.Length - 2) / 2; j++)
				{
					list.Add(new Actor.ActorData(int.Parse(array6[j * 2 + 2]), int.Parse(array6[j * 2 + 1])));
				}
				m_ActorData[int.Parse(array6[0])].ChooseActor(list.ToArray());
				break;
			}
			case "Flag":
			{
				string[] array5 = array3[1].Split(',');
				m_Flag.Add(array5[0], int.Parse(array5[1]));
				break;
			}
			case "Items":
			{
				string[] array4 = array3[1].Split(',');
				m_Items.Add(int.Parse(array4[0]), int.Parse(array4[1]));
				break;
			}
			}
		}
	}

	public string SaveInfo()
	{
		return "周目:" + m_GamePlus + "\n关卡:" + (m_NowLevel + 1);
	}

	public string Save()
	{
		string text = "Level:" + m_NowLevel + ";";
		string text2 = text;
		text = text2 + "Money:" + m_NowMoney + ";";
		text2 = text;
		text = text2 + "Plus:" + m_GamePlus + ";";
		foreach (string key in m_Flag.Keys)
		{
			text2 = text;
			text = text2 + "Flag:" + key + "," + m_Flag[key] + ";";
		}
		foreach (int key2 in m_Items.Keys)
		{
			text2 = text;
			text = text2 + "Items:" + key2 + "," + m_Items[key2] + ";";
		}
		for (int i = 0; i < m_ActorData.Count; i++)
		{
			int[] baseInfo = m_ActorData[i].BaseInfo;
			string text3 = i + ",";
			text3 = text3 + baseInfo[0] + ",";
			text3 = text3 + baseInfo[1] + ",";
			text3 = text3 + baseInfo[2] + ",";
			text3 = text3 + baseInfo[3] + ",";
			text3 = text3 + baseInfo[4] + ",";
			text3 = text3 + baseInfo[5] + ",";
			text3 += baseInfo[6];
			text = text + "Actor:" + text3 + ";";
			string text4 = i + ",";
			for (int j = 0; j < m_ActorData[i].ActorDataList.Count; j++)
			{
				text4 = text4 + m_ActorData[i].ActorDataList[j].RobotID + ",";
				text4 = text4 + m_ActorData[i].ActorDataList[j].UserID + ",";
			}
			text = text + "ActorData:" + text4 + ";";
		}
		return text;
	}

	public Robot GetRobot(int id)
	{
		if (id == -1)
		{
			return null;
		}
		return m_Robot[id];
	}

	public User GetUser(int id)
	{
		if (id == -1)
		{
			return null;
		}
		return m_User[id];
	}

	public void Text(int power, int exp)
	{
		foreach (Actor actorDatum in m_ActorData)
		{
			actorDatum.SetText(power, exp);
		}
	}
}
