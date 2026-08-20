using System;

using ClashofClans.Files;
using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.Logic;

namespace ClashofClans.Extensions
{
	public class GamePlayUtil
	{

		private static DataTable GetGlobalsDataTable()
		{
			return Csv.Tables.Get(LogicDataType.GLOBAL);
		}

		private static int GetGlobalNumberValue(string rowName)
		{
			return GetGlobalsDataTable().GetData<LogicGlobalData>(rowName).NumberValue;
		}

		private static int CalculateResourceCost(int sup, int inf, int supCost, int infCost, int amount)
		{
			return (int)Math.Round((supCost - infCost) * (long)(amount - inf) / (sup - inf * 1.0)) + infCost;
		}

		private static int CalculateSpeedUpCost(int sup, int inf, int supCost, int infCost, int amount)
		{
			return (int)Math.Round((supCost - infCost) * (long)(amount - inf) / (sup - inf * 1.0)) + infCost;
		}

		public static int GetResourceDiamondCost(int resourceCount, string resource)
		{
			int result = 0;
			if (resource == "DarkElixir")
			{
				result = GetDarkElixirDiamondCost(resourceCount);
			}
			else
			{

				if (resourceCount >= 1)
				{
					int supCost = 0;
					int infCost = 0;

					if (resourceCount >= 100)
					{
						if (resourceCount >= 1000)
						{
							if (resourceCount >= 10000)
							{
								if (resourceCount >= 100000)
								{
									if (resourceCount >= 1000000)
									{
										supCost = GetGlobalNumberValue("RESOURCE_DIAMOND_COST_10000000");
										infCost = GetGlobalNumberValue("RESOURCE_DIAMOND_COST_1000000");
										result = CalculateResourceCost(10000000, 1000000, supCost, infCost, resourceCount);
									}
									else
									{
										supCost = GetGlobalNumberValue("RESOURCE_DIAMOND_COST_1000000");
										infCost = GetGlobalNumberValue("RESOURCE_DIAMOND_COST_100000");
										result = CalculateResourceCost(1000000, 100000, supCost, infCost, resourceCount);
									}
								}
								else
								{
									supCost = GetGlobalNumberValue("RESOURCE_DIAMOND_COST_100000");
									infCost = GetGlobalNumberValue("RESOURCE_DIAMOND_COST_10000");
									result = CalculateResourceCost(100000, 10000, supCost, infCost, resourceCount);
								}
							}
							else
							{
								supCost = GetGlobalNumberValue("RESOURCE_DIAMOND_COST_10000");
								infCost = GetGlobalNumberValue("RESOURCE_DIAMOND_COST_1000");
								result = CalculateResourceCost(10000, 1000, supCost, infCost, resourceCount);
							}
						}
						else
						{
							supCost = GetGlobalNumberValue("RESOURCE_DIAMOND_COST_1000");
							infCost = GetGlobalNumberValue("RESOURCE_DIAMOND_COST_100");
							result = CalculateResourceCost(1000, 100, supCost, infCost, resourceCount);
						}
					}
					else
					{
						result = GetGlobalNumberValue("RESOURCE_DIAMOND_COST_100");
					}
				}
			}

			return result;
		}

		public static int GetDarkElixirDiamondCost(int resourceCount)
		{
			int result = 0;
			if (resourceCount >= 1)
			{
				if (resourceCount >= 10)
				{
					if (resourceCount >= 100)
					{
						if (resourceCount >= 1000)
						{
							if (resourceCount >= 10000)
							{
								int supCost = GetGlobalNumberValue("DARK_ELIXIR_DIAMOND_COST_100000");
								int infCost = GetGlobalNumberValue("DARK_ELIXIR_DIAMOND_COST_10000");
								result = CalculateResourceCost(100000, 10000, supCost, infCost, resourceCount);
							}
							else
							{
								int supCost = GetGlobalNumberValue("DARK_ELIXIR_DIAMOND_COST_10000");
								int infCost = GetGlobalNumberValue("DARK_ELIXIR_DIAMOND_COST_1000");
								result = CalculateResourceCost(10000, 1000, supCost, infCost, resourceCount);
							}
						}
						else
						{
							int supCost = GetGlobalNumberValue("DARK_ELIXIR_DIAMOND_COST_1000");
							int infCost = GetGlobalNumberValue("DARK_ELIXIR_DIAMOND_COST_100");
							result = CalculateResourceCost(1000, 100, supCost, infCost, resourceCount);
						}
					}
					else
					{
						int supCost = GetGlobalNumberValue("DARK_ELIXIR_DIAMOND_COST_100");
						int infCost = GetGlobalNumberValue("DARK_ELIXIR_DIAMOND_COST_10");
						result = CalculateResourceCost(100, 10, supCost, infCost, resourceCount);
					}
				}
				else
				{
					int supCost = GetGlobalNumberValue("DARK_ELIXIR_DIAMOND_COST_10");
					int infCost = GetGlobalNumberValue("DARK_ELIXIR_DIAMOND_COST_1");
					result = CalculateResourceCost(10, 1, supCost, infCost, resourceCount);
				}
			}

			return result;
		}


		public static int GetSpeedUpCost(int seconds)
		{
			DataTable globals = Csv.Tables.Get(LogicDataType.GLOBAL);
			int cost = 0;
			if (seconds >= 1)
			{
				if (seconds >= 60)
				{
					if (seconds >= 3600)
					{
						if (seconds >= 86400)
						{
							int supCost = globals.GetData<LogicGlobalData>("SPEED_UP_DIAMOND_COST_1_WEEK").NumberValue;
							int infCost = globals.GetData<LogicGlobalData>("SPEED_UP_DIAMOND_COST_24_HOURS").NumberValue;
							cost = CalculateSpeedUpCost(604800, 86400, supCost, infCost, seconds);
						}
						else
						{
							int supCost = globals.GetData<LogicGlobalData>("SPEED_UP_DIAMOND_COST_24_HOURS").NumberValue;
							int infCost = globals.GetData<LogicGlobalData>("SPEED_UP_DIAMOND_COST_1_HOUR").NumberValue;
							cost = CalculateSpeedUpCost(86400, 3600, supCost, infCost, seconds);
						}
					}
					else
					{
						int supCost = globals.GetData<LogicGlobalData>("SPEED_UP_DIAMOND_COST_1_HOUR")
							.NumberValue;
						int infCost = globals.GetData<LogicGlobalData>("SPEED_UP_DIAMOND_COST_1_MIN")
							.NumberValue;
						cost = CalculateSpeedUpCost(3600, 60, supCost, infCost, seconds);
					}
				}
				else
				{
					cost = globals.GetData<LogicGlobalData>("SPEED_UP_DIAMOND_COST_1_MIN")
						.NumberValue;
				}
			}

			return cost;
		}
	}
}