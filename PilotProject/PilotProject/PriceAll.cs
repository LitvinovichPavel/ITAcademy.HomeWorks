using System;
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
        public double PriceFoodAndDrink()
        {
            BeveragesAll beveragesAll = new BeveragesAll();
            PriceBeverages = beveragesAll.Beverages();
            MakiAll makiAll = new MakiAll();
            PriceMaki = makiAll.Maki();

            Price = PriceBeverages + PriceMaki + PriceSets;
            return Price;
        }
    }
}
