using System;

namespace Одномерные_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1

            /*   Console.Write($"Введите количество элементов массива:\t");

               int el = int.Parse(Console.ReadLine());
               int[] mas = new int[el];

               for (int i = 0; i < mas.Length; i++)
               {
                   Console.Write($"Введите элемент массива {i}:\t ");
                   mas[i] = int.Parse(Console.ReadLine());
               }


               Console.WriteLine("Вывод:");

               for (int i = 0; i < mas.Length; i++)
               {
                   Console.WriteLine(mas[i]);
               }
               Console.ReadKey(); */

            // 2

            /*    int[] mas = { 1, 4, 7, -5, 11 };

               for (int i = 0; i < mas.Length; i++)
               {
                   Console.WriteLine(mas[i]);
               }
               Console.ReadKey(); */

            // 3

            /*    int[] intArr;
                intArr = new int[5];
                foreach (int i in intArr) Console.WriteLine(i);    */

            // 4

         /*   Console.Write($"Введите количество элементов массива:\t");

            int el = int.Parse(Console.ReadLine());
            Random f = new Random();
            int[] a = new int[el];
            for (int i = 0; i < el; i++)
            {
                a[i] = f.Next(-20, 20);
            }
                foreach (int i in a) Console.WriteLine(i);
            Console.ReadKey(); */
        }
    }
}
