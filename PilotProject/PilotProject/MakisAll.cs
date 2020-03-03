using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class MakisAll : IPrice
    {
        //Данный класс предназначен для:
        //*перечисления перечень имеющихся в меню маки роллов, массу порции и их цену,
        //*запроса и ввода необходимого количества порций,
        //*расчета стоимости.
        public void Question()
        {
            //В данном методе перечисляем все маки роллы, массу и их цену.
            //Данные берем с файла json формата: menuJson.json
            MenuJson menuJson = new MenuJson();
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
            Console.WriteLine($"Из маки роллов можем предложить Вам: \n{titleMaki1} {massMaki1}л {priceMaki1}руб,\n" +
                $"{titleMaki2} {massMaki2}гр {priceMaki2}руб,\n" +
                $"{titleMaki3} {massMaki3}гр {priceMaki3}руб,\n" +
                $"{titleMaki4} {massMaki4}гр {priceMaki4}руб\n");
            Console.WriteLine("Какие маки будете?");
        }
        public double MakiAvokado()
        {
            //Считаем стоимость за 1-й вариант маки.
            MenuJson.MethodMenu(out string titleDrink1, out string titleDrink2, out string titleDrink3,
            out string titleMaki1, out string titleMaki2, out string titleMaki3, out string titleMaki4,
            out string titleSet1, out string titleSet2, out string titleSet3, out string titleSet4,
            out double volumeDrink1, out double volumeDrink2, out double volumeDrink3,
            out double massMaki1, out double massMaki2, out double massMaki3, out double massMaki4,
            out double massSet1, out double massSet2, out double massSet3, out double massSet4,
            out double priceDrink1, out double priceDrink2, out double priceDrink3,
            out double priceMaki1, out double priceMaki2, out double priceMaki3, out double priceMaki4,
            out double priceSet1, out double priceSet2, out double priceSet3, out double priceSet4);

            Console.Write($"Сколько {titleMaki1}?: ");
            ushort quantityMaki1 = Convert.ToUInt16(Console.ReadLine());
            return priceMaki1 * quantityMaki1;
        }
        public double MakiArizona()
        {
            //Считаем стоимость за 2-й вариант маки.
            MenuJson.MethodMenu(out string titleDrink1, out string titleDrink2, out string titleDrink3,
            out string titleMaki1, out string titleMaki2, out string titleMaki3, out string titleMaki4,
            out string titleSet1, out string titleSet2, out string titleSet3, out string titleSet4,
            out double volumeDrink1, out double volumeDrink2, out double volumeDrink3,
            out double massMaki1, out double massMaki2, out double massMaki3, out double massMaki4,
            out double massSet1, out double massSet2, out double massSet3, out double massSet4,
            out double priceDrink1, out double priceDrink2, out double priceDrink3,
            out double priceMaki1, out double priceMaki2, out double priceMaki3, out double priceMaki4,
            out double priceSet1, out double priceSet2, out double priceSet3, out double priceSet4);

            Console.Write($"Сколько {titleMaki2}?: ");
            ushort quantityMaki2 = Convert.ToUInt16(Console.ReadLine());
            return priceMaki2 * quantityMaki2;
        }
        public double MakiKarada()
        {
            //Считаем стоимость за 3-й вариант маки.
            MenuJson.MethodMenu(out string titleDrink1, out string titleDrink2, out string titleDrink3,
            out string titleMaki1, out string titleMaki2, out string titleMaki3, out string titleMaki4,
            out string titleSet1, out string titleSet2, out string titleSet3, out string titleSet4,
            out double volumeDrink1, out double volumeDrink2, out double volumeDrink3,
            out double massMaki1, out double massMaki2, out double massMaki3, out double massMaki4,
            out double massSet1, out double massSet2, out double massSet3, out double massSet4,
            out double priceDrink1, out double priceDrink2, out double priceDrink3,
            out double priceMaki1, out double priceMaki2, out double priceMaki3, out double priceMaki4,
            out double priceSet1, out double priceSet2, out double priceSet3, out double priceSet4);

            Console.Write($"Сколько {titleMaki3}?: ");
            ushort quantityMaki3 = Convert.ToUInt16(Console.ReadLine());
            return priceMaki3 * quantityMaki3;
        }
        public double MakiNara()
        {
            //Считаем стоимость за 4-й вариант маки.
            MenuJson.MethodMenu(out string titleDrink1, out string titleDrink2, out string titleDrink3,
            out string titleMaki1, out string titleMaki2, out string titleMaki3, out string titleMaki4,
            out string titleSet1, out string titleSet2, out string titleSet3, out string titleSet4,
            out double volumeDrink1, out double volumeDrink2, out double volumeDrink3,
            out double massMaki1, out double massMaki2, out double massMaki3, out double massMaki4,
            out double massSet1, out double massSet2, out double massSet3, out double massSet4,
            out double priceDrink1, out double priceDrink2, out double priceDrink3,
            out double priceMaki1, out double priceMaki2, out double priceMaki3, out double priceMaki4,
            out double priceSet1, out double priceSet2, out double priceSet3, out double priceSet4);

            Console.Write($"Сколько {titleMaki4}?: ");
            ushort quantityMaki4 = Convert.ToUInt16(Console.ReadLine());
            return priceMaki4 * quantityMaki4;
        }
        public double PriceProduct()
        {
            //Считаем общую стоимость за маки.
            //Далее это значение используется в классе PriceAll
            return MakiAvokado() + MakiArizona() + MakiKarada() + MakiNara();
        }
    }
}
