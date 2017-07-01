using System;
using MyCodeLibrary; // dll file, added in solution explorer

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();

            string value = myScrape.ScrapeWebpage("http://www.fz.se");
            Console.WriteLine(value);

            myScrape.ScrapeWebpage("http://www.arla.se", @"D:\temp\CSHARP\webscrape.txt");


            Console.ReadLine();
        }
    }
}
