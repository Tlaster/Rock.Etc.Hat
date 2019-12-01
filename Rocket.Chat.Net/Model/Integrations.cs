using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public partial class Integrations
    {
        [JsonProperty("totalIntegrations")]
        public long TotalIntegrations { get; set; }

        [JsonProperty("totalIncoming")]
        public long TotalIncoming { get; set; }

        [JsonProperty("totalIncomingActive")]
        public long TotalIncomingActive { get; set; }

        [JsonProperty("totalOutgoing")]
        public long TotalOutgoing { get; set; }

        [JsonProperty("totalOutgoingActive")]
        public long TotalOutgoingActive { get; set; }

        [JsonProperty("totalWithScriptEnabled")]
        public long TotalWithScriptEnabled { get; set; }
    }
}