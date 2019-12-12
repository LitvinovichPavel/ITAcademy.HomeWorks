using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;



namespace HW04._2_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Задайте направление движения игрока с помощью клавиш W,S,A,D\nесли действий не требуется нажмите Q : ");
            char player;
            player = (char)Console.Read();
            
            switch (player)
            {
                case 'Q':
                case 'q':
                case 'Й':
                case 'й':
                    Console.WriteLine("Перемещение не требуется");
                    break;
                case 'W':
                case 'w':
                case 'Ц':
                case 'ц':
                    Console.WriteLine("Переместить вверх");
                    break;
                case 'S':
                case 's':
                case 'Ы':
                case 'ы':
                    Console.WriteLine("Переместить вниз");
                    break;
                case 'A':
                case 'a':
                case 'Ф':
                case 'ф':
                    Console.WriteLine("Переместить влево");
                    break;
                case 'D':
                case 'd':
                case 'В':
                case 'в':
                    Console.WriteLine("Перестить вправо");
                    break;
            }
            Console.ReadKey();
        }
    }
}
