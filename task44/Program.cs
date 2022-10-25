/* Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые 2 числа Фибоначчи: 0 и 1. */
Main();

void Main()
{
    int number = EnterNumber();
    if (number == 0) Console.WriteLine($"Нет чисел Фибоначчи");
    else if (number == 1) Console.WriteLine($"0");
    else
    {
        int[] fib_array = Fibonacci(number);
        PrintArray(fib_array);
    }
}

int EnterNumber()
            {
                Console.Write("Введите число: ");
                return int.Parse(Console.ReadLine());
            }

void PrintArray(int[] array)
            {
                foreach (int el in array)
                {
                    Console.Write($"{el} ");
                }
                Console.WriteLine();
            }

int[] Fibonacci(int N)
{
    int[] array = new int[N];

    array[0] = 0;
    array[1] = 1;

    for (int i = 2; i < N; i++)
    {
        array[i] = array[i-2] + array[i-1];
    }
    return array;
}


