﻿using System;
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
                case 'Й':  //русские буквы введены не случай если какой-нибудь граматей забудет переключить на английскую раскладку клавиатуры
                case 'й':  //русские буквы введены не случай если какой-нибудь граматей забудет переключить на английскую раскладку клавиатуры
                    Console.WriteLine("Перемещение не требуется");
                    break;
                case 'W':
                case 'w':
                case 'Ц':  //русские буквы введены не случай если какой-нибудь граматей забудет переключить на английскую раскладку клавиатуры
                case 'ц':  //русские буквы введены не случай если какой-нибудь граматей забудет переключить на английскую раскладку клавиатуры
                    Console.WriteLine("Переместить вверх");
                    break;
                case 'S':
                case 's':
                case 'Ы':  //русские буквы введены не случай если какой-нибудь граматей забудет переключить на английскую раскладку клавиатуры
                case 'ы':  //русские буквы введены не случай если какой-нибудь граматей забудет переключить на английскую раскладку клавиатуры
                    Console.WriteLine("Переместить вниз");
                    break;
                case 'A':
                case 'a':
                case 'Ф':  //русские буквы введены не случай если какой-нибудь граматей забудет переключить на английскую раскладку клавиатуры
                case 'ф':  //русские буквы введены не случай если какой-нибудь граматей забудет переключить на английскую раскладку клавиатуры
                    Console.WriteLine("Переместить влево");
                    break;
                case 'D':
                case 'd':
                case 'В':  //русские буквы введены не случай если какой-нибудь граматей забудет переключить на английскую раскладку клавиатуры
                case 'в':  //русские буквы введены не случай если какой-нибудь граматей забудет переключить на английскую раскладку клавиатуры
                    Console.WriteLine("Перестить вправо");
                    break;
            }
            Console.ReadKey();
        }
    }
}
