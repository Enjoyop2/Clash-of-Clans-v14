using System;

using ClashofClans.Extensions;
using ClashofClans.Files;
using ClashofClans.Files.Logic;

using Newtonsoft.Json.Linq;

namespace ClashofClans.Logic.Manager.Items.GameObjects
{
	public class VillageObject : GameObject
	{
		private int _upgradeLevel;
		public int Data;
		public int Id;


		public Timer _buildTime;

		public VillageObject(Home.Home home) : base(home)
		{
		}


		public LogicVillageObjectData VillageObjectsData =>
			Csv.Tables.Get(LogicDataType.VILLAGE_OBJECT).GetDataWithId<LogicVillageObjectData>(Data);

		public void StartUpgrade()
		{
			if (_buildTime != null) return;
			int buildTime = VillageObjectsData.GetBuildTime(_upgradeLevel + 1);

			// TODO: WORKER

			if (buildTime <= 0)
			{
				FinishConstruction();
			}
			else
			{
				_buildTime = new Timer();
				_buildTime.StartTimer(Home.Time, buildTime);
			}
		}

		public void SetUpgradeLevel(int upgradeLevel)
		{
			_upgradeLevel = upgradeLevel;
		}

		public int GetUpgradeLevel()
		{
			return _upgradeLevel;
		}

		public void SpeedUpConstruction()
		{
			if (_buildTime == null) return;
			int cost = GamePlayUtil.GetSpeedUpCost(_buildTime.GetRemainingSeconds(Home.Time));

			if (Home.UseDiamonds(cost))
				FinishConstruction();
			else
				Logger.Log("Payment failed.", GetType(), LogErrorType.WARNING);
		}

		public void FinishConstruction()
		{
			SetUpgradeLevel(_upgradeLevel + 1);

			// TODO: WORKER
			Home.AddExpPoints((int)Math.Sqrt(VillageObjectsData.GetBuildTime(_upgradeLevel)));
			_buildTime = null;
		}

		public override void FastForward(int seconds)
		{
			_buildTime?.FastForward(seconds);

			base.FastForward(seconds);
		}

		public override void Tick()
		{
			if (_buildTime != null)
				if (_buildTime.GetRemainingSeconds(Home.Time) <= 0)
					FinishConstruction();

			base.Tick();
		}

		public override void Load(JObject jObject)
		{
			base.Load(jObject);

			Data = jObject["data"].ToObject<int>();
			SetUpgradeLevel(jObject["lvl"].ToObject<int>());

			if (jObject.ContainsKey("const_t"))
			{
				int constructionTime = jObject["const_t"].ToObject<int>();
				if (constructionTime > -1)
				{
					constructionTime = Math.Min(constructionTime, VillageObjectsData.GetBuildTime(_upgradeLevel + 1));

					_buildTime = new Timer();
					_buildTime.StartTimer(Home.Time, constructionTime);
					// TODO: WORKER
				}
			}
		}

		public override JObject Save()
		{
			JObject jObject = base.Save();

			jObject.Add("data", Data);
			jObject.Add("id", Id);
			jObject.Add("lvl", _upgradeLevel);

			if (_buildTime != null)
				jObject.Add("const_t", _buildTime.GetRemainingSeconds(Home.Time));

			return jObject;
		}
	}
}