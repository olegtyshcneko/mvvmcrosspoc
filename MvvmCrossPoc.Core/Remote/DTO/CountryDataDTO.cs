using System;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace MvvmCrossPoc.Core.Remote.DTO
{
//    {"id":"ABW","iso2Code":"AW","name":"Aruba",
//    "region":{"id":"LCN","value":"Latin America & Caribbean (all income levels)"},
//    "adminregion":{"id":"","value":""},
//    "incomeLevel":{"id":"NOC","value":"High income: nonOECD"},
//    "lendingType":{"id":"LNX","value":"Not classified"},
//    "capitalCity":"Oranjestad",
//    "longitude":"-70.0167","latitude":"12.5167"}
    public class CountryDataDTO : BaseDTO
    {
        [JsonProperty("iso2Code")]
        public string Iso2Code { get; set; }        

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public ValueDTO Region { get; set; }

        [JsonProperty("adminregion")]
        public ValueDTO AdminRegion { get; set; }

        [JsonProperty("incomeLevel")]
        public ValueDTO IncomeLevel { get; set; }

        [JsonProperty("lendingType")]
        public ValueDTO LendingType { get; set; }

        [JsonProperty("capitalCity")]
        public string CapitalCity { get; set; }

        [JsonProperty("longitude")]
        public float? Longitude { get; set; }

        [JsonProperty("latitude")]
        public float? Latitude { get; set; }
    }
}

