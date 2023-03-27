// Задача 2: Задайте значения M и N. Напишите программу, которая рекурсивно выведет все натуральные числа в промежутке от M до N. 
//M = 1; N = 5 -> "1, 2, 3, 4, 5" 
//M = 4; N = 8 -> "4, 6, 7, 8";

void SeriesNum(int numM, int numN)
{
   if (numM > numN) 
   {
    Console.WriteLine("Число М больше N ");
    return;
   }
   else
    {
        if (numM < numN ) 
        SeriesNum(numM, numN - 1);
        System.Console.Write($"{numN}, ");
    }
    
}

Console.WriteLine("Введите число М: ");
int numbersM = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int numbersN = int.Parse(Console.ReadLine()!);

SeriesNum(numbersM, numbersN);
