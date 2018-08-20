using System;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace GarfSG.GetProxyListClient
{
    public class GetProxyListClient : IGetProxyListClient
    {
        private const string _baseApiUrl = "https://api.getproxylist.com";

        public async Task<GetProxyResult> GetProxy(GetProxySearchCriteria criteria)
        {
            try
            {
                var httpClient = _baseApiUrl
                    .AppendPathSegment("proxy");

                _baseApiUrl.SetQueryParams(criteria);

                return await httpClient.GetJsonAsync<GetProxyResult>();

            }
            catch (FlurlHttpException ex)
            {
                ErrorResult errorResponse = await ex.GetResponseJsonAsync<ErrorResult>();
                throw new Exception(errorResponse.Error);
            }
        }
    }
}
