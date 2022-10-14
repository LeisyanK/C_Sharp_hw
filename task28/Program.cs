using System;

namespace task28
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу, которая 
принимает на вход число N и выдаёт 
произведение чисел от 1 до N.
4 -> 24 
5 -> 120*/
            int MultiplyNums(int number)
            {
                int multiply = 1;
                while (number > 0)
                {
                    multiply *= number;
                    number--;
                }
                return multiply;
            }

            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Произведение чисел равно {MultiplyNums(num)}");
        }
    }
}
