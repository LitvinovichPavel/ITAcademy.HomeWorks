using System;
using System.Collections.Generic;
using System.Text;

namespace hm_09.airport
{
    class CheckIn
    {
        private const byte _massLimitLuggage = 23;               // лимит массы багажа в кг.
        private const byte _massLimitHandLuggage = 8;            // лимит массы ручной клади в кг.
        private const byte _priceExscessWeidhtLuggage = 10;      // доплата за перевес каждого кг. багажа
        private const byte _priceExscessWeidhtHand = 12;         // доплата за перевес кучной клади
        public void HelloCheckIn()
        {
            Console.WriteLine("*****Стойка регистрации*****");
        }
        public void Ticket()
        {
            Console.WriteLine(" Покажите Ваш паспорт и посадочный талон");
            Console.WriteLine(" Спасибо! Вот ваш билет и паспорт.\n Ваше место A12");
        }
        public void LuggageSuitCase() // проверяем багаж
        {
            Console.Write("У Вас есть багаж? (да/нет): ");
            string questionLuggage;
            questionLuggage = Console.ReadLine();

            if (questionLuggage.Equals("да") || questionLuggage.Equals("ДА") || // на случай если не будет переключена
                questionLuggage.Equals("lf") || questionLuggage.Equals("LF"))   // клавиатура на русский язык
            {
                Console.WriteLine("Положите свой багаж на ленту.");

                byte massLuggage;
                massLuggage = (byte)new Random().Next(1, 50); // делаем вес багажа рандомным
                Console.WriteLine($"Масса Вашего багажа составляет {massLuggage} кг");
                // создаем ситуацию, когда необходимо доплачивать за перевес багажа
                if (massLuggage > _massLimitLuggage)    // т.к. есть лимиты по бесплатному провозу багажа,
                                                        // расчитываем доплату за перевес
                {
                    byte massBigger;
                    massBigger = (byte)(massLuggage - _massLimitLuggage);
                    uint moneyLuggage;
                    moneyLuggage = (uint)(_priceExscessWeidhtLuggage * massBigger);
                    Console.WriteLine($"Превышение составляет {massBigger}кг.\nНеобходимо доплатать {moneyLuggage}$ " +
                                      $"({_priceExscessWeidhtLuggage}$ за каждый кг.)");
                }
                else
                {
                    Console.WriteLine("Превышения массы багажа нет! Доплачивать не придется!");
                }
            }
            else
            {
                Console.WriteLine("Ясно, багаж отсутствует!");
            }
        }
        public void LuggageHand()     // проверяем ручную кладь
        {
            Console.Write("У Вас есть ручная кладь (да/нет)?: ");
            string questionHandLuggage;
            questionHandLuggage = Console.ReadLine();

            if (questionHandLuggage.Equals("да") || questionHandLuggage.Equals("ДА") || // на случай если не будет переключена
                questionHandLuggage.Equals("lf") || questionHandLuggage.Equals("LF"))   // клавиатура на русский язык
            {
                Console.WriteLine("Положите свою ручную кладь на весы.");

                byte massHandLuggage;
                massHandLuggage = (byte)new Random().Next(1, 25);
                Console.WriteLine($"Масса ручной клади составляет {massHandLuggage}");

                if (massHandLuggage > _massLimitHandLuggage)
                {
                    byte massBiggerHand;
                    massBiggerHand = (byte)(massHandLuggage - _massLimitHandLuggage);
                    uint moneyHand;
                    moneyHand = (uint)(_priceExscessWeidhtHand * massBiggerHand);
                    Console.WriteLine($"Превышение составляет {massBiggerHand}кг.\nНеобходимо доплатать {moneyHand}$ " +
                                      $"({_priceExscessWeidhtHand}$ за каждый кг.)");
                }
                else
                {
                    Console.WriteLine("Превышения массы ручной клади нет! Доплачивать не придется!");
                }
            }
            else
            {
                Console.WriteLine("Понятно! Ручная кладь отсутствует!");
            }
        }
        public void GoToSecurity()
        {
            Console.WriteLine($"Проходите далее на досмотр!");
        }
    }
}
