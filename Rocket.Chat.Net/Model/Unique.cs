using System.Collections.Generic;
using Newtonsoft.Json;

namespace Rocket.Chat.Net.Model
{
    public partial class Unique
    {
        [JsonProperty("year")]
        public long Year { get; set; }

        [JsonProperty("month")]
        public long Month { get; set; }

        [JsonProperty("day")]
        public long Day { get; set; }

        [JsonProperty("data")]
        public List<Datum> Data { get; set; }
    }
}