using System;
using System.Collections.Generic;
using System.Text;

namespace PupilDiary
{
    class Menu
    {
        public static string AskPupiName()
        {
            Console.WriteLine("Please enter a pupil name:");
            return Console.ReadLine();
        }
        public static string AskMainMenuPoint() {
                Console.WriteLine("Please select an option (what do you want to do):");
                Console.WriteLine("1 - if you want to add a score to diary;");
                Console.WriteLine("2 - if you want program to show statisctics (max, min, average score);");
                Console.WriteLine("3 - if you want to exit this program.");
         return Console.ReadLine();
        }

        public static int AskLesson()
        {
            Console.WriteLine("Choose a lesson");
            Console.WriteLine("1 -Математика");
            Console.WriteLine("2 - Чтение");
            Console.WriteLine("3 - Природоведение");
            Console.WriteLine("4 - Физкультура");
            Console.WriteLine("5 - Письмо");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int ReadScope()
        {
            Console.WriteLine("Please enter a score:");
            return Convert.ToInt32(Console.ReadLine());
        }




        }
}
