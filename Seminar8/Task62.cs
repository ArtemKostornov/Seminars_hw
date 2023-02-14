// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int[,] arr1 = new int[4, 4];
int count = 1;

for (int i = 0; i < arr1.GetLength(0); i++)
{
    for (int j = 0; j < arr1.GetLength(1); j++)
    {
        while (count >= 1 && count < 5)
        {
            arr1[i, j] = count;
            count++;
            if (j != 3)
            {
                j++;
            }
        }
        while (count >= 4 && count < 8)
        {
            if (i != 3)
            {
                i++;
            }
            arr1[i, j] = count;
            count++;
        }
        while (count >= 8 && count < 11)
        {
            j--;
            arr1[i, j] = count;
            count++;
        }
        while (count >= 11 && count < 13)
        {
            i--;
            arr1[i, j] = count;
            count++;
        }
        while (count >= 13 && count < 15)
        {
            if (j != 3)
            {
                j++;
            }
            arr1[i, j] = count;
            count++;
        }
        while (count >= 15 && count < 16)
        {
            i++;
            arr1[i, j] = count;
            count++;
        }
        while (count >= 16 && count < 17)
        {
            j--;
            arr1[i, j] = count;
            count++;
        }

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