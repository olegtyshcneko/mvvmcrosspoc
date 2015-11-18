using System;
using System.Collections;
using System.Dynamic;
using System.Collections.Generic;

namespace MvvmCrossPoc.Core.Remote.DTO
{
    public class CountriesPagingDTO
    {
        public PagingDTO PagingData { get; set; }
        public IEnumerable<CountryDataDTO> CountriesData { get; set; }
    }
}

