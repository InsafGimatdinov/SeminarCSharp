// 2.Даны два числа. Показать большее и меньшее число

//Вводим две переменные
int numberA = new Random().Next(1, 20);
int numberB = new Random().Next(1, 20);
int max = numberA;
int min = numberA;

//Задаём условие для нахождения минимального и максимального
if (numberB > max) 
{
    max = numberB;
    min = numberA;
}
else
{
   max = numberA;
   min = numberB;
}

System.Console.WriteLine($"max = {max}");
System.Console.WriteLine($"min = {min}");