/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
Main();

void Main()
{
    Console.Clear();
    Console.WriteLine("Массив 4х4:");
    int n = 4,
        m = 4;
    int[,] array = new int[n, m];
    FillArraySpirally(array, n, m);
    PrintArray(array);
    
    Console.WriteLine();
    Console.WriteLine("Массив 5х5:");
    int[,] array1 = new int[5, 5];
    FillArraySpirally(array1, 5, 5);
    PrintArray(array1);

    Console.WriteLine();
    Console.WriteLine("Массив 5х6:");
    int[,] array2 = new int[5, 6];
    FillArraySpirally(array2, 5, 6);
    PrintArray(array2);

    Console.WriteLine();
    Console.WriteLine("Массив 6х8:");
    int[,] array3 = new int[6, 8];
    FillArraySpirally(array3, 6, 8);
    PrintArray(array3);
}

void FillArraySpirally(int[,] array, int n, int m)
{
    int count = 1;
    int maxI = n,
        maxJ = m;
    int minI = 0,
        minJ = 0;
    int i = 0,
        j = 0;

    while (count <= n * m)
    {
        // 1
        if (count > n * m) break;
        while (j < maxJ) 
        {
            //Console.WriteLine("{0:d2}", count);
            array[i, j] = count;
            //Console.WriteLine($"a[{i},{j}] = {count}");
            count++;
            j++;
        }
        maxJ--;
        //Console.WriteLine($"1) i={i},j={j}");

        // 2
        if (count > n * m) break;
        i++;
        j--;
        //Console.WriteLine(i < n - j);
        while (i < maxI)
        {
            array[i, j] = count;
            //Console.WriteLine($"a[{i},{j}] = {count}");
            count++;
            i++;
        }
        maxI--;
        //Console.WriteLine($"2) i={i},j={j}");
        
        // 3
        if (count > n * m) break;
        i--;
        //Console.WriteLine(j > minJ);
        while (j > minJ) 
        {
            array[i, j - 1] = count;
            //Console.WriteLine($"a[{i},{j - 1}] = {count}");
            count++;
            j--;
        }
        //Console.WriteLine($"3) i={i},j={j}");
        minJ++;
        
        // 4
        if (count > n * m) break;
        i--;
        while (i > minI) 
        {
            array[i, j] = count;
            //Console.WriteLine($"a[{i},{j}] = {count}");
            count++;
            i--;
        }
        minI++;
        //Console.WriteLine($"4) i={i},j={j}");
       
        i++;
        j++;


        //Console.WriteLine("{0:d4}", count);
    }
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
