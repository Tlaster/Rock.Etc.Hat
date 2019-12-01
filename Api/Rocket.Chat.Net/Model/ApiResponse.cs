using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public class ApiResponse
    {
        [JsonProperty("success")] public bool Success { get; set; }
    }
}