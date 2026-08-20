using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicBuildingClassData : LogicData
	{
		public LogicBuildingClassData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string TID { get; protected set; }
		public bool CanBuy { get; protected set; }
		public bool ShopCategoryResource { get; protected set; }
		public bool ShopCategoryArmy { get; protected set; }
		public bool ShopCategoryDefense { get; protected set; }
		public bool Npc { get; protected set; }
		public string ParentClass { get; protected set; }
	}
}
