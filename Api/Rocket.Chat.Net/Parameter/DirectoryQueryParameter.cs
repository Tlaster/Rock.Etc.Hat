using System;
using Newtonsoft.Json;

namespace Rocket.Chat.Net.Parameter
{
    public class DirectoryQueryParameter : IFormattable
    {
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }

        [JsonProperty("type")] public DirectoryRequestType DirectoryRequestType { get; set; }

        [JsonProperty("workspace")]
        public DirectoryWorkspaceType DirectoryWorkspaceType { get; set; } = DirectoryWorkspaceType.Local;

        public string ToString(string format, IFormatProvider formatProvider)
        {
            return JsonConvert.SerializeObject(this);
        }
    }

    public enum DirectoryRequestType
    {
        [JsonProperty("users")] Users,
        [JsonProperty("channels")] Channels
    }

    public enum DirectoryWorkspaceType
    {
        [JsonProperty("local")] Local,
        [JsonProperty("all")] All
    }
}