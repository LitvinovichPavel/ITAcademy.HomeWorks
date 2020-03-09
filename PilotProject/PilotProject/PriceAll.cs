using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class PriceAll
    {
        //В данном классе осуществляется:
        //*проверка на корректность ввода информации,
        //*расчет общей стоимости заказа.
        public static double PriceBeverages { get; set; }          //цена за напитки
        public static double PriceMakis { get; set; }              //цена за маки ролл
        public static double PriceSets { get; set; }               //цена за сет
        public double PriceAllBeverages()
        {
            //Проверяем данные вводимые пользователем при заказе напитков.
            var beveragesAll = new BeveragesAll();
            try
            {
                PriceBeverages = beveragesAll.PriceProduct();
            }
            catch (FormatException)                  //в случае некорректного ввода срабатывает исключение
            {
                Console.WriteLine("\a\n***!!!Введите число!!!***\n");
                PriceAllBeverages();
            }
            catch (OverflowException)                //срабатывает если введено слишком большое число
            {
                Console.WriteLine("\a\n***Ого! У нас столько нет!***\n");
                PriceAllBeverages();
            }
            return PriceBeverages;
        }
        public double PriceAllMakis()
        {
            //Проверяем данные вводимые пользователем при заказе маки роллов.
            var makiAll = new MakisAll();
            try
            {
                PriceMakis = makiAll.PriceProduct();
            }
            catch (FormatException)                  //в случае некорректного ввода срабатывает исключение
            {
                Console.WriteLine("\a\n***!!!Введите число!!!***\n");
                PriceAllMakis();
            }
            catch (OverflowException)                //срабатывает если введено слишком большое число
            {
                Console.WriteLine("\a\n***Ого! У нас столько нет!***\n");
                PriceAllMakis();
            }
            return PriceMakis;
        }
        public double PriceAllSets()
        {
            //Проверяем данные вводимые пользователем при заказе сетов.
            var setsAll = new SetsAll();
            try
            {
                PriceSets = setsAll.PriceProduct();
            }
            catch (FormatException)                  //в случае некорректного ввода срабатывает исключение
            {
                Console.WriteLine("\a\n***!!!Введите число!!!***\n");
                PriceAllSets();
            }
            catch (OverflowException)                //срабатывает если введено слишком большое число
            {
                Console.WriteLine("\a\n***Ого! У нас столько нет!***\n");
                PriceAllSets();
            }
            return PriceSets;
        }
        public double Total()
        {
            //Считаем общую стоимость заказа  (напитки, маки, сеты).
            return PriceBeverages + PriceMakis + PriceSets;
        }
    }
}
