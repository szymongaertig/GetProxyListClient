using System;
using System.Threading.Tasks;
using AutoFixture.Xunit2;
using GarfSG.GetProxyListClient.Exceptions;
using GarfSG.GetProxyListClient.Model;
using GarfSG.GetProxyListClient.Tests.Properties;
using Newtonsoft.Json;
using Xunit;

namespace GarfSG.GetProxyListClient.Tests
{
    public class WhenGettingProxyTests
    {
        [Theory]
        [AutoData]
        public async Task With_Invalid_ApiKey_Then_Throw_Proper_Exception(string apiKey)
        {
            using (var fixture = new GetSearchListClientTestsFixture(apiKey))
            {
                // Given
                fixture.FlurlHttpTest.RespondWithJson(new
                {
                    error = ErrorMesssages.InvalidApiKey
                }, 401);

                // When, Then
                await Assert.ThrowsAsync<InvalidApiKeyException>(async () =>
                {
                    await fixture.Sut.GetProxy(new GetProxySearchCriteria());
                });
            }
        }

        [Theory]
        [AutoData]
        public async Task With_Expired_ApiKey_Then_Throw_Proper_Exception(string apiKey)
        {
            using (var fixture = new GetSearchListClientTestsFixture(apiKey))
            {
                // Given
                fixture.FlurlHttpTest.RespondWithJson(new
                {
                    error = ErrorMesssages.ExpiredApiKey
                }, 401);

                // When, Then
                await Assert.ThrowsAsync<ExpiredApiKeyException>(async () =>
                {
                    await fixture.Sut.GetProxy(new GetProxySearchCriteria());
                });
            }
        }

        [Theory]
        [InlineData(304, "lerem ipsum")]
        [InlineData(400, "Some error message")]
        public async Task With_Not_200_Result_Then_Pass_Valid_Exception_Message(
            int errorCode,
            string errorMessage)
        {
            using (var fixture = new GetSearchListClientTestsFixture(null))
            {
                // Given
                fixture.FlurlHttpTest.RespondWithJson(new
                {
                    error = errorMessage
                }, errorCode);

                // When, Then
                var exception = await Assert.ThrowsAsync<Exception>(
                    () => fixture.Sut.GetProxy(new GetProxySearchCriteria()));

                Assert.Equal(errorMessage, exception.Message);
            }
        }

        [Fact]
        public async Task With_200OK_Result_Then_Returns_Valid_Object()
        {
            using (var fixture = new GetSearchListClientTestsFixture(null))
            {
                // Given
                var jsonObject = JsonConvert.DeserializeObject(Resources.ValidGetProxyResponse1);
                fixture.FlurlHttpTest.RespondWithJson(jsonObject, 200);

                // When
                var result = await fixture.Sut.GetProxy(new GetProxySearchCriteria());

                // Then
                Assert.NotNull(result);

                Assert.Equal("148.103.49.247", result.Ip);
                Assert.Equal(21776, result.Port);
                Assert.Equal(ProtocolEnum.Http, result.Protocol);
                Assert.Equal(AnonymityEnum.High, result.Anonymity);
                Assert.Equal(new DateTime(2018, 08, 20, 10, 54, 9), result.LastTested);
                Assert.True(result.AllowsRefererHeader);
                Assert.True(result.AllowsUserAgentHeader);
                Assert.True(result.AllowsCustomHeaders);
                Assert.True(result.AllowsCookies);
                Assert.True(result.AllowsPost);
                Assert.True(result.AllowsHttps);
                Assert.Equal("DO", result.Country);
                Assert.Equal(0.180m, result.ConnectTime);
                Assert.Equal(17.000m, result.DownloadSpeed);
                Assert.Equal(9.901m, result.SecondsToFirstByte);
                Assert.Equal(88.889m, result.Uptime);
            }
        }
    }
}