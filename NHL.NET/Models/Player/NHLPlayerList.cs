using Newtonsoft.Json;
using System.Collections.Generic;

namespace NHL.NET.Models.Player
{
    public class NHLPlayerList
    {
        [JsonProperty(PropertyName = "people")]
        public List<NHLPlayer> Players { get; set; }
    }
}
