// Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, 
// y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Main();

void Main()
{
    Console.WriteLine("Введите коэффициенты уравнений 2 прямых:");
    Console.Write("Введите k1: ");
    double k1 = double.Parse(Console.ReadLine());
    Console.Write("Введите b1: ");
    double b1 = double.Parse(Console.ReadLine());
    Console.Write("Введите k2: ");
    double k2 = double.Parse(Console.ReadLine());
    Console.Write("Введите b2: ");
    double b2 = double.Parse(Console.ReadLine());
    IntersectionPoint(k1, b1, k2, b2);
}

void IntersectionPoint(double k1, double b1, double k2, double b2)
{
    if (k1 == k2) Console.WriteLine("Прямые параллельны");
    else 
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения: ({Math.Round(x,2)} ; {Math.Round(y,2)})");
    }
}