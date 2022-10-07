using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа: ");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            if (number1 == number2 * number2)
            {
                Console.WriteLine("Число " + number1 + " является квадратом числа " + number2);
            }
            else
            {
                Console.WriteLine("Число " + number1 + " не является квадратом числа " + number2);
            }
        }
    }
}
