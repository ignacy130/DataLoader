using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader
{
    public class WebsiteReader : IReadWebsite
    {
        public string GetTitle(string source)
        {
            var website = new HtmlDocument();
            website.LoadHtml(source);
            HtmlNode titleNode = null;
            try
            {
                titleNode = website.DocumentNode.SelectNodes("html/head/title").FirstOrDefault();
            }
            catch
            {

            }
            return titleNode?.InnerText;
        }
    }
}
