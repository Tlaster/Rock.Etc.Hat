using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public partial class Deploy
    {
        [JsonProperty("method")]
        public string Method { get; set; }

        [JsonProperty("platform")]
        public string Platform { get; set; }
    }
}