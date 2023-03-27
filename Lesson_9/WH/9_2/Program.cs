// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии. 
//M = 1; N = 15 -> 120 
//M = 4; N = 8 -> 30


int SumFromTo(int m, int n)
{
    int sumNum = m;
    if (m > n) return 0;
     else
        sumNum = sumNum + SumFromTo(m + 1, n);
    return sumNum;

}

Console.WriteLine("Введите число А: ");
int numbersA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В: ");
int numbersB = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumFromTo(numbersA, numbersB));