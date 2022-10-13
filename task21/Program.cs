using System;

namespace task21
{
    class Program
    {
        static void Main(string[] args)
        {
            double Kub(double ax, double ay, double az, double bx, double by, double bz)
            {
                double result = Math.Sqrt( Math.Pow(bx-ax, 2) + Math.Pow(by-ay, 2) + Math.Pow(bz-az, 2) );
                return result;
            }

            Console.Write("Введите координату х точки А: ");
            double Ax = double.Parse(Console.ReadLine());
            Console.Write("Введите координату у точки А: ");
            double Ay = double.Parse(Console.ReadLine());
            Console.Write("Введите координату z точки А: ");
            double Az = double.Parse(Console.ReadLine());
            
            Console.Write("Введите координату х точки B: ");
            double Bx = double.Parse(Console.ReadLine());
            Console.Write("Введите координату у точки B: ");
            double By = double.Parse(Console.ReadLine());
            Console.Write("Введите координату z точки В: ");
            double Bz = double.Parse(Console.ReadLine());

            //double result = Math.Sqrt( Math.Pow(Bx-Ax, 2) + Math.Pow(By-Ay, 2) + Math.Pow(Bz-Az, 2) );
            double res = Kub(Ax, Ay, Az, Bx, By, Bz);

            Console.WriteLine($"Расстояние между точками равно {Math.Round(res, 2)}");
        }
    }
}
