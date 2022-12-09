int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}
void Massiv(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(1000);
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int num = ReadNumber("Введите число:");
Massiv(num);
