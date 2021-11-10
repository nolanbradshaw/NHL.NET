using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace NHL.NET.Models.Division
{
    public class NHLSimpleDivision
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [JsonProperty(PropertyName = "nameShort")]
        public string ShortName { get; set; }

        public string Abbreviation { get; set; }
    }
}
