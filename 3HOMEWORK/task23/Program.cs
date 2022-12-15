void Tabl(int n)
{
    int count = 1;
    while (count <= n)
        {
            if (count == n)
            {
                double kub = Math.Pow(count,3);
                Console.Write($"{kub}");
                Console.WriteLine();
            }
            else
            {
                double kub = Math.Pow(count,3);
                Console.Write($"{kub}, ");
            }

            count +=1;
        }
}
Console.WriteLine("Введите число:");
Tabl(int.Parse(Console.ReadLine()));