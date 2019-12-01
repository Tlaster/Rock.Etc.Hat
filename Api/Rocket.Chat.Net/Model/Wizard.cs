using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public class Wizard
    {
        [JsonProperty("organizationType")] public string OrganizationType { get; set; }

        [JsonProperty("industry")] public string Industry { get; set; }

        [JsonProperty("size")] public string Size { get; set; }

        [JsonProperty("country")] public string Country { get; set; }

        [JsonProperty("language")] public string Language { get; set; }

        [JsonProperty("serverType")] public string ServerType { get; set; }

        [JsonProperty("registerServer")] public bool RegisterServer { get; set; }
    }
}