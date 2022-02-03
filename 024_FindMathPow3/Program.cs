// 24. Найти кубы чисел от 1 до N.

// Ввели число с консоли.
System.Console.WriteLine("Введите число N: ");

int N = Convert.ToInt32(Console.ReadLine());

// Для решения подобных задач чаще всего используется цикл for.
for (int i = 0; i * i * i <= N; i++)
{
    Console.WriteLine($"[{i}] = {i * i * i}, ");
    if (i % 5 == 0)
    {
        System.Console.WriteLine();
    }
}