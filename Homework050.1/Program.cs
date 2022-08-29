
// Напишите программу, которая на вход принимает позиции элемента в двумерном массивеи возвращает значение
// этого элемента или же указание, что такого элемента нет.

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

void FindElement(int[,] array)
{
    Console.WriteLine("Введите введите число");
    int num = Convert.ToInt32(Console.ReadLine()); 
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (num == array[i,j])
            {   result++;
                System.Console.WriteLine($"Число {num} находится на позиции {i};{j}");}
        }
    }
    if (result == 0)
        System.Console.WriteLine("Такого числа нет в массиве");
}

int[,] array = CreateMatrix(5, 5, 1, 10);
PrintMatrix(array);
FindElement(array);
