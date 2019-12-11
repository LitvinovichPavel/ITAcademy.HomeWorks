using System;
using System.IO;

namespace HW._02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.указываем файл из которого будет происходить считывание кода.
              2.считывается последовательный наборы символов
              3.создаем строчный массив
              4.создаем массив типа byte
              5.запускаем цикл for который перебирая поочередно нолики и единички из нашего текстового документа, конвертирует из в пиксели
              6.указывам место где будет сохранен сконвертированный файл и указываем его формат
              7.запускаем сборщик мусора для освобождения памяти
              8.пойду попантуюсь перед женой, что я крутой программист
            */
            
           StreamReader textReader = new StreamReader(@"C:\D\it\image.txt", true);
            string textReaderResult = textReader.ReadToEnd();
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                imageBytes[i] = binary;
            }

            File.WriteAllBytes(@"C:\D\it\image.png", imageBytes);
            textReader.Dispose();
        }
    }
}