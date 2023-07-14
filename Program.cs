/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными(тип double) числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

/* Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(m, n);
PrintArray(array);

double[,] GetArray(int rows, int columns)
{
    double[,] result = new bouble [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().NextDouble();
        }
    }
}

void PrintArray(double[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0;  j < inArray.GetLength(0); j++)
        {
            Console.WriteLine($"({Math.Round(inArray[i, j], 2)}  ");
        }
        Console.WriteLine();
    }
}
*/

/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
*/

/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 1, j = 2 -> 2
i = 4, j = 2 -> такого элемента не существует
*/

/* int rows = 4;
int columns = 4;
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine()!);

PrintFindNumber(rows, columns, row, column);

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns]
    for(int i = 0; i < rows, i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++);
    {
        for(int j = 0; j < inArray.GetLength(0); j++);
        {
        Console.WriteLine($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void PrintFindNumber(nt rows, int columns, int row, int column)
{
    if(row < rows || column < columns)
    {
        Console.WriteLine($"строкa = {rows}, колонкa = {columns}  -> {array[row, column]}");
    }
    else
    {
        Console.WriteLine("Такого элемента нет");
    }
}
*/
