using System;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace MvvmCrossPoc.Core.Remote.DTO
{
	
	//    "region":{"id":"LCN","value":"Latin America & Caribbean (all income levels)"},
	
	//    "incomeLevel":{"id":"NOC","value":"High income: nonOECD"},
	//    "lendingType":{"id":"LNX","value":"Not classified"},
	//    "capitalCity":"Oranjestad",
	//    "longitude":"-70.0167","latitude":"12.5167"}
	public class ValueDTO : BaseDTO
	{
        [JsonProperty("value")]
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }
	}

}

