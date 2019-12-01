using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public class User
    {
        [JsonProperty("_id")] public string Id { get; set; }

        [JsonProperty("username")] public string UserName { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("utcOffset")] public float UTCOffset { get; set; }

        [JsonProperty("roles")] public List<string> Roles { get; set; }

        [JsonProperty("status")] public UserStatus UserStatus { get; set; }

        [JsonProperty("statusText")] public string StatusText { get; set; }

        [JsonProperty("emails")] public List<Email> Emails { get; set; }
    }

    public class Email
    {
        [JsonProperty("address")] public string Address { get; set; }

        [JsonProperty("verified")] public bool Verified { get; set; }
    }

    public enum UserStatus
    {
        [JsonProperty("online")] Online,
        [JsonProperty("busy")] Busy,
        [JsonProperty("away")] Away,
        [JsonProperty("offline")] Offline
    }
}