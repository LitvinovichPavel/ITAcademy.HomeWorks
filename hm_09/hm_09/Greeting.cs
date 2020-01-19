using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09
{
    class Greeting
    {
        private const string _nameAirport = "аэропорт имени Маши и Медведя"; // название аэропорта 
        public void Hello() // приветствие
        {
            byte realTime;
            realTime = Convert.ToByte(DateTime.Now.Hour); // приветствуем исходя из реального времени
            string timeOfDay;

            if (realTime >= 6 && realTime < 12)
            {
                timeOfDay = "Доброе утро! ";
            }
            else if (realTime >= 12 && realTime < 18)
            {
                timeOfDay = "Добрый день! ";
            }
            else if (realTime >= 18 && realTime < 21)
            {
                timeOfDay = "Добрый вечер! ";
            }
            else
            {
                timeOfDay = "Доброй ночи! ";
            }

            Console.WriteLine($"{timeOfDay}Вас приветствует {_nameAirport}!");
        }
    }
}
