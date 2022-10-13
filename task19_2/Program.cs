using System;

namespace task19_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // ДЛЯ ЧИСЕЛ С ЛЮБЫМ КОЛИЧЕСТВОМ ЦИФР
            Console.WriteLine();
            Console.Write("Введите любое число: ");
            int num2 = int.Parse(Console.ReadLine());
            int n = 0;  // количество цифр в числе num2
            int flag = 0; // если флаг 0, то все соответствующие цифры совпадают
            int numberFirst;   // первая цифра числа
            int numberLast;    // последняя цифра числа
            double degree;
            
            int number2 = num2;
            while (number2 > 0)
            {
                number2/=10;
                n++;
            }
            // Console.WriteLine("Количество цифр равно " + n);

            // методом удаления цифр с конца и начала
            
            while (num2 > 9) 
            {
                numberLast = num2 % 10;    // Console.WriteLine("number_last = " + number_last);
                n = n - 2;
                degree = Math.Pow(10,n);
                num2 = num2 / 10;           // Console.WriteLine("num2 = " + num2);
                numberFirst = (int) Math.Truncate(num2 / degree); // Console.WriteLine("number_first = " + number_first);
                num2 = (int) Math.Truncate(num2 % degree);          // Console.WriteLine("num2 = " + num2);

                if (numberFirst != numberLast)
                {
                    flag = 1; // используем флаг
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Число является палиндромом");
            }
            else 
            {
                Console.WriteLine("Число не является палиндромом");
            }            
        }
    }
}
