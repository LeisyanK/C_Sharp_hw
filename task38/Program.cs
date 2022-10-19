using System;

namespace task38
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным
             элементами массива.
            [3 7 22 2 78] -> 76*/

            MyMain();

            void MyMain()
            {
                double[] array1 = FillArray(10, 1.0, 10.0);
                PrintArray(array1);

                Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {MaxMinusMin(array1)}");
            }

            double[] FillArray(int size, double minValue, double maxValue)
            {
                double[] array = new double[size];
                for (int i=0; i<size; i++)
                {
                    array[i] = Math.Round( new Random().NextDouble() * (maxValue - minValue) + minValue, 2 );
                    //NextDouble() генерирует от 0.0 до 1.0
                }
                return array;
            }

            void PrintArray(double[] array)
            {
                foreach (double el in array)
                {
                    Console.Write($"{el} ");
                }
                Console.WriteLine();
            }

            double MaxMinusMin(double[] array)
            {
                double max = array[0];
                double min = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max) max = array[i];
                    else if (array[i] < min) min = array[i];
                }
                Console.WriteLine($"{max} - {min} = {max-min}");
                return max-min;
            }
        }
    }
}
