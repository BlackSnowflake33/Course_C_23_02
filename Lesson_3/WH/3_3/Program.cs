// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число N: ");
int num = int.Parse(Console.ReadLine()!);
void CubeTable(int n)
{
    int i=1;
    while (n>=i)
    {
        Console.WriteLine(Math.Pow(i,3));
        i++;
    }
}

CubeTable(num);
