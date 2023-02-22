using System;

namespace Masarr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            byte n = byte.Parse(Console.ReadLine());
            int[] array = new int[n];

              for (int i = 0; i < array.Length; i++)
              {
                  Console.Write($"array[{i}]=");
                  array.SetValue(int.Parse(Console.ReadLine()),i);
              }

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"{array.GetValue(i)}");
                }
                Console.ReadKey();
        }
    }
}
