using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicTownhallLevelData : LogicData
	{
		public LogicTownhallLevelData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public int AttackCost { get; protected set; }
		public int ResourceStorageLootPercentage { get; protected set; }
		public int DarkElixirStorageLootPercentage { get; protected set; }
		public int ResourceStorageLootCap { get; protected set; }
		public int DarkElixirStorageLootCap { get; protected set; }
		public int WarPrizeResourceCap { get; protected set; }
		public int WarPrizeDarkElixirCap { get; protected set; }
		public int LegendPrizeGoldCap { get; protected set; }
		public int LegendPrizeElixirCap { get; protected set; }
		public int LegendPrizeDarkElixirCap { get; protected set; }
		public int WarPrizeAllianceExpCap { get; protected set; }
		public int CartLootCapResource { get; protected set; }
		public int CartLootReengagementResource { get; protected set; }
		public int CartLootCapDarkElixir { get; protected set; }
		public int CartLootReengagementDarkElixir { get; protected set; }
		public int ReengagementBuildingBudget { get; protected set; }
		public int ReengagementHeroBudget { get; protected set; }
		public int ReengagementWallBudget { get; protected set; }
		public int ReengagementLabBudget { get; protected set; }
		public int HeroBoostHours { get; protected set; }
		public int PowerBoostHours { get; protected set; }
		public int ResourceProductionBoostHours { get; protected set; }
		public int StarBonusBoostHours { get; protected set; }
		//public int TroopHousing { get; protected set; }
		//public int ElixirStorage { get; protected set; }
		//public int GoldStorage { get; protected set; }
		//public int ElixirPump { get; protected set; }
		//public int GoldMine { get; protected set; }
		//public int Barrack { get; protected set; }
		//public int Cannon { get; protected set; }
		//public int Cannon_gearup { get; protected set; }
		//public int Wall { get; protected set; }
		//public int ArcherTower { get; protected set; }
		//public int ArcherTower_gearup { get; protected set; }
		//public int WizardTower { get; protected set; }
		//public int AirDefense { get; protected set; }
		//public int Mortar { get; protected set; }
		//public int Mortar_gearup { get; protected set; }
		//public int AllianceCastle { get; protected set; }
		//public int Ejector { get; protected set; }
		//public int Superbomb { get; protected set; }
		//public int Mine { get; protected set; }
		//public int WorkerBuilding { get; protected set; }
		//public int Laboratory { get; protected set; }
		//public int Communicationsmast { get; protected set; }
		//public int TeslaTower { get; protected set; }
		//public int SpellForge { get; protected set; }
		//public int MiniSpellFactory { get; protected set; }
		//public int Bow { get; protected set; }
		//public int Halloweenbomb { get; protected set; }
		//public int Slowbomb { get; protected set; }
		//public int HeroAltarBarbarianKing { get; protected set; }
		//public int DarkElixirPump { get; protected set; }
		//public int DarkElixirStorage { get; protected set; }
		//public int HeroAltarArcherQueen { get; protected set; }
		//public int AirTrap { get; protected set; }
		//public int MegaAirTrap { get; protected set; }
		//public int DarkElixirBarrack { get; protected set; }
		//public int DarkTower { get; protected set; }
		//public int SantaTrap { get; protected set; }
		//public int StrengthMaxTroopTypes { get; protected set; }
		//public int StrengthMaxSpellTypes { get; protected set; }
		//public int StrengthMaxSiegeTypes { get; protected set; }
		//public int Totem { get; protected set; }
		//public int Halloweenskels { get; protected set; }
		//public int AirBlaster { get; protected set; }
		//public int HeroAltarGrandWarden { get; protected set; }
		//public int MegaCannon { get; protected set; }
		//public int AncientArtillery { get; protected set; }
		//public int BombTower { get; protected set; }
		//public int TreasuryGold { get; protected set; }
		//public int TreasuryElixir { get; protected set; }
		//public int TreasuryDarkElixir { get; protected set; }
		//public int TreasuryWarGold { get; protected set; }
		//public int TreasuryWarElixir { get; protected set; }
		//public int TreasuryWarDarkElixir { get; protected set; }
		//public int FriendlyCost { get; protected set; }
		//public int PackElixir { get; protected set; }
		//public int PackGold { get; protected set; }
		//public int PackDarkElixir { get; protected set; }
		//public int PackGold2 { get; protected set; }
		//public int PackElixir2 { get; protected set; }
		//public int FreezeBomb { get; protected set; }
		//public int DuelPrizeResourceCap { get; protected set; }
		//public int ElixirPump2 { get; protected set; }
		//public int ElixirStorage2 { get; protected set; }
		//public int GoldMine2 { get; protected set; }
		//public int GoldStorage2 { get; protected set; }
		//public int WallStraight { get; protected set; }
		//public int Cannon2 { get; protected set; }
		//public int ArcherTower2 { get; protected set; }
		//public int TroopHousing2 { get; protected set; }
		//public int TeslaTower2 { get; protected set; }
		//public int DoubleCannon { get; protected set; }
		//public int ClockTower { get; protected set; }
		//public int Laboratory2 { get; protected set; }
		//public int MultiMortar { get; protected set; }
		//public int Barrack2 { get; protected set; }
		//public int MegaTesla { get; protected set; }
		//public int GuardPost { get; protected set; }
		//public int Pusher { get; protected set; }
		//public int HeroAltarWarmachine { get; protected set; }
		//public int AirDefenseMini { get; protected set; }
		//public int Crusher { get; protected set; }
		//public int AirGroundTrap { get; protected set; }
		//public int AirDefense2 { get; protected set; }
		//public int MegaAirGroundTrap { get; protected set; }
		//public int AttackCostVillage2 { get; protected set; }
		//public int ChangeTroopCost { get; protected set; }
		//public int Flamer { get; protected set; }
		//public int GemMine { get; protected set; }
		//public int Ejector2 { get; protected set; }
		//public int GiantCannon { get; protected set; }
		//public int ShrinkTrap { get; protected set; }
		//public int SiegeWorkshop { get; protected set; }
		//public int TornadoTrap { get; protected set; }
		//public int LavaLauncher { get; protected set; }
		//public int MasterBuilderBuilding { get; protected set; }
		//public int ArtoBuilding { get; protected set; }
		//public int HeroAltarRoyalChampion { get; protected set; }
		//public int Scattershot { get; protected set; }
		//public int PetShop { get; protected set; }
	}
}
