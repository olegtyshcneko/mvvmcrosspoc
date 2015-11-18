using System;
using System.Collections.Generic;
using MvvmCrossPoc.Core.Remote.DTO;
using System.Threading.Tasks;

namespace MvvmCrossPoc.Core.Remote
{
    public interface ICountryDataService
    {
        Task<List<CountryDataDTO>> GetAllCountriesDataAsync();
        Task<CountriesPagingDTO> GetAllCountriesDataPagedAsync(int page, int itemsPerPage);
    }
}

