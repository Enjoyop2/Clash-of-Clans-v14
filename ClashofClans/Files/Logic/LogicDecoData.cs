using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicDecoData : LogicData
	{
		public LogicDecoData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string TID { get; protected set; }
		public string InfoTID { get; protected set; }
		public string SWF { get; protected set; }
		public string ExportName { get; protected set; }
		public string ExportNameConstruction { get; protected set; }
		public string BuildResource { get; protected set; }
		public int BuildCost { get; protected set; }
		public int RequiredExpLevel { get; protected set; }
		public int MaxCount { get; protected set; }
		public int Width { get; protected set; }
		public int Height { get; protected set; }
		public int PassableSubtilesAtEdge { get; protected set; }
		public string Icon { get; protected set; }
		public int BaseGfx { get; protected set; }
		public string ExportNameBase { get; protected set; }
		public bool IsRed { get; protected set; }
		public bool NotInShop { get; protected set; }
		public bool BPReward { get; protected set; }
		public int VillageType { get; protected set; }
		public int RedMul { get; protected set; }
		public int GreenMul { get; protected set; }
		public int BlueMul { get; protected set; }
		public int RedAdd { get; protected set; }
		public int GreenAdd { get; protected set; }
		public int BlueAdd { get; protected set; }
		public bool LightsOn { get; protected set; }
		public bool DecoPath { get; protected set; }
		public string ActiveEffect { get; protected set; }
		public int ActiveEffectDelay { get; protected set; }
	}
}