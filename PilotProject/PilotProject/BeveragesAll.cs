using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class BeveragesAll : Menu, IPrice
    {
        public double PriceBeverages { get; set; }

        public const string fanta = "Fanta (0,5л)";
        public const string cola = "Coca-Cala (0,5л)";
        public const string water = "Water (0.5л)";

        public const double priceFanta = 2.0;
        public const double priceCola = 2.0;
        public const double priceWater = 0.5;
        public void BeveragesQuestion()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Что будете пить?");
        }
        public double BeverationFanta()
        {
            Console.Write("Сколько Fanta?: ");
            ushort quantityFanta = Convert.ToUInt16(Console.ReadLine());
            double allPriceFanta = priceFanta * quantityFanta;
            return allPriceFanta;
        }
        public double BeverationCola()
        {
            Console.Write("Сколько Cola?: ");
            ushort quantityCola = Convert.ToUInt16(Console.ReadLine());
            double allPriceCola = priceCola * quantityCola;
            return allPriceCola;
        }
        public double BeverationWater()
        {
            Console.Write($"Сколько воды?: ");
            ushort quantityWater = Convert.ToUInt16(Console.ReadLine());
            double allPriceWater = priceWater * quantityWater;
            return allPriceWater;
        }
        public double PriceProduct()
        {
            BeveragesAll beveragesAll = new BeveragesAll();
            double allFanta;
            double allCola;
            double allWater;

            beveragesAll.BeveragesQuestion();
            allFanta = beveragesAll.BeverationFanta();
            allCola = beveragesAll.BeverationCola();
            allWater = beveragesAll.BeverationWater();

            return PriceBeverages = allFanta + allCola + allWater;
        }
    }
}
