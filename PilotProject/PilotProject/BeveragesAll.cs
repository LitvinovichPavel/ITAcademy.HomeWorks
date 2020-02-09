using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class BeveragesAll : Menu, IPrice
    {
        public const string fanta = "Fanta";
        public const string cola = "Coca-Cala";
        public const string water = "Water";

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
        enum BeveragesType
        {
            Fanta = 1,
            CocaCola = 2,
            Water = 3
        }
        public double Beverages()
        {
            Console.WriteLine("Что будете пить?");
            Console.Write($"Сколько бутылок {BeveragesType.Fanta}?: ");
            int quantityFanta = int.Parse(Console.ReadLine());
            Console.Write($"Сколько бутылок {BeveragesType.CocaCola}?: ");
            int quantityCocaCola = int.Parse(Console.ReadLine());
            Console.Write($"Сколько бутылок {BeveragesType.Water}?: ");
            int quantityWater = int.Parse(Console.ReadLine());

            double price = (priceFanta * quantityFanta) + (priceCola * quantityCocaCola) + (priceWater * quantityWater);
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
