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

        public const double priceFanta = 2.0;
        public const double priceCola = 2.0;
        public const double priceWater = 0.5;
        public BeveragesAll()
        {

        }
        public BeveragesAll(double choiseFanta, double choiseCola, double choiseWater)
        {
            choiseFanta = priceFanta;
            choiseCola = priceCola;
            choiseWater = priceWater;
        }
        public enum BeveragesType
        {
            Fanta = 1,
            CocaCola = 2,
            Water = 3
        }
        public double Beverages()
        {
            Console.WriteLine("Что будете пить?");
            Console.Write($"Сколько бутылок {fanta} (0,5)?: ");
            var quantityFanta = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Сколько бутылок {cola} (0,5)?: ");
            var quantityCocaCola = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Сколько бутылок {water} (0,5)?: ");
            var quantityWater = Convert.ToInt32(Console.ReadLine());

            var price = (priceFanta * quantityFanta) + (priceCola * quantityCocaCola) + (priceWater * quantityWater);
            PriceBeverages = price;
            return PriceBeverages;
        }
        public void PriceProduct()
        {
            BeveragesAll beveragesAll = new BeveragesAll();
            beveragesAll.Beverages();
            Console.WriteLine(beveragesAll.PriceBeverages);
        }
    }
}
