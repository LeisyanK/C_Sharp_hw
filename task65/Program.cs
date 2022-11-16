/* Задайте значения M и N. Напишите программу, которая 
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"  
*/
Main();

void Main()
{
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());
    Console.Write($"Числа от {m} до {n}: ");
    PrintNumber(m, n);
}
void PrintNumber(int m, int n)
{
    if (m == n) Console.WriteLine(m);
    else
    {
        Console.Write(m + " ");
        PrintNumber(m + 1, n);
    }
}
