using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 числа:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            if (number1 == number2) Console.WriteLine("Числа равны");
            else if (number1 > number2) Console.WriteLine(number1 + " больше " + number2);
            else Console.WriteLine(number2 + " больше " + number1);
        }
    }
}
