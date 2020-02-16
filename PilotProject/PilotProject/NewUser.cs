using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class NewUser : Menu//, IUser
    {
        public const string greeting = "Здравствуйте!";
        public void Hello()                            //приветствие
        {
            Console.WriteLine(greeting);
        }
        public int OrderNumber()                       //присваиваем заказу номер
        {
            Random randomOrderNumber = new Random();
            return randomOrderNumber.Next(111111, 555555);
        }
        public string EnterUserName()                       //пользователь сообщает свое имя
        {
            Console.Write("Введите Ваше имя: ");
            string userName = Console.ReadLine();
            return $"Покупатель: {userName}";
        }
        public void OutputName()
        {
            EnterUserName();//?????????????????????????????
        }
        public string PhoneNumber()                    //ввод номера телефона и проверка правильности ввода номера
        {
            Console.Write("\nВведите номер Вашего телефона: +375");
            string userPhoneNumberStr;
            int userPhoneNumberInt;
            userPhoneNumberStr = Console.ReadLine();

            if (userPhoneNumberStr.Length > 9)
            {
                Console.WriteLine("\a!!! Введен слишком длинный номер !!!");
                PhoneNumber();
            }
            else if (userPhoneNumberStr.Length < 9)
            {
                Console.WriteLine("\a!!! Введен слишком короткий номер !!!");
                PhoneNumber();
            }
            else
            {
                userPhoneNumberInt = Convert.ToInt32(userPhoneNumberStr);
                int checkNumber;
                checkNumber = userPhoneNumberInt / 10_000_000;
                
                if (checkNumber.Equals(29) || checkNumber.Equals(33) || checkNumber.Equals(44) || 
                    checkNumber.Equals(25) || checkNumber.Equals(17))
                {
                    //Console.WriteLine($"Телефон №: +375{userPhoneNumberInt}");
                }
                else
                {
                    Console.WriteLine("\a!!! В нашей стране мобильного оператора с данным кодом нет !!!");
                    PhoneNumber();
                }
            }
            return userPhoneNumberStr;                 //возвращаем номер телефона
        }
        public void Location(out string userCity, out string userStreet, out ushort userHouseNumber)                         //адрес доставки
        {
            Console.Write("Введите город: ");
            userCity = Console.ReadLine();
            Console.Write("Введите улицу: ");
            userStreet = Console.ReadLine();
            Console.Write("Введите номер дома: ");
            userHouseNumber = Convert.ToUInt16(Console.ReadLine());
        }
    }
}
