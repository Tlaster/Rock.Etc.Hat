using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public partial class LastMessage
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("rid")]
        public string Rid { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("u")]
        public SimpleUser U { get; set; }

        [JsonProperty("unread")]
        public bool Unread { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("mentions")]
        public List<object> Mentions { get; set; }

        [JsonProperty("channels")]
        public List<object> Channels { get; set; }
    }
}