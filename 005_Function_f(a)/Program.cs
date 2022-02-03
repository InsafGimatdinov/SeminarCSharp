// 6. Написать программу вычисления значения функции y = f(a) = (1 + 1 / a) ^ a

System.Console.WriteLine("введите число а");
double a = Convert.ToDouble(System.Console.ReadLine());
double y = 0;
if (a == 0)
{
    System.Console.WriteLine("Error uncorrect number");
}
else
{
    y = Math.Pow((1+1/a), a);
    System.Console.WriteLine($"y = {y}");
}

// double number = 2;
// double result = Math.Pow(number, 3);
// System.Console.WriteLine(result);