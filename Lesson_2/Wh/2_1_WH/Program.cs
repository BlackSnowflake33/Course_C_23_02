// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int TakeNum(int num)
{
        return (num/10) % 10;
}

Console.WriteLine("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);

int result = TakeNum(num);
Console.WriteLine(result);