using DataLoader.Contract;
using Moq;
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
            var httpClient = new Mock<HttpClient>();
            var msg = new HttpRequestMessage()
            {
                RequestUri = testCase.Url
            };
            var tokenSource = new CancellationTokenSource();
            httpClient.Setup(c => c.SendAsync(msg, tokenSource.Token))
                      .Returns(Task.FromResult(new HttpResponseMessage()
                      {
                          Content = new StringContent(testCase.TestSource),
                          StatusCode = System.Net.HttpStatusCode.OK
                      }));

            var httpClientFactoryMock = new Mock<IHttpClientFactory>();
            httpClientFactoryMock.Setup(x => x.Create()).Returns(httpClient.Object);
            var loader = new WebsiteLoader(httpClientFactoryMock.Object);
            var result = await loader.RequestData(testCase.Url);
            Assert.NotEmpty(result);
            Assert.True(result.Length > 500);
            Assert.Contains(testCase.CorrectTitle, result);
        }
    }
}
