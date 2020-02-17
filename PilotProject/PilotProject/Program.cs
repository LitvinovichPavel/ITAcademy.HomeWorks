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

            var newUser = new NewUser();
            newUser.Hello();                                                               //приветствие
            newUser.EnterUserName(out string userName);                                    //ввод имени

            var priceAll = new PriceAll();
            priceAll.PriceAllBeverages();
            priceAll.PriceAllMaki();
            priceAll.PriceAllSets();
            newUser.PhoneNumber();

            newUser.Location(out string userCity, out string userStreet,                   //ввод адреса доставки
                             out string userHouseNumber, out string userNumberApartment);

            Console.WriteLine("\n***********************************************************");
            Console.WriteLine($"\nЗака №: {NewUser.OrderNumber()}\n" +
                $"Сумма заказа: {priceAll.Total():#.##}\n" +
                $"Покупатель: {userName}\n" +
                $"Телефон: +375{newUser.DisplayNamber()}\n" +
                $"Адрес доставки: {userCity}, {userStreet}, {userHouseNumber}, {userNumberApartment}");
        }
    }
}
