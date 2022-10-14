using System;

namespace task24
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу, которая 
принимает на вход число (А) и выдаёт сумму чисел 
от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
            int GetSumNums(int number)
            {
                int sum = 0;
                while (number > 0)
                {
                    sum += number;
                    number--;
                }
                return sum;
            }

            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма чисел равна {GetSumNums(num)}");
        }
    }
}
