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
        public void Beverages()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Что будете пить?");

            try
            {
                Console.Write($"Сколько бутылок {fanta}?: ");
                ushort quantityFanta = Convert.ToUInt16(Console.ReadLine());
                Console.Write($"Сколько бутылок {cola}?: ");
                ushort quantityCocaCola = Convert.ToUInt16(Console.ReadLine());
                Console.Write($"Сколько бутылок {water}?: ");
                ushort quantityWater = Convert.ToUInt16(Console.ReadLine());

                PriceBeverages = (priceFanta * quantityFanta) + (priceCola * quantityCocaCola) +
                                 (priceWater * quantityWater);
            }

            catch(FormatException)                  //в случае некорректного ввода срабатывает исключение
            {
                Console.WriteLine("\a\n***!!!Введите число!!!***\n");
                var beveragesAll = new BeveragesAll();
                beveragesAll.Beverages();
            }

            catch(OverflowException)                //срабатывает если введено слишком большое число
            {
                Console.WriteLine("\a\n***Ого! У нас так много нет!***\n");
                var beveragesAll = new BeveragesAll();
                beveragesAll.Beverages();
            }
        }
        public void PriceProduct()
        {
            var beveragesAll = new BeveragesAll();
            beveragesAll.Beverages();
            object obj;
            obj = beveragesAll.PriceBeverages;
            double num = (double)obj;


            Console.WriteLine($"PRICE {num}");
        }
    }
}
