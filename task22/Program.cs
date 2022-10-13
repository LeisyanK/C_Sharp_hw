using System;

namespace task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i < num + 1; i++)
            {
                Console.Write($"{i*i} ");
            }
        }
    }
}
