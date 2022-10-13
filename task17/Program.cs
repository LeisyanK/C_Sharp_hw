/*
17. Напишите программу, которая принимает на вход 
координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт 
номер четверти плоскости, в которой находится эта 
точка.
*/
using System;

namespace task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите Х: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Введите Y: ");
            int y = int.Parse(Console.ReadLine());

            if(x>0 && y>0)
            {
                Console.WriteLine("1");
            }
            if(x<0 && y>0)
            {
                Console.WriteLine("2");
            }
            if(x<0 && y<0)
            {
                Console.WriteLine("3");
            }
            if(x>0 && y<0)
            {
                Console.WriteLine("4");
            }
        }
    }
}
