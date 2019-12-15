using System;

namespace HW04._1_Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter;                         //объявляю переменную символьного типа, называю ее "letter"
            for (int i = 90; i > 64; i--)        //запускаю цикл for в котором осуществляется перебор значений от 90(Z) до 65(A), при каждом шаге уменьшая значение на единицу
            {
                letter = Convert.ToChar(i);      //метод Convert.ToChar преобразует указанное значение в символ юникода
                Console.Write(letter + " ");     //выводит символ на консоль
            }
        }
    }
}
