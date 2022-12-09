int ReadNumber(string message)
{
    Console.Write(message);
    var s = Console.ReadLine();
    int a = s == null ? 0 : int.Parse(s);
    return a;
}

void deegree(int num1, int num2)
{
    int pr = 1;
    for (int i = 0; i < num2; i++)
    {
        pr *= num1;
    }
    Console.WriteLine($"{num1}^{num2} = {pr}");
}

int a = ReadNumber("Введите число 1:");
int b = ReadNumber("Введите число 2:");
deegree(a,b);