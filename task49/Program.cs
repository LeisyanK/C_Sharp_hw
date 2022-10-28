// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты.
// 1 4 7 2          1 4 7 2
// 5 9 2 3   ->     5 81 2 9
// 8 4 2 4          8 4 2 4
Main();

void Main()
{
    int rows = GetNumber();
    int columns = GetNumber();

    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();

    ChangeEvenIndex(array);
    PrintArray(array);
}

int GetNumber()
{
    Console.Write("Введите число:");
    return int.Parse(Console.ReadLine());
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

void ChangeEvenIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i,j] *= array[i,j];
        }
    }
}
/*
void ChangeEvenIndex(int[,] array)
{
    int i = 0;
    while (i < array.GetLength(0))
    {
        int j = 0;
        while (j < array.GetLength(1))
        {
            array[i,j] *= array[i,j];
            j += 2;
        }
        i += 2;
    }
}*/