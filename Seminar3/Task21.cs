// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


Console.Write("Введите x точки А: ");
int aX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y точки А: ");
int aY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z точки А: ");
int aZ = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите x точки B: ");
int bX = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите y точки B: ");
int bY = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите z точки B: ");
int bZ = Convert.ToInt32(Console.ReadLine());


double sumX = Math.Pow(bX - aX, 2);
double sumY = Math.Pow(bY - aY, 2);
double sumZ = Math.Pow(bZ - aZ, 2);
double sum = Math.Round(Math.Sqrt(sumX + sumY + sumZ), 2); 
Console.Write($"A ({aX},{aY},{aZ}); B ({bX},{bY},{bZ}) -> {sum}");