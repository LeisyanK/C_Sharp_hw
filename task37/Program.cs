using System;

namespace task37
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMain();

            void MyMain()
            {
                Console.Write("Введите количество элементов массива:");
                int size1 = int.Parse(Console.ReadLine());
                int[] array1 = FillArray(size1);
                PrintArray(array1);
                int[] array2 = NewArray(array1);
                PrintArray(array2);
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

            int[] NewArray(int[] array)
            {
                int n = array.Length;
                
                int size2 = n/2;
                if (n % 2 > 0) 
                {
                    //int[] newArray = new int[n/2+1]; //не проходит, т.к. новый массив будет виден только внутри if
                    size2 = n/2+1;
                    Console.WriteLine($"Размер нового массива = {size2}");
                    //newArray[n/2+1] = array[n/2+1]; 
                }
                int[] newArray = new int[size2];
                //int[] newArray = new int[]; 
                //else int[] newArray = new int[n/2]; //не проходит, т.к. новый массив будет виден только внутри if
                
                for (int i = 0; i < n/2; i++)
                {
                    newArray[i] = array[i] * array[n-i-1];
                    Console.WriteLine($"{array[i]} * {array[n-i-1]} = {newArray[i]}");
                    //Console.WriteLine($"array[{i}] и array[{n-i-1}] ");
                }        
                if (n % 2 > 0) 
                {
                    newArray[n/2] = array[n/2];
                }       
                
                return newArray;
            }
        }
    }
}
