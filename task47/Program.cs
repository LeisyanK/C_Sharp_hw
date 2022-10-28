// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.
Main();

void Main()
{
    Console.Write("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = int.Parse(Console.ReadLine());

    double[,] array = new double[rows, columns];
    FillArray(array);
    PrintArray(array);
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().NextDouble()*10 + 1;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(Math.Round(array[i,j], 2)+" ");
        }
        Console.WriteLine();
    }
}
