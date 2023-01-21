//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write(num + " -> ");
for(int n = 1; n <= num; n++)
{
    Console.Write(Math.Pow(n, 3) + " ");
}
