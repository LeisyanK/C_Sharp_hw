// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// 1 4 7 2
// 5 9 2 3   ->  [1,7] - нет такого элемента
// 8 4 2 4 
Main();

void Main()
{
    Console.Write("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = int.Parse(Console.ReadLine());

    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);

    Console.Write("Введите номер строки: ");
    int row = int.Parse(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int column = int.Parse(Console.ReadLine());

    if (IsPresent(array, row, column))
    {
        Console.WriteLine($"[{row},{column}] элемент равен {array[row,column]}");
    }
    else
    {
        Console.WriteLine($"Нет элемента [{row},{column}]");
    }
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

bool IsPresent(int[,] array, int row, int column)
{
    if (row < array.GetLength(0) && column < array.GetLength(1))
    {
        return true;
    }
    else
    {
        return false;
    }
}