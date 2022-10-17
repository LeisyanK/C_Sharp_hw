using System;

namespace task33
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.*/
            MyMain();

            static void MyMain()
            {
                int[] array1 = FillArray(10);
                PrintArray(array1);
                Console.Write("Введите число: ");
                int number = int.Parse(Console.ReadLine());
                bool exist = NumberExist(array1, number);
                if (exist) 
                    Console.WriteLine($"В массиве есть число {number}");
                else
                {
                    Console.WriteLine($"В массиве нет числа {number}");
                }
            }

            static int[] FillArray(int size)
            {
                int[] array = new int[size];
                for (int i=0; i<size; i++)
                {
                    array[i] = new Random().Next(size * -1, size);
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

            static bool NumberExist(int[] array, int number)
            {

                bool res = false;
                foreach (int el in array)
                {
                    if (el == number)
                    {
                        res = true;
                        break;
                    }
                }
                //Console.WriteLine(res);
                return res;
            }
        }
    }
}
