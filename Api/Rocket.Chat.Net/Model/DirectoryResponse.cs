using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public class DirectoryResponse
    {
        [JsonProperty("_id")] public string Id { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("username")] public string UserName { get; set; }

        [JsonProperty("createdAt")] public long CreatedAt { get; set; }

        [JsonProperty("ts")] public long TimeStamp { get; set; }
    }
}