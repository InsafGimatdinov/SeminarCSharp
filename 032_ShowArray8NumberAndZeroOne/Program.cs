// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран.

void FillArray(int[] arrayToFill)
{
    for (int i = 0; i < arrayToFill.Length; i++)
    {
        arrayToFill[i] = new Random().Next(0, 2);
    }
}

void ShowArray(int[] arrayToShow)
{
    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write($"[{i}]:{arrayToShow[i]}");
    }
    Console.WriteLine();
}

int[] array = new int[8];
FillArray(array);
ShowArray(array);