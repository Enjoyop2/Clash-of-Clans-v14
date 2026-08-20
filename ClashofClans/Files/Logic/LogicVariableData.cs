using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicVariableData : LogicData
	{
		public LogicVariableData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public int DefaultValue { get; protected set; }
		public bool AllowSnapshotUpdate { get; protected set; }
		public string TID { get; protected set; }
		public string InfoTID { get; protected set; }
		public string IconSWF { get; protected set; }
		public string IconExportName { get; protected set; }
	}
}
