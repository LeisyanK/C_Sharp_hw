using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число:");
            int num = int.Parse(Console.ReadLine());

            if (num < 100 || num > 999)
            {
                Console.WriteLine("Вы ввели некорректное число");
            }
            else
            {
                int num1 = num / 10;
                int num2 = num1 % 10;
                Console.WriteLine($"Вторая цифра числа {num} равна {num2}");
            }
        }
    }
}
