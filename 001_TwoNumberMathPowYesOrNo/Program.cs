// 1.По двум заданным числам проверять является ли первое квадратом второго

//Вводим две переменные:
int numberA = 36;
int numberB = new Random().Next(1, 50);

System.Console.WriteLine(numberA);
System.Console.WriteLine(numberB);

//Задаём условие проверки
if (numberA == Math.Pow(numberB, 2))
{
    System.Console.WriteLine("True");
}
else
{
    System.Console.WriteLine("False");
} 



