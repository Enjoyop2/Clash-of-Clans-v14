using System;
using System.Collections.Generic;
using System.IO;

namespace ClashofClans.CsvConverter
{
	public class CsWriter
	{
		internal CsWriter(string name, IReadOnlyList<string> header, string[] types, string[][] rows, string space)
		{
			string className = $"Logic{Uppercase(Singularize(name))}Data";
			using StreamWriter writer = new StreamWriter($"CS Output/{className}.cs");

			writer.WriteLine(
				$"using ClashofClans.Files.CsvHelpers;\n" +
				$"using ClashofClans.Files.CsvReader;\n\n" +
				$"namespace ClashofClans.Files.{space}");

			writer.WriteLine("{");
			writer.WriteLine($"\tpublic class {className} : LogicData");
			writer.WriteLine("\t{");

			writer.WriteLine(
				$"\t\tpublic {className}(Row row, DataTable datatable) : base(row, datatable)");

			writer.WriteLine("\t\t{");
			writer.WriteLine("\t\t\tLoadData(this, GetType(), row);");
			writer.WriteLine("\t\t}");
			writer.WriteLine();

			int count = header.Count;

			for (int index = 0; index < count; index++)
			{
				string type = types[index];

				if (type.Equals("boolean", StringComparison.OrdinalIgnoreCase))
					type = "bool";
				else
					type = type.ToLower();

				if (header[index] != "Name" && IsArrayColumn(index, header, rows))
				{
					type += "[]";
				}

				string propertyName = header[index].Replace(" ", string.Empty);

				writer.Write($"\t\tpublic {type} {propertyName} {{ get; protected set; }}");

				if (index < count - 1)
					writer.WriteLine();
			}

			writer.WriteLine("\n\t}");
			writer.WriteLine("}");
		}

		private bool IsArrayColumn(int columnIndex, IReadOnlyList<string> header, string[][] rows)
		{
			int nameIndex = -1;

			for (int index = 0; index < header.Count; index++)
			{
				if (header[index].Equals("Name", StringComparison.OrdinalIgnoreCase))
				{
					nameIndex = index;
					break;
				}
			}

			// Name control column is not found, so we cannot determine if the column is an array.
			if (nameIndex == -1)
				return false;

			foreach (string[] row in rows)
			{
				if (nameIndex >= row.Length || columnIndex >= row.Length)
					continue;

				string nameValue = row[nameIndex].Trim();
				string columnValue = row[columnIndex].Trim();

				// Name null or empty and column value is not null or empty, then this column is an array.
				if (string.IsNullOrEmpty(nameValue) &&
					!string.IsNullOrEmpty(columnValue))
				{
					return true;
				}
			}

			return false;
		}

		private string Singularize(string value)
		{
			if (string.IsNullOrEmpty(value))
				return string.Empty;

			// Countries -> Country
			if (value.EndsWith("ies", StringComparison.OrdinalIgnoreCase))
				return value.Substring(0, value.Length - 3) + "y";

			// Players -> Player
			if (value.EndsWith("s", StringComparison.OrdinalIgnoreCase))
				return value.Substring(0, value.Length - 1);

			return value;
		}

		private string Uppercase(string value)
		{
			if (string.IsNullOrEmpty(value))
				return string.Empty;

			string[] result = value.Split('_');
			string newString = string.Empty;

			foreach (string s in result)
			{
				if (string.IsNullOrEmpty(s))
					continue;

				char[] characters = s.ToCharArray();
				characters[0] = char.ToUpper(characters[0]);

				newString += new string(characters);
			}

			return newString;
		}
	}
}
