using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicVillageObjectData : LogicData
	{
		public LogicVillageObjectData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public bool Disabled { get; protected set; }
		public string TID { get; protected set; }
		public string InfoTID { get; protected set; }
		public string[] SWF { get; protected set; }
		public string[] ExportName { get; protected set; }
		public int[] TileX100 { get; protected set; }
		public int[] TileY100 { get; protected set; }
		public int RequiredTH { get; protected set; }
		public bool AutomaticUpgrades { get; protected set; }
		public int[] BuildTimeD { get; protected set; }
		public int[] BuildTimeH { get; protected set; }
		public int[] BuildTimeM { get; protected set; }
		public int[] BuildTimeS { get; protected set; }
		public bool[] RequiresBuilder { get; protected set; }
		public string BuildResource { get; protected set; }
		public int BuildCost { get; protected set; }
		public int[] TownHallLevel { get; protected set; }
		public string PickUpEffect { get; protected set; }
		public string Animations { get; protected set; }
		public int AnimX { get; protected set; }
		public int AnimY { get; protected set; }
		public int AnimID { get; protected set; }
		public int AnimDir { get; protected set; }
		public int AnimVisibilityOdds { get; protected set; }
		public bool HasInfoScreen { get; protected set; }
		public int VillageType { get; protected set; }
		public int UnitHousing { get; protected set; }
		public bool HousesUnits { get; protected set; }
		public bool AllianceBuilding { get; protected set; }
		public bool LightsOn { get; protected set; }
		public int GetBuildTime(int level)
		{
			return BuildTimeD[level] * 86400 + BuildTimeH[level] * 3600 + BuildTimeM[level] * 60 + BuildTimeS[level];
		}
	}
}