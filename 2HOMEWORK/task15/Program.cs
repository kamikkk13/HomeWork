string Week(int data)
{
    if (data == 6 || data == 7)
        return "day off";
    else
        return "weekday";           
}

Console.WriteLine("Input number:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Week(num));