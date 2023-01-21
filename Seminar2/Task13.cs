//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 0)
{
    num = num * -1;
}
if(num < 100)
{
    Console.WriteLine($"{num} -> третьей цифры нет ");
}
while (num > 1000)
{
    num = num/10;
}
if (num < 1000)
{
    Console.WriteLine($" {num%10}");
}