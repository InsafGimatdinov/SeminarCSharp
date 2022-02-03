// 15. Дано число. Проверить кратно ли оно 7 и 23.

// Задали значение по консоли в ручную.
System.Console.WriteLine("Введите любое число ");
int number = Convert.ToInt32(System.Console.ReadLine());

// Два числа от которых нужно плясать.
int numberA = 7;
int numberB = 23;

// задаём услови епри котором у нас число поделиться без остатка на 7 и на 23.
if ((number % numberA == 0) && (number % numberB == 0))
{
    System.Console.WriteLine("Число кратно 7 и 23, при делении остатка нет.");
    System.Console.ReadKey();
}
else
{
    System.Console.WriteLine($"Нет, число не кратно в обеих случаях или в одном \n{number % numberA}\n{number % numberB}");
    System.Console.ReadKey();
}