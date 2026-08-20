using ClashofClans.CsvConverter.Extensions;

using System;
using System.IO;
using System.Linq;

namespace ClashofClans.CsvConverter
{
	public class Program
	{
		public static void Main()
		{
			Console.Title = "ClashofClans CSV Converter v0.3.2";

			Console.SetOut(new Prefixed());

			Console.WriteLine("Converting...");

			if (!Directory.Exists("CSV Input"))
			{
				Directory.CreateDirectory("CSV Input");
				Console.WriteLine("Input Directory was not found so it has been created.");
			}

			if (!Directory.Exists("CS Output"))
			{
				Directory.CreateDirectory("CS Output");
				Console.WriteLine("Output Directory was not found so it has been created.");
			}

			Console.Write("Enter name (e.g. Logic): ");
			string name = Console.ReadLine();

			if (Directory.GetFiles("CSV Input").Any())
			{
				string[] files = Directory.GetFiles("CSV Input");

				foreach (string file in files)
				{
					if (Path.GetExtension(file) != ".csv")
						continue;

					string[] lines = File.ReadAllLines(file);

					if (lines.Length < 2)
					{
						Console.WriteLine($"File {Path.GetFileName(file)} is invalid.");
						continue;
					}

					string[] header = lines[0].Replace("\"", "").Split(',');
					string[] types = lines[1].Replace("\"", "").Split(',');

					string[][] rows = lines.Skip(2).Where(line => !string.IsNullOrWhiteSpace(line))
						.Select(line => line.Replace("\"", "").Split(',')).ToArray();

					new CsWriter(Path.GetFileNameWithoutExtension(file), header, types, rows, name);

					Console.WriteLine($"File {Path.GetFileNameWithoutExtension(file)} has been exported.");
				}
			}
			else
			{
				Console.WriteLine("No CSV File has been found.");
			}

			Console.ReadKey();
		}
	}
}
