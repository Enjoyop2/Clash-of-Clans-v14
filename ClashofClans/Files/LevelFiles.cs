using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using ClashofClans.Files.Logic;

namespace ClashofClans.Files
{
	public class LevelFiles
	{
		private int _data;

		public static string JsonDataChallengeJulyQualifier;
		public static string JsonDataEpicJungle;
		public static string JsonDataMaxHome;
		public static string JsonDataStartingHome;

		public List<string> NpcLevels = new List<string>();

		public LevelFiles()
		{
			if (Directory.Exists("GameAssets/level"))
			{
				if (File.Exists("GameAssets/starting_home.json"))
				{
					JsonDataMaxHome = File.ReadAllText("GameAssets/level/townhall14.json", Encoding.UTF8);
					JsonDataStartingHome = File.ReadAllText("GameAssets/starting_home.json", Encoding.UTF8);
					JsonDataEpicJungle = File.ReadAllText("GameAssets/level/challenge_epic_jungle.json", Encoding.UTF8);
					JsonDataChallengeJulyQualifier = File.ReadAllText("GameAssets/level/challenge_july_qualifier_2021.json", Encoding.UTF8);

					while (GetNpcDataLinesCount() > _data)
					{
						if (!string.IsNullOrEmpty(GetNpcsData().LevelFile))
							NpcLevels.Add(File.ReadAllText($"GameAssets/{GetNpcsData().LevelFile}", Encoding.UTF8));
						_data++;
					}
				}
				else
				{
					Console.WriteLine("Failed to load starting home.");
					Program.Exit();
				}
			}
			else
			{
				Console.WriteLine("GameAssets folder doesn't exist.");
				Program.Exit();
			}
		}

		private int GetNpcDataLinesCount() => Csv.Tables.Get(LogicDataType.NPC).Count();
		private LogicNpcData GetNpcsData() => Csv.Tables.Get(LogicDataType.NPC).GetDataWithId<LogicNpcData>(_data);
	}
}