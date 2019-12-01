using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace Rocket.Chat.Net.Model
{
    public partial class Room
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("t")]
        public string RoomType { get; set; }

        [JsonProperty("msgs")]
        public long Msgs { get; set; }

        [JsonProperty("usersCount")]
        public long UsersCount { get; set; }

        [JsonProperty("u")]
        public SimpleUser User { get; set; }

        [JsonProperty("customFields")]
        public JObject CustomFields { get; set; }

        [JsonProperty("broadcast")]
        public bool Broadcast { get; set; }

        [JsonProperty("encrypted")]
        public bool Encrypted { get; set; }

        [JsonProperty("ts")]
        public DateTimeOffset Ts { get; set; }

        [JsonProperty("ro")]
        public bool Readonly { get; set; }

        [JsonProperty("sysMes")]
        public bool SysMes { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("lm")]
        public DateTimeOffset Lm { get; set; }

        [JsonProperty("lastMessage")]
        public LastMessage LastMessage { get; set; }

        [JsonProperty("e2eKeyId")]
        public string E2EKeyId { get; set; }

        [JsonProperty("jitsiTimeout")]
        public DateTimeOffset JitsiTimeout { get; set; }
        
        [JsonProperty("fname")]
        public string FullName { get; set; }

        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("announcement")]
        public string Announcement { get; set; }
    }
}