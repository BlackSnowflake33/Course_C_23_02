﻿// Задача 3. Напишите программу 10 мин, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int N1 = -N;
while(N1<=N)
    {
        Console.Write($"{N1} ");
        N1 = N1+1;
    }
