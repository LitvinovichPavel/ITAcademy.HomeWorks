using System;

namespace hm_06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try                                                      //Проверка на случай, ели будет введено значение
            {                                                        //не соответстыующее типу int 
                Console.Write("Задайте размерность массива: ");
                int arrayValue;
                arrayValue = int.Parse(Console.ReadLine());           //Здесь мы задаем размерность для массивов
                if (arrayValue > 0)
                {
                    Console.WriteLine();

                    int[] array1 = new int[arrayValue];               //массив случайных чисел
                    for (int cell = 0; cell < array1.Length; cell++)
                    {
                        int ran = new Random().Next(-10, 10);
                        array1[cell] = ran;
                        Console.WriteLine($"Значение {cell} элемента массива случайных чисел = {ran}");
                    }
                    Console.WriteLine();

                    int[] array2 = new int[arrayValue];               //массив введенный с клавиатуры
                    for (int cell = 0; cell < array2.Length; cell++)
                    {
                        Console.Write($"Введите значение {cell} элемента второго массива: ");
                        int num2;
                        num2 = int.Parse(Console.ReadLine());
                        array2[cell] = num2;
                    }
                    Console.WriteLine();

                    int[] array3 = new int[arrayValue];               //третий (суммирующий) массив
                    for (int cell = 0; cell < array3.Length; cell++)
                    {
                        array3[cell] = array1[cell] + array2[cell];
                        Console.WriteLine($"Значение {cell} элемента третьего массива = {array3[cell]}");
                    }
                }
                else
                {
                    Console.WriteLine("Введено некорректное значение");
                }
            }
            catch
            {
                Console.WriteLine("Введено некорректное значение");
            }
            Console.ReadKey();
        }
    }
}
