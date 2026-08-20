using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicBillingPackageData : LogicData
	{
		public LogicBillingPackageData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string TID { get; protected set; }
		public bool Disabled { get; protected set; }
		public bool ExistsApple { get; protected set; }
		public bool ExistsAndroid { get; protected set; }
		public bool ExistsAmazon { get; protected set; }
		public int Diamonds { get; protected set; }
		public int USD { get; protected set; }
		public string IconSWF { get; protected set; }
		public string IconExportName { get; protected set; }
		public string ShopItemExportName { get; protected set; }
		public string OfferItemExportName { get; protected set; }
		public int Order { get; protected set; }
		public bool RED { get; protected set; }
		public int RMB { get; protected set; }
		public bool KunlunOnly { get; protected set; }
		public int LenovoID { get; protected set; }
		public string TencentID { get; protected set; }
		public int HuaweiID { get; protected set; }
		public int KunlunID { get; protected set; }
		public bool isOfferPackage { get; protected set; }
		public bool OfferedByCalendar { get; protected set; }
		public bool GiftCard { get; protected set; }
		public bool SCIDStore { get; protected set; }
	}
}
