using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Array
{
    class MyArray
    {
        int[] a;
        public MyArray(int arrayLenght, int number)
        {
            a = new int[arrayLenght];
            for (int i = 0; i < arrayLenght; i++)
                a[i] = number;
        }

        public MyArray(int arrayLenght, int firstElement, int step)
        {
            a = new int[arrayLenght];
            a[0] = firstElement;
            for (int i = 1; i < arrayLenght; i++)
                a[i] = a[i - 1] + step;
        }

        public MyArray(string filename)
        {
            if (File.Exists(filename))
            {
                string[] ss = File.ReadAllLines(filename);
                a = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                    a[i] = int.Parse(ss[i]);
            }
            else Console.WriteLine("Error load file");
        }

        public int Sum
        {
            get
            {
                int sum = 0;
                for (int i = 0; i < a.Length; i++)
                    sum += a[i];
                return sum;
            }
        }

        public int Inverse
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * -1;
            }
        }

        public int Multi
        {
            set
            {
                for (int i = 0; i < a.Length; i++)
                    a[i] = a[i] * value;
            }
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int MaxCount
        {
            get
            {
                int max = Max;
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] == max) count++;
                return count;
            }
        }

        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
}
