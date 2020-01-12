using System;
using System.Text;

namespace hm_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string strSymbol = "1a!2.3!!.. 4.!.?6 7! ..?";
            Task1(strSymbol);
        }

        static void Task1(string strSymbol)
        {
            string str1 = strSymbol;
            Console.WriteLine($"Исходная строка:\n{str1}");

            int indexTurn = str1.IndexOf("?"); //определяем положение вопросительного знака (?) в строке
            //разбиваем строку на две части (до и после вопросительного знака)
            string strStart; //до знака
            strStart = str1.Substring(0, indexTurn);
            strStart = strStart.Replace("!", string.Empty); //удалены восклицательные знаки до вопросительного знака

            string strEnd; //после знака
            strEnd = str1.Substring(indexTurn);
            strEnd = strEnd.Replace(" ", "_");

            StringBuilder sb = new StringBuilder(); //"склеиваем" обе части
            sb.Append(strStart).Append(strEnd);
            Console.WriteLine($"Конечная строка:\n{sb}");
        }
    }
}
