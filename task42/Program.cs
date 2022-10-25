/*Напишите программу, которая будет преобразовывать десятичное число в двоичное.*/
Main();

void Main()
{
    int num1 = EnterNumber();
    Console.WriteLine($"Число {num1} в двоичной системе счисления: {IsBinary(num1)}");
    num1 = EnterNumber();
    Console.WriteLine($"Число {num1} в двоичной системе счисления: {IsBinaryInString(num1)}");    
}

int EnterNumber()
            {
                Console.Write("Введите число: ");
                return int.Parse(Console.ReadLine());
            }

int IsBinary(int number)
{
    int result = 0; //число в двоичной системе
    int i = 0; // степени 10
    double degree = 1;
    while (number > 0)
    {
        result = (int) Math.Truncate(result + number % 2 * degree);
        number /= 2;
        i++;
        degree = Math.Pow(10, i);
    }
    return result;
}

string IsBinaryInString(int number)
{
    string binaryNumber = "";
    while (number > 0)
    {
        binaryNumber = number % 2 + binaryNumber;
        number /= 2;
    }
    return binaryNumber;
}