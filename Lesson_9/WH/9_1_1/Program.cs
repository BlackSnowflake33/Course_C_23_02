// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N 
//с помощью рекурсии. 
//M = 1; N = 5 -> "2, 4" 
//M = 4; N = 8 -> "4, 6, 8"

void EvenNum(int numM, int numN)
{
    if (numM >= numN) return;

    else if (numN % 2 != 0)
    {
        numN = numN - 1;
        EvenNum(numM, numN - 1);
        Console.Write($"{numN}, ");
    }
    else if (numN % 2 == 0)
    {
        EvenNum(numM, numN - 2);
        Console.Write($"{numN}, ");
    }
}

Console.WriteLine("Введите число М: ");
int numbersM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int numbersN = int.Parse(Console.ReadLine()!);

EvenNum(numbersM, numbersN);