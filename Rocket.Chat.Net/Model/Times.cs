using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public partial class Times
    {
        [JsonProperty("user")]
        public long User { get; set; }

        [JsonProperty("nice")]
        public long Nice { get; set; }

        [JsonProperty("sys")]
        public long Sys { get; set; }

        [JsonProperty("idle")]
        public long Idle { get; set; }

        [JsonProperty("irq")]
        public long Irq { get; set; }
    }
}