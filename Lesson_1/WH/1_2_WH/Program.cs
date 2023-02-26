// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if(max<b)
    {
       max = b;
    }
if(max<c)
    {
       max = c;
    }

Console.Write("max = ");
Console.Write(max); 