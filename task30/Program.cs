using System;

namespace task30
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишите программу, которая 
выводит массив из 8 элементов, заполненный 
нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
            int[] FillArray(int count)
            {
                int[] array = new int[count];
                for (int i = 0; i < count; i++)
                {
                    array[i] = new Random().Next(0,2);
                }
                return array;
            }
            void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write($"{arr[i]} ");    
                }                
                Console.WriteLine();
            }

            Console.WriteLine("Введите количество элементов массива");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Массив из 0 и 1");
            int[] array1 = FillArray(num);
            PrintArray(array1);
        }
    }
}
