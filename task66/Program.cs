/* Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
Main();

void Main()
{
    Console.Write("Введите число M: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Введите число N: ");
    int n = int.Parse(Console.ReadLine());

    int sum = 0;
    Console.WriteLine($"Сумма чисел от {m} до {n} равна " + NumbersSum(m,n,sum));
}

int NumbersSum(int m, int n, int sum)
{
    sum += m;
    //Console.WriteLine(sum);
    if (m == n) return sum; 
    return NumbersSum(m+1, n, sum);
}
