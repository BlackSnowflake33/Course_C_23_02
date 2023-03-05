// Напишите программу, которая принимает на вход координаты 2-х точек и 
// находит расстояние между ними в 2D пространстве.


Console.WriteLine("Hello, World!");

double Dis(double x1, double y1, double x2, double y2)
{
return Math.Sqrt(Math.Pow(x2-x1,2)+ Math.Pow(y2-y1,2));
}
Console.WriteLine(Dis(3, 6, 2, 1));