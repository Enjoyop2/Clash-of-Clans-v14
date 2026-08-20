using System;

using ClashofClans.Files;
using ClashofClans.Files.Logic;

using Newtonsoft.Json.Linq;

namespace ClashofClans.Logic.Manager.Items.GameObjects
{
	public class Trap : GameObject
	{
		private int _upgradeLevel;
		private bool _attackMode;

		public int Data { get; set; }
		public int Id { get; set; }
		public int Level { get; set; }
		public Timer ConstructionTimer { get; set; }

		public Trap(Home.Home home) : base(home)
		{
		}

		public LogicTrapData GetTrapData() => Csv.Tables.Get(LogicDataType.TRAP).GetDataWithId<LogicTrapData>(Data);

		public void StartUpgrade()
		{
			if (ConstructionTimer != null) return;
			int buildTime = GetTrapData().GetBuildTime(_upgradeLevel + 1);

			// TODO: WORKER

			if (buildTime <= 0)
			{
				FinishConstruction();
			}
			else
			{
				ConstructionTimer = new Timer();
				ConstructionTimer.StartTimer(Home.Time, buildTime);
			}
		}

		public int GetUpgradeLevel()
		{
			return _upgradeLevel;
		}

		public void SetUpgradeLevel(int upgradeLevel)
		{
			_upgradeLevel = upgradeLevel;
		}

		public void FinishConstruction()
		{
			SetUpgradeLevel(_upgradeLevel + 1);

			// TODO: WORKER
			Home.AddExpPoints((int)Math.Sqrt(GetTrapData().GetBuildTime(_upgradeLevel)));
			ConstructionTimer = null;
		}

		public override void Load(JObject jObject)
		{
			base.Load(jObject);

			Data = jObject["data"].ToObject<int>();
			Level = jObject["lvl"].ToObject<int>();

			if (jObject.ContainsKey("const_t"))
			{
				int constructionTime = jObject["const_t"].ToObject<int>();
				if (constructionTime > -1)
				{
					constructionTime = Math.Min(constructionTime, GetTrapData().GetBuildTime(_upgradeLevel + 1));

					ConstructionTimer = new Timer();
					ConstructionTimer.StartTimer(Home.Time, constructionTime);
					// TODO: WORKER
				}
			}

			if (jObject.ContainsKey("attack_mode"))
				_attackMode = jObject["attack_mode"].ToObject<bool>();
		}

		public override JObject Save()
		{
			JObject jObject = base.Save();

			jObject.Add("data", Data);
			jObject.Add("id", Id);
			jObject.Add("lvl", Level);

			if (ConstructionTimer != null)
				jObject.Add("const_t", ConstructionTimer.GetRemainingSeconds(Home.Time));

			if (_attackMode)
				jObject.Add("attack_mode", true);

			return jObject;
		}
	}
}