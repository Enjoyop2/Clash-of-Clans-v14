using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicAlliancePortalData : LogicData
	{
		public LogicAlliancePortalData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string TID { get; protected set; }
		public string SWF { get; protected set; }
		public string[] ExportName { get; protected set; }
		public int Width { get; protected set; }
		public int Height { get; protected set; }
		public int VillageType { get; protected set; }
	}
}
