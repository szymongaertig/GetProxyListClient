using System.Threading.Tasks;

namespace GarfSG.GetProxyListClient
{
    public interface IGetProxyListClient
    {
        Task<GetProxyResult> GetProxy(GetProxySearchCriteria criteria);
    }
}
