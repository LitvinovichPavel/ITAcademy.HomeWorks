using System;
using System.Collections.Generic;
using System.Text;

namespace PilotProject
{
    class NewUser : Menu, IUser
    {
        public int UserPhoneNumber { get; set; }
        public void Hello()                                //приветствуем исходя из реального времеми
        {
            byte realHour = Convert.ToByte(DateTime.Now.Hour);

            if (realHour >= 5 && realHour < 11)
            {
                Console.WriteLine("Доброе утро!");
            }
            else if (realHour >= 11 && realHour < 18)
            {
                Console.WriteLine("Добрый день!");
            }
            else if (realHour >= 18 && realHour < 22)
            {
                Console.WriteLine("Добрый вечер!");
            }
            else
            {
                Console.WriteLine("Доброй ночи!");
            }
        }
        public static int OrderNumber()                              //присваиваем заказу номер
        {
            Random randomOrderNumber = new Random();
            return randomOrderNumber.Next(100000, 555555);
        }
        public void EnterUserName(out string userName)        //пользователь сообщает свое имя
        {
            Console.Write("Введите Ваше имя: ");
            userName = Console.ReadLine();
        }
        public int PhoneNumber()                              //ввод номера телефона и проверка правильности ввода
        {
            Console.Write("\nВведите номер Вашего телефона: +375");
            string userPhoneNumberStr;
            int userPhoneNumberInt;
            userPhoneNumberStr = Console.ReadLine();
            try
            {
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
                        UserPhoneNumber = userPhoneNumberInt;
                    }
                    else
                    {
                        Console.WriteLine("\a!!! В нашей стране мобильного оператора с данным кодом нет !!!");
                        PhoneNumber();
                    }
                }
            }
            catch(FormatException)
            {
                Console.WriteLine("!!! Введите число !!!");
                PhoneNumber();
            }

            return UserPhoneNumber;
        }                                                                             
        public void Location(out string userCity, out string userStreet,                    //адрес доставки
                             out string userHouseNumber, out string userNumberApartment)
        {
            Console.WriteLine("\n***********************************************************");
            Console.Write("Введите адрес доставки - ");
            Console.Write("город: ");
            userCity = Console.ReadLine();
            Console.Write("                         улица: ");
            userStreet = Console.ReadLine();
            Console.Write("                         номер дома: ");
            userHouseNumber = Console.ReadLine();
            Console.Write("                         номер квартиры: ");
            userNumberApartment = Console.ReadLine();
        }
    }
}
