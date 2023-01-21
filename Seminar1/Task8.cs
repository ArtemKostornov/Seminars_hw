Console.WriteLine("Введите число : ");
int number = Int32.Parse(Console.ReadLine());

int count = 1;

while (count < number)
{
    if (count % 2 == 0)
    {
        Console.Write(count + ", ");
        count = count + 2;
    }
    else
    {
        count = count + 1;
    }
}
Console.Write("\b\b  ");
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.