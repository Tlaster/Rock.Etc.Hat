using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public class Datum
    {
        [JsonProperty("count")] public long Count { get; set; }

        [JsonProperty("time")] public long Time { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("version")] public string Version { get; set; }
    }
}