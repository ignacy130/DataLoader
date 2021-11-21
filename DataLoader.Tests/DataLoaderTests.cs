using Moq;
using System.Net.Http;
using Xunit;

namespace DataLoader.Tests
{
    public class DataLoaderTests
    {
        [Theory]
        [InlineData("https://wikipedia.pl")]
        public async void LoadWebsite(string url)
        {
            var httpClient = new Mock<HttpClient>();

            httpClient.Setup(c => c.GetAsync(url)).Returns(new tes);

            var fakeResult = httpClient.Object.YourMethod();

            var loader = new WebsiteLoader(httpClient.Object);
            Assert.NotEmpty(await loader.RequestData(new System.Uri(url)));
        }
    }
}
