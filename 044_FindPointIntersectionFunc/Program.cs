// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы.

// k - угловой коэффициент, b - величина отрезка, отсекаемого данной прямой на отрезки
// после решения уравнения получается x = (b1 - b2) / (k2 - k1) 

Console.WriteLine("Даны две прямые, заданные уравнением y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine("введите угловой коэффициент к1");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите величину отрезка b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициент k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите величину отрезка b2");
double b2 = Convert.ToInt32(Console.ReadLine());
double x = 0;
double y = 0;

if (k1 != k2) // исключение параллельности двух прямых
{
    x = (b1 - b2) / (k2 - k1);
    y = k1 * x + b1;
    Console.WriteLine($"Координата точки пересечения прямых: x {x}, y {y} ");
}
else
{
    Console.WriteLine("Прямые не пересекаются");
}
