using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public enum RoomType
    {
        [JsonProperty("c")]
        Channel,
        [JsonProperty("p")]
        PrivateGroup,
        [JsonProperty("d")]
        DirectMessage,
        [JsonProperty("l")]
        LiveChat
    }
}