using System;

namespace task27
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу, которая принимает на 
вход число и выдаёт сумму цифр в числе.*/
            int SumNums(int number)
            {
                int sum = 0;
                while (number > 0)
                {
                    int num1 = number % 10;
                    number /= 10;
                    sum += num1;
                }
                return sum;
            }

            Console.WriteLine("Введите число:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine($"Сумма цифр равна {SumNums(num)}");
        }
    }
}
