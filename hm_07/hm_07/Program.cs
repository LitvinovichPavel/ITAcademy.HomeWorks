using System;
using System.Collections.Generic;
using System.Linq;

namespace hm_07
{
    class Program
    {
        static void Main(string[] args)
        {
            string lineFirst;
            lineFirst = "Но мы все-таки приходим в кино. До начала сеанса еще минут пятнадцать." +
                " Мы стоим посреди фойе и слушаем певицу, но ее плохо слышно: возле нас много народу," +
                " и все потихоньку разговаривают. Я давно заметил, что те, кто стоит в фойе, плохо" +
                " слушают оркестр. Слушают и аплодируют только передние, а сзади едят мороженое и" +
                " конфеты и тихо переговариваются. Решив, что певицу все равно не услышишь как следует," +
                " я принимаюсь разглядывать картины. Я никогда раньше не обращал внимания на них, но" +
                " теперь я очень заинтересован. Я думаю о художниках, которые их нарисовали. Видимо, не" +
                " зря повесили эти картины в фойе. Очень хорошо, что они висят тут.\n";

            Task1();
            Task2(lineFirst);
        }

        static void Task1()
        {
            Console.WriteLine("Хочешь получить подарок от дедушки Мороза? " +
                "Тогда введи стишок (на русском языке)\nв одну строку, разделяя строки точкой с запятой");
            string poem;
            poem = Console.ReadLine();

            char[] arrayCopy = poem.ToCharArray(); //массив символов

            for (int i = 0; i < arrayCopy.Length; i++) //заменяем О на А
            {
                if (arrayCopy[i] == 'О')
                {
                    arrayCopy[i] = 'А';
                }

                if (arrayCopy[i] == 'о')
                {
                    arrayCopy[i] = 'а';
                }
            }

            for (int i = 0; i < arrayCopy.Length; i++) //разбиваем на столбики
            {
                if (arrayCopy[i] != ';')
                {
                    Console.Write(arrayCopy[i]);
                }
                else
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static void Task2(string lineFirst)
        {
            string lineSecond;
            lineSecond = lineFirst;
            Console.WriteLine($"Исходный текст:\n{lineSecond}");

            string[] str = lineSecond.Split(new Char[] { ' ', ',', '.', ':', '!', '?', ';', '-' },
                                                        StringSplitOptions.RemoveEmptyEntries);

            int maxlen = 0;
            int indexMax = 0;
            int minlen = int.MaxValue;
            int indexMin = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > maxlen) //ищем самое длинное слово
                {
                    maxlen = str[i].Length;
                    indexMax = i;
                }

                if (str[i].Length < minlen) //ищем самое короткое слово
                {
                    minlen = str[i].Length;
                    indexMin = i;
                }
            }

            string longWord = str[indexMax]; // самое длинное слово
            string shortWord = str[indexMin]; //самое короткое слово

            lineSecond = lineSecond.Replace(longWord, string.Empty); // удаляем самое длинное слово
            lineSecond = lineSecond.Replace(longWord, shortWord); //меняем слова местами
            lineSecond = lineSecond.Replace(shortWord, longWord);

            int countGeneral = 0;
            int countTotal = 0;
            int countSign = 0;

            for (int i = 0; i < lineSecond.Length; i++) //считаем символы и знаки
            {
                countTotal++;

                if (lineSecond[i] == ' ' || lineSecond[i] == '.' || lineSecond[i] == ',' || lineSecond[i] == '!' ||
                    lineSecond[i] == '(' || lineSecond[i] == ')' || lineSecond[i] == '"' || lineSecond[i] == '?' ||
                    lineSecond[i] == ':' || lineSecond[i] == '-')
                {
                    countGeneral++;
                }

                if (lineSecond[i] == '-' || lineSecond[i] == '.' || lineSecond[i] == ',' || lineSecond[i] == '!' ||
                    lineSecond[i] == '(' || lineSecond[i] == ')' || lineSecond[i] == '"' || lineSecond[i] == '?' ||
                    lineSecond[i] == ':')
                {
                    countSign++;
                }
            }

            Console.WriteLine($"Количество букв: {countTotal - countGeneral}");
            Console.WriteLine($"Количество пунктуационных знаков: {countSign}");

            lineSecond = lineSecond.Replace("   ", " ");
            lineSecond = lineSecond.Replace("  ", " ");

            string[] arrayStr = lineSecond.Split(' ', ',', '.', '-');

            IEnumerable<string> query = from word in arrayStr //сортируем массив
                                        orderby word.Length
                                        select word;

            foreach (string item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}