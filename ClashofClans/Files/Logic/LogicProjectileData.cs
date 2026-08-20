using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicProjectileData : LogicData
	{
		public LogicProjectileData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string SWF { get; protected set; }
		public string ExportName { get; protected set; }
		public bool ScaleTimeline { get; protected set; }
		public int DirectionCount { get; protected set; }
		public string ParticleEmitter { get; protected set; }
		public string Effect { get; protected set; }
		public int Speed { get; protected set; }
		public int StartHeight { get; protected set; }
		public int StartOffset { get; protected set; }
		public bool IsBallistic { get; protected set; }
		public string ShadowSWF { get; protected set; }
		public string ShadowExportName { get; protected set; }
		public bool RandomHitPositionOnCharacters { get; protected set; }
		public bool SmallRandomHitPositionOnBuildings { get; protected set; }
		public bool UseRotate { get; protected set; }
		public bool DirectionFrame { get; protected set; }
		public bool PlayOnce { get; protected set; }
		public bool UseTopLayer { get; protected set; }
		public int Scale { get; protected set; }
		public string HitSpell { get; protected set; }
		public int HitSpellLevel { get; protected set; }
		public bool HitSpellInheritAffectType { get; protected set; }
		public bool DontTrackTarget { get; protected set; }
		public int BallisticHeight { get; protected set; }
		public int TrajectoryStyle { get; protected set; }
		public int FixedTravelTime { get; protected set; }
		public int DamageDelay { get; protected set; }
		public string DestroyedEffect { get; protected set; }
		public string BounceEffect { get; protected set; }
		public int TargetPosRandomRadius { get; protected set; }
		public int SlowdownDefencePercent { get; protected set; }
		public bool UseNormalizeLenghtFix { get; protected set; }
		public int MaxBounceDistance { get; protected set; }
		public int StopToTargetTime { get; protected set; }
		public bool CanBounceOverWall { get; protected set; }
		public bool SmoothDamage { get; protected set; }
		public bool StartOffsetFromGunBone { get; protected set; }
		public int PenetratingHitBoxWidth { get; protected set; }
		public int MaxHitBuildings { get; protected set; }
	}
}
