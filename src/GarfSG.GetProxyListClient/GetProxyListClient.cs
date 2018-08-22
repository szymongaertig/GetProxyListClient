using System;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using GarfSG.GetProxyListClient.Exceptions;
using GarfSG.GetProxyListClient.Model;

namespace GarfSG.GetProxyListClient
{
    public class GetProxyListClient : IGetProxyListClient
    {
        private const string _baseApiUrl = "https://api.getproxylist.com";
        private string _apiKey;

        public GetProxyListClient(string apiKey)
        {
            _apiKey = apiKey;
        }

        public GetProxyListClient()
        {

        }

        public async Task<GetProxyResult> GetProxy(GetProxySearchCriteria criteria)
        {
            try
            {
                return await _baseApiUrl
                    .AppendPathSegment("proxy")
                    .SetQueryParams(criteria.GetQueryParamsObject())
                    .SetQueryParam("apiKey", _apiKey)
                    .GetJsonAsync<GetProxyResult>();
            }
            catch (FlurlHttpException ex)
            {
                var errorResponse = await ex.GetResponseJsonAsync<ErrorResult>();
                switch (errorResponse.Error)
                {
                    case ErrorMesssages.InvalidApiKey:
                        throw new InvalidApiKeyException();
                    case ErrorMesssages.ExpiredApiKey:
                        throw new ExpiredApiKeyException();
                    default: throw new Exception(errorResponse.Error);
                }
            }
        }
    }
}
