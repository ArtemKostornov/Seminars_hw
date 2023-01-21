// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндром.
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99999 || num < 10000)
{
    Console.WriteLine("ошибка ввода");
}
else
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num / 10 % 10;
    int num5 = num % 10;
    if(num1 == num5 && num2 == num4 )
    {
        Console.WriteLine($"{num} -> да");
    }
    else
    {
         Console.WriteLine($"{num} -> нет");
    }
}