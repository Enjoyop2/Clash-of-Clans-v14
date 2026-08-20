using System.Collections.Generic;
using System.Threading.Tasks;

using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files
{
	public partial class Csv
	{
		public static readonly List<string> Gamefiles = new List<string>();

		public static Gamefiles Tables;

		public Csv()
		{
			Gamefiles.Add("GameAssets/logic/buildings.csv"); // 1
			Gamefiles.Add("GameAssets/logic/locales.csv"); // 2
			Gamefiles.Add("GameAssets/logic/resources.csv"); // 3
			Gamefiles.Add("GameAssets/logic/characters.csv"); // 4
			Gamefiles.Add("GameAssets/csv/animations.csv"); // 5
			Gamefiles.Add("GameAssets/logic/projectiles.csv"); // 6
			Gamefiles.Add("GameAssets/logic/building_classes.csv"); // 7
			Gamefiles.Add("GameAssets/logic/obstacles.csv"); // 8
			Gamefiles.Add("GameAssets/logic/effects.csv"); // 9
			Gamefiles.Add("GameAssets/csv/particle_emitters.csv"); // 10
			Gamefiles.Add("GameAssets/logic/experience_levels.csv"); // 11
			Gamefiles.Add("GameAssets/logic/traps.csv"); // 12
			Gamefiles.Add("GameAssets/logic/alliance_badges.csv"); // 13
			Gamefiles.Add("GameAssets/logic/globals.csv"); // 14
			Gamefiles.Add("GameAssets/logic/townhall_levels.csv"); // 15
			Gamefiles.Add("GameAssets/logic/alliance_portal.csv"); // 16
			Gamefiles.Add("GameAssets/logic/npcs.csv"); // 17
			Gamefiles.Add("GameAssets/logic/decos.csv"); // 18
			Gamefiles.Add("GameAssets/csv/resource_packs.csv"); // 19
			Gamefiles.Add("GameAssets/logic/shields.csv"); // 20
			Gamefiles.Add("GameAssets/logic/missions.csv"); // 21
			Gamefiles.Add("GameAssets/csv/billing_packages.csv"); // 22
			Gamefiles.Add("GameAssets/logic/achievements.csv"); // 23
			Gamefiles.Add("GameAssets/csv/credits.csv"); // 24
			Gamefiles.Add("GameAssets/logic/starter_pass_tasks.csv"); // 25
			Gamefiles.Add("GameAssets/logic/spells.csv"); // 26
			Gamefiles.Add("GameAssets/csv/hints.csv"); // 27
			Gamefiles.Add("GameAssets/logic/heroes.csv"); // 28
			Gamefiles.Add("GameAssets/logic/leagues.csv"); // 29
			Gamefiles.Add("GameAssets/logic/starter_pass.csv"); // 30
			Gamefiles.Add("GameAssets/logic/war.csv"); // 31
			Gamefiles.Add("GameAssets/logic/regions.csv"); // 32
			Gamefiles.Add("GameAssets/csv/client_globals.csv"); // 33
			Gamefiles.Add("GameAssets/logic/alliance_badge_layers.csv"); // 34
			Gamefiles.Add("GameAssets/logic/alliance_levels.csv"); // 35
			Gamefiles.Add("GameAssets/csv/helpshift.csv"); // 36
			Gamefiles.Add("GameAssets/logic/variables.csv"); // 37
			Gamefiles.Add("GameAssets/logic/gem_bundles.csv"); // 38
			Gamefiles.Add("GameAssets/logic/village_objects.csv"); // 39
			Gamefiles.Add("GameAssets/logic/calendar_event_functions.csv"); // 40

			Tables = new Gamefiles();

			Parallel.ForEach(Gamefiles,
				file => { Tables.Initialize(new Table(file), (LogicDataType)Gamefiles.IndexOf(file) + 1); });

			Logger.Log($"{Gamefiles.Count} Gamefile(s) loaded.", GetType());
		}
	}
}