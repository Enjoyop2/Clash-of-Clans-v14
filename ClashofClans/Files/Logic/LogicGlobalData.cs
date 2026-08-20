using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicGlobalData : LogicData
	{
		public LogicGlobalData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public int NumberValue { get; protected set; }
		public bool BooleanValue { get; protected set; }
		public string TextValue { get; protected set; }
		public int[] NumberArray { get; protected set; }
		public int[] AltNumberArray { get; protected set; }
		public string StringArray { get; protected set; }
		public string AltStringArray { get; protected set; }
	}
}
