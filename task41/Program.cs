/* Пользователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 ввел пользователь*/
Main();

void Main()
{
    int M = EnterNumber();
    Console.WriteLine($"Количество положительных чисел: {PositiveCount(M)}");
}

int EnterNumber()
            {
                Console.Write("Введите количество чисел: ");
                return int.Parse(Console.ReadLine());
            }

int PositiveCount(int number)
{
    int count = 0;
    for (int i = 0; i < number; i++)
    {
        Console.Write($"Введите {i+1}-ое число: ");
        int num = int.Parse(Console.ReadLine());
        if(num > 0) count ++;
    }
    return count;
}
