// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

void Triangle(int a, int b, int c)
{
    if(a<b+c & b<a+c & c< a+b)
        Console.WriteLine("Треугольник существует со сторонами такой длины");
    else
        Console.WriteLine("Треугольник не существует со сторонами такой длины");
}

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

Triangle(a,b,c);