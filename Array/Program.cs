using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryPrinter;

namespace Array
{
    internal class Program
    {
        static int GetInt()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод (требуется числовое значение).\nПожалуйста, повторите ввод: ");
                else return x;
        }
        static void Main(string[] args)
        {
            Library.PrintInfo(4);

            Console.WriteLine("Программа демонстрации возможностей класса для работы с массивом");
            Console.Write("Введите желаемый размер массива: ");
            int size = GetInt();
            Console.Write("Введите первый элемент массива: ");
            int firstElement = GetInt();
            Console.Write("Введите шаг для добавления последующих элементов: ");
            int step = GetInt();

            MyArray a = new MyArray(size, firstElement, step);

            Console.WriteLine("\nСоздан массив: [ " + a.ToString() + " ]\n");

            Console.WriteLine("Сумма элементов массива: " + a.Sum);

            a.Inverse = -1;

            Console.WriteLine("Массив с изменёнными знаками: [ " + a.ToString() + " ]\n");

            Console.Write("Введите число, на которое будут умножены элементы массива: ");

            a.Multi = GetInt();

            Console.WriteLine("Массив, умноженный на число: [ " + a.ToString() + " ]\n");

            Console.WriteLine("Максимальный элемент массива: " + a.Max);

            Console.WriteLine("Количество максимальных элементов массива: " + a.MaxCount);
        }
    }
}
