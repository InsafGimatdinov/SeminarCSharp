// 9. Показать последнюю цифру трёхзначного числа

// int number = 387;

System.Console.WriteLine("Введите число трёхзначное");
int number = Convert.ToInt32(System.Console.ReadLine());
if (number >= 100 && number < 1000)
{
    System.Console.WriteLine(number % 10);
}
else
{
    System.Console.WriteLine("Введено некорректное значение");
}