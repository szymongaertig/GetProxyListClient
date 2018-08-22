using System.Threading.Tasks;
using GarfSG.GetProxyListClient.Model;

namespace GarfSG.GetProxyListClient
{
    public interface IGetProxyListClient
    {
        Task<GetProxyResult> GetProxy(GetProxySearchCriteria criteria);
    }
}
