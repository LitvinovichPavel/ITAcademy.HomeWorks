using System;
using System.Text.Json;
using Newtonsoft.Json;
using System.Reflection;

namespace PilotProject
{
    class Program
    {
        static void Main(string[] args)
        {
            NewUser newUser = new NewUser();
            //Приветствуем пользователя.
            Console.WriteLine(NewUser.Hello());            

            PriceAll priceAll = new PriceAll();
            BeveragesAll beveragesAll = new BeveragesAll();
            //Перечисляем имеющиеся напитки.
            beveragesAll.Question();
            //Пользователь заказывает необходимое количество напитка.
            priceAll.PriceAllBeverages();                   

            MakisAll makisAll = new MakisAll();
            //Перечисляем имеющиеся маки роллы.
            makisAll.Question();
            //Пользователь заказывает необходимое количество маки роллов.
            priceAll.PriceAllMakis();                       

            SetsAll setsAll = new SetsAll();
            //Перечисляем имеющиеся сеты.
            setsAll.Question();
            //Пользователь заказывает необходимое количество сетов.
            priceAll.PriceAllSets();
            //Пользователь вводит свое имя.
            NewUser.EnterUserName(out string userName);
            //Пользователь вводит номер своего телефона.
            newUser.PhoneNumber();
            //Сообщается адрес доставки.
            newUser.LocationCity();                         
            newUser.LocationStreet();
            newUser.LocationNumberHouse();
            newUser.LocationNumberApartment();
            //Выводим информацию о заказе.
            Console.WriteLine($"\n\n**************************************************\n" +
                $"**************************************************\n" +
                $"{NewUser.Hello()}\n" +
                $"Покупатель: {userName}.\n" +
                $"Телефон: +375{newUser.UserPhoneNumber}.\n" +
                $"Адрес доставки: город {newUser.CityNames}, {newUser.StreetNames}, номер дома {newUser.NumberHouse} квартира {newUser.NumberApartment}\n" +
                $"Сумма заказа: {priceAll.Total():#.##}");
            //Отправляем сообщения на указанную электронную почту.
            MessageEmail messageEmail = new MessageEmail(); 
            messageEmail.EmailImput();
            messageEmail.Message();
            Console.ReadLine();
        }
    }
}
