using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace masslinq
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("qwe.txt"))
            {
                StreamWriter sw = new StreamWriter("qwe.txt");
                Console.WriteLine("Введите колличество элементов массива: ");
                try
                {
                    int k = Convert.ToInt32(Console.ReadLine()); 
                    int[] a = new int[k];
                for (int i = 0; i < k; i++)
                {
                    Console.Write("Введите числo: ", i);
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                IEnumerable<int> ev = from i in a
                                      where i % 2 == 0
                                      select i;
                foreach (int i in ev)
                {
                    Console.WriteLine(i);
                    sw.Write(i);
                }
                sw.Close();
                }
                catch { Console.WriteLine("Вы ввели не число"); }
            }
            else
                Console.WriteLine("Файл не найден");      
        }
    }
}
