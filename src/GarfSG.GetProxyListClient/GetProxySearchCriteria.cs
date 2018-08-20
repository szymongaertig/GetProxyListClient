namespace GarfSG.GetProxyListClient
{
    /// <summary>
    ///     https://getproxylist.com/#the-api
    /// </summary>
    public class GetProxySearchCriteria
    {
        /// <summary>
        ///     Seconds since last tested
        /// </summary>
        public int? LastTested { get; set; }

        /// <summary>
        ///     Port available on
        /// </summary>
        public int[] Port { get; set; }

        /// <summary>
        ///     How much of your info is hidden
        /// </summary>
        public AnonymityEnum[] Anonymity { get; set; }

        /// <summary>
        ///     The type
        /// </summary>
        public ProtocolEnum[] Protocol { get; set; }

        /// <summary>
        ///     Supports the Referer header
        /// </summary>
        public bool? AllowsRefererHeader { get; set; }

        /// <summary>
        ///     Supports the User-Agent header
        /// </summary>
        public bool? AllowsUserAgentHeader { get; set; }

        /// <summary>
        ///     Supports any custom headers
        /// </summary>
        public bool? AllowsCustomHeaders { get; set; }

        /// <summary>
        ///     Supports cookies
        /// </summary>
        public bool? AllowsCookies { get; set; }

        /// <summary>
        ///     Supports POST requests
        /// </summary>
        public bool? AllowsPost { get; set; }

        /// <summary>
        ///     Supports HTTPS requests
        /// </summary>
        public bool? AllowsHttps { get; set; }

        /// <summary>
        ///     Country it originates from
        /// </summary>
        public string[] Country { get; set; }

        /// <summary>
        ///     Filter out specific countries
        /// </summary>
        public string[] NotCountry { get; set; }

        /// <summary>
        ///     The IP
        /// </summary>
        public string[] Ip { get; set; }

        /// <summary>
        ///     optional, removes daily limits
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        ///     Seconds to establish connection
        /// </summary>
        public decimal? MaxConnectTime { get; set; }

        /// <summary>
        ///     Seconds before data is received
        /// </summary>
        public decimal? MaxSecondsToFirstByte { get; set; }

        /// <summary>
        ///     Download speed in bytes per second
        /// </summary>
        public decimal? MinDownloadSpeed { get; set; }

        /// <summary>
        ///     What percentage uptime the proxy has
        /// </summary>
        public decimal? MinUptime { get; set; }

        /// <summary>
        ///     Returns all matching proxies - Paid only
        /// </summary>
        public bool? All { get; set; }
    }
}