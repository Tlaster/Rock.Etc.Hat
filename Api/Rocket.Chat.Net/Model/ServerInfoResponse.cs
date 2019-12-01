using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public class ServerInfoResponse : ApiResponse
    {
        [JsonProperty("version")] public string Version { get; set; }
    }
}