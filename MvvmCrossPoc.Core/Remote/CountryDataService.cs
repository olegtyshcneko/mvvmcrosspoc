using System;
using RestSharp.Portable;
using System.Collections.Generic;
using MvvmCrossPoc.Core.Remote.DTO;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace MvvmCrossPoc.Core.Remote
{
    public class CountryDataService : ICountryDataService
    {
        private const string cityDataBaseUrl = "http://api.worldbank.org/countries";
        private const int maxCityCount = 264;

        private RestClient restClient;

        public CountryDataService()
        {
            restClient = new RestClient(cityDataBaseUrl);
        }

        public async Task<List<CountryDataDTO>> GetAllCountriesDataAsync()
        {
            var req = RequestsFactory.CreateCountriesRequest(1, maxCityCount, RequestFormat.json);
            var countriesResp = await DoCountriesRequest(req);

            return countriesResp.CountriesData.ToList();
        }

        public async Task<CountriesPagingDTO> GetAllCountriesDataPagedAsync(int page, int itemsPerPage)
        {
            var req = RequestsFactory.CreateCountriesRequest(page, itemsPerPage, RequestFormat.json);
            return await DoCountriesRequest(req);
        }

        private async Task<CountriesPagingDTO> DoCountriesRequest(RestRequest restRequest)
        {
            var response = await restClient.Execute<List<Object>>(restRequest);

            if(response.IsSuccess)                
            {                
                var data = response.Data;
                var pagingData = (data[0] as JContainer).ToObject<PagingDTO>();
                var countriesData = (data[1] as JContainer).ToObject<List<CountryDataDTO>>();

                return new CountriesPagingDTO { PagingData = pagingData, CountriesData = countriesData };
            }
            else
            {
                throw new HttpRequestException(string.Format("http failed with response code: {0}", response.StatusCode));
            }
        }
    }
}