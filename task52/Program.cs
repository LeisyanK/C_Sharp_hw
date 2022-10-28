// Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
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
    Console.WriteLine("Среднее арифметическое по столбцам:");
    ArithmeticAverageByColumns(array);

    Console.WriteLine("Второй способ (по столбцам):");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{ArithmeticAverageByColumns2(array, j)} ");
    }
    Console.WriteLine();

    Console.WriteLine("Среднее арифметическое по строкам:");
    ArithmeticAverageByRows(array);

    Console.WriteLine("Второй способ (по строкам):");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{ArithmeticAverageByRows2(array, i)} ");
    }
    Console.WriteLine();
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

void ArithmeticAverageByColumns(int[,] array)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        //double average = sum/array.GetLength(0);
        //Console.Write($"{average} ");
        Console.Write($"{Math.Round(sum / array.GetLength(0), 2)} ");
    }
    Console.WriteLine();
    //Console.WriteLine(10/3);
}

double ArithmeticAverageByColumns2(int[,] array, int number)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, number];
    }
    return Math.Round(sum / array.GetLength(0), 2);
}

void ArithmeticAverageByRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        //double average = sum/array.GetLength(0);
        //Console.Write($"{average} ");
        Console.Write($"{Math.Round(sum / array.GetLength(1), 2)} ");
    }
    Console.WriteLine();
    //Console.WriteLine(10/3);
}

double ArithmeticAverageByRows2(int[,] array, int number)
{
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[number, j];
        //Console.Write(array[number, j] + " ");
    }
    return Math.Round(sum / array.GetLength(1), 2);
}