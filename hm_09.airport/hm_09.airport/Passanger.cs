using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09.airport
{
    class Passanger
    {
        private string _surname;                                 // фамилия пассажира
        private string _name;                                    // имя пассажира
        private string _patronymic;                              // отчество пассажира

        public void FullName()
        {
            Console.Write("Введите Вашу фамилию: ");
            string nameSurname;
            nameSurname = Console.ReadLine();
            Passanger surname = new Passanger();
            surname.Surname = nameSurname;

            Console.Write("Введите Ваше имя: ");
            string nameName;
            nameName = Console.ReadLine();
            Passanger name = new Passanger();
            name.Name = nameName;

            Console.Write("Введите Ваше отчество: ");
            string namePatronymic;
            namePatronymic = Console.ReadLine();
            Passanger patronymic = new Passanger();
            patronymic.Patronymic = namePatronymic;
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Patronymic
        {
            get
            {
                return _patronymic;
            }
            set
            {
                _patronymic = value;
            }
        }
    }
}
