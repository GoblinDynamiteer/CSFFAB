//using System;
using System.IO;
using System.Net; // Auto inserted by CTRL + . on WebClient clas

namespace AssembliesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Namespace System */
            System.Console.WriteLine("Hellow WOrld!");

            string text = "Hellow WOrld!!! In a textfile!";

            // System.IO.
            File.WriteAllText(@"D:\Temp\CSHARP\WriteText.txt", text);

            /* Press CTRL + . on Class to find assembly reference */
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://www.arla.se");
            System.Console.WriteLine(reply);

            System.Console.ReadLine();
        }
    }
}
