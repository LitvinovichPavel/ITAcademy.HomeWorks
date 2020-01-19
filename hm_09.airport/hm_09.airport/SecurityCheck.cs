using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09.airport
{
    class SecurityCheck
    {
        private const string _prohibitedItem = "лезвие, канцелярский нож, ножницы,\nемкости более 100 мл и т.д.";
        public string answer;
        private const string questionWeapons = " У Вас имеются при себе оружие (да/нет)?: ";
        public void HelloSecurityCheck()
        {
            Console.WriteLine("*****Служба досмотра*****");
            Console.WriteLine(" Здравствуйте! Выложите из карманов все металлические предметы.");
        }
        public void SearchClothes()
        {
            Console.Write($" Вы везете запрещенные предметы, такие как: {_prohibitedItem}(да/нет)?: ");
            answer = Console.ReadLine();

            if (answer.Equals("да") || answer.Equals("ДА") || answer.Equals("lf") || answer.Equals("LF"))
            {
                Console.WriteLine(" Выложите эти предметы!");
            }
        }
        public void SearchWeapons()
        {
            Console.Write(questionWeapons); // имеется ли оружие
            answer = Console.ReadLine();

            if (answer.Equals("да") || answer.Equals("ДА") || answer.Equals("lf") || answer.Equals("LF"))
            {
                Console.Write(" Есть разрешение на ношение оружия(да/нет)?: ");
                answer = Console.ReadLine();

                if (answer.Equals("да") || answer.Equals("ДА") || answer.Equals("lf") || answer.Equals("LF"))
                {
                    Console.WriteLine(" Вам придется сдать оружие!\n В самолет с оружием нельзя!");
                }
                else
                {
                    Console.WriteLine(" !!!ОСТАВАТЬСЯ НА МЕСТЕ!!!\n ВЫ ЗАДЕРЖАНЫ ПО ПОДОЗРЕНИЮ " +
                                      "В НЕЗАКОННОМ НОШЕНИИ ОРУЖИЯ!!!");
                    System.Diagnostics.Process.GetCurrentProcess().Kill(); // т.к. нашего пассажира загребли
                                                                           // копы, программа останавливается :(((
                }
            }
        }
        public void SearchMetalDetector()
        {
            Console.Write(" Проходите через рамку металлодетектора. (нажмите ENTER)");
            Console.ReadLine();

            byte metalDetector;
            metalDetector = (byte)new Random().Next(0, 2);
            if (metalDetector == 1)  // разыгрываем ситуацию, когда металлодетектор сработал, т.к. не все
            {                        // металлические предметы были извлечены из одежды
                Console.WriteLine("\a\a\a"); // имитируем звук металлодетектора
                Console.WriteLine(" Сработал металлодетектор!\n Еще раз проверьте все карманы" +
                                  " и попробуйте пройти еще раз. (нажмите ENTER)");
                Console.ReadLine();
            }
        }
        public void GoToPassportControl()
        {
            Console.WriteLine(" Все хорошо!\n Следуйте далее для прохождения паспортного контроля!");
        }
    }
}
