Console.WriteLine("Введите число : ");
int number1 = Int32.Parse(Console.ReadLine());

if (number1 % 2 == 0 )
{
   
   Console.WriteLine($"чётное");
    
}
else
{
    Console.WriteLine($"нечётное");
}

// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).