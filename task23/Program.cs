using System;

namespace task23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Кубы чисел от 1 до " + N + ":");
            for (int i=1; i < N+1; i++)
            {
                Console.Write(i*i*i + " ");
            }
        }
    }
}
