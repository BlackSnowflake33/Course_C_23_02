// Задача 4: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии. 
//A = 3; B = 5 -> 243 
//(3⁵) A = 2; B = 3 -> 8

int PowerNum(int a, int b)
{
    if (b==0) return 1;
    return a*PowerNum(a,b-1);
   
}



Console.WriteLine("Введите число А: ");
int numbersA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В: ");
int numbersB = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {numbersA} в степени {numbersB}: {PowerNum(numbersA, numbersB)}");