using ClashofClans.Files.Logic;

namespace ClashofClans.Files.CsvUtils
{
	public class LeagueUtils
	{
		private static int Data;
		private static LogicLeagueData GetLeagueData() => Csv.Tables.Get(LogicDataType.LEAGUE).GetDataWithId<LogicLeagueData>(Data);
		public static int GetPlacementLimitLow(int league)
		{
			Data = 0;
			int League = 0;
			while (league != League)
			{
				if (!string.IsNullOrEmpty(GetLeagueData().Name))
					League++;
				Data++;
			}

			return GetLeagueData().PlacementLimitLow;
		}

		public static int GetPlacementLimitHigh(int league)
		{
			Data = 0;
			int League = 0;
			while (league != League)
			{
				if (!string.IsNullOrEmpty(GetLeagueData().Name))
					League++;
				Data++;
			}

			return GetLeagueData().PlacementLimitHigh;
		}

		public static int GetLeagueByScore(int score)
		{
			Data = 0;
			int League = 0;

			while (score > GetLeagueData().PlacementLimitLow && score > GetLeagueData().PlacementLimitHigh)
			{
				if (!string.IsNullOrEmpty(GetLeagueData().Name))
					League++;
				Data++;
			}

			return League;
		}
	}
}