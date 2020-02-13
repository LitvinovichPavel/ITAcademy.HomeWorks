using System;
using System.Text.Json;
using Newtonsoft.Json;

namespace PilotProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceAll priceAll = new PriceAll();
            priceAll.PriceFoodAndDrink();
        }
    }
}
