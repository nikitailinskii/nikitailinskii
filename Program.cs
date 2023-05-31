using System;

namespace zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.Write("x=");
             int x = int.Parse(Console.ReadLine());
             Console.WriteLine($"e={x % 10}\td={x / 10}");
             Console.ReadKey(); */


            /* Console.Write("x=");
             int x = int.Parse(Console.ReadLine());
             if (x>0)
             {
                 Console.WriteLine($"{x + 1}");
             }
             else
             {
                 Console.WriteLine($"{x - 2}");
             }
             Console.ReadKey();  */


            /* Console.Write("x=");
             int x = int.Parse(Console.ReadLine());
             if (x > 0)
             {
                 Console.WriteLine($"{x + 1}");
             }
             else if (x < 0) 
             {
                 Console.WriteLine($"{x - 2}");
             }
             else
             {
                 Console.WriteLine($"{x = 10}");
             }
             Console.ReadKey(); */


            /*   Console.Write("a="); //16 zad
               int a = int.Parse(Console.ReadLine());
               Console.Write("b=");
               int b = int.Parse(Console.ReadLine());            
               if (a == b)
               {
                   Console.WriteLine("Равносторонний");
               }
               else
               {
                   Console.WriteLine("Не равносторонний");
               }
               Console.ReadKey();  */


            /*  Console.Write("x=");
              int x = int.Parse(Console.ReadLine());
              if (x % 3 == 0)
              {
                  Console.Write("Число явл делителем числа 3");
              }
              else
              {
                  Console.Write("Число не явл делителем числа 3");              
              }
              Console.ReadKey(); */


            /* Random rnd = new Random(); //Создание объекта случайных чисел
             for (int x = 1; x <= 10; x++)
             {
                 int el = rnd.Next(-30, 30);
                 if (el > 0)
                 {
                     Console.WriteLine($"{el} - pol");
                 }
                 else
                 {
                     Console.WriteLine($"{el} - otr");
                 }
             }
             Console.ReadKey(); */


            /* for (int x = 1; x <= 11; x += 2) // 31 zad
             {
                 if (x != 3)
                 {
                     Console.Write($"{x}\t");
                 }                              
             }*/


            /* for (int x = 100; x <= 200; x++)
             {
                 if (x % 3 == 0)
                 {
                     Console.Write($"{x}\t");
                 }                   
             } */


            /* for (int x = 1; x <= 20; x++)
             {
                 Console.Write($"{x}шт = {x * 20.4:f1}руб\t");
             }*/


            /*  int[] mas = new int[6];
              for (int i = 0; i < mas.Length; i++)
              {
                  Console.Write($"[{i}]=");
                      mas[i] = int.Parse(Console.ReadLine());
              }
              foreach (var item in mas) 
              {
                  Console.WriteLine(item);
              }  */


            /*  int[] mas = new int[6];
              for (int i = 0; i < mas.Length; i++)
              {
                  Console.Write($"[{i}]=");
                  mas[i] = int.Parse(Console.ReadLine());
              }
              Array.Reverse(mas);
              foreach (var item in mas)
              {
                  Console.WriteLine(item);
              } */


            Random rnd = new Random(); // 37 zad
            double[] mas = new double[5];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.NextDouble() * 20 - 10;
            }
            foreach (var el in mas)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine();
        }
    }
}
