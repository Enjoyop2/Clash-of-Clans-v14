using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicRegionData : LogicData
	{
		public LogicRegionData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}
		public string Name { get; protected set; }
		public string TID { get; protected set; }
		public string DisplayName { get; protected set; }
		public bool IsCountry { get; protected set; }
		public bool HS { get; protected set; }
		public string ChinaDisplayName { get; protected set; }
		public string ChinaCountryCode { get; protected set; }
	}
}