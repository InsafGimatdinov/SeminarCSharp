// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

//Задали отрезок для числа
int number = new Random().Next(10, 99);

Console.WriteLine(number);

//Расписаны варианты для нахождения цифр в числе
int result = number % 10;
int result1 = number / 10;
int result2 = result1 % 10;

int max = result;

//Задали условие для нахождения максимальной цифры
if (result2 > result) 
{
    Console.WriteLine($"max = {result2}");
}
else
{
    Console.WriteLine($"max = {result}");
} 