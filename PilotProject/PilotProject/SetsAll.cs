using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class SetsAll : IPrice
    {
        //Данный класс предназначен для:
        //*перечисления перечень имеющихся в меню сетов, массу порции и их цену,
        //*запроса и ввода необходимого количества порций,
        //*расчета стоимости.
        public void Question()
        {
            //В данном методе перечисляем все сеты, массу и их цену.
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
            Console.WriteLine($"Из сетов можем предложить Вам: \n{titleSet1} {massSet1}л {priceSet1}руб,\n" +
                $"{titleSet2} {massSet2}гр {priceSet2}руб,\n" +
                $"{titleSet3} {massSet3}гр {priceSet3}руб,\n" +
                $"{titleSet4} {massSet4}гр {priceSet4}руб\n");
            Console.WriteLine("Какой сет будете?");
        }
        public double Set1()
        {
            //Считаем стоимость за 1-й вариант сета.
            MenuJson.MethodMenu(out string titleDrink1, out string titleDrink2, out string titleDrink3,
            out string titleMaki1, out string titleMaki2, out string titleMaki3, out string titleMaki4,
            out string titleSet1, out string titleSet2, out string titleSet3, out string titleSet4,
            out double volumeDrink1, out double volumeDrink2, out double volumeDrink3,
            out double massMaki1, out double massMaki2, out double massMaki3, out double massMaki4,
            out double massSet1, out double massSet2, out double massSet3, out double massSet4,
            out double priceDrink1, out double priceDrink2, out double priceDrink3,
            out double priceMaki1, out double priceMaki2, out double priceMaki3, out double priceMaki4,
            out double priceSet1, out double priceSet2, out double priceSet3, out double priceSet4);

            Console.Write($"Сколько {titleSet1}?: ");
            ushort quantitySet1 = Convert.ToUInt16(Console.ReadLine());
            return priceSet1 * quantitySet1;
        }
        public double Set2()
        {
            //Считаем стоимость за 2-й вариант сета.
            MenuJson.MethodMenu(out string titleDrink1, out string titleDrink2, out string titleDrink3,
            out string titleMaki1, out string titleMaki2, out string titleMaki3, out string titleMaki4,
            out string titleSet1, out string titleSet2, out string titleSet3, out string titleSet4,
            out double volumeDrink1, out double volumeDrink2, out double volumeDrink3,
            out double massMaki1, out double massMaki2, out double massMaki3, out double massMaki4,
            out double massSet1, out double massSet2, out double massSet3, out double massSet4,
            out double priceDrink1, out double priceDrink2, out double priceDrink3,
            out double priceMaki1, out double priceMaki2, out double priceMaki3, out double priceMaki4,
            out double priceSet1, out double priceSet2, out double priceSet3, out double priceSet4);

            Console.Write($"Сколько {titleSet2}?: ");
            ushort quantitySet2 = Convert.ToUInt16(Console.ReadLine());
            return priceSet2 * quantitySet2;
        }
        public double Set3()
        {
            //Считаем стоимость за 3-й вариант сета.
            MenuJson.MethodMenu(out string titleDrink1, out string titleDrink2, out string titleDrink3,
            out string titleMaki1, out string titleMaki2, out string titleMaki3, out string titleMaki4,
            out string titleSet1, out string titleSet2, out string titleSet3, out string titleSet4,
            out double volumeDrink1, out double volumeDrink2, out double volumeDrink3,
            out double massMaki1, out double massMaki2, out double massMaki3, out double massMaki4,
            out double massSet1, out double massSet2, out double massSet3, out double massSet4,
            out double priceDrink1, out double priceDrink2, out double priceDrink3,
            out double priceMaki1, out double priceMaki2, out double priceMaki3, out double priceMaki4,
            out double priceSet1, out double priceSet2, out double priceSet3, out double priceSet4);

            Console.Write($"Сколько {titleSet3}?: ");
            ushort quantitySet3 = Convert.ToUInt16(Console.ReadLine());
            return priceSet3 * quantitySet3;
        }
        public double SetBig()
        {
            //Считаем стоимость за 4-й вариант сета.
            MenuJson.MethodMenu(out string titleDrink1, out string titleDrink2, out string titleDrink3,
            out string titleMaki1, out string titleMaki2, out string titleMaki3, out string titleMaki4,
            out string titleSet1, out string titleSet2, out string titleSet3, out string titleSet4,
            out double volumeDrink1, out double volumeDrink2, out double volumeDrink3,
            out double massMaki1, out double massMaki2, out double massMaki3, out double massMaki4,
            out double massSet1, out double massSet2, out double massSet3, out double massSet4,
            out double priceDrink1, out double priceDrink2, out double priceDrink3,
            out double priceMaki1, out double priceMaki2, out double priceMaki3, out double priceMaki4,
            out double priceSet1, out double priceSet2, out double priceSet3, out double priceSet4);

            Console.Write($"Сколько {titleSet4}?: ");
            ushort quantitySet4 = Convert.ToUInt16(Console.ReadLine());
            return priceSet4 * quantitySet4;
        }
        public double PriceProduct()
        {
            //Считаем общую стоимость за сеты.
            //Далее это значение используется в классе PriceAll
            return Set1() + Set2() + Set3() + SetBig();
        }
    }
}