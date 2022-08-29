// Задайте двумерный массив размером m на n, заполненный случайными целыми числами. Каждый элемент массива
// находится по формуле Amn = m + n. Выведенный массив выводится на экран

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; ++row)
    {
        for (int column = 0; column < columnCount; ++column)
        {
            array[row, column] = row + column;
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); ++row)
    {
        for (int column = 0; column < arr.GetLength(1); ++column)
        {
           System.Console.Write($"{arr[row, column]}\t");
        }
        System.Console.WriteLine();
    }
}

int[,] array = CreateMatrix(3, 4, 0, 10);
PrintMatrix(array);
