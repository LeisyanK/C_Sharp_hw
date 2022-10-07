using System;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int N = int.Parse(Console.ReadLine());

            int i = N * (-1);
            while (i <= N)
            {
                Console.Write(i + " ");
                i++;
            }
        }
    }
}
