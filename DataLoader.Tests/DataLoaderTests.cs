using Moq;
using System.Net.Http;
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

            httpClient.Setup(c => c.GetAsync(url)).Returns(new tes);

            var fakeResult = httpClient.Object.YourMethod();

            var loader = new WebsiteLoader(httpClient.Object);
            Assert.NotEmpty(await loader.RequestData(new System.Uri(url)));
        }
    }
}
