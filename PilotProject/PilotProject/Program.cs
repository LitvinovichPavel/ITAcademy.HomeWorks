using System;
using System.Text.Json;
using Newtonsoft.Json;

namespace PilotProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var priceAll = new PriceAll();
            priceAll.PriceAllBeverages();
            priceAll.PriceAllMaki();
            priceAll.PriceAllSets();
            
            Console.WriteLine($"TOTAL: {priceAll.Total()}");
        }
    }
}
