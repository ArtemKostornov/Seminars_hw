//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int summ = 0;
int num1 = num;

while(num1 > 9)
{
    summ = summ + (num1 % 10);
    num1 = num1 / 10;
    if(num1 < 10)
    {
        summ = summ + num1;
    }

}
if(num < 10)
    {
        summ = summ + num % 10;
    }

Console.WriteLine(summ);