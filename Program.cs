using System;
using System.Collections.Generic;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Denis!");
            Console.WriteLine("Hello World!");
            //Console.Read();

            /*  Dictionary<string, decimal> itemPrices = new Dictionary<string, decimal>()
              {
                  {"cheese", 5.99 }
              };*/

            Dictionary<string, string> itemPrices = new Dictionary<string, string>()
            {
                {"cheese", "5.99" },
                {"carrots","2.99" }
            };
            Console.WriteLine(itemPrices["cheese"]);
            Console.WriteLine(itemPrices["carrots"]);

            Dictionary<string, decimal> itemPrices2 = new Dictionary<string, decimal>()
            {
                {"cheese", 5.99m },
                {"carrots",2.99m }
            };
            Console.WriteLine(itemPrices["cheese"]);
            Console.WriteLine(itemPrices["carrots"]);


        }
    }
}

