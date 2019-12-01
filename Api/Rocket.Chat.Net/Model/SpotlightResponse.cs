using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public class SpotlightResponse
    {
        public class Welcome : ApiResponse
        {
            [JsonProperty("users")] public List<User> Users { get; set; }

            [JsonProperty("rooms")] public List<Room> Rooms { get; set; }
        }
    }
}