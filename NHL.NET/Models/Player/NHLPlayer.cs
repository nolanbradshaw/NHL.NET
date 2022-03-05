using Newtonsoft.Json;
using NHL.NET.Models.Position;
using NHL.NET.Models.Team;
using System;
using System.Collections.Generic;
using System.Text;

namespace NHL.NET.Models.Player
{
    public class NHLPlayer
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int PrimaryNumber { get; set; }

        public DateTime BirthDate { get; set; }

        public int CurrentAge { get; set; }

        public string BirthCity { get; set; }

        public string BirthStateProvince { get; set; }

        public string BirthCountry { get; set; }

        public string Nationality { get; set; }

        public string Height { get; set; }

        public int Weight { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool IsActive { get; set; }

        [JsonProperty(PropertyName = "alternateCaptain")]
        public bool IsAlternateCaptain { get; set; }

        [JsonProperty(PropertyName = "captain")]
        public bool IsCaptain { get; set; }

        [JsonProperty(PropertyName = "rookie")]
        public bool Rookie { get; set; }

        [JsonProperty(PropertyName = "shootsCatches")]
        public string Handedness { get; set; }

        public NHLSimpleTeam CurrentTeam { get; set; }

        public PlayerPosition PrimaryPosition { get; set; }
    }
}
