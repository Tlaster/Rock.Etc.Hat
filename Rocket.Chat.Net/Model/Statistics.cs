using System;
using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public partial class Statistics
    {
        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("wizard")]
        public Wizard Wizard { get; set; }

        [JsonProperty("uniqueId")]
        public string UniqueId { get; set; }

        [JsonProperty("installedAt")]
        public DateTimeOffset InstalledAt { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("totalUsers")]
        public long TotalUsers { get; set; }

        [JsonProperty("activeUsers")]
        public long ActiveUsers { get; set; }

        [JsonProperty("nonActiveUsers")]
        public long NonActiveUsers { get; set; }

        [JsonProperty("onlineUsers")]
        public long OnlineUsers { get; set; }

        [JsonProperty("awayUsers")]
        public long AwayUsers { get; set; }

        [JsonProperty("totalConnectedUsers")]
        public long TotalConnectedUsers { get; set; }

        [JsonProperty("offlineUsers")]
        public long OfflineUsers { get; set; }

        [JsonProperty("totalRooms")]
        public long TotalRooms { get; set; }

        [JsonProperty("totalChannels")]
        public long TotalChannels { get; set; }

        [JsonProperty("totalPrivateGroups")]
        public long TotalPrivateGroups { get; set; }

        [JsonProperty("totalDirect")]
        public long TotalDirect { get; set; }

        [JsonProperty("totalLivechat")]
        public long TotalLivechat { get; set; }

        [JsonProperty("totalDiscussions")]
        public long TotalDiscussions { get; set; }

        [JsonProperty("totalThreads")]
        public long TotalThreads { get; set; }

        [JsonProperty("totalLivechatVisitors")]
        public long TotalLivechatVisitors { get; set; }

        [JsonProperty("totalLivechatAgents")]
        public long TotalLivechatAgents { get; set; }

        [JsonProperty("livechatEnabled")]
        public bool LivechatEnabled { get; set; }

        [JsonProperty("totalMessages")]
        public long TotalMessages { get; set; }

        [JsonProperty("totalChannelMessages")]
        public long TotalChannelMessages { get; set; }

        [JsonProperty("totalPrivateGroupMessages")]
        public long TotalPrivateGroupMessages { get; set; }

        [JsonProperty("totalDirectMessages")]
        public long TotalDirectMessages { get; set; }

        [JsonProperty("totalLivechatMessages")]
        public long TotalLivechatMessages { get; set; }

        [JsonProperty("federatedServers")]
        public long FederatedServers { get; set; }

        [JsonProperty("federatedUsers")]
        public long FederatedUsers { get; set; }

        [JsonProperty("lastLogin")]
        public DateTimeOffset LastLogin { get; set; }

        [JsonProperty("lastMessageSentAt")]
        public DateTimeOffset LastMessageSentAt { get; set; }

        [JsonProperty("lastSeenSubscription")]
        public DateTimeOffset LastSeenSubscription { get; set; }

        [JsonProperty("os")]
        public Os Os { get; set; }

        [JsonProperty("process")]
        public Process Process { get; set; }

        [JsonProperty("deploy")]
        public Deploy Deploy { get; set; }

        [JsonProperty("uploadsTotal")]
        public long UploadsTotal { get; set; }

        [JsonProperty("uploadsTotalSize")]
        public long UploadsTotalSize { get; set; }

        [JsonProperty("migration")]
        public Migration Migration { get; set; }

        [JsonProperty("instanceCount")]
        public long InstanceCount { get; set; }

        [JsonProperty("oplogEnabled")]
        public bool OplogEnabled { get; set; }

        [JsonProperty("mongoVersion")]
        public string MongoVersion { get; set; }

        [JsonProperty("mongoStorageEngine")]
        public string MongoStorageEngine { get; set; }

        [JsonProperty("uniqueUsersOfYesterday")]
        public Unique UniqueUsersOfYesterday { get; set; }

        [JsonProperty("uniqueUsersOfLastMonth")]
        public Unique UniqueUsersOfLastMonth { get; set; }

        [JsonProperty("uniqueDevicesOfYesterday")]
        public Unique UniqueDevicesOfYesterday { get; set; }

        [JsonProperty("uniqueDevicesOfLastMonth")]
        public Unique UniqueDevicesOfLastMonth { get; set; }

        [JsonProperty("uniqueOSOfYesterday")]
        public Unique UniqueOsOfYesterday { get; set; }

        [JsonProperty("uniqueOSOfLastMonth")]
        public Unique UniqueOsOfLastMonth { get; set; }

        [JsonProperty("apps")]
        public Apps Apps { get; set; }

        [JsonProperty("integrations")]
        public Integrations Integrations { get; set; }

        [JsonProperty("createdAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("_updatedAt")]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}