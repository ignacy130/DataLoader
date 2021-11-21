using DataLoader.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader
{
    public class WebsiteLoader : ILoadData
    {
        private readonly HttpClient _httpClient;
        public WebsiteLoader(IHttpClientFactory httpClientFactory) 
        {
            _httpClient = httpClientFactory.Create();
        }

        public Task<string> RequestData(Uri url)
        {
            throw new NotImplementedException();
        }
    }
}
