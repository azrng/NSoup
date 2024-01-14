using System;
using System.IO;

namespace NSoup.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var str = File.ReadAllText(@"D:\Test\ConsoleApp3\ConsoleApp3\index.html");
            var nsoup = NSoupClient.Parse(str);
            var htmlElementList = nsoup.GetAllElements();

            var resultHtmlStr = nsoup.Html();

            Console.WriteLine("Hello World!");
        }
    }
}