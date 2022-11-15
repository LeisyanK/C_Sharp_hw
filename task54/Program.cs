// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
//двумерного массива.
/*Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Main();

void Main()
{
    Console.Clear();
    Console.Write("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = int.Parse(Console.ReadLine());

    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine("Отсортированный по строкам массив:");
    SortRowsDescending(array);
    PrintArray(array);
} 

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SortRowsDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        //Console.WriteLine($"{i}-ая строка:");
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < array.GetLength(1) - j - 1; z++)
            {
                //Console.Write($"array[{i},{z}] и array[{i},{z+1}],  ");
                if(array[i,z + 1] > array[i,z])  // если это условие убрать, то строка запишется наоборот
                {
                    int temp = array[i,z];
                    array[i,z] = array[i,z + 1];
                    array[i,z + 1] = temp;
                }
            }
            //Console.WriteLine();
        }
    }
}
