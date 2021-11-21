using DataLoader.Contract;
using System.Net.Http;

namespace DataLoader
{
    public class AppHttpClientFactory : IHttpClientFactory
    {
        public HttpClient Create()
        {
            return HttpClientFactory.Create();
        }
    }
}
