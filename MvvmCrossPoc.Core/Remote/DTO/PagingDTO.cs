using System;
using Newtonsoft.Json;
using System.Collections;

namespace MvvmCrossPoc.Core.Remote.DTO
{
    public class PagingDTO 
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("pages")]
        public int Pages { get; set; }

        [JsonProperty("per_page")]
        public int ItemsPerPage { get; set; }
    }
}