using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GarfSG.GetProxyListClient.Model
{
    public class GetProxyResult
    {
        public string Ip { get; set; }
        public int Port { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public ProtocolEnum Protocol { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public AnonymityEnum Anonymity { get; set; }
        public DateTime LastTested { get; set; }
        public bool AllowsRefererHeader { get; set; }
        public bool AllowsUserAgentHeader { get; set; }
        public bool AllowsCustomHeaders { get; set; }
        public bool AllowsCookies { get; set; }
        public bool AllowsPost { get; set; }
        public bool AllowsHttps { get; set; }
        public string Country { get; set; }
        public decimal ConnectTime { get; set; }
        public decimal DownloadSpeed { get; set; }
        public decimal SecondsToFirstByte { get; set; }
        public decimal Uptime { get; set; }
    }

}
