// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = new int[3, 4];
array = FillArray(array);


int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 11);
        }
    }
    return arr;
}



void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j],4}");
        }
        Console.WriteLine();
    }
}

PrintArray(array);

void ColumnSredn(int [,] arr)
{
    double sum1 = 0.0;
    double sum2 = 0.0;
    double sum3 = 0.0;
    double sum4 = 0.0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
           if(j == 0)
           {
            sum1 +=  arr[i,j];
           }
           if(j == 1)
           {
            sum2 +=  arr[i,j];
           }
           if(j == 2)
           {
            sum3 +=  arr[i,j];
           }
           if(j == 3)
           {
            sum4 +=  arr[i,j];
           }
        }
     }
     double sredn1 = Math.Round(sum1 / arr.GetLength(0),2);
     double sredn2 = Math.Round(sum2 / arr.GetLength(0),2);
     double sredn3 = Math.Round(sum3 / arr.GetLength(0),2);
     double sredn4 = Math.Round(sum4 / arr.GetLength(0),2);
     Console.Write($"Среднее арифметическое каждого столбца:{sredn1};{sredn2};{sredn3};{sredn4}.");
}

ColumnSredn(array);