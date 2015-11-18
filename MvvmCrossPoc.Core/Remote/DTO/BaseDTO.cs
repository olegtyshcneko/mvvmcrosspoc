using System;
using Newtonsoft.Json;


namespace MvvmCrossPoc.Core.Remote.DTO
{
    public class BaseDTO 
    {
        [JsonProperty("id")]
        public string Id { get; set; }
    }
    
}
