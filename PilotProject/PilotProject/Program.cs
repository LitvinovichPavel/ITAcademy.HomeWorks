using System;
using System.Text.Json;
using Newtonsoft.Json;

namespace PilotProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var newUser = new NewUser();
            newUser.Hello();                                                               //приветствие
            newUser.EnterUserName(out string userName);                                    //ввод имени
            newUser.PhoneNumber();                                                         //ввод номера телефона

            var priceAll = new PriceAll();
            priceAll.PriceAllBeverages();
            priceAll.PriceAllMaki();
            priceAll.PriceAllSets();

            newUser.Location(out string userCity, out string userStreet,                   //ввод адреса доставки
                             out string userHouseNumber, out string userNumberApartament);

            



            Console.WriteLine($"TOTAL: {priceAll.Total():#.##}");
            

        }
    }
}
