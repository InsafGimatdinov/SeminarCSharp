// 6. Выяснить является ли число чётным

//Сделаем запрос ввода числа с консоли
System.Console.WriteLine("Введите любое число");

//Введем переменную
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}