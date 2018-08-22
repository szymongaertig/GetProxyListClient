namespace GarfSG.GetProxyListClient.Model
{
    public static class GetProxySearchCriteriaExtensions
    {
        public static object GetQueryParamsObject(this GetProxySearchCriteria value)
        {
            return new
            {
                lastTested = value.LastTested,
                port = value.Port,
                anonymity = value.Anonymity,
                protocol = value.Protocol,
                allowsRefererHeader = value.AllowsRefererHeader,
                allowsUserAgentHeader = value.AllowsUserAgentHeader,
                allowsCustomHeaders = value.AllowsCustomHeaders,
                allowsCookies = value.AllowsCookies,
                allowsPost = value.AllowsPost,
                allowsHttps = value.AllowsHttps,
                country = value.Country,
                notCountry = value.NotCountry,
                ip = value.Ip,
                maxConnectTime = value.MaxConnectTime,
                maxSecondsToFirstByte = value.MaxSecondsToFirstByte,
                minDownloadSpeed = value.MinDownloadSpeed,
                minUptime = value.MinUptime,
                all = value.All
            };
        }
    }
}
