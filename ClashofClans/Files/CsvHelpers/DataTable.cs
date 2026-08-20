using System.Collections.Generic;

using ClashofClans.Files.CsvReader;
using ClashofClans.Files.Logic;

namespace ClashofClans.Files.CsvHelpers
{
	public class DataTable
	{
		public List<LogicData> Datas;
		public LogicDataType Index;

		public DataTable()
		{
			Datas = new List<LogicData>();
		}

		public DataTable(Table table, LogicDataType index)
		{
			Index = index;
			Datas = new List<LogicData>();

			for (int i = 0; i < table.GetRowCount(); i += 2)
			{
				Row row = table.GetRowAt(i);
				LogicData data = Csv.Create(Index, row, this);
				Datas.Add(data);
			}
		}

		public int Count()
		{
			return Datas?.Count ?? 0;
		}

		public List<LogicData> GetDatas()
		{
			return Datas;
		}

		public LogicData GetDataWithId(int id)
		{
			return Datas[GlobalId.GetInstanceId(id)];
		}

		public T GetDataWithId<T>(int id) where T : LogicData
		{
			return Datas[GlobalId.GetInstanceId(id)] as T;
		}

		public T GetDataWithInstanceId<T>(int id) where T : LogicData
		{
			if (Datas.Count < id) return null;

			return Datas[id] as T;
		}

		public T GetData<T>(string name) where T : LogicData
		{
			return Datas.Find(data => data.GetName() == name) as T;
		}

		public int GetIndex()
		{
			return (int)Index;
		}
	}
}