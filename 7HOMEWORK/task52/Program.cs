/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/



int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minvalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxvalue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minvalue, maxvalue +1);
    }
    return array;
}

void Show2dArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

void AverageColumns (int[,] array)
{
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {            
            sum = sum + array[i, j];
        }
        average = sum / array.GetLength(0);
        double[] newArray = new double[array.GetLength(1)];
        int ind = 0;
        newArray[ind] = Math.Round(average, 1);
        Console.Write(newArray[ind] + "; ");
    }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
AverageColumns(myArray);