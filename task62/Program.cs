/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
Main();

void Main()
{
    int n = 4, m = 4;
    int[,] array = new int[n,m];
    FillArraySpirally(array, n, m);
    PrintArray(array);
}

void FillArraySpirally(int[,] array, int n, int m)
{
    int count = 1;

    // 1
    int i = 0, j = 0;
    while (j < m)
    {
        //Console.WriteLine("{0:d2}", count);
        array[i,j] = count;
        //Console.WriteLine($"a[{i},{j}] = {count}");
        count++;
        j++;
    }
    //Console.WriteLine($"i={i},j={j}");

    // 2
    i++; j--;
    while (i < n)
    {
        array[i,j] = count;
        //Console.WriteLine($"a[{i},{j}] = {count}");
        count++;
        i++;
    }
    //Console.WriteLine($"i={i},j={j}");

    // 3
    i--; 
    while (j > 0)  
    {
        array[i,j - 1] = count;
        //Console.WriteLine($"a[{i},{j - 1}] = {count}");
        count++;
        j--;
    }
    //Console.WriteLine($"i={i},j={j}");

    // 4
    i--;
    while (i > 0)  
    {
        array[i,j] = count;
        //Console.WriteLine($"a[{i},{j}] = {count}");
        count++;
        i--;
    }
    //Console.WriteLine($"i={i},j={j}");

    // 5
    i++; j++; m -= i;
    while (j < m)
    {
        array[i,j] = count;
        //Console.WriteLine($"a[{i},{j}] = {count}");
        count++;
        j++;
    }
    //Console.WriteLine($"i={i},j={j}");
    
    //6
    n -= i;
    i++; j--; //n -= 1;
    while (i < n)
    {
        array[i,j] = count;
        //Console.WriteLine($"a[{i},{j}] = {count}");
        count++;
        i++;
    }
    //Console.WriteLine($"i={i},j={j}");

    // 7
    i--;
    while (j > 1)  
    {
        array[i,j - 1] = count;
        //Console.WriteLine($"a[{i},{j - 1}] = {count}");
        count++;
        j--;
    }
    //Console.WriteLine($"i={i},j={j}");

    /*for (int i = 0; i < 15; i++)
    {
        Console.WriteLine("{0:d4}", i);    // Спецификаторы форматирования -> Форматирование целых чисел
    }*/
    //Console.WriteLine("{0:d4}", count);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0:d2}", array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
