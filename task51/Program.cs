// // Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0), (1,1) и т.д.).
// 1 4 7 2          
// 5 9 2 3   
// 8 4 2 4   
// Сумма элементов по диагонали = 12       
Main();

void Main()
{
    int rows = GetNumber();
    int columns = GetNumber();

    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine($"Сумма элементов на главной диагонали равна {SumDiagonalNumbers(array)}");
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

int SumDiagonalNumbers(int[,] array)
{
    int sum = 0;
    int length = array.GetLength(0);
    if (length > array.GetLength(1)) 
    {
        length = array.GetLength(1);
    }    

    for (int i = 0; i < length; i++)
    {
        sum += array[i,i];
    }
    return sum;
}