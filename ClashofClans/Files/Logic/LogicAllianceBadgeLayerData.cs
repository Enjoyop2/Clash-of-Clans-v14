using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicAllianceBadgeLayerData : LogicData
	{
		public LogicAllianceBadgeLayerData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string Type { get; protected set; }
		public string SWF { get; protected set; }
		public string ExportName { get; protected set; }
		public int RequiredClanLevel { get; protected set; }
	}
}
