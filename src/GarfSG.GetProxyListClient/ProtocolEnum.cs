using System.Runtime.Serialization;

namespace GarfSG.GetProxyListClient
{
    public enum ProtocolEnum
    {
        [EnumMember(Value = "http")]
        Http,
        [EnumMember(Value = "socks4")]
        Socks4,
        [EnumMember(Value = "socks4a")]
        Socks4a,
        [EnumMember(Value = "socks5")]
        Socks5,
        [EnumMember(Value = "socks5h")]
        Socks5h
    }
}
