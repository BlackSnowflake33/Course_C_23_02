﻿// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N 
//с помощью рекурсии. 
//M = 1; N = 5 -> "2, 4" 
//M = 4; N = 8 -> "4, 6, 8"

int[] ComparisonNum(int numM, int numN)
{
    int[] arr = new int[1]; // Задаем массив 
    if (numM > numN)
    {
        Console.WriteLine("Число М больше N, меняем местоами M и N ");
        (numM, numN) = (numN, numM);
    }
    arr[1] = numM;
    arr[2] = numN;
    return arr;
}

Console.WriteLine("Введите число М: ");
int numbersM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int numbersN = int.Parse(Console.ReadLine()!);

int[] arr = ComparisonNum(numbersM, numbersN);
Console.WriteLine($"{arr[1]}, {arr[2]}");

