using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicBoosterData : LogicData
	{
		public LogicBoosterData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string TID { get; protected set; }
		public string InfoTID { get; protected set; }
		public string OfferInfoTID { get; protected set; }
		public string AltTID { get; protected set; }
		public string SWF { get; protected set; }
		public string ExportName { get; protected set; }
		public string IconSWF { get; protected set; }
		public string IconExportName { get; protected set; }
		public bool Enabled { get; protected set; }
		public int MaxItems { get; protected set; }
		public int DiamondValue { get; protected set; }
		public int DisplayOrder { get; protected set; }
		public bool Troop { get; protected set; }
		public bool Building { get; protected set; }
		public bool Spell { get; protected set; }
		public bool Hero { get; protected set; }
		public bool Wall { get; protected set; }
		public bool SuperTroop { get; protected set; }
		public bool StartUpgrade { get; protected set; }
		public bool FinishUpgrade { get; protected set; }
		public bool MaxLevelArmy { get; protected set; }
		public bool BoostResource { get; protected set; }
		public bool BoostProduction { get; protected set; }
		public string FillStorageResource { get; protected set; }
		public bool BoostBuilders { get; protected set; }
		public bool BoostClocktower { get; protected set; }
		public bool BoostLaboratory { get; protected set; }
	}
}
