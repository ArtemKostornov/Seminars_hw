// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число N : ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число M : ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write(SumNumbers(N, M));
int SumNumbers( int num, int num1)
{
    if(num == num1+1) return 0;
    return (num + SumNumbers(num + 1, num1));
}

