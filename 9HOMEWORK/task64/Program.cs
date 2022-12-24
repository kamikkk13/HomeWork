string rec(int n)
{
    if (n == 2)
        return "2 ";
    if (n % 2  == 1)
    {
        n = n - 1;
        return rec(n - 2) + $"{n} ";
    }
    else return rec(n - 2) + $"{n} ";
}

Console.Clear();
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(rec(n));