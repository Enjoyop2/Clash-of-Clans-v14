using ClashofClans.Files;
using ClashofClans.Files.Logic;

using Newtonsoft.Json.Linq;

namespace ClashofClans.Logic.Manager.Items.GameObjects
{
	public class Obstacle : GameObject
	{
		public bool Cleared;
		public Timer ClearingTimer;
		public int Data;
		public int Id;

		public Obstacle(Home.Home home) : base(home)
		{
		}

		public LogicObstacleData GetObstacleData() => Csv.Tables.Get(LogicDataType.OBSTACLE).GetDataWithId<LogicObstacleData>(Data);

		public override void Tick()
		{
			if (ClearingTimer == null) return;
			if (ClearingTimer.GetRemainingSeconds(Home.Time) <= 0) ClearingFinished();
		}

		public void StartClearing()
		{
			int clearingTime = GetObstacleData().ClearTimeSeconds;

			if (clearingTime <= 0)
			{
				ClearingFinished();
			}
			else
			{
				ClearingTimer = new Timer();
				ClearingTimer.StartTimer(Home.Time, clearingTime);
			}
		}

		public void ClearingFinished()
		{
			ClearingTimer = null;
			Cleared = true;
		}

		public override void FastForward(int seconds)
		{
			ClearingTimer?.FastForward(seconds);
		}

		public override JObject Save()
		{
			JObject jObject = base.Save();

			if (Id > 0)
				jObject.Add("id", Id);

			jObject.Add("data", Data);

			if (ClearingTimer != null)
				jObject.Add("clear_t", ClearingTimer.GetRemainingSeconds(Home.Time));

			return jObject;
		}

		public override void Load(JObject jObject)
		{
			base.Load(jObject);

			Data = jObject["data"].ToObject<int>();

			if (!jObject.ContainsKey("clear_t")) return;
			int clearingTime = jObject["clear_t"].ToObject<int>();
			if (clearingTime <= -1) return;
			ClearingTimer = new Timer();
			ClearingTimer.StartTimer(Home.Time, clearingTime);
		}
	}
}