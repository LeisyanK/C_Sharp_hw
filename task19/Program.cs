using System;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            void Palindrom(int number)
            {
                if ((number % 10 == number / 10000) && (number % 100 / 10 == number / 1000 % 10))
            {
                Console.WriteLine("Число является палиндромом");
            }
            else 
            {
                Console.WriteLine("Число не является палиндромом");
            }
            }

            Console.Write("Введите пятизначное число: ");
            int num = int.Parse(Console.ReadLine());

            Palindrom(num);
/*
            if ((num % 10 == num / 10000) && (num % 100 / 10 == num / 1000 % 10))
            {
                /*Console.WriteLine(num % 10);
                Console.WriteLine(num / 10000);
                Console.WriteLine(num % 100 / 10);
                Console.WriteLine(num / 1000 % 10);*/
/*                Console.WriteLine("Число является палиндромом");
            }
            else 
            {
                Console.WriteLine("Число не является палиндромом");
            }*/
        }
    }
}
