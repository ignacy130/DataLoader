using DataLoader.Contract;
using Moq;
using Moq.Protected;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace DataLoader.Tests
{
    public class DataLoaderTests
    {
        [Theory]
        [ClassData(typeof(TestFiles))]
        public async void LoadWebsite(WebsiteTestCase testCase)
        {
            var handlerMock  = new Mock<HttpMessageHandler>();
            var msg = new HttpRequestMessage()
            {
                RequestUri = testCase.Url
            };

            var response = new HttpResponseMessage()
            {
                Content = new StringContent(testCase.TestSource),
                StatusCode = System.Net.HttpStatusCode.OK
            };

            handlerMock 
               .Protected()
               .Setup<Task<HttpResponseMessage>>(
                  nameof(HttpClient.SendAsync),
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>())
               .ReturnsAsync(response);

            var httpClient = new HttpClient(handlerMock.Object);
            var httpClientFactoryMock = new Mock<IHttpClientFactory>();
            httpClientFactoryMock.Setup(x => x.Create()).Returns(httpClient);

            var loader = new WebsiteLoader(httpClientFactoryMock.Object);
            var result = await loader.RequestData(testCase.Url);
            Assert.NotEmpty(result);
        }
    }
}
