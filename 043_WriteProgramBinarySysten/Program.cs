// 43. Написать программу преобразования десятичного числа в двоичное.
Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());

string binary = Convert.ToString(number, 2);
System.Console.WriteLine($"Перевод десятичного числа {number} в двоичное {binary}");