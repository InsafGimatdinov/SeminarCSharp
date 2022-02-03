// 8. Показать четные числа от 1 до N

//Ввели массив с определенным размером и начальным индексом
// int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 4,2,46, 7, 44, 2, 4, 567, 7, 435, 2};
// int size = array.Length;
// int index = 0;

// //Задаём цикл для выполнения проверки
// while (index < size)
// {
//     if (array[index] % 2 == 0)
//     {
//         //Выводим новый массив только уже с четными значениями
//         Console.WriteLine(array[index]);
//     }
//     //Именно индекс увеличиваем иначе будет зацикливание
//     index++;
// }


// Возможен и такой вариант работы.

System.Console.WriteLine("Введите значение N");
int N = Convert.ToInt32(System.Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        System.Console.WriteLine(i);
    }
}
// while (N <= 30)
// {
//     if (N % 2 == 0)
//     {
//         System.Console.WriteLine(N); 
//     }
//     N++;
// }