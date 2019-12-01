using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public partial class StatisticsResponse: ApiResponse
    {
        [JsonProperty("statistics")]
        public Statistics Statistics { get; set; }
    }
}