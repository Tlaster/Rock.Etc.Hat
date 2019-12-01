using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public class StatisticsResponse : ApiResponse
    {
        [JsonProperty("statistics")] public Statistics Statistics { get; set; }
    }
}