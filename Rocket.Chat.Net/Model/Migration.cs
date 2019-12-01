using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public partial class Migration
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }

        [JsonProperty("version")]
        public long Version { get; set; }
    }
}