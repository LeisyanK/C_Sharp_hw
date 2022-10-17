using System;

namespace task32
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу замены элементов массива: положительные элементы замените на соответствующие 
            отрицательные, и наоборот.
            [-4, -8, 8, 2] -> [4, 8, -8, -2]*/
            MyMain();

            void MyMain()
            {
                int[] array1 = FillArray(10);
                PrintArray(array1);

                array1 = ChangeArray(array1);
                PrintArray(array1);
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

            int[] ChangeArray(int[] array)
            {
                for (int i=0; i < array.Length; i++)
                {
                    array[i] *= -1;
                }
                return array;
            }
        }
    }
}
