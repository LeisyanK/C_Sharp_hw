/* Напишите программу, которая на вход принимает два числа A и B, и 
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/
Main();

void Main()
{
    Console.Write("Введите число: ");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write("Введите степень: ");
    int number2 = int.Parse(Console.ReadLine());
    int power = 1;
    Console.WriteLine($"Число {number1} в степени {number2} равно " + FirstNumberInTheSecondNumberPower(a: number1, b: number2, power: power));

    // второй способ
    int count = 0;
    int result = DegNumber(number1, number2, count);
    Console.Write(result);
}

int FirstNumberInTheSecondNumberPower(int a, int b, int power)
{
    //Console.WriteLine(b);
    power *= a;
    if (b == 1) return power;
    return FirstNumberInTheSecondNumberPower(a, b-1, power);
}

int DegNumber(int number1, int number2, int count)
{
    if(count == number2) return 1;
    count++;
    return number1 * DegNumber(number1, number2, count);
}