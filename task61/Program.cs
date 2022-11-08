// треугольник Паскаля

    //Console.Clear();
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());
    int[,] array = new int[n + 1, 2 * n + 1];
    //PrintArray(array);
    PascalTriangle(array, n);
    PrintArray(array);


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == 0) Console.Write("  ");
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void PascalTriangle(int[,] array, int n)
{
    //int j = n;
    // первая строка
    array[0, n] = 1;
    //array[1, n - 1] = 1; array[1, n + 1] = 1;
    
    // со второй по предпоследнюю строки
    for (int i = 1; i < n; i++)
    {
        for (int j = n - i; j < 2 * n; j+=2)
        {
            array[i,j] = array[i-1, j-1] + array[i-1, j+1];
        }            
    }
    // последняя строка
    array[n, 0] = 1; array[n, 2 * n] = 1;
    for (int j = 2; j < 2 * n; j+=2)
    {
        array[n,j] = array[n-1, j-1] + array[n-1, j+1];
    }
}