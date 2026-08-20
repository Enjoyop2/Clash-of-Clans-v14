using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicLeagueVillage2Data : LogicData
	{
		public LogicLeagueVillage2Data(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public int TrophyLimitLow { get; protected set; }
		public int TrophyLimitHigh { get; protected set; }
		public int GoldReward { get; protected set; }
		public int ElixirReward { get; protected set; }
		public int BonusGold { get; protected set; }
		public int BonusElixir { get; protected set; }
		public int SeasonTrophyReset { get; protected set; }
		public int MaxDiamondCost { get; protected set; }
	}
}
