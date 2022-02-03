// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

// Задали две строковые переменные X и Y.
string X = "True";
string Y = "True";

// Преобразовали эти переменные в булевый тип переменных.
bool myBool = bool.Parse(X);
bool myBool1 = bool.Parse(Y);

// В данном случае все решено поэтапно.
// 1 
bool result = myBool || myBool1;
System.Console.WriteLine(result); // Да

// 2
bool result1 = !result;
System.Console.WriteLine(result1); // Да

// 3
bool result2 = !myBool & !myBool1;
System.Console.WriteLine(result2); // Да

// 4
if (result1 == result2)
{
    System.Console.WriteLine("True");
}
else
{
    System.Console.WriteLine("False");
}

/*
    Возможно и такое решение то есть в одну строку
*/

// if (!(myBool || myBool1) == !myBool & !myBool1)
// {
//     System.Console.Write("True");
//     System.Console.WriteLine($"myBool || myBool1 = {myBool || myBool1}");
// }
// else
// {
//     System.Console.WriteLine("False");
// }