using System;

namespace task0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            int sqr = number * number;
            Console.WriteLine("Квадрат числа " + number + " равен " + sqr);

        }
    }
}
