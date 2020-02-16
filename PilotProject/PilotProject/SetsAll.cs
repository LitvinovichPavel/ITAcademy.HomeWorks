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
        public void SetsQuestion()
        {
            Console.WriteLine("\n***********************************************************");
            Console.WriteLine("Какой сет будете?");
        }
        public double SetsNum1()
        {
            Console.Write($"Сколько {num1Set}?: ");
            ushort quantityNum1 = Convert.ToUInt16(Console.ReadLine());
            double allPriceNum1 = priceNum1Set * quantityNum1;
            return allPriceNum1;
        }
        public double SetsNum2()
        {
            Console.Write($"Сколько {num2Set}?: ");
            ushort quantityNum2 = Convert.ToUInt16(Console.ReadLine());
            double allPriceNum2 = priceNum2Set * quantityNum2;
            return allPriceNum2;
        }
        public double SetsNum3()
        {
            Console.Write($"Сколько {num3Set}?: ");
            ushort quantityNum3 = Convert.ToUInt16(Console.ReadLine());
            double allPriceNum3 = priceNum3Set * quantityNum3;
            return allPriceNum3;
        }
        public double SetsBig()
        {
            Console.Write($"Сколько {bigSet}?: ");
            ushort quantityBigSet = Convert.ToUInt16(Console.ReadLine());
            double allPriceBigSet = priceBigSet * quantityBigSet;
            return allPriceBigSet;
        }
        public double PriceProduct()
        {
            SetsQuestion();
            PriceSets = SetsNum1() + SetsNum2() + SetsNum3() + SetsBig();
            return PriceSets;
        }
    }
}
