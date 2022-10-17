using System;

namespace task31
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9].
            Найдите суммы отрицательных и положительных элементов массива.*/
            int[] GetArray(int size, int minValue, int maxValue)
            {
                int[] result = new int[size];
                for (int i=0; i < size; i++)
                {
                    result[i] = new Random().Next(minValue, maxValue + 1);
                    Console.Write($"{result[i]} ");
                }
                return result;
            }

            int[] array = GetArray(12, -9, 9);
            int positiveSum = 0;
            int negativeSum = 0;
            foreach (int el in array)
            {
                if (el > 0) positiveSum += el;
                else negativeSum += el;
            }
            Console.WriteLine();
            Console.WriteLine($"Сумма положительных чисел = {positiveSum}, сумма отрицательных чисел = {negativeSum}");
        }
    }
}
