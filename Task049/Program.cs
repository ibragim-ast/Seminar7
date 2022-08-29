// Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, 
// и замените эти элементы на их квадраты

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

int[,] MatrixCube(int[,] matrix)
{
    int[,] newMatrix = new int[row, column];
    int length = matrix.GetLength;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] % 2 == 1)
            matrix[i,j] *= matrix[i,j];
        }
    }
    return matrix;
}



int[,] matrix = CreateMeatrix(5, 5, 0, 99);
PrintMatrix(matrix);
int[,] newMatrix = MatrixCube(matrix);
PrintMatrix(newMatrix);