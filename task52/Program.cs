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
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        //double average = sum/array.GetLength(0);
        //Console.Write($"{average} ");
        Console.Write($"{sum / array.GetLength(0)} ");
    }
    Console.WriteLine();
    //Console.WriteLine(10/3);
}

int ArithmeticAverageByColumns2(int[,] array, int number)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, number];
    }
    return sum / array.GetLength(0);
}
