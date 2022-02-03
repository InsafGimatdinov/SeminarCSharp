// 3. Найти минимальное из трех чисел

//Зададимся переменными
int A = new Random().Next(1, 50);
int B = new Random().Next(1, 40);
int C = new Random().Next(1, 30);

//Для проверки работоспособности программы выводим то, что получается в наборе случайных чисел
System.Console.WriteLine(A);
System.Console.WriteLine(B);
System.Console.WriteLine(C);

//Изначально присваиваем минимум первой переменной
int min = A;

//Задаём условие проверки на минимум
if (B < min) min = B;
if (C < min) min = C;

//Выводим минимальное значение из 3
Console.WriteLine($"min = {min}");