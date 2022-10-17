using System;

namespace task36
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на 
            нечётных позициях.
            [3, 7, 23, 12] -> 19
            [-4, -6, 89, 6] -> 0*/

            MyMain();

            void MyMain()
            {
                int size = EnterNumber();
                int[] array1 = FillArray(size);
                PrintArray(array1);
                Console.WriteLine($"Сумма элементов на нечетных позициях равна {UnevenSum(array1)}");
            }

            int EnterNumber()
            {
                Console.Write("Введите число: ");
                return int.Parse(Console.ReadLine());
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

            int UnevenSum(int[] array)
            {
                int sum = 0;
                int i = 1;
                while (i < array.Length)
                {
                    sum += array[i];
                    i += 2;
                }
                return sum;
            }
        }
    }
}
