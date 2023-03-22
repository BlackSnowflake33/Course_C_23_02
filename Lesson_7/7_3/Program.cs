// Задача 3: Задайте двумерный массив. Найдите сумму элементов главной диагонали.

int[,] InputDuoRandomMassive(int rows, int columns, int form, int to)
{
    int[,] masDuoRandom = new int[rows, columns]; // Задаем массив
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            masDuoRandom[i, j] = new Random().Next(form, to); // случайные числа в диапозоне   
        }
    return masDuoRandom;
}
// Вывод массива
void PrintDuoMassive(int[,] masDuo)
{
    for (int i = 0; i < masDuo.GetLength(0); i++)
    {
        for (int j = 0; j < masDuo.GetLength(1); j++)
            Console.Write($" {masDuo[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int SumDiagonalMass(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int sum = 0;
    for (int i = 0; i < rows; i ++)
        for (int j = 0; j < columns; j ++)
            if (i == j)
                sum = sum + arr[i, j];
    return sum;
}

Console.WriteLine("Введите число строк в двухмерном массиве: ");
int lineMass = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов в двухмерном массиве: ");
int columnMass = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int minRangeMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int maxRangeMas = int.Parse(Console.ReadLine()!);

int[,] masDuoRandom = InputDuoRandomMassive(lineMass, columnMass, minRangeMas, maxRangeMas);
PrintDuoMassive(masDuoRandom);
Console.WriteLine();
int sumDiagonal = SumDiagonalMass(masDuoRandom);
Console.WriteLine(sumDiagonal);

