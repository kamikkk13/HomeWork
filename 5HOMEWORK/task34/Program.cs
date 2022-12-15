int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for(int i = 0; i <size; i++)
        array[i] = new Random().Next(100, 1000); 
    return array;
}   
void Showarray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[" + array[i] + ", ");
        else
        {
            if (i == array.Length - 1) Console.Write(array[i] + "]");
            else
                Console.Write(array[i] + ", ");
        }
    }
}
int EvenIntQuantity (int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;
    return count;
}
Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray(size, min, max);
Console.WriteLine("Array is: ");
Showarray(myArray);
int count = EvenIntQuantity(myArray);
Console.WriteLine();
Console.WriteLine("Quantity of even integers in array is: " + count);