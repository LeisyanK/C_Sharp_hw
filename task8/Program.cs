using System;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Четные числа в диапазоне от 1 до " + N + ":");
            for (int i=2; i<=N; i+=2)
            {
                Console.Write(i + " ");
            }
        }
    }
}
