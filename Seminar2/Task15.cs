// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 7 || num < 1)
{
    Console.WriteLine($"{num} -> такого дня недели нет");
}
if(num < 6 && num > 0)
{
    Console.WriteLine("нет");
}
if(num > 5 && num < 8)
{
    Console.WriteLine("да");
}