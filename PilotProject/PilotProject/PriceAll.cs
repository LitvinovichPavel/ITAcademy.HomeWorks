using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class PriceAll
    {
        public static double Price { get; set; }            //общая цена
        public double PriceBeverages { get; set; }          //цена за напитки
        public static double PriceMaki { get; set; }        //цена за маки
        public static double PriceSets { get; set; }        //цена за сет
        public double PriceAllBeverages()
        {
            var beveragesAll = new BeveragesAll();
            
            try
            {
                beveragesAll.PriceProduct();
                PriceBeverages = beveragesAll.PriceBeverages;
            }
            catch (FormatException)                  //в случае некорректного ввода срабатывает исключение
            {
                Console.WriteLine("\a\n***!!!Введите число!!!***\n");
                PriceAllBeverages();
            }
            catch (OverflowException)                //срабатывает если введено слишком большое число
            {
                Console.WriteLine("\a\n***Ого! У нас так много нет!***\n");
                PriceAllBeverages();
            }

            return PriceBeverages;
        }
        public double PriceAllMaki()
        {
            var makiAll = new MakiAll();

            try
            {
                makiAll.PriceProduct();
                PriceMaki = makiAll.PriceMaki;
            }
            catch (FormatException)                  //в случае некорректного ввода срабатывает исключение
            {
                Console.WriteLine("\a\n***!!!Введите число!!!***\n");
                PriceAllMaki();
            }
            catch (OverflowException)                //срабатывает если введено слишком большое число
            {
                Console.WriteLine("\a\n***Ого! У нас так много нет!***\n");
                PriceAllMaki();
            }

            return PriceMaki;
        }
        public double PriceAllSets()
        {
            var setsAll = new SetsAll();

            try
            {
                setsAll.PriceProduct();
                PriceSets = setsAll.PriceSets;
            }
            catch (FormatException)                  //в случае некорректного ввода срабатывает исключение
            {
                Console.WriteLine("\a\n***!!!Введите число!!!***\n");
                PriceAllSets();
            }
            catch (OverflowException)                //срабатывает если введено слишком большое число
            {
                Console.WriteLine("\a\n***Ого! У нас так много нет!***\n");
                PriceAllSets();
            }

            return PriceSets;
        }
        public double Total()
        {
            return PriceBeverages + PriceMaki + PriceSets;
        }
    }
}
