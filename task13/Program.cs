using System;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели:");
            int num = int.Parse(Console.ReadLine());

            if (num < 1 || num > 7)
            {
                Console.WriteLine("Вы ввели некорректное число");
            }
            else
            {
                if (num == 6 || num == 7) 
                {
                    Console.WriteLine("Выходной день");
                }
                else
                {
                    Console.WriteLine("Будний день");
                }
            }
        }
    }
}
