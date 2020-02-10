using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class MakiAll : Menu, IPrice
    {
        public const string avokadoMaki = "Авокадо маки (100гр)";
        public const string arizonaMaki = "Аризона маки (100гр)";
        public const string karadaMaki = "Карада маки (100гр)";
        public const string naraMaki = "Нара маки (100гр)";

        public const double priceAvokadoMaki = 5.6;
        public const double priceArizonaMaki = 6.2;
        public const double priceKaradaMaki = 5.1;
        public const double priceNaraMaki = 8.7;
        public void Maki()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Какие маки будете?");

            try
            {
                Console.Write($"Сколько хотите: {avokadoMaki}?: ");
                ushort quantityAvokadoMaki = Convert.ToUInt16(Console.ReadLine());
                Console.Write($"Сколько хотите: {arizonaMaki}?: ");
                ushort quantityArizonaMaki = Convert.ToUInt16(Console.ReadLine());
                Console.Write($"Сколько хотите: {karadaMaki}?: ");
                ushort quantityKaradaMaki = Convert.ToUInt16(Console.ReadLine());
                Console.Write($"Сколько хотите: {naraMaki}?: ");
                ushort quantityNaraMaki = Convert.ToUInt16(Console.ReadLine());

                var price = (priceArizonaMaki * quantityArizonaMaki) + (priceAvokadoMaki * quantityAvokadoMaki) +
                            (priceKaradaMaki * quantityKaradaMaki) + (priceNaraMaki * quantityNaraMaki);
                PriceMaki = price;
                Console.WriteLine(PriceMaki);
            }
            catch (FormatException)                  //в случае некорректного ввода срабатывает исключение
            {
                Console.WriteLine("\a\n***!!!Введите число!!!***\n");
                MakiAll makiAll = new MakiAll();
                makiAll.Maki();
            }
            catch (OverflowException)                //срабатывает если введено слишком большое число
            {
                Console.WriteLine("\a\n***Ого! У нас так много нет!***\n");
                MakiAll makiAll = new MakiAll();
                makiAll.Maki();
            }
        }
        public void PriceProduct()
        {
            MakiAll makiAll = new MakiAll();
            Console.WriteLine($"PRICE {makiAll.PriceMaki:#.##}");///////////////not price
        }
    }
}
