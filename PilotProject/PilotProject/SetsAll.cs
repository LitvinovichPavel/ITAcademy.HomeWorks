using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class SetsAll : Menu//, IPrice
    {
        public const string num1Set = "Сет №1 (410гр)";
        public const string num2Set = "Сет №2 (430гр)";
        public const string num3Set = "Сет №3 (420гр)";
        public const string bigSet = "Большой сет (1000гр)";

        public const double priceNum1Set = 32.0;
        public const double priceNum2Set = 35.2;
        public const double priceNum3Set = 37.1;
        public const double priceBigSet = 55.7;
        public void Sets()
        {
            Console.WriteLine("Какие сеты будете?");
            Console.WriteLine("***********************************************************");

            try
            {
                Console.Write($"Сколько хотите: {num1Set}?: ");
                ushort quantity1Set = Convert.ToUInt16(Console.ReadLine());
                Console.Write($"Сколько хотите: {num2Set}?: ");
                ushort quantity2Set = Convert.ToUInt16(Console.ReadLine());
                Console.Write($"Сколько хотите: {num3Set}?: ");
                ushort quantity3Set = Convert.ToUInt16(Console.ReadLine());
                Console.Write($"Сколько хотите: {bigSet}?: ");
                ushort quantityBigSet = Convert.ToUInt16(Console.ReadLine());

                PriceSets = (priceNum1Set * quantity1Set) + (priceNum2Set * quantity2Set) +
                            (priceNum3Set * quantity3Set) + (priceBigSet * quantityBigSet);
            }

            catch (FormatException)                  //в случае некорректного ввода срабатывает исключение
            {
                Console.WriteLine("\a\n***!!!Введите число!!!***\n");
                var setsAll = new SetsAll();
                setsAll.Sets();
            }

            catch (OverflowException)                //срабатывает если введено слишком большое число
            {
                Console.WriteLine("\a\n***Ого! У нас так много нет!***\n");
                var setsAll = new SetsAll();
                setsAll.Sets();
            }
        }
        public double PriceProduct()
        {
            return 0;
        }
    }
}
