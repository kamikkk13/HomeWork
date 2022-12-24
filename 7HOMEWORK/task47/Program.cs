//* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.  0,5 7 -2 -0,2  1 -3,3 8 -9,9  8 7,8 -7,1 9

double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minvalue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxvalue = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble(), 2);
            array[i, j] = array[i, j] + new Random().Next(minvalue, maxvalue + 1);
        }
    }
    return array;
}
void Show2dArray (double[,] array) // в одну строку выводить двумерные нельзя
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);