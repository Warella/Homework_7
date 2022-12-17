// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();
int[,] CreateArray(int rows, int columns, int left_range, int rigth_range)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i,j] = rand.Next(left_range, rigth_range);
        }
    }
    return matrix;
}
void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
void FindAverage(int[,] array)
{
    double sum = 0;
    double result = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i,j];
        }
        result = sum / array.GetLength(0);
        Console.Write("{0:0.0}", result);
        Console.Write("; ");
        result = 0;
        sum = 0;
    }
}

int rows = 3;
int columns = 4;
int[,] matrix = CreateArray(rows, columns, 1, 10);
PrintArray(matrix);
Console.WriteLine($"Среднее арифметическое столбцов: ");
FindAverage(matrix);