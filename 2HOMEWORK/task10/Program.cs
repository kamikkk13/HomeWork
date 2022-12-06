int a = 0;
int b = 0;

Console.Write("Введите трехзначное число: ");
a = int.Parse(Console.ReadLine());

b = a / 10 % 10;

System.Console.WriteLine($"Вторая цифра числа {a} - это {b} ");