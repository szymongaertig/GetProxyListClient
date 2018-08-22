using System.Runtime.Serialization;

namespace GarfSG.GetProxyListClient
{
    public enum AnonymityEnum
    {
        [EnumMember(Value = "transparent")]
        Transparent,
        [EnumMember(Value = "anonymous")]
        Anonymous,
        [EnumMember(Value = "high anonymity")]
        High
    }
}