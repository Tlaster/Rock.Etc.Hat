using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public class SimpleUser
    {
        [JsonProperty("_id")] public string Id { get; set; }

        [JsonProperty("username")] public string UserName { get; set; }

        [JsonProperty("name")] public string Name { get; set; }
    }
}