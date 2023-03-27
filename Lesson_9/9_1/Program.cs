// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N при помощи рекурсии. 
//N = 5 -> "1, 2, 3, 4, 5" 
//N = 6 -> "1, 2, 3, 4, 5, 6"

void SeriesNum(int num)
{
    if (num == 0) return;
    SeriesNum(num - 1);
    System.Console.Write($"{num}, ");
}



Console.WriteLine("Введите число: ");
int numbers = int.Parse(Console.ReadLine()!);
SeriesNum(numbers);