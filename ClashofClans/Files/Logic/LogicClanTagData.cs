using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicClanTagData : LogicData
	{
		public LogicClanTagData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string TID { get; protected set; }
		public string IconSWF { get; protected set; }
		public string IconExportName { get; protected set; }
		public int SortKey { get; protected set; }
	}
}
