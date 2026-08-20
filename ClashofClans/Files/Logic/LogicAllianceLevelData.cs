using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicAllianceLevelData : LogicData
	{
		public LogicAllianceLevelData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public int ExpPoints { get; protected set; }
		public bool IsVisible { get; protected set; }
		public int TroopRequestCooldown { get; protected set; }
		public int TroopDonationLimit { get; protected set; }
		public int SpellDonationLimit { get; protected set; }
		public int TroopDonationRefund { get; protected set; }
		public int TroopDonationUpgrade { get; protected set; }
		public int WarLootCapacityPercent { get; protected set; }
		public int WarLootMultiplierPercent { get; protected set; }
		public int BadgeLevel { get; protected set; }
		public string BannerSWF { get; protected set; }
	}
}
