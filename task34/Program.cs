using System;

namespace task34
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задайте массив, заполненный случайными положительными трёхзначными числами. Напишите программу, 
            которая покажет количество чётных чисел в массиве.

            [345, 897, 568, 234] -> 2*/

            MyMain();

           static void MyMain()
            {
                int size = EnterNumber();
                int[] array1 = FillArray(size, 100, 999);
                PrintArray(array1);
                Console.WriteLine($"Количество четных чисел равно {CountEvens(array1)}");
            }

           static int EnterNumber()
            {
                Console.Write("Введите число:");
                return int.Parse(Console.ReadLine());
            }

           static int[] FillArray(int size, int minValue, int maxValue)
            {
                int[] array = new int[size];
                for (int i=0; i<size; i++)
                {
                    array[i] = new Random().Next(minValue, maxValue + 1);
                }
                return array;
            }

           static void PrintArray(int[] array)
            {
                foreach (int el in array)
                {
                    Console.Write($"{el} ");
                }
                Console.WriteLine();
            }

           static int CountEvens(int[] array)
            {
                int count = 0;
                foreach (int el in array)
                {
                    if (el % 2 == 0) count++;
                }
                return count;
            }
            
        }
    }
}
