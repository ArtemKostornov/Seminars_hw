// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 
 Console.Write("Введите число A: ");
 int A = int.Parse(Console.ReadLine());

 Console.Write("Введите число B: ");
 int B = int.Parse(Console.ReadLine());

 int count = 2;
 int proisv = A;
 
 if(B == 0)
 {
    Console.WriteLine($"{A}, {B} -> 0");
 }
 else
 {
    while(count <= B)
    {
        proisv = proisv * A;
        count = count + 1;
    }
    Console.WriteLine($"{A}, {B} -> {proisv}");
 }