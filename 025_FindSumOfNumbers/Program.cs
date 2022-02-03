// 25. Найти сумму чисел от 1 до А.

// Ввели число с консоли.
System.Console.WriteLine("Введите число А ");
long numberA = Convert.ToInt64(System.Console.ReadLine());

DateTime dt = DateTime.Now; // Текущее время.
// Ввели некую переменную sum и присвоили ей значение 0.
long sum = 0;

// Воспользовались циклом for.
// for (long i = 1; i <= numberA ; i++)
// {
//     sum = sum + i;  
// }
sum = numberA * (numberA + 1) / 2;
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
System.Console.WriteLine(sum);