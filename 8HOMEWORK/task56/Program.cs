/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

string Summ(int[,] array)
{
    int[] new_arr = new int[array.GetLength(0)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        int summa = 0;
       
        for (int j = 0; j < array.GetLength(1); j++)
            summa += array[i,j];
        
        new_arr[i] = summa;
    }
    int min_sum = new_arr[0];
    int index = 0;

    for (int i = 1; i < new_arr.Length; i++)
    {   
        if (new_arr[i] < min_sum) 
        {
            min_sum = new_arr[i];
            index = i;
        }
    }
    
    return $"String №{index + 1}";
}

Console.Write("Enter the number of rows: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int column = int.Parse(Console.ReadLine());
Console.WriteLine("Enter range of numbers:");
int[,] arr_1 = MassNums(row, column,
                        int.Parse(Console.ReadLine()),
                        int.Parse(Console.ReadLine()));
Print(arr_1);
Console.WriteLine(Summ(arr_1));