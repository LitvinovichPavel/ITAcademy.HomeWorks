using System;

namespace hm_06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Вверите размерность массива: ");
                int arraySize;
                arraySize = int.Parse(Console.ReadLine());                   //задаем размерность массива

                int[] arrayStart = new int[arraySize];                       //создаем массив

                Array.Clear(arrayStart, 0, arrayStart.Length);               //очищаем массив

                for (int cell = 0; cell < arrayStart.Length - 1; cell++)     //заполняем массив с клавиатуры
                {
                    Console.Write($"Введите значение {cell} индекса массива: ");
                    int number = int.Parse(Console.ReadLine());
                    arrayStart[cell] = number;
                }

                Console.Write("Исходный массив: ");                           //выводим исходный массив

                foreach (int item in arrayStart)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                Console.Write("Введите еще одно значение: ");                 //задаем новое значение
                int numAdd;
                numAdd = int.Parse(Console.ReadLine());

                Console.Write($"Введите позицию в массиве в диапазоне от 0 до {arraySize - 1}: ");  //задаем позицию в массиве
                int position = int.Parse(Console.ReadLine());

                int[] arrayFinish = new int[arraySize];                     //создаем новый массив

                Array.Copy(arrayStart, 0, arrayFinish, 0, position); //Копируем элементы которые не будут смещаться из
                                                                     //исходного в конечный массив.
                arrayFinish[position] = numAdd;                      //Записываем новое значение по указонному индексу
                                                                     //в конечный массив.            
                for (int cell = position + 1; cell < arrayStart.Length; cell++)  //Переписываем оставшиеся элементы
                                                                                 //с учетом сдвига.
                {
                    arrayFinish[cell] = arrayStart[cell - 1];
                }

                Console.Write("Полученный массив: ");

                foreach (int item in arrayFinish)                   //Выводим полученный результат
                {
                    Console.Write(item + " ");
                }
            }
            catch
            {
                Console.WriteLine("Некорректный ввод");
            }
            Console.ReadKey();
        }
    }
}
