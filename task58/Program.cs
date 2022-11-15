/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.(посмотрите как 
реализуется произведение матриц, там не просто перемножение элемент на элемент)
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/
Main();

void Main()
{
    Console.Clear();
    Console.Write("Введите количество строк первого массива: ");
    int rowsFirst = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов первого массива: ");
    int columnsFirst = int.Parse(Console.ReadLine());

    Console.Write("Введите количество строк второго массива: ");
    int rowsSecond = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов второго массива: ");
    int columnsSecond = int.Parse(Console.ReadLine());

    if (columnsFirst == rowsSecond)
    {
        int[,] array1 = CreateArray(rowsFirst, columnsFirst);
        int[,] array2 = CreateArray(rowsSecond, columnsSecond);
        
        PrintArray(Multiplication(array1,array2));
    }
    else if (columnsSecond == rowsFirst)
    {
        int[,] array1 = CreateArray(rowsFirst, columnsFirst);
        int[,] array2 = CreateArray(rowsSecond, columnsSecond);
        
        Console.WriteLine("Умножаем второй массив на первый.");
        PrintArray(Multiplication(array2,array1));
    }
    else Console.Write("Невозможно перемножить массивы");
}

int[,] CreateArray(int row, int column)
{
    int[,] array = new int[row, column];
    FillArray(array); 
    PrintArray(array); 
    Console.WriteLine();
    return array;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
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

int[,] Multiplication(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    Console.WriteLine($"Новый массив: {array1.GetLength(0)} x {array2.GetLength(1)}");
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        { 
            //Console.Write($"result[{i},{j}] = ");
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                //Console.Write($"А[{i},{k}] * В[{k},{j}]; ");
                result[i,j] += array1[i,k] * array2[k,j];
            }
            //Console.WriteLine();
        }
        //Console.WriteLine();
    }
    return result;
}