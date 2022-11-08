// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

 Console.Clear();
    Console.Write("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int columns = int.Parse(Console.ReadLine());

    int[,] array = new int[rows, columns];
    FillArray(array);
    PrintArray(array);
    Console.WriteLine();
    ChangeRows(array);
    

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

void ChangeRows(int[,] array)
{
    int rowLength = array.GetLength(0);
    int colLength = array.GetLength(1);
    if (rowLength == colLength) 
    {
        
        for (int i = 0; i < rowLength; i++)
        {
            for (int j = i; j < colLength; j++)
            {
                int temp = array[i,j];
                array[i,j] = array[j,i];
                array[j,i] = temp;
            }
        }
        PrintArray(array);
    }
    else Console.WriteLine("Замена невозможна");
}

