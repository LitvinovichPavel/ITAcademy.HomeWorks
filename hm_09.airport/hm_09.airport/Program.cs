using System;

namespace hm_09.airport
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting greeting = new Greeting();
            greeting.Hello();                                // приветствие. зависит от реального времени суток

            Passanger passanger = new Passanger();
            passanger.FullName();                            // вводим данные пассажира

            CheckIn checkIn = new CheckIn();
            checkIn.HelloCheckIn();
            checkIn.Ticket();                                // выдача билета
            checkIn.LuggageSuitCase();                       // взвешивание багажа
            checkIn.LuggageHand();                           // взвешивание ручной клади
            checkIn.GoToSecurity();                          // приглашают пройти далее

            SecurityCheck securityCheck = new SecurityCheck();
            securityCheck.HelloSecurityCheck();               // приветствие
            securityCheck.SearchClothes();                    // досмотр на наличие запрещенных предметов
            securityCheck.SearchWeapons();                    // разбираемся есть ли оружие
            securityCheck.SearchMetalDetector();              // проходим металлодетектор
            securityCheck.GoToPassportControl();              // приглашают пройти далее

            PassportControl passportControl = new PassportControl();
            passportControl.Passport();                       // проходим паспортный контроль
        }
    }
}
