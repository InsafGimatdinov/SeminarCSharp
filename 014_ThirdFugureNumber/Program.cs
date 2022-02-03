// 14. Найти третью цифру числа или сообщить, что её нет.

System.Console.WriteLine("Введите любое целое число ");
int number = Convert.ToInt32(System.Console.ReadLine());

// Задали условие при котором третья цифра может быть только в этих пределах
if ((number > 99) && (number < 1000))
{
    System.Console.WriteLine(number % 10);
    System.Console.ReadKey();
}
else
{
    System.Console.Write("В этом числе нет третьей цифры ");
    System.Console.ReadKey();
}