using System;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите пятизначное число: ");
            int num = int.Parse(Console.ReadLine());

            if ((num % 10 == num / 10000) && (num % 100 / 10 == num / 1000 % 10))
            {
                /*Console.WriteLine(num % 10);
                Console.WriteLine(num / 10000);
                Console.WriteLine(num % 100 / 10);
                Console.WriteLine(num / 1000 % 10);*/
                Console.WriteLine("Число является палиндромом");
            }
            else 
            {
                Console.WriteLine("Число не является палиндромом");
            }
        }
    }
}
