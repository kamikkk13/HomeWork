/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
    
    Массив размером 2 x 2 x 2
    66(0,0,0) 25(0,1,0)
    34(1,0,0) 41(1,1,0)
    27(0,0,1) 90(0,1,1)
    26(1,0,1) 55(1,1,1)
*/

void InputCube(int[,,] cube)            
{
    int elementsCount = 0;

    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(0); j++)
        {
            for (int k = 0; k < cube.GetLength(0); k++)
            {
                cube[i,j,k] = elementsCount;
                elementsCount++;
            }
        }
    }
}

void PrintCube(int[,,] cube)            
{
    int elementsCount = 0;

    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(0); j++)
        {
            for (int k = 0; k < cube.GetLength(0); k++)
            {
                Console.Write($"{cube[i,j,k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }      
    }
}

int[,,] cube = new int[2,2,2];

InputCube(cube);

PrintCube(cube);

