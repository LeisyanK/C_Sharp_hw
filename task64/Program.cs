/* Задайте значение N. Напишите программу, которая выведет все чётные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "4, 2"
N = 8 -> "8, 6, 4, 2,"
*/
Main();

void Main()
{
    Console.Write("Введите число: ");
    int n = int.Parse(Console.ReadLine());
    if (n % 2 == 0) PrintNumber(n);
    else PrintNumber(n-1);
}

void PrintNumber(int n)
{
    if (n <= 2) Console.WriteLine(n);
    else
    {
        Console.Write(n + " ");
        PrintNumber(n-2);
    }
}
