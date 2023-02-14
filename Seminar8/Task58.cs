// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] arr1 = new int[2, 2];

for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        arr1[i, j] = new Random().Next(1, 10);
    }
}

void PrintArr(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j],4}");
        }
        Console.WriteLine();
    }
}

PrintArr(arr1);

int[,] arr2 = new int[2, 2];

for (int i = 0; i < arr2.GetLength(0); i++)
{
    for (int j = 0; j < arr2.GetLength(1); j++)
    {
        arr2[i, j] = new Random().Next(1, 10);
    }
}

Console.WriteLine();
PrintArr(arr2);

int[,] ArrPow(int[,] arr1, int[,] arr2)
{
    int[,] arr3 = new int[2, 2];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr1.GetLength(1); j++)
        {
            if (j == 0 && i == 0)
            {
                arr3[i, j] = (arr1[i, j] * arr2[i, j]) + (arr1[i, j + 1] * arr2[i + 1, j]);
            }
            if(i == 0 && j == 1)
            {
                arr3[i, j] = (arr1[i, j-1] * arr2[i, j]) + (arr1[i, j] * arr2[i + 1, j]);
            }
            if(i == 1 && j == 0)
            {
                arr3[i, j] = (arr1[i, j] * arr2[i-1, j]) + (arr1[i, j+1] * arr2[i, j]);
            }
             if(i == 1 && j == 1)
            {
                arr3[i, j] = (arr1[i, j-1] * arr2[i-1, j]) + (arr1[i, j] * arr2[i, j]);
            }
        }
    }
    return arr3;
}






int[,] arr3 =  new int[2,2];
arr3 = ArrPow(arr1, arr2);

Console.WriteLine("Результирующая матрица будет:");
PrintArr(arr3);
