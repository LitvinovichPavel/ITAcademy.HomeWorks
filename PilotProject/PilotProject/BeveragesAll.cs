using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class BeveragesAll : Menu//, IPrice
    {
        public const string fanta = "Fanta";
        public const string cola = "Coca-Cala";
        public const string water = "Water";
        public const double priceFanta = 2.0;
        public const double priceCola = 2.0;
        public const double priceWater = 0.5;
        enum BeveragesType
        {
            Fanta = 1,
            CocaCola = 2,
            Water = 3
        }
        public void Beverages()
        {
            Console.Write("Что будете пить?: ");
            Console.Write($"\n1: {BeveragesType.Fanta}\n2: {BeveragesType.CocaCola}\n3: {BeveragesType.Water}");
            int choiseDrink;
            choiseDrink = Convert.ToInt32(Console.ReadLine());

        }
        //public double PriceProduct()
        //{
        //
        //}
    }
}
