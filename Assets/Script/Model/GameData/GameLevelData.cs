public class GameLevelData
{
	public Level this[int level]
	{
		get
		{
			if (GameDataBase.Instance.GamePlus == 2)
			{
				return GetLevelForPlus2(level);
			}
			return level switch
			{
				0 => new GameLevel_1(), 
				1 => new GameLevel_2(), 
				2 => new GameLevel_3(), 
				3 => new GameLevel_4(), 
				4 => new GameLevel_5(), 
				5 => new GameLevel_6(), 
				6 => new GameLevel_7(), 
				7 => new GameLevel_8(), 
				8 => new GameLevel_9(), 
				9 => new GameLevel_10(), 
				10 => new GameLevel_11(), 
				11 => new GameLevel_12(), 
				12 => new GameLevel_13(), 
				13 => new GameLevel_14(), 
				14 => new GameLevel_15(), 
				15 => new GameLevel_16(), 
				16 => new GameLevel_17(), 
				17 => new GameLevel_18(), 
				18 => new GameLevel_19(), 
				19 => new GameLevel_20(), 
				20 => new GameLevel_21(), 
				21 => new GameLevel_22(), 
				22 => new GameLevel_23(), 
				23 => new GameLevel_24(), 
				24 => new GameLevel_25(), 
				25 => new GameLevel_26(), 
				26 => new GameLevel_27(), 
				_ => null, 
			};
		}
	}

	private Level GetLevelForPlus2(int level)
	{
		if (level == 0)
		{
			return new GameLevel_27();
		}
		return null;
	}
}
