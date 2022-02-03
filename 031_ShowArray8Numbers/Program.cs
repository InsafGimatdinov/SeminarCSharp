// 31. Задать массив из 8 элементов и вывести их на экран.

// Для того чтобы задать воспользуемся вот таким вот методом.
void FillArray(int[] ArrayShow) 
{
    int size = ArrayShow.Length; // В данном случае это размер массива.
    // for это короткая запись цикла.
    for (int i = 0; i < size; i++)
    {
        ArrayShow[i] = new Random().Next(1, 10); // Сгенерировали случайные числа в массиве.
    }
}

// Для показа массива в консоли воспользуемся данным методом.
void PrintArray(int[] ArrayWrite) 
{
    int count = ArrayWrite.Length; // В данном случае это размер массива.
    for (int pos = 0; pos < count; pos++)
    {
        System.Console.WriteLine(ArrayWrite[pos]); // Команда вызова массива на экран консоли.
    }
}

int[] array = new int[8]; // Мы даем понять программе массив из скольки чисел нам нужен.

FillArray(array);
PrintArray(array);