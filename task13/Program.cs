﻿using System;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int n = 3;  // позиция искомой цифры
            Console.WriteLine("Введите любое число:");
            int num = int.Parse(Console.ReadLine());
            //int num = new Random().Next(1, 100000);

            if (num < -99 || num > 99)
            {
                // Третья справа цифра
                int num1 = num / 100;
                num1 = num1 % 10;
                if (num1 < 0) num1 = num1 * (-1);
                Console.WriteLine($"Третья справа цифра числа {num} равна {num1}");

                // третья слева цифра
                int num2 = num;
                int count = 0;
                while (num2 != 0)
                {
                    num2 = num2 / 10;
                    count++;
                }
                //Console.WriteLine("Количество цифр " + count);
                count = count - n;
                /*double t = Math.Pow(10, count);
                Console.WriteLine("t="+ t);
                num2 = Math.Round( num / t ); // ошибка типов данных
                Console.WriteLine("num2="+num2);
                */

                int znam = 1;       // знаменатель деления
                while (count > 0 )
                {
                    znam = znam * 10;
                    count--;
                }
                //Console.WriteLine("znam="+znam);
                num2 = num / znam;
                num2 = num2 % 10;
                if (num2 < 0) num2 = num2 * (-1);
                Console.WriteLine($"Третья слева цифра числа {num} равна {num2}");
            }
            else
            {
                Console.WriteLine("Нет третьей цифры");
            }
        }
    }
}
