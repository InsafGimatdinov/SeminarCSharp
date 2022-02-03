// 10. Показать вторую цифру трёхзначного числа

//Ввели число наугад
int number = 255;

//В начале отбросили третье значение
int result = number / 10;

//Высчитали второе значение числа
int result1 = result % 10;

System.Console.WriteLine(result1);