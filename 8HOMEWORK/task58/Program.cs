/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);

    return arr;
}

int[,] Multiplication(int[,] array1, int[,] array2)
{
    int[,] matrix = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
                matrix[i, j] += array1[i, k] * array2[k, j];

            //Console.WriteLine($"[{i},{j}] = {matrix[i, j]}");
        }
    }
    return matrix;
}

Console.Write("Enter the number of rows for 1st matrix: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns for 1st matrix: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine("Enter range of numbers:");
int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));

Console.Write("Enter the number of rows for 2nd matrix: ");
int row1 = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns for 2nd matrix: ");
int column1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter range of numbers:");
int[,] arr_2 = MassNums(row1, column1,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));

Print(arr_1);
Print(arr_2);
int[,] arr_mult = Multiplication(arr_1, arr_2);
Console.WriteLine();
Print(arr_mult);