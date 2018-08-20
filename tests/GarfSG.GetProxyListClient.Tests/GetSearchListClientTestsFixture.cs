using System;
using Flurl.Http.Testing;

namespace GarfSG.GetProxyListClient.Tests
{
    public class GetSearchListClientTestsFixture : IDisposable
    {
        public GetProxyListClient Sut { get; set; }

        public HttpTest FlurlHttpTest { get; set; }
        public GetSearchListClientTestsFixture()
        {
            FlurlHttpTest = new HttpTest();
            Sut = new GetProxyListClient();
        }

        public void Dispose()
        {
            FlurlHttpTest?.Dispose();
        }
    }
}
