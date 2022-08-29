
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
    Console.WriteLine("Введите номер строки");
    int userRow = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца");
    int userColumn = Convert.ToInt32(Console.ReadLine());

    if (userRow > array.GetLength(0) || userColumn > array.GetLength(1))
        System.Console.WriteLine($"Элемент со значениями {userRow};{userColumn} в массиве отсутствует"); 
    else if (userRow < 0 || userColumn < 0) 
        System.Console.WriteLine("Некорректное значение позиции элемента. Попробуйте еще раз");  

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == userRow && j == userColumn)
                System.Console.WriteLine($"Элемент со значениями {userRow};{userColumn} в массиве: {array[i,j]}");
        }
        
    }

}

int[,] array = CreateMatrix(5, 5, 1, 10);
PrintMatrix(array);
FindElement(array);