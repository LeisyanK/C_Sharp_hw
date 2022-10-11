// Решение от преподавателя
using System;

namespace task13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Введите любое число:");
            int num = int.Parse(Console.ReadLine());
            //int num = new Random().Next(1, 100000);

            if (num < -99 || num > 99)
            {
                Console.Write("Третья цифра числа " + num);
                if (num < 0) num*=(-1);
                while (num >1000 )
                {
                    num = num / 10;
                }
                num = num % 10;
                Console.WriteLine($" равна {num}");
            }
            else
            {
                Console.WriteLine("Нет третьей цифры");
            }
        }
    }
}
