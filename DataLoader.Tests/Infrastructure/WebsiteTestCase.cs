using System;

namespace DataLoader.Tests
{
    public class WebsiteTestCase
    {
        public string File { get; private set; }
        public Uri Url { get; private set; }
        public string CorrectTitle { get; private set; }
        /// <summary>
        /// Should correspond with the real page source.
        /// </summary>
        public string TestSource { get; set; }

        public WebsiteTestCase(string file, string url, string correctTitle)
        {
            File = file;
            Url = new Uri(url);
            CorrectTitle = correctTitle;
        }
    }
}
