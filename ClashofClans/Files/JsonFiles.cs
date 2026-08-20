using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using ClashofClans.Files.Logic;

namespace ClashofClans.Files
{
	public class JsonFiles
	{
		public static string JsonDataCalendar;
		public static string JsonDataGlobals;

		public JsonFiles()
		{
			if (Directory.Exists("GameAssets"))
			{
				JsonDataGlobals = File.ReadAllText("GameAssets/globals.json", Encoding.UTF8);
				JsonDataCalendar = File.ReadAllText("GameAssets/calendar.json", Encoding.UTF8);
			}
			else
			{
				Console.WriteLine("GameAssets folder doesn't exist.");
				Program.Exit();
			}
		}
	}
}