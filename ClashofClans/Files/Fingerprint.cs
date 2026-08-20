using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ClashofClans.Files
{
	public class Fingerprint
	{
		public const string PATH_FINERPRINT = "GameAssets/fingerprint.json";

		public Fingerprint()
		{
			try
			{
				if (File.Exists(PATH_FINERPRINT))
				{
					Json = File.ReadAllText(PATH_FINERPRINT);
					Files = new List<Asset>();

					JObject json = JObject.Parse(Json);
					{
						Sha = json["sha"].ToObject<string>();
						Version = json["version"].ToObject<string>().Split('.').Select(int.Parse).ToArray();

						foreach (JToken file in json["files"]) Files.Add(file.ToObject<Asset>());

						Logger.Log($"Fingerprint [v{GetVersion}] loaded.",
							GetType());
					}
				}
				else
				{
					Console.WriteLine("The Fingerprint cannot be loaded, the file does not exist.");
					Program.Exit();
				}
			}
			catch (Exception)
			{
				Console.WriteLine("Failed to load the Fingerprint.");
				Program.Exit();
			}
		}

		[JsonIgnore] public string Json { get; set; }
		[JsonIgnore] public int[] Version { get; set; }

		public int GetMajorVersion() => Version?[0] ?? 14;
		public int GetBuildVersion() => Version?[1] ?? 211;
		public int GetContentVersion() => Version?[2] ?? 0;

		[JsonProperty("files")] public List<Asset> Files { get; set; }
		[JsonProperty("sha")] public string Sha { get; set; }

		[JsonProperty("version")]
		public string GetVersion => $"{GetMajorVersion()}.{GetBuildVersion()}.{GetContentVersion()}";

		public void Save()
		{
			string json = JsonConvert.SerializeObject(this, new JsonSerializerSettings
			{
				DefaultValueHandling = DefaultValueHandling.Include,
				Formatting = Formatting.None
			});

			Json = json.Replace("/", "\\/").TrimEnd();

			File.WriteAllText(PATH_FINERPRINT, Json);
		}
	}
}