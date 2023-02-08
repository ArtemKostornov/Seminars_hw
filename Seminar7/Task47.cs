// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


double[,] array = new double[3, 4];
array = FillArray(array);

double GetRandomDouble(int min, int max, int round)
{
    double number = new Random().NextDouble();
    number = number *(max - min);
    number = number + min;
    return Math.Round(number, round);
}

double[,] FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = GetRandomDouble(-10,10,1);
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j],4}" + " ");
        }
        Console.WriteLine();
    }
}

PrintArray(array);