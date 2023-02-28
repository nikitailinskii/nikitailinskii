using System;
using static System.Console;
namespace Класраб__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("n = ");
            //Length свойство класса Array для оперделения размера о.м.
            byte n = byte.Parse(ReadLine());
            int[] arr = new int[n];

            //Цикл для заполнения о.м с помощью метода SetValue.
            for (int i = 0; i < arr.Length; i++)
            {
                Write($"arr[{i}]=");
                arr.SetValue(int.Parse(ReadLine()), i);
            }

            //Цикл вывода информации.
            /*  for (int i = 0; i < arr.Length; i++)
              {
                  WriteLine($"{arr.GetValue(i)}"); 
              }
            WriteLine();
            Array.Reverse(arr); */

            for (int i = 0; i < arr.Length; i++)
            {
                WriteLine($"{arr.GetValue(i)}");
            }
            Write($"\n");
            Array.Clear(arr, 2, 4);

            foreach(int el in arr)
            {
                Write($"{el}\n");
            }
            ReadKey();
        } 
    }
}
