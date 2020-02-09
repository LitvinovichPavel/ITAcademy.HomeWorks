using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class MakiAll : Menu//, IPrice
    {
        public const string avokadoMaki = "Авокадо маки";
        public const string losiakiMaki = "Лосяки маки";
        public const string nesvezakiMaki = "Несвежаки маки";
        public const string mytoMaki = "Мутно маки";
        enum MakiType
        {
            AvokadoMaki = 1,
            LosiakiMaki = 2,
            NesvezakiMaki = 3,
            MytoMaki = 4
        }
        public void Maki()
        {
            Console.Write("Какие маки будете?: ");
            Console.Write($"\n1: {avokadoMaki}\n2: {losiakiMaki}\n3: {nesvezakiMaki}\n4: {mytoMaki} ");
            int choiseMaki;
            choiseMaki = Convert.ToInt32(Console.ReadLine());
        }
    }
}
