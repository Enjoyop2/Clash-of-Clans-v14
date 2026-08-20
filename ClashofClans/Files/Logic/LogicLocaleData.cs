using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicLocaleData : LogicData
	{
		public LogicLocaleData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string FileName { get; protected set; }
		public string LocalizedName { get; protected set; }
		public bool HasEvenSpaceCharacters { get; protected set; }
		public bool isRTL { get; protected set; }
		public string UsedSystemFont { get; protected set; }
		public string HelpshiftSDKLanguage { get; protected set; }
		public string HelpshiftSDKLanguageAndroid { get; protected set; }
		public int SortOrder { get; protected set; }
		public bool TestLanguage { get; protected set; }
		public string[] TestExcludes { get; protected set; }
		public bool BoomboxEnabled { get; protected set; }
		public string BoomboxUrl { get; protected set; }
		public string BoomboxStagingUrl { get; protected set; }
		public string BoomBoxCommunityUrl { get; protected set; }
		public string BoomBoxCommunityStagingUrl { get; protected set; }
		public bool BoomBoxCommunityContentShowsBadge { get; protected set; }
		public string BoomBoxEsportsUrl { get; protected set; }
		public string BoomBoxEsportsStagingUrl { get; protected set; }
		public string TournamentHubUrl { get; protected set; }
		public string TournamentHubStagingUrl { get; protected set; }
		public string HelpshiftLanguageTagOverride { get; protected set; }
		public string ForcedFontName { get; protected set; }
		public string SelfHelpUrl { get; protected set; }
	}
}