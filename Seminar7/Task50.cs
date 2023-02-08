
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] array = new int[4, 4];


Console.WriteLine("Введите позицию элемента в строке: ");
int numI = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите позицию элемента в столбце: ");
int numJ = Convert.ToInt32(Console.ReadLine());



int[,] FillArray(int[,] arr, int numI, int numJ)
{
    int count = 0;
    for (int i = 0; i <= arr.GetLength(0)-1; i++)
    {
        for (int j = 0; j <= arr.GetLength(1)-1; j++)
        {
            arr[i, j] = new Random().Next(0, 20);
            if(i == numI && j == numJ)
            {
                Console.WriteLine($"{i} {j} -> {arr[i,j]}");
            }
            else
            {
                count++;
            }
        }
    }
    if(count == 16)
    {
        Console.WriteLine($"{numI} {numJ} -> Такого элемента в массиве нет.");

    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
array = FillArray(array, numI, numJ);
Console.WriteLine();
PrintArray(array);