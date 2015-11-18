using System;
using RestSharp.Portable;
using System.Net.Http;

namespace MvvmCrossPoc.Core.Remote
{
    public enum RequestFormat { json, xml }

    public static class RequestsFactory
    {
        public static RestRequest CreateCountriesRequest(int page, int countriesPerPage, RequestFormat format)
        {
            var restReq = new RestRequest(HttpMethod.Get);

            restReq.AddQueryParameter("format", format.ToString());
            restReq.AddQueryParameter("page", page);
            restReq.AddQueryParameter("per_page", countriesPerPage);

            return restReq;
        }        
    }
}

