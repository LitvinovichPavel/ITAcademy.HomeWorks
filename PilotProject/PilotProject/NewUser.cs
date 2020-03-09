using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace PilotProject
{
    class NewUser
    {
        //В данном классе осуществляется:
        //*приветствие пользователя,
        //*заказу присваивается индивидуальный номер,
        //*ввод имени пользователя,
        //*ввод данных необходимых для осуществления доставки (адрес, номер телефона).
        public string CityNames { get; set; }
        public string ChoiseCity { get; set; }
        public string StreetNames { get; set; }
        public string NumberHouse { get; set; }
        public string NumberApartment { get; set; }
        public int UserPhoneNumber { get; set; }
        public static string Hello()                                
        {
            //Приветствуем исходя из реального времеми.
            byte realHour = Convert.ToByte(DateTime.Now.Hour);

            if (realHour >= 5 && realHour < 11)
            {
                return "Доброе утро!";
            }
            else if (realHour >= 11 && realHour < 18)
            {
                return  "Добрый день!";
            }
            else if (realHour >= 18 && realHour < 22)
            {
                return "Добрый вечер!";
            }
            else
            {
                return "Доброй ночи!";
            }
        }
        public static int OrderNumberMethod()
        {
            //Присваиваем заказу номер.
            Random randomOrderNumber = new Random();
            return randomOrderNumber.Next(100000, 555555);
        }
        public static void EnterUserName(out string userName)        
        {
            //Пользователь вводит свое имя.
            Console.Write("\nВведите Ваше имя: ");
            userName = Console.ReadLine();
        }
        public int PhoneNumber()                              
        {
            //Ввод номера телефона.
            //Проверка корректности ввода номера.
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
                        Console.WriteLine("\a!!! В нашей стране мобильного оператора с данным кодом нет !!!\n" +
                            "(необходим 29, 33, 44, 25 ,17)");
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
        public void LocationCity()
        {
            //Пользователь сообщает город доставки.
            //В случае некорректного ввода программа просит ввести данные повторно.
            //Данные можно вводить как с помощью цифр (от 1 до 4), так и прописью.
            Console.WriteLine("\n***********************************************************");
            Console.Write("Введите адрес доставки : \n");
            Console.Write($"Где Вы живете: Минск (1)\n" +
                $"               Кобрин (2)\n" +
                $"               Лос-Анджелес (3).\nВыберите город (1-3): ");
            ChoiseCity = Console.ReadLine();

            if (ChoiseCity.Equals("1") || ChoiseCity.Equals("Минск") || ChoiseCity.Equals("минск"))
            {
                CityNames = "Минск";
            }
            else if (ChoiseCity.Equals("2") || ChoiseCity.Equals("Кобрин") || ChoiseCity.Equals("кобрин"))
            {
                CityNames = "Кобрин";
            }
            else if (ChoiseCity.Equals("3") || ChoiseCity.Equals("Лос-Анджелес") || ChoiseCity.Equals("лос-анджелес") ||
                     ChoiseCity.Equals("лос анджелес") || ChoiseCity.Equals("лосанджелес"))
            {
                CityNames = "Лос-Анджелес";
            }
            else
            {
                Console.Write("\a\n!!! Введено неверное значение !!!\n!!! Введите значение от 1 до 4 или напишите название города !!!" +
                    "\nПовторный ввод: ");
                LocationCity();
            }
        }
        public void LocationStreet()
        {
            //Пользователь сообщает улицу доставки, выбирая ее из предложенного перечня,
            // (ну да... в каждом городе всего по четыре улицы, т.к. я посчитал, что вводить больше смысла нет.)
            //В случае некорректного ввода программа просит ввести данные повторно.
            //Данные вводятся путем ввода цифр от 1 до 4.
            string streetMinsk1, streetMinsk2, streetMinsk3, streetMinsk4;
            string streetKobrin1, streetKobrin2, streetKobrin3, streetKobrin4;
            string streetLosAngeles1, streetLosAngeles2, streetLosAngeles3, streetLosAngeles4;
            DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(AllAddressJson));
            using (FileStream fs = new FileStream("C:/D/ReposGit/ITAcademy.HomeWorks/PilotProject/PilotProject/addressJson.json", FileMode.OpenOrCreate))
            {
                AllAddressJson address = (AllAddressJson)formatter.ReadObject(fs);
                streetMinsk1 = address.Minsk[0].Street;
                streetMinsk2 = address.Minsk[1].Street;
                streetMinsk3 = address.Minsk[2].Street;
                streetMinsk4 = address.Minsk[3].Street;
                streetKobrin1 = address.Kobrin[0].Street;
                streetKobrin2 = address.Kobrin[1].Street;
                streetKobrin3 = address.Kobrin[2].Street;
                streetKobrin4 = address.Kobrin[3].Street;
                streetLosAngeles1 = address.LosAngeles[0].Street;
                streetLosAngeles2 = address.LosAngeles[1].Street;
                streetLosAngeles3 = address.LosAngeles[2].Street;
                streetLosAngeles4 = address.LosAngeles[3].Street;
            }

            string choiseStreet;

            if (ChoiseCity.Equals("1") || ChoiseCity.Equals("Минск") || ChoiseCity.Equals("минск"))
            {
                Console.WriteLine($"Ваш город Минск.\nВыберите улицу для доставки (1-4): {streetMinsk1} (1)\n" +
                                  $"                                   {streetMinsk2} (2)\n" +
                                  $"                                   {streetMinsk3} (3)\n" +
                                  $"                                   {streetMinsk4} (4)");
                Console.Write($"Ваш выбор (1-4): ");
                choiseStreet = Console.ReadLine();

                if (choiseStreet.Equals("1"))
                {
                    StreetNames = streetMinsk1;
                }
                else if (choiseStreet.Equals("2"))
                {
                    StreetNames = streetMinsk2;
                }
                else if (choiseStreet.Equals("3"))
                {
                    StreetNames = streetMinsk3;
                }
                else if (choiseStreet.Equals("4"))
                {
                    StreetNames = streetMinsk4;
                }
                else
                {
                    Console.Write($"!!! Введено не верное значение !!!\nВведите значение от 1 до 4:");
                    LocationStreet();
                }
            }
            else if (ChoiseCity.Equals("2") || ChoiseCity.Equals("Кобрин") || ChoiseCity.Equals("кобрин"))
            {
                Console.WriteLine($"Ваш город Кобрин.\nВыберите улицу для доставки (1-4): {streetKobrin1} (1)\n" +
                                  $"                                   {streetKobrin2} (2)\n" +
                                  $"                                   {streetKobrin3} (3)\n" +
                                  $"                                   {streetKobrin4} (4)");
                Console.Write($"Ваш выбор (1-4): ");
                choiseStreet = Console.ReadLine();

                if (choiseStreet.Equals("1"))
                {
                    StreetNames = streetKobrin1;
                }
                else if (choiseStreet.Equals("2"))
                {
                    StreetNames = streetKobrin2;
                }
                else if (choiseStreet.Equals("3"))
                {
                    StreetNames = streetKobrin3;
                }
                else if (choiseStreet.Equals("4"))
                {
                    StreetNames = streetKobrin4;
                }
                else
                {
                    Console.Write($"!!! Введено не верное значение !!!\nВведите значение от 1 до 4:");
                    LocationStreet();
                }
            }
            else if (ChoiseCity.Equals("3") || ChoiseCity.Equals("Лос-Анджелес") || ChoiseCity.Equals("лос-анджелес") ||
                     ChoiseCity.Equals("лос анджелес") || ChoiseCity.Equals("лосанджелес"))
            {
                Console.WriteLine($"Ваш город Лос-Анджелес.\nВыберите улицу для доставки (1-4): {streetLosAngeles1} (1)\n" +
                                  $"                                   {streetLosAngeles2} (2)\n" +
                                  $"                                   {streetLosAngeles3} (3)\n" +
                                  $"                                   {streetLosAngeles4} (4)");
                Console.Write($"Ваш выбор (1-4): ");
                choiseStreet = Console.ReadLine();

                if (choiseStreet.Equals("1"))
                {
                    StreetNames = streetLosAngeles1;
                }
                else if (choiseStreet.Equals("2"))
                {
                    StreetNames = streetLosAngeles2;
                }
                else if (choiseStreet.Equals("3"))
                {
                    StreetNames = streetLosAngeles3;
                }
                else if (choiseStreet.Equals("4"))
                {
                    StreetNames = streetLosAngeles4;
                }
                else
                {
                    Console.Write($"!!! Введено не верное значение !!!\nВведите значение от 1 до 4:");
                    LocationStreet();
                }
            }
        }
        public void LocationNumberHouse()
        {
            //Пользователь вводит номер своего дома.
            //Пустая строка не может быть введена.
            Console.Write($"Введите номер Вашего дома: ");
            string userHouse = Console.ReadLine();
            userHouse = userHouse.Replace(" ", "");

            if (userHouse.Equals(""))
            {
                LocationNumberHouse();
            }
            else
            {
                NumberHouse = userHouse;
            }
        }
        public void LocationNumberApartment()
        { 
            //Пользователь вводит номер квартиры.
            Console.Write($"Введите номер квартиры: ");
            NumberApartment = Console.ReadLine();
        }
    }
}
