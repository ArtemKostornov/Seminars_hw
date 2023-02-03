// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[new Random().Next(10, 20)];

Console.Write($"[");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-30, 30);
    Console.Write($"{arr[i]} ");
}
Console.Write("] ->");
int summ = 0;

for(int i = 1; i < arr.Length; i++)
{
    if(i % 2 != 0)
    {
        summ = summ + arr[i];
    }
    
}
Console.Write(summ);