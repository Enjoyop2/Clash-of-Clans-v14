using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicChatLocaleData : LogicData
	{
		public LogicChatLocaleData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string TID { get; protected set; }
		public string DisplayName { get; protected set; }
		public string RelatedLocale { get; protected set; }
	}
}
