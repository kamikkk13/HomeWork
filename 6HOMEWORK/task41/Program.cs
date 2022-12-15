void Number()
{
    bool result = true;
    int count = 0;

    while (result)
    {
        string num = Console.ReadLine();

        if (num == "")
            result = false;
        else if (int.Parse(num) > 0)
            count++;
    }
    Console.WriteLine($"Количество чисел больше нуля равно {count}");
}
Number();