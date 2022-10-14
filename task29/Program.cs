using System;

namespace task29
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу, которая задаёт массив 
                из 8 элементов и выводит их на экран.
            */
            int[] FillArray(int count)
            {
                int[] array = new int[count];
                for (int i = 0; i < count; i++)
                {
                    array[i] = new Random().Next(0,100);
                }
                return array;
            }
            void PrintArray(int[] arr)
            {
                Console.Write("[");
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    Console.Write($"{arr[i]} ");    
                }                
                Console.WriteLine($"{arr[arr.Length - 1]}]");
            }

            int[] array1 = FillArray(8);
            PrintArray(array1);
        }
    }
}
