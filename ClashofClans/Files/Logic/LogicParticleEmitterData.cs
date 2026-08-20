using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicParticleEmitterData : LogicData
	{
		public LogicParticleEmitterData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public int ParticleCount { get; protected set; }
		public int EmissionTime { get; protected set; }
		public int MinLife { get; protected set; }
		public int MaxLife { get; protected set; }
		public int MinHorizAngle { get; protected set; }
		public int MaxHorizAngle { get; protected set; }
		public int MinVertAngle { get; protected set; }
		public int MaxVertAngle { get; protected set; }
		public int MinSpeed { get; protected set; }
		public int MaxSpeed { get; protected set; }
		public int StartX { get; protected set; }
		public int StartY { get; protected set; }
		public int StartZ { get; protected set; }
		public int TargetedEndZ { get; protected set; }
		public int Gravity { get; protected set; }
		public bool OrientToMovement { get; protected set; }
		public bool OrientToParent { get; protected set; }
		public bool BounceFromGround { get; protected set; }
		public bool IsIsoParticle { get; protected set; }
		public string ParticleSwf { get; protected set; }
		public string[] ParticleExportName { get; protected set; }
		public bool[] AdditiveBlend { get; protected set; }
		public int Inertia { get; protected set; }
		public int Slowdown { get; protected set; }
		public int StartRadius { get; protected set; }
		public int StartScale { get; protected set; }
		public int EndScale { get; protected set; }
		public int MinRotate { get; protected set; }
		public int MaxRotate { get; protected set; }
		public int ParticleFadeOutTime { get; protected set; }
		public bool ScaleTimeline { get; protected set; }
		public int FadeInTime { get; protected set; }
		public int FadeOutTime { get; protected set; }
		public int StartAngleMin { get; protected set; }
		public int StartAngleMax { get; protected set; }
		public int ScaleRandomMin { get; protected set; }
		public int ScaleRandomMax { get; protected set; }
		public int Alpha { get; protected set; }
	}
}
