using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicTrapData : LogicData
	{
		public LogicTrapData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string TID { get; protected set; }
		public string InfoTID { get; protected set; }
		public string SWF { get; protected set; }
		public string[] ExportName { get; protected set; }
		public string[] ExportNameAir { get; protected set; }
		public string[] ExportNameBuildAnim { get; protected set; }
		public string[] ExportNameBuildAnimAir { get; protected set; }
		public string[] ExportNameBroken { get; protected set; }
		public string[] ExportNameBrokenAir { get; protected set; }
		public string[] BigPicture { get; protected set; }
		public string BigPictureSWF { get; protected set; }
		public string EffectBroken { get; protected set; }
		public int[] Damage { get; protected set; }
		public int[] DamageRadius { get; protected set; }
		public int TriggerRadius { get; protected set; }
		public int Width { get; protected set; }
		public int Height { get; protected set; }
		public string Effect { get; protected set; }
		public string Effect2 { get; protected set; }
		public string DamageEffect { get; protected set; }
		public bool Passable { get; protected set; }
		public string BuildResource { get; protected set; }
		public int[] BuildTimeD { get; protected set; }
		public int[] BuildTimeH { get; protected set; }
		public int[] BuildTimeM { get; protected set; }
		public int[] BuildCost { get; protected set; }
		public int[] TownHallLevel { get; protected set; }
		public bool EjectVictims { get; protected set; }
		public int MinTriggerHousingLimit { get; protected set; }
		public int[] EjectHousingLimit { get; protected set; }
		public string[] ExportNameTriggered { get; protected set; }
		public string[] ExportNameTriggeredAir { get; protected set; }
		public int ActionFrame { get; protected set; }
		public string PickUpEffect { get; protected set; }
		public string PlacingEffect { get; protected set; }
		public string AppearEffect { get; protected set; }
		public string ToggleAttackModeEffect { get; protected set; }
		public int[] DurationMS { get; protected set; }
		public int SpeedMod { get; protected set; }
		public int DamageMod { get; protected set; }
		public bool AirTrigger { get; protected set; }
		public bool GroundTrigger { get; protected set; }
		public bool HealerTrigger { get; protected set; }
		public int HitDelayMS { get; protected set; }
		public int HitCnt { get; protected set; }
		public string[] Projectile { get; protected set; }
		public string Spell { get; protected set; }
		public int[] StrengthWeight { get; protected set; }
		public int PreferredTargetDamageMod { get; protected set; }
		public string PreferredTarget { get; protected set; }
		public string SpawnedCharGround { get; protected set; }
		public string SpawnedCharAir { get; protected set; }
		public int[] NumSpawns { get; protected set; }
		public int SpawnInitialDelayMs { get; protected set; }
		public int TimeBetweenSpawnsMs { get; protected set; }
		public int SpawnLvl { get; protected set; }
		public bool Disabled { get; protected set; }
		public int ThrowDistance { get; protected set; }
		public int VillageType { get; protected set; }
		public int[] Pushback { get; protected set; }
		public bool[] DoNotScalePushByDamage { get; protected set; }
		public bool EnabledByCalendar { get; protected set; }
		public int DirectionCount { get; protected set; }
		public bool HasAltMode { get; protected set; }
		public int UpgradeLevelByTH { get; protected set; }
		public int HintPriority { get; protected set; }

		public int GetBuildTime(int lvl) =>
			BuildTimeD[lvl] * 86400
			+ BuildTimeH[lvl] * 3600
			+ BuildTimeM[lvl] * 60;
	}
}