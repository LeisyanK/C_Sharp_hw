/* Задайте значение N. Напишите программу, которая выведет 
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/ 
Main();

void Main()
{
    Console.Write("Введите число: ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("Первый способ: ");
    string result = "";
    PrintNumbers(n, result);
    //Console.WriteLine(result);

    Console.Write("Второй способ: ");
    string result2 = " ";
    Console.WriteLine(PrintNumbers2(n, result2));

    Console.Write("Третий способ: ");
    int newNumber = 1;
    WriteNumber(n, newNumber);
}

void PrintNumbers(int n, string result)
{    
    if (n == 1) 
    {
        result = n + result;
        Console.WriteLine(result);
    }
    else 
    {
        result = " " + n + result;
        //Console.WriteLine(result);
        PrintNumbers(n - 1, result);
    }
    //Console.WriteLine(result);
}

string PrintNumbers2(int n, string result)
{    
    //Console.Write(n + " ");
    if (n == 1) 
    {
        result = n + " " + result;
        //Console.WriteLine(result);
        return result;
    }
    else 
    {
        /*
        return "+" + n + result;
        //Console.WriteLine(result);
        PrintNumbers2(n - 1, result);
        */
        result = n + " " + result;
        //Console.WriteLine(result);
        return PrintNumbers2(n - 1, result);
    }
    // сюда программа не доходит :), т.к. выше стоит return
    //Console.WriteLine(result);
    //Console.Write(" " + n);
}

void WriteNumber(int number, int newNumber)
{
    Console.Write(newNumber + " ");
    if(newNumber < number) WriteNumber(number, newNumber + 1);
}