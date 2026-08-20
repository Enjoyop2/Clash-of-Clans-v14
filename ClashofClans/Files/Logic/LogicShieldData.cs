using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicShieldData : LogicData
	{
		public LogicShieldData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string TID { get; protected set; }
		public string InfoTID { get; protected set; }
		public int TimeH { get; protected set; }
		public int GuardTimeH { get; protected set; }
		public int Diamonds { get; protected set; }
		public string IconSWF { get; protected set; }
		public string IconExportName { get; protected set; }
		public int CooldownS { get; protected set; }
		public int LockedAboveScore { get; protected set; }
	}
}
