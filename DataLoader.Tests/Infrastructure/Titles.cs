using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader.Tests.Data
{
    public static class Titles
    {
        public static readonly List<WebsiteTestCase> TitlesWithSource;

        static Titles()
        {
            var dataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            TitlesWithSource = new List<WebsiteTestCase>()
            {
                new WebsiteTestCase("wikipedia.html","https://pl.wikipedia.org/", "Wikipedia, wolna encyklopedia"),
                new WebsiteTestCase("example.html","https://example.com", "Example Domain"),
                new WebsiteTestCase("no-title-element.html","http://no-title.localhost", null),
                new WebsiteTestCase("empty-title-element.html","http://empty-title.localhost", "")
            };

            foreach (var item in TitlesWithSource)
            {
                item.TestSource = File.ReadAllText(Path.Combine(dataDir, item.File));
            }
        }
    }
}
