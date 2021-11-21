using DataLoader.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DataLoader.Tests
{
    public class AppHttpClientFactory : IHttpClientFactory
    {
        public HttpClient Create()
        {
            return HttpClientFactory.Create();
        }
    }

    public class AppTests
    {
        [Fact]
        public async void RunApp()
        {
            var app = new App(new WebsiteLoader(new AppHttpClientFactory()), new WebsiteReader());
            await app.SaveDataFor(new Uri("https://example.com/"));
        }
    }
}
