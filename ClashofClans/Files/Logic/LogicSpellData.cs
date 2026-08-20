using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicSpellData : LogicData
	{
		public LogicSpellData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string TID { get; protected set; }
		public string InfoTID { get; protected set; }
		public bool DisableProduction { get; protected set; }
		public int[] SpellForgeLevel { get; protected set; }
		public int[] LaboratoryLevel { get; protected set; }
		public string TrainingResource { get; protected set; }
		public int[] TrainingCost { get; protected set; }
		public int DonateCost { get; protected set; }
		public int[] HousingSpace { get; protected set; }
		public int[] TrainingTime { get; protected set; }
		public int[] DeployTimeMS { get; protected set; }
		public int[] ChargingTimeMS { get; protected set; }
		public int[] HitTimeMS { get; protected set; }
		public int[] UpgradeTimeH { get; protected set; }
		public string UpgradeResource { get; protected set; }
		public int[] UpgradeCost { get; protected set; }
		public int[] BoostTimeMS { get; protected set; }
		public int[] SpeedBoost { get; protected set; }
		public int[] SpeedBoost2 { get; protected set; }
		public int[] JumpHousingLimit { get; protected set; }
		public int[] JumpBoostMS { get; protected set; }
		public int[] DamageBoostPercent { get; protected set; }
		public int[] BuildingDamageBoostPercent { get; protected set; }
		public int[] Damage { get; protected set; }
		public int TroopDamagePermil { get; protected set; }
		public int[] BuildingDamagePermil { get; protected set; }
		public int ExecuteHealthPermil { get; protected set; }
		public int DamagePermilMin { get; protected set; }
		public int PreferredDamagePermilMin { get; protected set; }
		public int[] Radius { get; protected set; }
		public int[] NumberOfHits { get; protected set; }
		public int[] RandomRadius { get; protected set; }
		public int[] TimeBetweenHitsMS { get; protected set; }
		public string IconSWF { get; protected set; }
		public string[] IconExportName { get; protected set; }
		public string[] BigPicture { get; protected set; }
		public string[] PreDeployEffect { get; protected set; }
		public string[] DeployEffect { get; protected set; }
		public int DeployEffect2Delay { get; protected set; }
		public string[] DeployEffect2 { get; protected set; }
		public string ChargingEffect { get; protected set; }
		public string HitEffect { get; protected set; }
		public bool RandomRadiusAffectsOnlyGfx { get; protected set; }
		public int[] FreezeTimeMS { get; protected set; }
		public string SpawnObstacle { get; protected set; }
		public int NumObstacles { get; protected set; }
		public int[] StrengthWeight { get; protected set; }
		public string ProductionBuilding { get; protected set; }
		public bool TroopsOnly { get; protected set; }
		public string TargetInfoString { get; protected set; }
		public string PreferredTarget { get; protected set; }
		public int PreferredTargetDamageMod { get; protected set; }
		public bool BoostDefenders { get; protected set; }
		public int HeroDamageMultiplier { get; protected set; }
		public int ShieldProjectileSpeed { get; protected set; }
		public int ShieldProjectileDamageMod { get; protected set; }
		public int[] ExtraHealthPermil { get; protected set; }
		public int[] ExtraHealthMin { get; protected set; }
		public int[] ExtraHealthMax { get; protected set; }
		public int[] PoisonDPS { get; protected set; }
		public bool PoisonIncreaseSlowly { get; protected set; }
		public int[] AttackSpeedBoost { get; protected set; }
		public bool BoostLinkedToPoison { get; protected set; }
		public bool PoisonAffectAir { get; protected set; }
		public bool ScaleDeployEffects { get; protected set; }
		public int[] ShieldTime { get; protected set; }
		public int ShieldProtectionPercent { get; protected set; }
		public int MaxUnitsHit { get; protected set; }
		public string EnemyDeployEffect { get; protected set; }
		public bool SnapToGrid { get; protected set; }
		public int[] DuplicateHousing { get; protected set; }
		public int DuplicateLifetime { get; protected set; }
		public string SummonTroop { get; protected set; }
		public int[] UnitsToSpawn { get; protected set; }
		public int ShrinkReduceSpeedRatio { get; protected set; }
		public int ShrinkHitpointsRatio { get; protected set; }
		public int[] SpawnDuration { get; protected set; }
		public int SpawnFirstGroupSize { get; protected set; }
		public int DamageTHPercent { get; protected set; }
		public bool ScaleByTH { get; protected set; }
		public bool EnabledByCalendar { get; protected set; }
		public int VillageType { get; protected set; }
		public int PauseCombatComponentsMs { get; protected set; }
		public int UpgradeLevelByTH { get; protected set; }
		public bool CanDamageStorages { get; protected set; }
		public int ChangeTeamTime { get; protected set; }
		public int InvisibilityTime { get; protected set; }
		public bool AffectsSiegeMachines { get; protected set; }
		public int[] FreezeOuterTimeMS { get; protected set; }
		public int ConeAngle { get; protected set; }
		public int FreezePercent { get; protected set; }
		public int MinRadius { get; protected set; }
		public int[] MinDamage { get; protected set; }
	}
}
