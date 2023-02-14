// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Write("Задайте размер массива, столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[4, m];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1, 10);
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

PrintArr(arr);
int summ = 0;
int summ1 = SumArr(arr, 0, summ);
int summ2 = SumArr(arr, 1, summ);
int summ3 = SumArr(arr, 2, summ);
int summ4 = SumArr(arr, 3, summ);


int SumArr(int[,] arr, int count, int summ)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        while (i == count)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                summ = arr[i,j] + summ;
                if(j == arr.GetLength(1) - 1)
                {
                    i++;
                }
            }
            
        }
    }
    return summ;
}

if (summ1 < summ2 && summ1 < summ3 && summ1 < summ4)
{
    Console.WriteLine("номер строки с наименьшей суммой элементов: 1 строка");
}
if (summ2 < summ1 && summ2 < summ3 && summ2 < summ4)
{
    Console.WriteLine("номер строки с наименьшей суммой элементов: 2 строка");
}
if (summ3 < summ2 && summ3 < summ1 && summ3 < summ4)
{
    Console.WriteLine("номер строки с наименьшей суммой элементов: 3 строка");
}
if (summ4 < summ2 && summ4 < summ3 && summ4 < summ1)
{
    Console.WriteLine("номер строки с наименьшей суммой элементов: 4 строка");
}