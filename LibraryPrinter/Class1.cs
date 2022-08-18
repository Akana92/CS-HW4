using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryPrinter
{
    public class Library
    {
        public static void PrintInfo(int homeworkNumber)
        {
            Console.WriteLine($"Домашняя работа: {homeworkNumber}");
            Console.WriteLine("Студент: Ыбыраев Канат");
            Console.WriteLine("========================================================================");
            Console.WriteLine();
        }
    }
}
