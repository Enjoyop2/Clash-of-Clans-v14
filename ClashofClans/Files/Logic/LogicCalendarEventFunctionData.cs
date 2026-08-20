using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicCalendarEventFunctionData : LogicData
	{
		public LogicCalendarEventFunctionData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string[] ParameterType { get; protected set; }
		public string[] ParameterName { get; protected set; }
		public string[] Description { get; protected set; }
		public int[] MinValue { get; protected set; }
		public int[] MaxValue { get; protected set; }
		public bool TargetingSupported { get; protected set; }
		public string Category { get; protected set; }
		public bool Deprecated { get; protected set; }
	}
}
