using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public partial class Apps
    {
        [JsonProperty("engineVersion")]
        public string EngineVersion { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        [JsonProperty("totalInstalled")]
        public long TotalInstalled { get; set; }

        [JsonProperty("totalActive")]
        public long TotalActive { get; set; }
    }
}