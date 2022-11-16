/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9*/
Main();

void Main()
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine("Первый способ");
    int sum = 0;
    Console.WriteLine("Сумма цифр равна "+ NumberSum(number, sum));
    
    Console.WriteLine("Второй способ");
    int result = SumElements(number);
    Console.WriteLine(result);
}

int NumberSum(int n, int sum)
{
    if (n == 0) {//Console.WriteLine("#"+sum); 
        return sum;}
    sum += n % 10;
    //Console.WriteLine(n % 10 + " - " +sum);
    //if (n == 0) return sum;
    return NumberSum(n / 10, sum);
}

int SumElements(int number)
{
    if(number == 0) return 0;
    return number % 10 + SumElements(number / 10);
}