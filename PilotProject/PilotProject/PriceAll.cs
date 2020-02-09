﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class PriceAll
    {
        public static double Price { get; set; }            //общая цена
        public static double PriceBeverages { get; set; }   //цена за напитки
        public static double PriceMaki { get; set; }        //цена за маки
        public static double PriceSets { get; set; }        //цена за сет
        public void PriceFoodAndDrink()
        {
            BeveragesAll beveragesAll = new BeveragesAll();
            PriceBeverages = beveragesAll.Beverages();

            Price = PriceBeverages + PriceMaki + PriceSets;
            Console.WriteLine($"Общий счет: {Price} рублей.");
        }
    }
}
