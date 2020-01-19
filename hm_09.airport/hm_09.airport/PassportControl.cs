using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09.airport
{
    class PassportControl
    {
        private string passportSerNum;
        public void Passport()
        {
            Console.Write("*****Паспортный контроль*****\n Укажите серию и номер Вашего паспорта: ");
            passportSerNum = Console.ReadLine();
            Console.WriteLine(" Виза есть! Документы в полном порядке! Удачного полета!");
            Console.ReadKey();
        }
    }
}
