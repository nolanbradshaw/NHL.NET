using Newtonsoft.Json;
using NHL.NET.Models.Conference;

namespace NHL.NET.Models.Division
{
    public class NHLDivision
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [JsonProperty(PropertyName = "nanmeShort")]
        public string ShortName { get; set; }

        public string Abbreviation { get; set; }

        public NHLSimpleConference Conference { get; set; }

        public bool Active { get; set; }
    }
}
