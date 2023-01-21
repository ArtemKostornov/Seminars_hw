// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    num = num * -1;
}
if (num < 100 || num > 999)
{
    Console.WriteLine($" {num} не трёхзначное число, ошибка ввода ");
}
else
{
    num = num / 10 % 10;
    Console.WriteLine($" {num} ");
}