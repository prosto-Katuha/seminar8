// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
// программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int GetUniqNumber(int[] intArray)
{
    int nextNumber;
    do
    {
        nextNumber = new Random().Next(10, 100);
    }
    while (intArray[nextNumber] != 0);
    intArray[nextNumber] = 1;
    return nextNumber;
}
int[,,] Generate3DArray(int rows, int columns, int layers, int[] intArray)
{
    int[,,] returnArray = new int[rows, columns, layers];

    if (rows * columns * layers < 90)
    {
        for (int i = 0; i < returnArray.GetLength(0); i++)
        {
            for (int j = 0; j < returnArray.GetLength(1); j++)
            {
                for (int k = 0; k < returnArray.GetLength(2); k++)
                {
                    returnArray[i, j, k] = GetUniqNumber(intArray);
                }
            }
        }
    }
    else
    {
        Console.WriteLine("Слишком большой массив для уникальных двухзначных чисел");
    }
    return returnArray;

}
void Print3DArray(int[,,] int3DArray)
{
    for (int i = 0; i < int3DArray.GetLength(0); i++)
    {
        for (int j = 0; j < int3DArray.GetLength(1); j++)
        {
            for (int k = 0; k < int3DArray.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] {int3DArray[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[] intArray = new int[100];
int[,,] array3D = Generate3DArray(2, 2, 2, intArray);
Print3DArray(array3D);
System.Console.WriteLine();