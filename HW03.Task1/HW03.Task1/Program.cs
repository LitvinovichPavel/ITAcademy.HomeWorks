using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // явное преобразование
            // 1 пример
            int peopleCity = 2_000_000;
            byte peopleVillage = (byte)peopleCity;
            Console.WriteLine($"явное преобразование. до преобразования значение = {peopleCity},\n после преобразования значение = {peopleVillage}\n");

            // 2 пример
            decimal num111 = 1234567.89M;
            int num222 = (int)num111;
            Console.WriteLine($"явное преобразование. до преобразования значение = {num111},\n после преобразования значение = {num222}\n");

            // 3 пример
            long @long = -9_223_222_222;
            sbyte @sbyte = (sbyte)@long;
            Console.WriteLine($"явное преобразование. до преобразования значение =  {@long},\n после преобразования значение = {@sbyte}\n");

            // неявное преобразование
            // 1 пример
            byte number1 = 5;
            byte number2 = 122;
            int sum1 = number1 + number2;
            Console.WriteLine($"неявное преобразование sum1 = {sum1}\n");

            // 2 пример
            int number3 = 12345;
            double number4 = number3;
            Console.WriteLine($"неявное преобразование number4 = {number4}\n");

            // 3 пример
            short number5, number6;
            int sum2;
            number5 = 32_767;
            number6 = 32_767;
            sum2 = number5 + number6;
            Console.WriteLine($"неявное преобразование sum2 = {sum2}\n");

            // Boxing
            byte boxByte = 33;
            int boxInt = 44;
            double boxDouble = 55;

            object obj1 = boxByte;
            object obj2 = boxInt;
            object obj3 = boxDouble;

            // Unboxing
            int unBox1 = (byte)obj1;
            int unBox2 = (int)obj2;
            double unBox3 = (double)obj3;

            Console.WriteLine($"obj1 = {obj1}");
            Console.WriteLine($"obj2 = {obj2}");
            Console.WriteLine($"obj3 = {obj3}");
        }
    }
}