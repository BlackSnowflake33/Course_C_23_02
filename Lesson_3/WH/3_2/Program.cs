﻿// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double Dis(double x1, double y1, double z1, double x2, double y2, double z2)
{
return Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2-y1,2)+ Math.Pow(z2-z1,2));
}
Console.WriteLine("Введите координаты первой точки: ");
double x1 = double.Parse(Console.ReadLine()!);
double y1 = double.Parse(Console.ReadLine()!);
double z1 = double.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты второй точки: ");
double x2 = double.Parse(Console.ReadLine()!);
double y2 = double.Parse(Console.ReadLine()!);
double z2 = double.Parse(Console.ReadLine()!);


Console.WriteLine($"Ростояние между точками: {Math.Round(Dis(x1, y1, z1, x2, y2, z2),2)}");
