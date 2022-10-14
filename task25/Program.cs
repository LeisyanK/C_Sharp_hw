using System;

namespace task25
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишите цикл, который принимает на вход 
два числа (A и B) и возводит число A в натуральную 
степень B.*/
            int DegreeNum(int a, int b)
            {
                int degree = a;
                for (int i = 2; i < b+1; i++)
                {
                    degree *= a;
                }
                return degree;
            }

            Console.WriteLine("Введите числo А:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите числo B:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"{a} в степени {b} равно {DegreeNum(a,b)}");
        }
    }
}
