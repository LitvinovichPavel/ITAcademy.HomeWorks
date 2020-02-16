using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class PriceAll
    {
        public static double Price { get; set; }            //общая цена
        public double PriceBeverages { get; set; }   //цена за напитки
        public static double PriceMaki { get; set; }        //цена за маки
        public static double PriceSets { get; set; }        //цена за сет
        public void PriceFoodAndDrink()
        {
            var beveragesAll = new BeveragesAll();
            var makiAll = new MakiAll();

            try
            {
                beveragesAll.PriceProduct();
                PriceBeverages = beveragesAll.PriceBeverages;
                Console.WriteLine($"PRICE DRINK:------> {PriceBeverages:#.##}");
            }
            catch (FormatException)                  //в случае некорректного ввода срабатывает исключение
            {
                Console.WriteLine("\a\n***!!!Введите число!!!***\n");
                PriceFoodAndDrink();
            }
            catch (OverflowException)                //срабатывает если введено слишком большое число
            {
                Console.WriteLine("\a\n***Ого! У нас так много нет!***\n");
                PriceFoodAndDrink();
            }

            try
            {
                makiAll.PriceProduct();
                PriceMaki = makiAll.PriceMaki;
                Console.WriteLine($"PRICE MAKI:------> {PriceMaki:#.##}");
            }
            catch (FormatException)                  //в случае некорректного ввода срабатывает исключение
            {
                Console.WriteLine("\a\n***!!!Введите число!!!***\n");
                PriceFoodAndDrink();
            }
            catch (OverflowException)                //срабатывает если введено слишком большое число
            {
                Console.WriteLine("\a\n***Ого! У нас так много нет!***\n");
                PriceFoodAndDrink();
            }

            Console.WriteLine($"ОБСТСЩИЙ PRICE:->->->->-> {(PriceBeverages + PriceMaki):#.##}");
        }
    }
}
