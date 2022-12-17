// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
Console.Clear();
int InputNumber(string msg)
{
    Console.WriteLine(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}
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
void FindElement(int[,] array, int row, int column)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == row || j == column)
            {
                Console.WriteLine($"{array[i,j]}");
            }
            else
            {
                Console.WriteLine("Такого элемента нет");
            }    
            break;
        }
    }
}
int m = InputNumber("Введите значение m: ");
int n = InputNumber("Введите значение n: ");
int[,] matrix = CreateArray(m, n, -10, 10);
PrintArray(matrix);
int row = InputNumber("Введите номер строки: ");
int column = InputNumber("Введите номер столбца: ");
FindElement(matrix, row, column);