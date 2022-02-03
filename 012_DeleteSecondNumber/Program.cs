// 12.Удалить вторую цифру трёхзначного числа

// Console.WriteLine("Введите любое трёхзначное число");
int number = new Random().Next(99,1000);
// int number = Convert.ToInt32(Console.ReadLine());

// Для того чтобы не возникли трудности с числом зададим лучше генерируемое число.
System.Console.WriteLine($"genNumber = {number}");

// Для каждой цифры в числе введем переменные.
int number1;
int number2;
int number3;

// И находим каждую цифру из числа.
number1 = number / 100;
number2 = (number /10) % 10;
number3 = number % 10;

// Выводим число которе хотим удалить и уже конечный результат.
System.Console.WriteLine(number2);
System.Console.WriteLine($"numberWithout number2 = {number1}{number3}");