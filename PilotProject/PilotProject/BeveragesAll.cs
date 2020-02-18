using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class BeveragesAll : Menu, IPrice
    {
        public const string fanta = "Fanta (0,5л)";
        public const string cola = "Coca-Cala (0,5л)";
        public const string water = "Water (0.5л)";
        public string Title { get; set; }
        public double Price { get; set; }
        public BeveragesAll()
        {
        }
        public BeveragesAll(string title, double price)
        {
            Title = title;
            Price = price;
        }
        public void BeveragesQuestion()
        {
            Console.WriteLine("\n***********************************************************");
            Console.WriteLine("Что будете пить?");
        }
        public void ListBeverages(out double totalPriceFanta, out double totalPriceCola, out double totalPriceWater)
        {
            List<BeveragesAll> scroll = new List<BeveragesAll>() { };
            scroll.Add(new BeveragesAll(Title = "Fanta", Price = 2.0));
            scroll.Add(new BeveragesAll(Title = "Coca-Cola", Price = 2.0));
            scroll.Add(new BeveragesAll(Title = "Water", Price = 0.5));

            Console.Write($"Сколько {fanta}?: ");
            ushort quantityFanta = Convert.ToUInt16(Console.ReadLine());
            totalPriceFanta = quantityFanta * scroll[0].Price;

            Console.Write($"Сколько {cola}?: ");
            ushort quantityCola = Convert.ToUInt16(Console.ReadLine());
            totalPriceCola = quantityCola * scroll[1].Price;

            Console.Write($"Сколько {water}?: ");
            ushort quantityWater = Convert.ToUInt16(Console.ReadLine());
            totalPriceWater = quantityWater * scroll[2].Price;
        }
        public double PriceProduct()
        {
            BeveragesQuestion();
            ListBeverages(out double totalPriceFanta, out double totalPriceCola, out double totalPriceWater);
            PriceBeverages = totalPriceFanta + totalPriceCola + totalPriceWater;
            return PriceBeverages;
        }
    }
}
