using System;

namespace task26
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу, которая принимает 
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/
            int CountNums(int number)
            {
                int count = 0;
                while (number > 0)
                {
                    number /= 10;
                    count++;
                }
                return count;
            }

            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Количество цифр равно {CountNums(num)}");
        }
    }
}
