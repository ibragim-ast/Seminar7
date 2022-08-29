// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами(0,0);(1,1) и т.д.

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

void SumDiagonalMatrix(int[,] array)
{
    int sum = 0;
    int column = 0;
    for (int row = 0; row < array.GetLength(0); row++)
    {
            if(row == column)
            sum += array[row, column];
            column++;
    }
    System.Console.WriteLine($"Сумма элементов, находящихся на главной диагонали: {sum}");
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
SumDiagonalMatrix(array);