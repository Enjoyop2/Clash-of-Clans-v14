using Newtonsoft.Json;

namespace ClashofClans.Files
{
	public class Asset
	{
		[JsonProperty("file")] public string File { get; set; }
		[JsonProperty("sha")] public string Sha { get; set; }
	}
}