Console.WriteLine("Введите число 1: ");
int number1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int number2 = Int32.Parse(Console.ReadLine());

if (number2 < number1)
{
    Console.WriteLine($" max= {number1} min= {number2}");
}
if (number2 == number1)
{
    Console.WriteLine($" Вы ввели одинаковые числа");
}
else
{
    Console.WriteLine($" max= {number2} min= {number1}");
}