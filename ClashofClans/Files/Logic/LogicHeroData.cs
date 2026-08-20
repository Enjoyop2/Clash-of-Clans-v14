using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicHeroData : LogicData
	{
		public LogicHeroData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string TID { get; protected set; }
		public string InfoTID { get; protected set; }
		public int Speed { get; protected set; }
		public int[] Hitpoints { get; protected set; }
		public int[] UpgradeTimeH { get; protected set; }
		public string UpgradeResource { get; protected set; }
		public int[] UpgradeCost { get; protected set; }
		public int[] RequiredTownHallLevel { get; protected set; }
		public int AttackRange { get; protected set; }
		public int AttackSpeed { get; protected set; }
		public int CoolDownOverride { get; protected set; }
		public int[] DPS { get; protected set; }
		public int PreferedTargetDamageMod { get; protected set; }
		public int DamageRadius { get; protected set; }
		public string IconSWF { get; protected set; }
		public string IconExportName { get; protected set; }
		public string BigPicture { get; protected set; }
		public string BigPictureSWF { get; protected set; }
		public string SmallPicture { get; protected set; }
		public string SmallPictureSWF { get; protected set; }
		public string[] Projectile { get; protected set; }
		public string[] RageProjectile { get; protected set; }
		public string PreferedTargetBuilding { get; protected set; }
		public string DeployEffect { get; protected set; }
		public string AttackEffect { get; protected set; }
		public string AttackEffectAlt { get; protected set; }
		public string HitEffect { get; protected set; }
		public string HitEffectActive { get; protected set; }
		public bool IsFlying { get; protected set; }
		public bool AirTargets { get; protected set; }
		public bool GroundTargets { get; protected set; }
		public bool IsJumper { get; protected set; }
		public int AttackCount { get; protected set; }
		public string DieEffect { get; protected set; }
		public string[] Animation { get; protected set; }
		public int ActivationTime { get; protected set; }
		public int ActiveDuration { get; protected set; }
		public int AbilityAttackCount { get; protected set; }
		public string[] AnimationActivated { get; protected set; }
		public int MaxSearchRadiusForDefender { get; protected set; }
		public int HousingSpace { get; protected set; }
		public string SpecialAbilityEffect { get; protected set; }
		public int[] RegenerationTimeMinutes { get; protected set; }
		public int TrainingTime { get; protected set; }
		public string TrainingResource { get; protected set; }
		public int TrainingCost { get; protected set; }
		public string CelebrateEffect { get; protected set; }
		public int SleepOffsetX { get; protected set; }
		public int SleepOffsetY { get; protected set; }
		public int PatrolRadius { get; protected set; }
		public string AbilityTriggerEffect { get; protected set; }
		public bool AbilityAffectsHero { get; protected set; }
		public string AbilityAffectsCharacter { get; protected set; }
		public int AbilityRadius { get; protected set; }
		public int[] AbilityTime { get; protected set; }
		public bool AbilityOnce { get; protected set; }
		public int AbilityCooldown { get; protected set; }
		public int[] AbilitySpeedBoost { get; protected set; }
		public int[] AbilitySpeedBoost2 { get; protected set; }
		public int[] AbilityDamageBoostPercent { get; protected set; }
		public string AbilitySummonTroop { get; protected set; }
		public int[] AbilitySummonTroopCount { get; protected set; }
		public bool AbilityStealth { get; protected set; }
		public int[] AbilityDamageBoostOffset { get; protected set; }
		public int[] AbilityHealthIncrease { get; protected set; }
		public int AbilityShieldProjectileSpeed { get; protected set; }
		public int AbilityShieldProjectileDamageMod { get; protected set; }
		public string AbilityTID { get; protected set; }
		public string AbilityDescTID { get; protected set; }
		public string AbilityIcon { get; protected set; }
		public string AbilityBigPictureExportName { get; protected set; }
		public int AbilityDelay { get; protected set; }
		public int[] StrengthWeight { get; protected set; }
		public int[] StrengthWeight2 { get; protected set; }
		public int AlertRadius { get; protected set; }
		public int Scale { get; protected set; }
		public string AuraSpell { get; protected set; }
		public int[] AuraSpellLevel { get; protected set; }
		public string AuraTID { get; protected set; }
		public string AuraDescTID { get; protected set; }
		public string AuraBigPictureExportName { get; protected set; }
		public string[] AbilitySpell { get; protected set; }
		public int[] AbilitySpellLevel { get; protected set; }
		public string RetributionSpell { get; protected set; }
		public int RetributionSpellLevel { get; protected set; }
		public int RetributionSpellTriggerHealth { get; protected set; }
		public bool HasAltMode { get; protected set; }
		public bool AltModeFlying { get; protected set; }
		public string AltModeAnimation { get; protected set; }
		public string PreferedTargetBuildingClass { get; protected set; }
		public bool NoAttackOverWalls { get; protected set; }
		public bool TargetGroups { get; protected set; }
		public bool FightWithGroups { get; protected set; }
		public int TargetGroupsRadius { get; protected set; }
		public int TargetGroupsRange { get; protected set; }
		public int TargetGroupsMinWeight { get; protected set; }
		public bool SmoothJump { get; protected set; }
		public int WakeUpSpeed { get; protected set; }
		public int WakeUpSpace { get; protected set; }
		public int FriendlyGroupWeight { get; protected set; }
		public int EnemyGroupWeight { get; protected set; }
		public string AttackEffectShared { get; protected set; }
		public int TargetedEffectOffset { get; protected set; }
		public bool TriggersTraps { get; protected set; }
		public int VillageType { get; protected set; }
		public bool NoDefence { get; protected set; }
		public string PreAttackEffect { get; protected set; }
		public bool AbilityAffectsSummonedUnits { get; protected set; }
		public string DefaultSkin { get; protected set; }
		public string AbilityProjectile { get; protected set; }
		public int AbilityProjectileBounces { get; protected set; }
		public int AbilityProjectileRange { get; protected set; }
		public int AbilityProjectileCount { get; protected set; }
		public bool UseAutoHeroAbility { get; protected set; }
		public int NewTargetAttackDelay { get; protected set; }
		public int[] AbilityDamage { get; protected set; }
		public string Gender { get; protected set; }
	}
}
