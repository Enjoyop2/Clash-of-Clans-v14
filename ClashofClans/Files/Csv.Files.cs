using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;
using ClashofClans.Files.Logic;

namespace ClashofClans.Files
{
	public partial class Csv
	{
		public static Dictionary<LogicDataType, Type> DataTypes = new Dictionary<LogicDataType, Type>();
		static Csv()
		{
			DataTypes.Add(LogicDataType.BUILDING, typeof(LogicBuildingData));
			DataTypes.Add(LogicDataType.LOCALE, typeof(LogicLocaleData));
			DataTypes.Add(LogicDataType.RESOURCE, typeof(LogicResourceData));
			DataTypes.Add(LogicDataType.CHARACTER, typeof(LogicCharacterData));
			DataTypes.Add(LogicDataType.ANIMATION, typeof(LogicData));
			DataTypes.Add(LogicDataType.PROJECTILE, typeof(LogicProjectileData));
			DataTypes.Add(LogicDataType.BUILDING_CLASS, typeof(LogicBuildingClassData));
			DataTypes.Add(LogicDataType.OBSTACLE, typeof(LogicObstacleData));
			DataTypes.Add(LogicDataType.EFFECT, typeof(LogicEffectData));
			DataTypes.Add(LogicDataType.PARTICLE_EMITTER, typeof(LogicParticleEmitterData));
			DataTypes.Add(LogicDataType.EXPERIENCE_LEVEL, typeof(LogicExperienceLevelData));
			DataTypes.Add(LogicDataType.TRAP, typeof(LogicTrapData));
			DataTypes.Add(LogicDataType.ALLIANCE_BADGE, typeof(LogicAllianceBadgeData));
			DataTypes.Add(LogicDataType.GLOBAL, typeof(LogicGlobalData));
			DataTypes.Add(LogicDataType.TOWNHALL_LEVEL, typeof(LogicTownhallLevelData));
			DataTypes.Add(LogicDataType.ALLIANCE_PORTAL, typeof(LogicAlliancePortalData));
			DataTypes.Add(LogicDataType.NPC, typeof(LogicNpcData));
			DataTypes.Add(LogicDataType.DECO, typeof(LogicDecoData));
			DataTypes.Add(LogicDataType.RESOURCE_PACK, typeof(LogicResourcePackData));
			DataTypes.Add(LogicDataType.SHIELD, typeof(LogicShieldData));
			DataTypes.Add(LogicDataType.MISSION, typeof(LogicMissionData));
			DataTypes.Add(LogicDataType.BILLING_PACKAGE, typeof(LogicBillingPackageData));
			DataTypes.Add(LogicDataType.ACHIEVEMENT, typeof(LogicAchievementData));
			DataTypes.Add(LogicDataType.CREDIT, typeof(LogicData));
			DataTypes.Add(LogicDataType.STARTER_PASS_TASK, typeof(LogicStarterPassTaskData));
			DataTypes.Add(LogicDataType.SPELL, typeof(LogicSpellData));
			DataTypes.Add(LogicDataType.HINT, typeof(LogicData));
			DataTypes.Add(LogicDataType.HERO, typeof(LogicHeroData));
			DataTypes.Add(LogicDataType.LEAGUE, typeof(LogicLeagueData));
			DataTypes.Add(LogicDataType.STARTER_PASS, typeof(LogicStarterPassData));
			DataTypes.Add(LogicDataType.WAR, typeof(LogicWarData));
			DataTypes.Add(LogicDataType.REGION, typeof(LogicRegionData));
			DataTypes.Add(LogicDataType.CLIENT_GLOBAL, typeof(LogicGlobalData));
			DataTypes.Add(LogicDataType.ALLIANCE_BADGE_LAYER, typeof(LogicAllianceBadgeLayerData));
			DataTypes.Add(LogicDataType.ALLIANCE_LEVEL, typeof(LogicAllianceLevelData));
			DataTypes.Add(LogicDataType.HELPSHIFT, typeof(LogicHelpshiftData));
			DataTypes.Add(LogicDataType.VARIABLE, typeof(LogicVariableData));
			DataTypes.Add(LogicDataType.GEM_BUNDLE, typeof(LogicGemBundleData));
			DataTypes.Add(LogicDataType.VILLAGE_OBJECT, typeof(LogicVillageObjectData));
			DataTypes.Add(LogicDataType.CALENDAR_EVENT_FUNCTION, typeof(LogicCalendarEventFunctionData));
		}

		public static LogicData Create(LogicDataType file, Row row, DataTable dataTable)
		{
			if (DataTypes.ContainsKey(file))
			{
				return Activator.CreateInstance(DataTypes[file], row, dataTable) as LogicData;
			}

			return null;
		}
	}
}