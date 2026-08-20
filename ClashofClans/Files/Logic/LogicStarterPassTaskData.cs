using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicStarterPassTaskData : LogicData
	{
		public LogicStarterPassTaskData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string TaskType { get; protected set; }
		public string ProgressType { get; protected set; }
		public string Set { get; protected set; }
		public string TID { get; protected set; }
		public string InfoTID { get; protected set; }
		public string IconSWF { get; protected set; }
		public string IconExportName { get; protected set; }
		public int Score { get; protected set; }
		public int DurationMinutes { get; protected set; }
		public int Quantity { get; protected set; }
		public int Quantity2 { get; protected set; }
		public string Data1 { get; protected set; }
		public string Data2 { get; protected set; }
		public int SelectionWeight { get; protected set; }
		public bool Disabled { get; protected set; }
	}
}
