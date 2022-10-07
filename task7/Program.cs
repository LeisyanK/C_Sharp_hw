using System;

namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 99 && number < 1000)
            {
                Console.Write("Последняя цифра числа " + number);
                number = number % 10;
                Console.WriteLine(" равна " + number);
            }
            else 
            {
                Console.WriteLine("Вы ввели неправильное число");
            }
        }
    }
}
