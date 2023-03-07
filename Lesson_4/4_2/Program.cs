// Задача 2: Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.
int СompositionNum(int num)
{
    int multiply = 1;
    for(int i=1; num>=i; i++)
        multiply *=i;
    return multiply;
}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = СompositionNum(num);
Console.WriteLine(result);
