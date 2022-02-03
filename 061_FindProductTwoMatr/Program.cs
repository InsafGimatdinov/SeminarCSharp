// 61. Найти произведение двух матриц.

int[,] CreateArray(int rowsLength, int columnsLength)
{
    int[,] arrayCreate = new int[rowsLength, columnsLength];
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            arrayCreate[i, j] = new Random().Next(1, 20);
        }
    }
    return arrayCreate;
}

void ShowArray(int[,] arrayToShow)
{
    for (int i = 0; i < arrayToShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToShow.GetLength(1); j++)
        {
            Console.Write($"[{i}{j}]:{arrayToShow[i,j]}\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ProductTwoArray(int[,] matrix1, int[,] matrix2)
{
    int[,] arrayToProduct = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (var i = 0; i < matrix1.GetLength(0); i++)
    {
        for (var j = 0; j < matrix2.GetLength(1); j++)
        {
            for (var k = 0; k < matrix1.GetLength(1); k++)
            {
                arrayToProduct[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return arrayToProduct;
}

int[,] matrix1 = CreateArray(3, 4);
ShowArray(matrix1);
Console.WriteLine();
int[,] matrix2 = CreateArray(4, 3);
ShowArray(matrix2);
Console.WriteLine();
int[,] arrayToProduct = ProductTwoArray(matrix1, matrix2);
ShowArray(arrayToProduct);