using System;
using System.Collections.Generic;
using System.IO;

namespace WebScraperConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // we will create a List data structure of string type to store the returned data
            // from the scraper object
            List<string> fetched_data = new List<string>();

            // this is the object from the scraper class we have created
            ScrapingLogic scraper = new ScrapingLogic();

            // a variable to store the url of a web page to be scraped
            string url = "https://www.usf.edu/engineering/";

            // we will use the method of the scraper to return the list of nodes' Inner Html
            fetched_data = scraper.extractNodes(url);

            File.WriteAllLines("./RESULTS_2.txt",
                fetched_data);
        }
    }
}
