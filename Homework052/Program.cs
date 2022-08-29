
int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
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

void SumColums(int[,] array)
{
    int length = array.GetLength(0);
    double[] newArray = new double[length];
    double rowLength = array.GetLength(1);
    for (int i = 0; i < length; i++)
    {
        int temp = 0;
        for (int j = 0; j < rowLength; j++)
        {
            temp += array[j,i];
            newArray[i] = temp / rowLength;
        }
        System.Console.Write($"{newArray[i]} "); 
    }
    
}

int[,] array = CreateMatrix(5, 5, 1, 10);
PrintMatrix(array);
System.Console.WriteLine();
SumColums(array);