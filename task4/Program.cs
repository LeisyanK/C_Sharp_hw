using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три числа:");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            if ((num1 > num2) && (num1 > num3)) Console.WriteLine("Максимальное число - " + num1);
            else if (num2 > num3) Console.WriteLine("Максимальное число - " + num2);
            else Console.WriteLine("Максимальное число - " + num3);
        }
    }
}
