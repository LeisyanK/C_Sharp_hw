/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
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
    Console.WriteLine("Первый способ: используем 2 переменные для запоминания индекса строки и минимальной суммы.");
    MinSum(array);    

    Console.WriteLine("Второй способ: используем массив для хранения сумм всех строк.");
    MinSum2(array);    
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

int ElementsSum(int[,] array, int number)  // number  это номер строки
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum += array[number, j];
    }
    //Console.WriteLine($"Сумма элементов {number + 1}-й строки равна {sum}");
    return sum;
}

void MinSum(int[,] array)
{
    int minIndex = 0;
    int minSum = ElementsSum(array, minIndex);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int elemSum = ElementsSum(array, i);
        if (minSum > elemSum)
        {
            minSum = elemSum;
            minIndex = i;
        }
    }
    Console.WriteLine($"Минимальная сумма элементов - на {minIndex + 1} строке и равна {minSum}");
}

void MinSum2(int[,] array)
{
    int[] sums = new int[array.GetLength(0)];
    int minIndex = 0;
    sums[0] = ElementsSum(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        sums[i] = ElementsSum(array, i);
        if (sums[minIndex] > sums[i]) minIndex = i;
    }

    // вывод массива сумм
    /*for (int i = 0; i < sums.GetLength(0); i++)
    {
        Console.Write(sums[i] + " ");
    }
    Console.WriteLine();*/
    Console.WriteLine($"Минимальная сумма элементов - на {minIndex + 1} строке и равна {sums[minIndex]}");
}
