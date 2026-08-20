using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicLeagueData : LogicData
	{
		public LogicLeagueData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string TID { get; protected set; }
		public string TIDShort { get; protected set; }
		public string IconSWF { get; protected set; }
		public string IconExportName { get; protected set; }
		public string LeagueBannerIcon { get; protected set; }
		public string LeagueBannerIconNum { get; protected set; }
		public string LeagueBannerIconHUD { get; protected set; }
		public int GoldReward { get; protected set; }
		public int ElixirReward { get; protected set; }
		public int DarkElixirReward { get; protected set; }
		public bool UseStarBonus { get; protected set; }
		public int GoldRewardStarBonus { get; protected set; }
		public int ElixirRewardStarBonus { get; protected set; }
		public int DarkElixirRewardStarBonus { get; protected set; }
		public int PlacementLimitLow { get; protected set; }
		public int PlacementLimitHigh { get; protected set; }
		public int DemoteLimit { get; protected set; }
		public int PromoteLimit { get; protected set; }
		public int[] BucketPlacementRangeLow { get; protected set; }
		public int[] BucketPlacementRangeHigh { get; protected set; }
		public int[] BucketPlacementSoftLimit { get; protected set; }
		public int[] BucketPlacementHardLimit { get; protected set; }
		public bool IgnoredByServer { get; protected set; }
		public bool DemoteEnabled { get; protected set; }
		public bool PromoteEnabled { get; protected set; }
		public int AllocateAmount { get; protected set; }
		public int SaverCount { get; protected set; }
		public int VillageGuardInMins { get; protected set; }
		public int ShieldReductionInHours { get; protected set; }
	}
}