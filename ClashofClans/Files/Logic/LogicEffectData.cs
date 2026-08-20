using ClashofClans.Files.CsvHelpers;
using ClashofClans.Files.CsvReader;

namespace ClashofClans.Files.Logic
{
	public class LogicEffectData : LogicData
	{
		public LogicEffectData(Row row, DataTable datatable) : base(row, datatable)
		{
			LoadData(this, GetType(), row);
		}

		public string Name { get; protected set; }
		public string SWF { get; protected set; }
		public string ExportName { get; protected set; }
		public string[] ParticleEmitter { get; protected set; }
		public string AltParticleEmitter { get; protected set; }
		public int[] EmitterDelayMs { get; protected set; }
		public string IsoLayer { get; protected set; }
		public int CameraShake { get; protected set; }
		public int CameraShakeTimeMS { get; protected set; }
		public bool CameraShakeInReplay { get; protected set; }
		public bool AttachToParent { get; protected set; }
		public bool OrientToParent { get; protected set; }
		public bool SortInFrontOfParent { get; protected set; }
		public bool DestroyWhenParentDies { get; protected set; }
		public bool DetachAfterStart { get; protected set; }
		public bool Targeted { get; protected set; }
		public bool Looping { get; protected set; }
		public bool Beam { get; protected set; }
		public int MaxCount { get; protected set; }
		public int MinLifeTime { get; protected set; }
		public string[] Sound { get; protected set; }
		public int[] Volume { get; protected set; }
		public int[] MinPitch { get; protected set; }
		public int[] MaxPitch { get; protected set; }
		public string LowEndSound { get; protected set; }
		public int LowEndVolume { get; protected set; }
		public int LowEndMinPitch { get; protected set; }
		public int LowEndMaxPitch { get; protected set; }
		public int SoundDelay { get; protected set; }
		public bool StopSound { get; protected set; }
		public int PitchIncrease { get; protected set; }
		public bool OffsetFromGunBone { get; protected set; }
		public string AttachLocator { get; protected set; }
		public int OffsetX { get; protected set; }
		public int OffsetY { get; protected set; }
		public int OffsetZ { get; protected set; }
		public int Scale { get; protected set; }
		public int LifeTimeScale { get; protected set; }
	}
}
