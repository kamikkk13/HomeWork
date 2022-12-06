string Number(int n)
{
    if (n < 100)
        return "not have third number";
    else if (n > 99 && n < 1000)
        return $"Number is {n % 10}"; 
    else
    {
        while (n > 1000)
        {
            n = n / 10;
        }   
    }
        return $"Number is {n % 10}";  

}

Console.WriteLine("Input number:");
int num = int.Parse(Console.ReadLine());
Console.WriteLine(Number(num));
