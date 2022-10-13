using System;

namespace task19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Введите пятизначное число: ");
            int num = int.Parse(Console.ReadLine());

            if ((num % 10 == num / 10000) && (num % 100 / 10 == num / 1000 % 10))
            {
                /*Console.WriteLine(num % 10);
                Console.WriteLine(num / 10000);
                Console.WriteLine(num % 100 / 10);
                Console.WriteLine(num / 1000 % 10);*/
/*                Console.WriteLine("Число является палиндромом");
            }
            else 
            {
                Console.WriteLine("Число не является палиндромом");
            }
            */

            // ДЛЯ ЧИСЕЛ С ЛЮБЫМ КОЛИЧЕСТВОМ ЦИФР
            Console.WriteLine();
            Console.Write("Введите любое число: ");
            int num1 = int.Parse(Console.ReadLine());
            int n = 0;  // количество цифр в числе num1
            int flag = 0;    // если флаг 0, то все соответствующие цифры совпадают
            //double degree;   // степень 10
            
            // считаем количество цифр
            int number1 = num1;
            while (number1 > 0)
            {
                number1/=10;
                n++;
            }
            // Console.WriteLine("Количество цифр равно " + n);

            // ОТБИРАЕМ ЦИФРЫ, НЕ УДАЛЯЯ ИХ
            
            for (int i=1; i < n/2 + 1; i++)
            {
                // Console.Write(i + " шаг) ");       //Console.WriteLine("num1=" + num1);
                double degree = Math.Pow(10,n-i);  //Console.WriteLine(" degree = " + degree);                
                int number_start = (int) Math.Truncate(num1 / degree % 10); // числа, начиная слева
                // Console.Write(i + "-я цифра = " + number_start + ", ");

                degree = Math.Pow(10,i);           //Console.WriteLine(" degree = " + degree);                
                int number_end = (int) Math.Truncate(num1 % degree / (degree/10));  //числа, начиная справа
                // Console.WriteLine(n-i+1 + "-я цифра = " + number_end);  

                if (number_start != number_end)
                {
                    flag = 1; // используем флаг
                    //Console.WriteLine("flag=1!!!!!");
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
