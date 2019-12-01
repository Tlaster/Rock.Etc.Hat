using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public class Os
    {
        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("platform")] public string Platform { get; set; }

        [JsonProperty("arch")] public string Arch { get; set; }

        [JsonProperty("release")] public string Release { get; set; }

        [JsonProperty("uptime")] public long Uptime { get; set; }

        [JsonProperty("loadavg")] public List<double> Loadavg { get; set; }

        [JsonProperty("totalmem")] public long Totalmem { get; set; }

        [JsonProperty("freemem")] public long Freemem { get; set; }

        [JsonProperty("cpus")] public List<Cpus> Cpus { get; set; }
    }
}