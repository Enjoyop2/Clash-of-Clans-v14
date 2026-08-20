using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicGemBundleData : LogicData
	{
		public LogicGemBundleData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public int LinkedPackageID { get; protected set; }
		public string BillingPackage { get; protected set; }
		public string TID { get; protected set; }
		public string InfoTID { get; protected set; }
		public string AnimatedTID { get; protected set; }
		public bool Disabled { get; protected set; }
		public bool ExistsApple { get; protected set; }
		public bool ExistsAndroid { get; protected set; }
		public bool ExistsKunlun { get; protected set; }
		public bool ExistsBazaar { get; protected set; }
		public bool ExistsTencent { get; protected set; }
		public bool ExistsAmazon { get; protected set; }
		public bool ExistsSCID { get; protected set; }
		public int DurationDays { get; protected set; }
		public string ShopItemExportName { get; protected set; }
		public string ShopInfoItemExportName { get; protected set; }
		public string ShopItemBG { get; protected set; }
		public string ShopItemBGColor { get; protected set; }
		public int TownhallLimitMin { get; protected set; }
		public int TownhallLimitMax { get; protected set; }
		public int VillageType { get; protected set; }
		public string[] Buildings { get; protected set; }
		public string[] BuildingType { get; protected set; }
		public int BuildingNumber { get; protected set; }
		public int[] BuildingLevel { get; protected set; }
		public string UnlocksTroop { get; protected set; }
		public string TroopType { get; protected set; }
		public int GiftGems { get; protected set; }
		public int GiftUsers { get; protected set; }
		public string[] Resources { get; protected set; }
		public int[] ResourceAmounts { get; protected set; }
		public bool ResourceAmountFromThCSV { get; protected set; }
		public int THResourceMultiplier { get; protected set; }
		public string[] MagicItems { get; protected set; }
		public int[] MagicItemAmounts { get; protected set; }
		public bool RED { get; protected set; }
		public int[] Priority { get; protected set; }
		public bool FrontPageItem { get; protected set; }
		public bool TreasureItem { get; protected set; }
		public string ReplacesBillingPackage { get; protected set; }
		public int ValueForUI { get; protected set; }
		public int ValueStarsForUI { get; protected set; }
		public int TimesCanBePurchased { get; protected set; }
		public bool PremiumPass { get; protected set; }
	}
}
