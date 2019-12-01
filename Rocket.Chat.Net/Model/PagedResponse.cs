using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public class PagedResponse<T>
    {
        [JsonProperty("total")]
        public long Total { get; set; }
        
        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("result")]
        public List<T> Result { get; set; }
    }
}