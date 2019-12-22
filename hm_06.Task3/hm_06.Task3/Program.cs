using System;
using System.Diagnostics;

namespace hm_06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64[] array1 = new Int64[100_000_000];             //создаем массив

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();                                   //запускаем таймер

            for (int i = 0; i < array1.Length; i++)              //записываем в массив случайные числа
            {
                Int64 num = new Random().Next(0, 1000);
                array1[i] = num;
            }
            stopwatch.Stop();                                    //останавливаем таймер
            Console.WriteLine("Время выполнения моего метода: " + stopwatch.Elapsed.ToString());

            stopwatch.Start();                                   //запускаем таймер
            Array.Reverse(array1);                               //делаем реверс массива
            stopwatch.Stop();                                    //останавливаем таймер
            Console.WriteLine("Время выполнения Reverse:      " + stopwatch.Elapsed.ToString());
            Console.ReadKey();
        }
    }
}
