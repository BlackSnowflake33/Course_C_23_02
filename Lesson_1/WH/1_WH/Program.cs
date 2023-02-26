// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
int max = a;
if(max>b)
    {
        Console.Write("max = ");
        Console.Write(max);
    }
else
    {
        max = b;
       Console.Write("max = ");
        Console.Write(max); 
    }