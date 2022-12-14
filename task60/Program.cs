/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет
построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/
Main();

void Main()
{
    Console.Clear();
    Console.Write("Введите количество строк: ");
    int x = int.Parse(Console.ReadLine());
    Console.Write("Введите количество столбцов: ");
    int y = int.Parse(Console.ReadLine());
    Console.Write("Введите ширину массива: ");
    int z = int.Parse(Console.ReadLine());

    int[,,] array = new int[x, y, z];
    Console.WriteLine("Первый способ - заполнение по порядку: ");
    FillArray(array);
    PrintArray(array);
    
    Console.WriteLine();
    Console.WriteLine("Второй способ - случайное заполнение: ");
    FillArray2(array);
    PrintArray(array);
}

void FillArray(int[,,] array)
{
    int count = 10;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = count; //new Random().Next(1, 10);
                count++;
            }
        }
    }
}

void FillArray2(int[,,] array)
{
    int[] tempArray = new int[90];
    /*foreach (int el in tempArray)
    {
        Console.Write(el);
    }*/
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                while (count != array.GetLength(0) * array.GetLength(1) * array.GetLength(2))
                {
                    int number = new Random().Next(10, 90);
                    //Console.Write($"number = {number} -> ");
                    if (tempArray[number] == 0)
                    {
                        tempArray[number] = 1;
                        array[i, j, k] = number;
                        count++;
                        //Console.WriteLine($"array[{i}, {j}, {k}] = {number} || count = {count}");
                        break;
                    }
                }
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    Console.WriteLine("Массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array[i, j, k] + $"[{i}, {j}, {k}] ");
            }
            Console.WriteLine();
        }
        //Console.WriteLine();
    }
}
