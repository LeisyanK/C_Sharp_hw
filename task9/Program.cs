using System;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Наибольшая цифра двузначного числа
            Console.Clear();
            int num = new Random().Next(10, 100);
            int num1 = num / 10;
            int num2 = num % 10;

            if (num1 > num2)
            {
                Console.WriteLine($"Наибольшая цифра числа {num} равна {num1}");
            }
            else Console.WriteLine($"Наибольшая цифра числа {num} равна {num2}");
        }
    }
}
