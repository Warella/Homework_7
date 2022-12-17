// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
int InputNumber(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
double[,] CreateArray(int rows, int columns, int left_range, int rigth_range)
{
    double[,] matrix = new double[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(left_range, rigth_range) + rand.NextDouble();
            matrix[i, j] = Math.Round(matrix[i, j], 1);
        }
    }
    return matrix;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int m = InputNumber("Введите значение m: ");
int n = InputNumber("Введите значение n: ");
double[,] matrix = CreateArray(m, n, -10, 10);
PrintArray(matrix);