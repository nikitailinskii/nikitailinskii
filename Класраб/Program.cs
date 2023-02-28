using System;
using static System.Console;

namespace Класраб
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1.Найти максимальное значение. о.м и его индекс
            /*   int[] array = { -3, 4, 0, 18, 9, -2, 11 };
               int max = -3;
               int indexMax = 0;
               for (int i = 1; i < array.Length; i++) 
               {
                   if (array[i] > max)
                   {
                       max = array[i];
                       indexMax = i;
                   }
               }
               Console.WriteLine($"max={max}\tindexMax={indexMax}");
               Console.ReadKey(); */

            // Задача 1.1 мин знач
            /*  int[] array = { -3, 4, 0, 18, -9, -2, 11 };
              int min = -3;
              int indexMin = 0;
              for (int i = 1; i < array.Length; i++)
              {
                  if (array[i] < min)
                  {
                      min = array[i];
                      indexMin = i;
                  }
              }
              Console.WriteLine($"min={min}\tindexMin={indexMin}");
              Console.ReadKey(); */

            // Задание 2
            /*  int n;
              Write("Введи размерность о.м");

              n = Convert.ToInt32(ReadLine());
              Random rand = new Random();
              int[] arr = new int[n];
              int max = arr[0], min = arr[0], indexMin = 0, indexMax = 0;

              for (int i = 0; i < arr.Length; i++)
              {
                  arr[i] = rand.Next(-10,10) ;
                  WriteLine(arr[i]);
              }

              for (int i = 0; i < arr.Length; i++)
              {
                  if (arr[i] > max)
                  {
                      max = arr[i];
                      indexMax = i;
                  }
                  if (arr[i] < min)
                  {
                      min = arr[i];
                      indexMin = i;
                  }
              }

             /* int[] b = arr[indexMax];
              arr[indexMax] = arr[indexMin];
              arr[indexMin] = b; */
            /*  for (int i = 0; i < arr.Length; i++)
              {
                  WriteLine($"arr[{i}]={arr[i]}");
              }
              ReadKey(); */

            // Задание 3

            /*int n;
              Write("Введи размерность о.м - ");

              n = Convert.ToInt32(ReadLine());
              Random rand = new Random();
              int[] arr = new int[n];
              int max = arr[0], min = arr[0];

              for (int i = 0; i < arr.Length; i++)
              {
                  arr[i] = rand.Next(-10, 10);
                  WriteLine(arr[i]);
              }
              int count = n - 2;
              Write($"Количество элементов между минимальным и максимальным элементами = {count}"); */

            // Задание 4
            int n;
            Write("Введи размерность о.м : ");

            n = Convert.ToInt32(ReadLine());
            Random rand = new Random();
            int[] arr = new int[n];
            int max = arr[0], min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[0]+ n + rand.Next(-10, 10);
                WriteLine(arr[i]);
            }
            ReadKey();
        }
    }
}
