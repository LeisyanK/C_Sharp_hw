using System;

namespace task20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите координату х точки А: ");
            double Ax = double.Parse(Console.ReadLine());
            Console.Write("Введите координату у точки А: ");
            double Ay = double.Parse(Console.ReadLine());
            
            Console.Write("Введите координату х точки B: ");
            double Bx = double.Parse(Console.ReadLine());
            Console.Write("Введите координату у точки B: ");
            double By = double.Parse(Console.ReadLine());

            double result = Math.Sqrt(Math.Pow(Bx-Ax, 2) + Math.Pow(By-Ay, 2));

            Console.WriteLine($"Расстояние между точками равно {Math.Round(result, 2)}");

        }
    }
}
