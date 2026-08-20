using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicWarData : LogicData
	{
		public LogicWarData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public int TeamSize { get; protected set; }
		public int PreparationMinutes { get; protected set; }
		public int WarMinutes { get; protected set; }
		public bool DisableProduction { get; protected set; }
		public bool AllowArrangedWar { get; protected set; }
	}
}
