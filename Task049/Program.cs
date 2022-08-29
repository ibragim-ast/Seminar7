// Задайте двумерный массив. Найдите элементы, у которых оба индекса нечетные, 
// и замените эти элементы на их квадраты

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; ++row)
    {
        for (int column = 0; column < columnCount; ++column)
        {
            array[row, column] = new Random().Next(min, max);
        }
    }
    return array;
}

int[,] ReplaceIndexOnCube(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            if(row % 2 == 1 && column % 2 == 1)
            array[row, column] *= array[row, column];
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

int[,] array = CreateMatrix(4, 4, 1, 10);
PrintMatrix(array);
System.Console.WriteLine();
array = ReplaceIndexOnCube(array);
PrintMatrix(array);