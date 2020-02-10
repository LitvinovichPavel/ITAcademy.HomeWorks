using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class User : Menu, IUser
    {
        public const string greeting = "Здравствуйте!";
        public User()                                  //конструктор
        {

        }
        public int OrderNumber()                       //присваиваем заказу номер
        {
            Random randomOrderNumber = new Random();
            return randomOrderNumber.Next(111, 555);
        }
        public void UserName()                       //пользователь сообщает свое имя
        {
            Console.Write("Введите Ваше имя: ");
            string enterUserName;
            enterUserName = Console.ReadLine();
            Console.WriteLine($"Покупатель: {enterUserName}");
        }
        public void PhoneNumber()                    //ввод номера телефона
        {
            Console.Write("Введите номер Вашего телефона: +375");
            string userPhoneNumberStr;
            int userPhoneNumberInt;
            userPhoneNumberStr = Console.ReadLine();

            if (userPhoneNumberStr.Length > 9)
            {
                Console.WriteLine("Введен слишком длинный номер!");
            }
            else if (userPhoneNumberStr.Length < 9)
            {
                Console.WriteLine("Введен слишком короткий номер!");
            }
            else
            {
                userPhoneNumberInt = Convert.ToInt32(userPhoneNumberStr);
                int checkNumber;
                checkNumber = userPhoneNumberInt / 10_000_000;
                if (checkNumber.Equals(29) || checkNumber.Equals(33) || checkNumber.Equals(44) || 
                    checkNumber.Equals(25) || checkNumber.Equals(17))
                {
                    Console.WriteLine($"Телефон №: +375{userPhoneNumberInt}");
                }
                else
                {
                    Console.WriteLine("В нашей стране мобильного оператора с данным кодом нет!");
                }
            }
        }
        public void Location()                         //адрес доставки
        {
            Console.Write("Введите город: ");
            string userCity;
            userCity = Console.ReadLine();
            Console.Write("Введите улицу: ");
            string userStreet;
            userStreet = Console.ReadLine();
            Console.Write("Введите номер дома: ");
            int userHouseNumber;
            userHouseNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}
