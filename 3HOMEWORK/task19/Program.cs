string Polindrom(string str)
{
    int n = str.Length;
    int count = 0;
    int half = n / 2;
    while (count < half)
    {
        if (str[count] == str[n-1])
        {
            n--; 
            count++;      
        }  
        else
            break;
    }
    if (half == count)
        return "Полиндром";
    else
        return "Не полиндром";
}

Console.WriteLine("Bведите число:");
Console.WriteLine(Polindrom(Console.ReadLine()));
