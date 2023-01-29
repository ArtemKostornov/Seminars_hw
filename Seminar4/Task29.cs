//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] collection)


{
    int lenght = collection.Length;
    int index = 0;
    Console.Write("Введите диапазон массива от ..");
    int begin = int.Parse(Console.ReadLine());
    Console.Write("до");
    int end = int.Parse(Console.ReadLine());
    while (index < lenght)
    {
        collection[index] = new Random().Next(begin, end);
        index ++;
    }
}

void PrintArray(int [] shnyaga)
{
    int count = shnyaga.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{shnyaga[position]}, ");
        position ++;
    }
}

Console.Write("Введите размер массива: ");
int [] array = new int[int.Parse(Console.ReadLine())];
FillArray(array);
PrintArray(array);