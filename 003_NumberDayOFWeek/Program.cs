// 3. По заданному номеру дня недели вывести его название

//Зададим запрос числа из консоли
Console.WriteLine("Введите номер дня недели от 1 до 7");

//Конвертирование типа данных
int DayOfWeek = Convert.ToInt32(Console.ReadLine());

//Задаём условие при котором число дает день недели
if (DayOfWeek == 1) System.Console.WriteLine("Monday");
if (DayOfWeek == 2) System.Console.WriteLine("Tuesday");
if (DayOfWeek == 3) System.Console.WriteLine("Wednesday");
if (DayOfWeek == 4) System.Console.WriteLine("Thursday");
if (DayOfWeek == 5) System.Console.WriteLine("Friday");
if (DayOfWeek == 6) System.Console.WriteLine("Saturday");
if (DayOfWeek == 7) System.Console.WriteLine("Sunday");
