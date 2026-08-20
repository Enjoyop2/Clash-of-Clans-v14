using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicResourceData : LogicData
	{
		public LogicResourceData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string TID { get; protected set; }
		public string AltTID { get; protected set; }
		public string IconSWF { get; protected set; }
		public string IconExportName { get; protected set; }
		public string CollectEffect { get; protected set; }
		public string ResourceIconExportName { get; protected set; }
		public string StealEffect { get; protected set; }
		public int StealLimitMid { get; protected set; }
		public string StealEffectMid { get; protected set; }
		public int StealLimitBig { get; protected set; }
		public string StealEffectBig { get; protected set; }
		public bool PremiumCurrency { get; protected set; }
		public string HudInstanceName { get; protected set; }
		public string CapFullTID { get; protected set; }
		public int TextRed { get; protected set; }
		public int TextGreen { get; protected set; }
		public int TextBlue { get; protected set; }
		public string BankedRefResource { get; protected set; }
		public string WarRefResource { get; protected set; }
		public string BundleIconExportName { get; protected set; }
		public int VillageType { get; protected set; }
	}
}