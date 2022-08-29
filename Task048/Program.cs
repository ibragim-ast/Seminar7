// 
int[,] CreateMeatrix(int rowCount, int columnCount)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; ++row)
    {
        for (int column = 0; column < columnCount; ++column)
        {
            array[row, column] = array[row] + array[column] ;
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

int[,] array = CreateMeatrix(3, 4);
PrintMatrix(array);
