using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicAllianceBadgeData : LogicData
	{
		public LogicAllianceBadgeData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string IconSWF { get; protected set; }
		public string IconExportName { get; protected set; }
		public string IconLayer0 { get; protected set; }
		public string IconLayer1 { get; protected set; }
		public string IconLayer2 { get; protected set; }
	}
}
