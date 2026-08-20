using ClashofClans.Files;
using ClashofClans.Files.Logic;

using Newtonsoft.Json.Linq;

namespace ClashofClans.Logic.Manager.Items.GameObjects
{
	public class Deco : GameObject
	{
		public int Data { get; set; }
		public int Id { get; set; }

		public Deco(Home.Home home) : base(home)
		{
		}

		public LogicDecoData GetDecoData() => Csv.Tables.Get(LogicDataType.DECO).GetDataWithId<LogicDecoData>(Data);

		public override void Load(JObject jObject)
		{
			base.Load(jObject);

			Data = jObject["data"].ToObject<int>();
		}

		public override JObject Save()
		{
			JObject jObject = base.Save();

			jObject.Add("data", Data);
			jObject.Add("id", Id);

			return jObject;
		}
	}
}