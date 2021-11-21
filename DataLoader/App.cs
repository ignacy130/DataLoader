using System;
using System.Threading.Tasks;

namespace DataLoader
{
    public class App
    {
        private readonly ILoadData _loader;
        private readonly IReadWebsite _reader;
        public App(ILoadData loader, IReadWebsite reader)
        {
            _loader = loader;
            _reader = reader;
        }

        public async Task SaveDataFor(Uri url)
        {
            var source = await _loader.RequestData(url);
            _reader.GetTitle(source);

        }
    }
}
