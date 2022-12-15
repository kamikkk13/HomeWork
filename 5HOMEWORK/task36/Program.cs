void Print(int[] arr_1)
{
    int num = arr_1.Length;

    for (int i = 0; i < num; i++)
        Console.Write($"{arr_1[i]} ");
    
    Console.WriteLine();
}

int[] Massiv(int size, int begin, int end)
{
    int[] arr_1 = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr_1[i] = new Random().Next(begin, end);
    }
    return arr_1;
}  

int Summ(int[] arr_1)
{
    int sum = 0;
    
    for (int i = 0; i < arr_1.Length; i++)
    {
        if (i % 2 == 0)
            sum += arr_1[i] ; 
    }
    return sum;
}

int[] arr = Massiv(int.Parse(Console.ReadLine()),  // количество элементов массива
                   int.Parse(Console.ReadLine()),  // begin
                   int.Parse(Console.ReadLine())); // end
Print(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {Summ(arr)}");