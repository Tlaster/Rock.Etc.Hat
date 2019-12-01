using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public partial class Cpus
    {
        [JsonProperty("model")]
        public string Model { get; set; }

        [JsonProperty("speed")]
        public long Speed { get; set; }

        [JsonProperty("times")]
        public Times Times { get; set; }
    }
}