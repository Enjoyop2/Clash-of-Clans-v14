using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicMissionData : LogicData
	{
		public LogicMissionData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}
		public string Name { get; protected set; }
		public string Dependencies { get; protected set; }
		public int MissionCategory { get; protected set; }
		public int VillageType { get; protected set; }
		public bool FirstStep { get; protected set; }
		public bool Deprecated { get; protected set; }
		public string Action { get; protected set; }
		public string Character { get; protected set; }
		public string FixVillageObject { get; protected set; }
		public string BuildBuilding { get; protected set; }
		public int BuildBuildingLevel { get; protected set; }
		public int BuildBuildingCount { get; protected set; }
		public string DefendNPC { get; protected set; }
		public string AttackNPC { get; protected set; }
		public int[] Delay { get; protected set; }
		public int TrainTroops { get; protected set; }
		public bool ShowMap { get; protected set; }
		public string[] ClientCondition { get; protected set; }
		public string ClientStartAction { get; protected set; }
		public string[] TutorialText { get; protected set; }
		public int[] TutorialStep { get; protected set; }
		public bool[] Darken { get; protected set; }
		public string[] TutorialTextBox { get; protected set; }
		public string[] TutorialCharacter { get; protected set; }
		public string[] CharacterSWF { get; protected set; }
		public bool LoopAnim { get; protected set; }
		public bool[] SwitchAnim { get; protected set; }
		public string[] SpeechBubble { get; protected set; }
		public bool[] RightAlignTextBox { get; protected set; }
		public string[] ButtonText { get; protected set; }
		public string[] TutorialMusic { get; protected set; }
		public string[] TutorialSound { get; protected set; }
		public string[] HighlightArrowPath { get; protected set; }
		public string[] HighlightArrowDirection { get; protected set; }
		public string[] ClientAction { get; protected set; }
		public string RewardResource { get; protected set; }
		public int RewardResourceCount { get; protected set; }
		public int RewardXP { get; protected set; }
		public string RewardTroop { get; protected set; }
		public int RewardTroopCount { get; protected set; }
		public int CustomData { get; protected set; }
		public int Villagers { get; protected set; }
		public bool ForceCamera { get; protected set; }
		public bool WaitUntilPopupIsClosed { get; protected set; }
		public int LinkedReengagementStep { get; protected set; }
		public bool[] RewindOnConditionFail { get; protected set; }
		public bool[] ProgressWithCondition { get; protected set; }
	}
}