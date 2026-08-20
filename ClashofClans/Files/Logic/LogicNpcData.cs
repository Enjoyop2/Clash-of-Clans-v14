using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicNpcData : LogicData
	{
		public LogicNpcData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string MapInstanceName { get; protected set; }
		public string[] MapDependencies { get; protected set; }
		public string TID { get; protected set; }
		public int ExpLevel { get; protected set; }
		public string Type { get; protected set; }
		public int TutorialUnlockTHLevel { get; protected set; }
		public int TutorialTHLevel { get; protected set; }
		public int minRecommendedTHLevel { get; protected set; }
		public string UnitType { get; protected set; }
		public int UnitCount { get; protected set; }
		public string LevelFile { get; protected set; }
		public int Gold { get; protected set; }
		public int Elixir { get; protected set; }
		public int DarkElixir { get; protected set; }
		public bool AlwaysUnlocked { get; protected set; }
		public string PlayerName { get; protected set; }
		public string AllianceName { get; protected set; }
		public int AllianceBadge { get; protected set; }
		public bool[] SinglePlayer { get; protected set; }
		public string[] AllianceUnitType { get; protected set; }
		public int[] AllianceUnitLevel { get; protected set; }
		public int[] AllianceUnitCount { get; protected set; }
		public string[] FixedArmyUnitType { get; protected set; }
		public int[] FixedArmyUnitLevel { get; protected set; }
		public int[] FixedArmyUnitCount { get; protected set; }
		public bool[] FixedArmyUnitAlliance { get; protected set; }
		public string[] FixedArmyUnitPet { get; protected set; }
		public int[] FixedArmyUnitPetLevel { get; protected set; }
		public int[] FixedArmySkin { get; protected set; }
		public string[] DeploySteps { get; protected set; }
		public bool UseFullMapSize { get; protected set; }
		public string[] DefendingHero { get; protected set; }
		public int[] DefendingHeroLevel { get; protected set; }
		public int[] DefendingHeroSkin { get; protected set; }
		public int VillageBackground { get; protected set; }
		public int AttackTimeSeconds { get; protected set; }
	}
}