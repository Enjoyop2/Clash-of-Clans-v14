using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicStarterPassData : LogicData
	{
		public LogicStarterPassData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string[] Tasks { get; protected set; }
		public int[] TownHallUnlock { get; protected set; }
		public string[] Prerequisite { get; protected set; }
		public int[] TierScores { get; protected set; }
		public string[] RewardType { get; protected set; }
		public int[] RewardAmount { get; protected set; }
	}
}
