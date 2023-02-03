// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] arr = new int[new Random().Next(0, 10)];

Console.Write($"[");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-5, 10);
    Console.Write($"{arr[i]} ");
}
Console.Write("] ->");
int deff = 0;
int max = 1;
int min = 0;


for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > arr[max])
    {
        max = i;
    }
    if (arr[i] < arr[min])
    {
        min = i;
    }
}


deff = arr[max] - arr[min];
Console.WriteLine(deff);
Console.WriteLine(arr[max]);
Console.WriteLine(arr[min]);