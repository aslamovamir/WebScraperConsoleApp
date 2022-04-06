using System;
using HtmlAgilityPack;
using System.Collections.Generic;


namespace WebScraperConsoleApp
{
    public class ScrapingLogic
    {
        public List<string> extractNodes(string url)
        {
            // a list to store nodes form a web page
            List<string> extracted_nodes = new List<string>();

            // an object DOM to crawl and extract data from web pages
            HtmlWeb web = new HtmlWeb();

            // the DOM loads a web pages from a url and stores in a variable
            var HTML_doc = web.Load(url);

            // we will specify what nodes from a web page we want to fetch data from
            var nodes = HTML_doc.DocumentNode.SelectNodes("/html/body");

            foreach(var node in nodes)
            {
                extracted_nodes.Add(node.InnerHtml);
            }

            return extracted_nodes;
        }
    }
}
