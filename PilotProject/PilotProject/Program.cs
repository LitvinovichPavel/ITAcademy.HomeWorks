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
            //newUser.Hello();                                //приветствие
            //newUser.EnterUserName();    //покупатель вводит имя
            newUser.PhoneNumber();
            newUser.Location(out string userCity, out string userStreet, out ushort userHouseNumber);


            /*
            var priceAll = new PriceAll();
            priceAll.PriceAllBeverages();
            priceAll.PriceAllMaki();
            priceAll.PriceAllSets();
            
            Console.WriteLine($"TOTAL: {priceAll.Total():#.##}");
            */
            
        }
    }
}
