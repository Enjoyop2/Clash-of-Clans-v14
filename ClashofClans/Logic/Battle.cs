using ClashofClans.Files;
using ClashofClans.Files.Logic;
using ClashofClans.Protocol.Messages.Server;
using ClashofClans.Utilities.LogicMath;

namespace ClashofClans.Logic
{
	public class Battle
	{
		private int Data;
		private int League;


		private bool _battleStatus;
		private int _battlePercentage;
		private int _battleStars;
		private Player _enemyData;

		private LogicLeagueData GetLeagueData() => Csv.Tables.Get(LogicDataType.LEAGUE).GetDataWithId<LogicLeagueData>(Data);
		private LogicGlobalData GlobalsData => Csv.Tables.Get(LogicDataType.GLOBAL).GetDataWithId<LogicGlobalData>(Data);

		public async void StartBattle(Device device)
		{
			if (!IsBattleStatus())
			{
				SetBattleStatus(true);
			}
			else
			{
				Logger.Log("Battle already started", null, LogErrorType.ERROR);
				await new OutOfSyncMessage(device).SendAsync();
			}
		}

		public async void EndBattle(Player player, Device device)
		{
			if (IsBattleStatus())
			{
				SetBattleStatus(false);

				if (GetBattleStars() > 3)
				{
					await new OutOfSyncMessage(device).SendAsync();
					return;
				}

				Player enemy = GetEnemyData();

				int attackerScore = player.Home.Trophies;
				int defenderScore = enemy.Home.Trophies;

				int multiplier = GetBattleStars();

				if (GetBattleStars() <= 0)
				{
					multiplier = GetScoreMultiplierOnAttackLose();
				}

				int newAttackerScore;
				int newDefenderScore;

				if (EloOffsetDampeningEnabled())
				{
					newAttackerScore = LogicELOMath.CalculateNewRating(GetBattleStars() > 0, attackerScore, defenderScore, 20 * multiplier, GetEloDampeningFactor(), GetEloDampeningLimit(), GetEloDampeningScoreLimit());
					newDefenderScore = LogicELOMath.CalculateNewRating(GetBattleStars() <= 0, defenderScore, attackerScore, 20 * multiplier, GetEloDampeningFactor(), GetEloDampeningLimit(), GetEloDampeningScoreLimit());
				}
				else
				{
					newAttackerScore = LogicELOMath.CalculateNewRating(GetBattleStars() > 0, attackerScore, defenderScore, 20 * multiplier);
					newDefenderScore = LogicELOMath.CalculateNewRating(GetBattleStars() <= 0, defenderScore, attackerScore, 20 * multiplier);
				}

				int attackerGainCount = newAttackerScore - attackerScore;
				int defenderGainCount = newDefenderScore - defenderScore;

				if (attackerScore < 1000 && attackerGainCount < 0)
				{
					attackerGainCount = attackerScore * attackerGainCount / 1000;
				}

				if (defenderScore < 1000 && defenderGainCount < 0)
				{
					defenderGainCount = defenderScore * defenderGainCount / 1000;
				}

				if (LogicELOMath.CalculateNewRating(true, attackerScore, defenderScore, 60) > attackerScore)
				{
					if (GetBattleStars() <= 0)
					{
						if (attackerGainCount >= 0)
						{
							attackerGainCount = -1;
						}
					}
					else
					{
						if (attackerGainCount <= 0)
						{
							attackerGainCount = 1;
						}

						if (defenderGainCount >= 0)
						{
							defenderGainCount = -1;
						}
					}
				}

				newAttackerScore = LogicMath.Max(attackerScore + attackerGainCount, 0);
				newDefenderScore = LogicMath.Max(defenderScore + defenderGainCount, 0);

				player.Home.Trophies = newAttackerScore;
				enemy.Home.Trophies = newDefenderScore;

				if (GetBattleStars() > 0)
				{
					SetBattleWin(player);
					SetBattleLose(enemy, false);
					player.Home.AttacksWon++;
				}
				else
				{
					SetBattleLose(player);
					SetBattleWin(enemy);
					enemy.Home.DefensesWon++;
				}

				await Database.PlayerDb.SaveAsync(enemy);

				enemy.Save();

				Logger.Log($"The battle is over. Attacker id: {player.Home.Id}, attacker name: {player.Home.Name}, defender id: {enemy.Home.Id}, defender name: {enemy.Home.Name}, percentage: {GetBattlePercenatage() + "%"}, stars: {GetBattleStars()}, trophies won: {newAttackerScore - attackerScore}", null, LogErrorType.DEBUG);

				Destruct();
			}
			else
			{
				Logger.Log("Battle already ended", null, LogErrorType.ERROR);
				await new OutOfSyncMessage(device).SendAsync();
			}
		}

		public void Destruct()
		{
			Data = 0;
			League = 0;

			SetBattleStars(0);
			SetEnemyData(null);
			SetBattleStatus(false);
			SetBattlePercenatage(0);
		}

		private void SetBattleWin(Player player)
		{
			Data = 0;
			League = 0;
			while (player.Home.Trophies > GetLeagueData().PlacementLimitLow && player.Home.Trophies > GetLeagueData().PlacementLimitHigh)
			{
				if (!string.IsNullOrEmpty(GetLeagueData().Name))
					League++;
				Data++;
			}

			player.Home.League = League;
		}

		private void SetBattleLose(Player player, bool isAttacker = true)
		{
			Data = 0;
			League = 0;
			if (isAttacker || player.Home.League != 0)
			{
				while (player.Home.Trophies > GetLeagueData().PlacementLimitLow && player.Home.Trophies > GetLeagueData().PlacementLimitHigh)
				{
					if (!string.IsNullOrEmpty(GetLeagueData().Name))
						League++;
					Data++;
				}

				player.Home.League = League;
			}
		}

		public void SetBattleStatus(bool status)
		{
			_battleStatus = status;
		}

		public bool IsBattleStatus() => _battleStatus;
		public int GetBattlePercenatage() => _battlePercentage;
		public int GetBattleStars() => _battleStars;
		public Player GetEnemyData() => _enemyData;
		public void SetBattlePercenatage(int percentage) => _battlePercentage = percentage;
		public void SetBattleStars(int stars) => _battleStars = stars;
		public void SetEnemyData(Player enemy) => _enemyData = enemy;

		private bool EloOffsetDampeningEnabled()
		{
			Data = 0;
			string EloOffsetDampeningEnabled = string.Empty;
			while (EloOffsetDampeningEnabled != "ELO_OFFSET_DAMPENING_ENABLED")
			{
				if (!string.IsNullOrEmpty(GlobalsData.Name))
					EloOffsetDampeningEnabled = GlobalsData.Name;
				Data++;
			}
			Data--;

			return GlobalsData.BooleanValue;
		}

		private int GetEloDampeningFactor()
		{
			Data = 0;
			string EloDampeningFactor = string.Empty;
			while (EloDampeningFactor != "ELO_OFFSET_DAMPENING_FACTOR")
			{
				if (!string.IsNullOrEmpty(GlobalsData.Name))
					EloDampeningFactor = GlobalsData.Name;
				Data++;
			}
			Data--;

			return GlobalsData.NumberValue;
		}

		private int GetEloDampeningLimit()
		{
			Data = 0;
			string EloDampeningLimit = string.Empty;
			while (EloDampeningLimit != "ELO_OFFSET_DAMPENING_LIMIT")
			{
				if (!string.IsNullOrEmpty(GlobalsData.Name))
					EloDampeningLimit = GlobalsData.Name;
				Data++;
			}
			Data--;

			return GlobalsData.NumberValue;
		}

		private int GetEloDampeningScoreLimit()
		{
			Data = 0;
			string EloDampeningScoreLimit = string.Empty;
			while (EloDampeningScoreLimit != "ELO_OFFSET_DAMPENING_SCORE_LIMIT")
			{
				if (!string.IsNullOrEmpty(GlobalsData.Name))
					EloDampeningScoreLimit = GlobalsData.Name;
				Data++;
			}
			Data--;

			return GlobalsData.NumberValue;
		}

		private int GetScoreMultiplierOnAttackLose()
		{
			Data = 0;
			string ScoreMultiplierOnAttackLose = string.Empty;
			while (ScoreMultiplierOnAttackLose != "SCORE_MULTIPLIER_ON_ATTACK_LOSE")
			{
				if (!string.IsNullOrEmpty(GlobalsData.Name))
					ScoreMultiplierOnAttackLose = GlobalsData.Name;
				Data++;
			}
			Data--;

			return GlobalsData.NumberValue;
		}
	}
}