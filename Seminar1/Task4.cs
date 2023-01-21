Console.WriteLine("Введите число 1: ");
int number1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int number2 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Введите число 3: ");
int number3 = Int32.Parse(Console.ReadLine());


if (number1 > number2)
{
    if (number1 > number3)
    {
        Console.WriteLine($" max= {number1}");
    }
}
else
{
   if (number2 > number3)
   {
    Console.WriteLine($" max= {number2} ");
   } 
   else
   {
    Console.WriteLine($" max= {number3}");
   }
}
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
