using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class BeveragesAll : IPrice
    {
        //Данный класс предназначен для:
        //*вывода информации о имеющихся напитках (данные берутся из файла json формата: menuJson.json), 
        //*запроса и ввода необходимого количества единиц бутылок,
        //*расчета стоимости напитков.
        public void Question()
        {
            //В данном методе перечисляем все напитки, емкость и их цену.
            //Данные берем с файла json формата: menuJson.json
            MenuJson.MethodMenu(out string titleDrink1, out string titleDrink2, out string titleDrink3,
            out string titleMaki1, out string titleMaki2, out string titleMaki3, out string titleMaki4,
            out string titleSet1, out string titleSet2, out string titleSet3, out string titleSet4,
            out double volumeDrink1, out double volumeDrink2, out double volumeDrink3,
            out double massMaki1, out double massMaki2, out double massMaki3, out double massMaki4,
            out double massSet1, out double massSet2, out double massSet3, out double massSet4,
            out double priceDrink1, out double priceDrink2, out double priceDrink3,
            out double priceMaki1, out double priceMaki2, out double priceMaki3, out double priceMaki4,
            out double priceSet1, out double priceSet2, out double priceSet3, out double priceSet4);
            Console.WriteLine("\n***********************************************************");
            Console.WriteLine($"Из напитков можем предложить Вам: \n{titleDrink1} {volumeDrink1}л {priceDrink1}руб,\n" +
                $"{titleDrink2} {volumeDrink2}л {priceDrink2}руб,\n" +
                $"{titleDrink3} {volumeDrink3}л {priceDrink3}руб");
            Console.WriteLine("\nЧто будете пить?");
        }
        public double BeveragesFanta()
        {
            //Считаем стоимость за Fanta.
            MenuJson.MethodMenu(out string titleDrink1, out string titleDrink2, out string titleDrink3,
            out string titleMaki1, out string titleMaki2, out string titleMaki3, out string titleMaki4,
            out string titleSet1, out string titleSet2, out string titleSet3, out string titleSet4,
            out double volumeDrink1, out double volumeDrink2, out double volumeDrink3,
            out double massMaki1, out double massMaki2, out double massMaki3, out double massMaki4,
            out double massSet1, out double massSet2, out double massSet3, out double massSet4,
            out double priceDrink1, out double priceDrink2, out double priceDrink3,
            out double priceMaki1, out double priceMaki2, out double priceMaki3, out double priceMaki4,
            out double priceSet1, out double priceSet2, out double priceSet3, out double priceSet4);

            Console.Write($"Сколько {titleDrink1}?: ");
            ushort quantityWater1 = Convert.ToUInt16(Console.ReadLine());
            return priceDrink1 * quantityWater1;
        }
        public double BeveragesCola()
        {
            //Считаем стоимость за Coca-Cola.
            MenuJson.MethodMenu(out string titleDrink1, out string titleDrink2, out string titleDrink3,
            out string titleMaki1, out string titleMaki2, out string titleMaki3, out string titleMaki4,
            out string titleSet1, out string titleSet2, out string titleSet3, out string titleSet4,
            out double volumeDrink1, out double volumeDrink2, out double volumeDrink3,
            out double massMaki1, out double massMaki2, out double massMaki3, out double massMaki4,
            out double massSet1, out double massSet2, out double massSet3, out double massSet4,
            out double priceDrink1, out double priceDrink2, out double priceDrink3,
            out double priceMaki1, out double priceMaki2, out double priceMaki3, out double priceMaki4,
            out double priceSet1, out double priceSet2, out double priceSet3, out double priceSet4);

            Console.Write($"Сколько {titleDrink2}?: ");
            ushort quantityWater2 = Convert.ToUInt16(Console.ReadLine());
            return priceDrink2 * quantityWater2;
        }
        public double BeveragesWater()
        {
            //Считаем стоимость за воду
            MenuJson.MethodMenu(out string titleDrink1, out string titleDrink2, out string titleDrink3,
            out string titleMaki1, out string titleMaki2, out string titleMaki3, out string titleMaki4,
            out string titleSet1, out string titleSet2, out string titleSet3, out string titleSet4,
            out double volumeDrink1, out double volumeDrink2, out double volumeDrink3,
            out double massMaki1, out double massMaki2, out double massMaki3, out double massMaki4,
            out double massSet1, out double massSet2, out double massSet3, out double massSet4,
            out double priceDrink1, out double priceDrink2, out double priceDrink3,
            out double priceMaki1, out double priceMaki2, out double priceMaki3, out double priceMaki4,
            out double priceSet1, out double priceSet2, out double priceSet3, out double priceSet4);

            Console.Write($"Сколько {titleDrink3}?: ");
            ushort quantityWater3 = Convert.ToUInt16(Console.ReadLine());
            return priceDrink3 * quantityWater3;
        }
        public double PriceProduct()
        {
            //Считаем общую стоимость за напитки.
            //Далее это значение используется в классе PriceAll
            return BeveragesFanta() + BeveragesCola() + BeveragesWater();
        }
    }
}
