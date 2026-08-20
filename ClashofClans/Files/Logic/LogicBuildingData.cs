using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicBuildingData : LogicData
	{
		public LogicBuildingData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public int[] BuildingLevel { get; protected set; }
		public string TID { get; protected set; }
		public string InfoTID { get; protected set; }
		public string BuildingClass { get; protected set; }
		public string SecondaryTargetingClass { get; protected set; }
		public string ShopBuildingClass { get; protected set; }
		public string SWF { get; protected set; }
		public string[] ExportName { get; protected set; }
		public string ExportNameNpc { get; protected set; }
		public string ExportNameConstruction { get; protected set; }
		public string ExportNameLocked { get; protected set; }
		public int[] BuildTimeD { get; protected set; }
		public int[] BuildTimeH { get; protected set; }
		public int[] BuildTimeM { get; protected set; }
		public int[] BuildTimeS { get; protected set; }
		public string BuildResource { get; protected set; }
		public int[] BuildCost { get; protected set; }
		public int[] TownHallLevel { get; protected set; }
		public int[] TownHallLevel2 { get; protected set; }
		public int[] Width { get; protected set; }
		public int[] Height { get; protected set; }
		public string Icon { get; protected set; }
		public string[] ExportNameBuildAnim { get; protected set; }
		public string[] ExportNameUpgradeAnim { get; protected set; }
		public int[] MaxStoredGold { get; protected set; }
		public int[] MaxStoredElixir { get; protected set; }
		public int[] MaxStoredDarkElixir { get; protected set; }
		public int[] MaxStoredWarGold { get; protected set; }
		public int[] MaxStoredWarElixir { get; protected set; }
		public int[] MaxStoredWarDarkElixir { get; protected set; }
		public int[] MaxStoredGold2 { get; protected set; }
		public int[] MaxStoredElixir2 { get; protected set; }
		public int PercentageStoredGold { get; protected set; }
		public int PercentageStoredElixir { get; protected set; }
		public int[] PercentageStoredDarkElixir { get; protected set; }
		public bool LootOnDestruction { get; protected set; }
		public bool Bunker { get; protected set; }
		public int Village2Housing { get; protected set; }
		public int[] HousingSpace { get; protected set; }
		public int[] HousingSpaceAlt { get; protected set; }
		public int[] HousingSpaceSiege { get; protected set; }
		public string ProducesResource { get; protected set; }
		public int[] ResourcePer100Hours { get; protected set; }
		public int[] ResourceMax { get; protected set; }
		public int[] ResourceIconLimit { get; protected set; }
		public int[] UnitProduction { get; protected set; }
		public string UpgradesUnitType { get; protected set; }
		public int ProducesUnitsOfType { get; protected set; }
		public string LevelRequirementTID { get; protected set; }
		public int[] BoostCost { get; protected set; }
		public bool FreeBoost { get; protected set; }
		public int[] Hitpoints { get; protected set; }
		public int[] RegenTime { get; protected set; }
		public int[] AttackRange { get; protected set; }
		public bool AltAttackMode { get; protected set; }
		public int AltAttackRange { get; protected set; }
		public int PrepareSpeed { get; protected set; }
		public int[] AttackSpeed { get; protected set; }
		public int AltAttackSpeed { get; protected set; }
		public int CoolDownOverride { get; protected set; }
		public int[] DPS { get; protected set; }
		public int[] AltDPS { get; protected set; }
		public int[] Damage { get; protected set; }
		public string PreferredTarget { get; protected set; }
		public int PreferredTargetDamageMod { get; protected set; }
		public bool RandomHitPosition { get; protected set; }
		public string[] DestroyEffect { get; protected set; }
		public string[] DestroyDamageEffect { get; protected set; }
		public string[] AttackEffect { get; protected set; }
		public string[] AttackEffect2 { get; protected set; }
		public int ChainAttackDistance { get; protected set; }
		public int ChainAttackMaxTargets { get; protected set; }
		public int ChainAttackDelay { get; protected set; }
		public int ChainAttackDamageReductionPercent { get; protected set; }
		public string AttackEffectAlt { get; protected set; }
		public string[] HitEffect { get; protected set; }
		public string[] Projectile { get; protected set; }
		public string[] AltProjectile { get; protected set; }
		public string[] ExportNameDamaged { get; protected set; }
		public int[] BuildingW { get; protected set; }
		public int[] BuildingH { get; protected set; }
		public int BaseGfx { get; protected set; }
		public string[] ExportNameBase { get; protected set; }
		public bool AirTargets { get; protected set; }
		public bool GroundTargets { get; protected set; }
		public bool MultiTargets { get; protected set; }
		public int NumMultiTargets { get; protected set; }
		public bool AltAirTargets { get; protected set; }
		public bool AltGroundTargets { get; protected set; }
		public bool AltMultiTargets { get; protected set; }
		public int AmmoCount { get; protected set; }
		public string AmmoResource { get; protected set; }
		public int[] AmmoCost { get; protected set; }
		public int MinAttackRange { get; protected set; }
		public int DamageRadius { get; protected set; }
		public int PushBack { get; protected set; }
		public bool[] WallCornerPieces { get; protected set; }
		public string LoadAmmoEffect { get; protected set; }
		public string NoAmmoEffect { get; protected set; }
		public string ToggleAttackModeEffect { get; protected set; }
		public string[] PickUpEffect { get; protected set; }
		public string[] PlacingEffect { get; protected set; }
		public bool AnimateTurret { get; protected set; }
		public string[] DefenderCharacter { get; protected set; }
		public int[] DefenderCount { get; protected set; }
		public int[] DefenderZ { get; protected set; }
		public int[] AltDefenderZ { get; protected set; }
		public int[] DestructionXP { get; protected set; }
		public bool Locked { get; protected set; }
		public int StartingHomeCount { get; protected set; }
		public bool Hidden { get; protected set; }
		public string AOESpell { get; protected set; }
		public string AOESpellAlternate { get; protected set; }
		public int TriggerRadius { get; protected set; }
		public string[] ExportNameTriggered { get; protected set; }
		public string AppearEffect { get; protected set; }
		public bool ForgesSpells { get; protected set; }
		public bool ForgesMiniSpells { get; protected set; }
		public bool IsHeroBarrack { get; protected set; }
		public string HeroType { get; protected set; }
		public bool IncreasingDamage { get; protected set; }
		public int[] DPSLv2 { get; protected set; }
		public int[] DPSLv3 { get; protected set; }
		public int[] DPSMulti { get; protected set; }
		public int[] Lv2SwitchTime { get; protected set; }
		public int[] Lv3SwitchTime { get; protected set; }
		public string[] AttackEffectLv2 { get; protected set; }
		public string[] AttackEffectLv3 { get; protected set; }
		public string TransitionEffectLv2 { get; protected set; }
		public string TransitionEffectLv3 { get; protected set; }
		public int[] AltNumMultiTargets { get; protected set; }
		public bool PreventsHealing { get; protected set; }
		public int[] StrengthWeight { get; protected set; }
		public int AlternatePickNewTargetDelay { get; protected set; }
		public string[] AltBuildResource { get; protected set; }
		public int SpeedMod { get; protected set; }
		public int StatusEffectTime { get; protected set; }
		public int[] ShockwavePushStrength { get; protected set; }
		public int ShockwaveArcLength { get; protected set; }
		public int ShockwaveExpandRadius { get; protected set; }
		public int TargetingConeAngle { get; protected set; }
		public int AimRotateStep { get; protected set; }
		public bool PenetratingProjectile { get; protected set; }
		public int PenetratingRadius { get; protected set; }
		public int PenetratingExtraRange { get; protected set; }
		public int TurnSpeed { get; protected set; }
		public bool NeedsAim { get; protected set; }
		public bool TargetGroups { get; protected set; }
		public int TargetGroupsRadius { get; protected set; }
		public string HitSpell { get; protected set; }
		public int HitSpellLevel { get; protected set; }
		public string ExportNameBeamStart { get; protected set; }
		public string ExportNameBeamEnd { get; protected set; }
		public int Damage2 { get; protected set; }
		public int Damage2Radius { get; protected set; }
		public int Damage2Delay { get; protected set; }
		public int Damage2Min { get; protected set; }
		public int Damage2FalloffStart { get; protected set; }
		public int Damage2FalloffEnd { get; protected set; }
		public string HitEffect2 { get; protected set; }
		public int WakeUpSpeed { get; protected set; }
		public int[] WakeUpSpace { get; protected set; }
		public string PreAttackEffect { get; protected set; }
		public bool ShareHeroCombatData { get; protected set; }
		public int BurstCount { get; protected set; }
		public int BurstDelay { get; protected set; }
		public int AltBurstCount { get; protected set; }
		public int AltBurstDelay { get; protected set; }
		public int DummyProjectileCount { get; protected set; }
		public int[] DieDamage { get; protected set; }
		public int DieDamageRadius { get; protected set; }
		public string DieDamageEffect { get; protected set; }
		public int DieDamageDelay { get; protected set; }
		public bool IsRed { get; protected set; }
		public int VillageType { get; protected set; }
		public string WallBlockX { get; protected set; }
		public string WallBlockY { get; protected set; }
		public int RedMul { get; protected set; }
		public int GreenMul { get; protected set; }
		public int BlueMul { get; protected set; }
		public int RedAdd { get; protected set; }
		public int GreenAdd { get; protected set; }
		public int BlueAdd { get; protected set; }
		public int[] DefenceTroopCount { get; protected set; }
		public string[] DefenceTroopCharacter { get; protected set; }
		public string DefenceTroopCharacter2 { get; protected set; }
		public int[] DefenceTroopLevel { get; protected set; }
		public int[] AmountCanBeUpgraded { get; protected set; }
		public bool SelfAsAoeCenter { get; protected set; }
		public int NewTargetAttackDelay { get; protected set; }
		public string GearUpBuilding { get; protected set; }
		public int GearUpLevelRequirement { get; protected set; }
		public string GearUpResource { get; protected set; }
		public int[] GearUpCost { get; protected set; }
		public int[] GearUpTime { get; protected set; }
		public string GearUpTID { get; protected set; }
		public int[] StartUpgradeBoosterCost { get; protected set; }
		public int[] ActivateCombatOnDamageTaken { get; protected set; }
		public string ActivatedCombatAddBuildingClass { get; protected set; }
		public int[] CombatActivationDelay { get; protected set; }
		public string CombatActivationEffect { get; protected set; }
		public string[] Weapon { get; protected set; }
		public int HintPriority { get; protected set; }
		public string UpgradeTasks { get; protected set; }
		public int[] UpgradeTasksRequired { get; protected set; }
		public int[] AnimationActionFrame { get; protected set; }

		public bool IsBarrack() => UnitProduction[0] > 0 && ProducesUnitsOfType == 1 && !ForgesSpells;
		public bool IsDarkBarrack() => UnitProduction[0] > 0 && ProducesUnitsOfType == 2 && !ForgesSpells;
		public bool IsLaboratory() => UpgradesUnitType == "UNIT";
		public bool IsTownHall() => BuildingClass == "Town Hall";
		public bool IsTownHall2() => BuildingClass == "Town Hall2";
		public bool IsTrainingHousing() => HousingSpace[0] > 0 && !Bunker;
		public bool IsWorker() => BuildingClass == "Worker";

		public int GetMaxLevel() => BuildCost.Length - 1;

		public bool CanStoreResources() =>
			MaxStoredGold[0] > 0
			|| MaxStoredElixir[0] > 0
			|| MaxStoredDarkElixir[0] > 0
			|| MaxStoredWarGold[0] > 0
			|| MaxStoredWarElixir[0] > 0
			|| MaxStoredWarDarkElixir[0] > 0
			|| MaxStoredGold2[0] > 0
			|| MaxStoredElixir2[0] > 0;

		public int GetBuildTime(int level)
		{
			return BuildTimeD[level] * 86400 + BuildTimeH[level] * 3600 + BuildTimeM[level] * 60 + BuildTimeS[level];
		}
	}
}