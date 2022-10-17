using System;

namespace task35
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения 
            которых лежат в отрезке [10,99].*/
            MyMain();

            void MyMain()
            {
                int[] array1 = FillArray(123);
                PrintArray(array1);

                Console.WriteLine($"Количество элементов массива в отрезке [10, 99] = {CountBetween10and99(array1)}");
            }

            int CountBetween10and99(int[] array)
            {
                int count = 0;
                Console.WriteLine();
                foreach (int el in array)
                {
                    if (el > 9 && el < 100)
                    {
                        count++;
                        Console.Write($"{el} ");
                    }
                }
                Console.WriteLine();
                return count;
            }

            int[] FillArray(int size)
            {
                int[] array = new int[size];
                for (int i=0; i<size; i++)
                {
                    array[i] = new Random().Next(size * -1, size);
                }
                return array;
            }

            void PrintArray(int[] array)
            {
                foreach (int el in array)
                {
                    Console.Write($"{el} ");
                }
                Console.WriteLine();
            }
        }
    }
}
