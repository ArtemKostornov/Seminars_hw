// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] arr1 = new int[2, 2, 2];

for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        for (int k = 0; k < arr1.GetLength(2); k++)
        {
            arr1[i, j, k] = new Random().Next(10, 100);
        }
    }
}


void PrintArr(int[,,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            for (int k = 0; k < arry.GetLength(2); k++)
            {
                Console.Write($"{arry[i, j, k],4} ({i},{j},{k})");
            }
            
        }
        Console.WriteLine();
    }
}
PrintArr(arr1);
