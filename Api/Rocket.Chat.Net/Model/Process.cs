using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public class Process
    {
        [JsonProperty("nodeVersion")] public string NodeVersion { get; set; }

        [JsonProperty("pid")] public long Pid { get; set; }

        [JsonProperty("uptime")] public double Uptime { get; set; }
    }
}