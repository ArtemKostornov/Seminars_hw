//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] arr = new int[5];
Console.WriteLine("Введите 5 чисел: ");

int count = 0;

for (int i = 0; i < 5; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
    if(arr[i] > 0)
    {
        count ++;
    }
}

Console.Write($" -> {count}");
