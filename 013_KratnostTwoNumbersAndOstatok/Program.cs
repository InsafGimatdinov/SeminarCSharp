// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.

// Заданное число вводим руками.
Console.WriteLine("Введите любое целое число ");
int numberA = Convert.ToInt32(Console.ReadLine());

// Нужно узнать кратно ли этомиу числу заданное.
int numberB = 4;

// Задаём условие если остаток от деления двух числе равен нулю тогда условие кратности выполняется.
if (numberA % numberB == 0)
{
    System.Console.WriteLine("Да, число кратно заданному");
}
// Иначе условие кратности не выполняется и выводится соответствующее сообщение и остаток.
else
{
    System.Console.WriteLine("Нет, число не кратно заданному");
    System.Console.WriteLine(numberA % numberB);
    System.Console.ReadKey();
}