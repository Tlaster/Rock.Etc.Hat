using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Rocket.Chat.Net.Model
{
    public class ApiResponse
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }
}