using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[100];
            for (int i = 0; i < mass.Length; i++)
            {
                Random rnd = new Random();
                mass[i] = rnd.Next(100);
            }

            for (int i = 0; i < mass.Length; i++)
            {
                Console.WriteLine(mass[i] + " ");
            }

            int min = int.MaxValue;
            int max = int.MinValue;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] > max)
                {
                    max = mass[i];
                }
                if (mass[i] < min)
                {
                    min = mass[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное число: " + max);
            Console.WriteLine("Минимальное число: " + min);
        }
    }
}
