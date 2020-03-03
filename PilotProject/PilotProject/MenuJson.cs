using System;
using System.IO;
using System.Runtime.Serialization.Json;

namespace PilotProject
{
    class MenuJson
    {
        public static void MethodMenu(out string titleDrink1, out string titleDrink2, out string titleDrink3,
            out string titleMaki1, out string titleMaki2, out string titleMaki3, out string titleMaki4,
            out string titleSet1, out string titleSet2, out string titleSet3, out string titleSet4,
            out double volumeDrink1, out double volumeDrink2, out double volumeDrink3,
            out double massMaki1, out double massMaki2, out double massMaki3, out double massMaki4,
            out double massSet1, out double massSet2, out double massSet3, out double massSet4,
            out double priceDrink1, out double priceDrink2, out double priceDrink3,
            out double priceMaki1, out double priceMaki2, out double priceMaki3, out double priceMaki4,
            out double priceSet1, out double priceSet2, out double priceSet3, out double priceSet4)
        {
            //С помощию данного метода осуществляется присваивание значений полученных из json файла нашим переменным.
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(AllMenu));
            using (FileStream fs = new FileStream("C:/D/ReposGit/ITAcademy.HomeWorks/PilotProject/PilotProject/menuJson.json", FileMode.OpenOrCreate))
            {
                AllMenu menu = (AllMenu)formatter.ReadObject(fs);

                titleDrink1 = menu.Beverages[0].Title;      //название напитка
                titleDrink2 = menu.Beverages[1].Title;
                titleDrink3 = menu.Beverages[2].Title;
                volumeDrink1 = menu.Beverages[0].Volume;    //объем напитка
                volumeDrink2 = menu.Beverages[1].Volume;
                volumeDrink3 = menu.Beverages[2].Volume;
                priceDrink1 = menu.Beverages[0].Price;      //цена за единицу
                priceDrink2 = menu.Beverages[1].Price;
                priceDrink3 = menu.Beverages[2].Price;
                titleMaki1 = menu.Makis[0].Title;           //название маки роллов
                titleMaki2 = menu.Makis[1].Title;
                titleMaki3 = menu.Makis[2].Title;
                titleMaki4 = menu.Makis[3].Title;
                massMaki1 = menu.Makis[0].Mass;             //масса порции маки ролла
                massMaki2 = menu.Makis[1].Mass;
                massMaki3 = menu.Makis[2].Mass;
                massMaki4 = menu.Makis[3].Mass;
                priceMaki1 = menu.Makis[0].Price;           //цена за порцию маки ролла
                priceMaki2 = menu.Makis[1].Price;
                priceMaki3 = menu.Makis[2].Price;
                priceMaki4 = menu.Makis[3].Price;
                titleSet1 = menu.Sets[0].Title;             //название сета
                titleSet2 = menu.Sets[1].Title;
                titleSet3 = menu.Sets[2].Title;
                titleSet4 = menu.Sets[3].Title;
                massSet1 = menu.Sets[0].Mass;               //масса порции сета
                massSet2 = menu.Sets[1].Mass;
                massSet3 = menu.Sets[2].Mass;
                massSet4 = menu.Sets[3].Mass;
                priceSet1 = menu.Sets[0].Price;             //цена за порцию сета
                priceSet2 = menu.Sets[1].Price;
                priceSet3 = menu.Sets[2].Price;
                priceSet4 = menu.Sets[3].Price;
            }
        }
    }
    public class AllMenu
    {
        public Beverage[] Beverages { get; set; }
        public Maki[] Makis { get; set; }
        public Set[] Sets { get; set; }
    }
    public class Beverage
    {
        public string Title { get; set; }
        public double Volume { get; set; }
        public double Price { get; set; }
    }
    public class Maki
    {
        public string Title { get; set; }
        public double Mass { get; set; }
        public double Price { get; set; }
    }
    public class Set
    {
        public string Title { get; set; }
        public double Mass { get; set; }
        public double Price { get; set; }
    }
}
