﻿// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine()!;
    int result = Convert.ToInt32(value);
    return result;
}
int number = Prompt("Введите трехзначное число: ");
if (number<100 || number>=1000)
    {
        Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод");
        return;
    }
Console.WriteLine($"Введенное число {number}");
int secondRank = number /10 %10;
Console.WriteLine($"Вторая цифра {secondRank}");
