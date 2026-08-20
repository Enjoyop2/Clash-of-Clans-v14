using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicAchievementData : LogicData
	{
		public LogicAchievementData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public int Level { get; protected set; }
		public int LevelCount { get; protected set; }
		public string TID { get; protected set; }
		public string InfoTID { get; protected set; }
		public string Action { get; protected set; }
		public int ActionCount { get; protected set; }
		public string ActionData { get; protected set; }
		public int ActionDataLevel { get; protected set; }
		public int ExpReward { get; protected set; }
		public int DiamondReward { get; protected set; }
		public string IconSWF { get; protected set; }
		public string IconExportName { get; protected set; }
		public string CompletedTID { get; protected set; }
		public bool ShowValue { get; protected set; }
		public string AndroidID { get; protected set; }
		public int UIGroup { get; protected set; }
		public int UIPriority { get; protected set; }
	}
}

