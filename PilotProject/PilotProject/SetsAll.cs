using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class SetsAll : Menu, IPrice
    {
        public const string num1Set = "Сет №1 (410гр)";
        public const string num2Set = "Сет №2 (430гр)";
        public const string num3Set = "Сет №3 (420гр)";
        public const string bigSet = "Большой сет (1000гр)";

        public const double priceNum1Set = 32.0;
        public const double priceNum2Set = 35.2;
        public const double priceNum3Set = 37.1;
        public const double priceBigSet = 55.7;
        public double Sets()
        {
            Console.WriteLine("Какие сеты будете?");
            Console.Write($"Сколько хотите: {num1Set}?: ");
            var quantity1Set = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Сколько хотите: {num2Set}?: ");
            var quantity2Set = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Сколько хотите: {num3Set}?: ");
            var quantity3Set = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Сколько хотите: {bigSet}?: ");
            var quantityBigSet = Convert.ToInt32(Console.ReadLine());

            var price = (priceNum1Set * quantity1Set) + (priceNum2Set * quantity2Set) +
                        (priceNum3Set * quantity3Set) + (priceBigSet * quantityBigSet);
            PriceSets = price;
            return PriceSets;
        }
        public void PriceProduct()
        {
            var setsAll = new SetsAll();
            Console.WriteLine(setsAll.PriceSets);
        }
    }
}
