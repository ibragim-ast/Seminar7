// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали (с индексами(0,0);(0,1) и т.д.

int[,] CreateMeatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; ++row)
    {
        for (int column = 0; column < columnCount; ++column)
        {
            array[row, column] = new Random().Next(min, max+1);
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

int[,] DiagonalSum(int[,] matrix)
{

    int result = 0;
    for (int row = 0; i < matrix.GetLength; row++)
    {
        result = matrix[row] + matrix[column];
        matrix[row]++;
        matrix[column]++
    }
    return result;
}

int[,] array = CreateMeatrix(4, 4, 10, 99);
PrintMatrix(array);
int result = DiagonalSum(matrix);
PrintMatrix
