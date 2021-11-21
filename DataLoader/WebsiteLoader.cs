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
        public WebsiteLoader(HttpClient httpClient) 
        {
            _httpClient = httpClient;
        }

        public Task<string> RequestData(Uri url)
        {
            throw new NotImplementedException();
        }
    }
}
