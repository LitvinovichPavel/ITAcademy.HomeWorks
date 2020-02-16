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
        public void MakiQuestion()
        {
            Console.WriteLine("***********************************************************");
            Console.WriteLine("Какие маки будете?");
        }
        public double MakiAvokado()
        {
            Console.Write($"Сколько {avokadoMaki}?: ");
            ushort quantityAvokado = Convert.ToUInt16(Console.ReadLine());
            double allPriceAvokado = priceAvokadoMaki * quantityAvokado;
            return allPriceAvokado;
        }
        public double MakiArizona()
        {
            Console.Write($"Сколько {arizonaMaki}: ");
            ushort quantityArizona = Convert.ToUInt16(Console.ReadLine());
            double allPriceArizona = priceArizonaMaki * quantityArizona;
            return allPriceArizona;
        }
        public double MakiKarada()
        {
            Console.Write($"Сколько {karadaMaki}?: ");
            ushort quantityKarada = Convert.ToUInt16(Console.ReadLine());
            double allPriceKarada = priceKaradaMaki * quantityKarada;
            return allPriceKarada;
        }
        public double MakiNara()
        {
            Console.Write($"Сколько {naraMaki}?: ");
            ushort quantityNara = Convert.ToUInt16(Console.ReadLine());
            double allPriceNara = priceNaraMaki * quantityNara;
            return allPriceNara;
        }
        public double PriceProduct()
        {
            MakiQuestion();
            PriceMaki = MakiAvokado() + MakiArizona() + MakiKarada() + MakiNara();
            return PriceMaki;
        }
    }
}
