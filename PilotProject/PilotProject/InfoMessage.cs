using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class InfoMessage
    {
        public void Message()
        {
            PriceAll priceAll = new PriceAll();
            BeveragesAll beveragesAll = new BeveragesAll();
            MakiAll makiAll = new MakiAll();

            Console.WriteLine($"Общая стоимость составляет: {priceAll.PriceFoodAndDrink():#.##}");
            Console.WriteLine($"Стоимость напитков: {beveragesAll.Beverages():#.##}");
            Console.WriteLine($"Стоимость маки: {makiAll.Maki():#.##}");
        }
    }
}
