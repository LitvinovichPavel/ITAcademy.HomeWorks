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
        public enum MakiType
        {
            AvokadoMaki = 1,
            ArizonaMaki = 2,
            KaradaMaki = 3,
            NaraMaki = 4
        }
        public double Maki()
        {
            Console.Write("Какие маки будете?");
            Console.WriteLine($"Сколько хотите: {MakiType.AvokadoMaki}?: ");
            var quantityAvokadoMaki = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сколько хотите: {MakiType.ArizonaMaki}?: ");
            var quantityArizonaMaki = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сколько хотите: {MakiType.KaradaMaki}?: ");
            var quantityKaradaMaki = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сколько хотите: {MakiType.NaraMaki}?: ");
            var quantityNaraMaki = Convert.ToInt32(Console.ReadLine());

            var price = (priceArizonaMaki * quantityArizonaMaki) + (priceAvokadoMaki * quantityAvokadoMaki) +
                        (priceKaradaMaki * quantityKaradaMaki) + (priceNaraMaki * quantityNaraMaki);
            PriceMaki = price;
            return PriceMaki;
        }
        public void PriceProduct()
        {
            MakiAll makiAll = new MakiAll();
            makiAll.Maki();
            Console.WriteLine(makiAll.PriceMaki);
        }
    }
}
