// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
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

int[,] MultiplicationMass(int[,] arr_first, int[,] arr_second)
{
    int row_size = arr_first.GetLength(0);
    int column_size = arr_first.GetLength(1);
    int[,] pr_matrix = new int[row_size, column_size];

    if (row_size != arr_second.GetLength(0) || column_size != arr_second.GetLength(1)) return pr_matrix;
    
    for (int i = 0; i < row_size; i++)       
        for (int j = 0; j < column_size; j++)
            pr_matrix[i, j] = arr_first[i, j] * arr_second[i, j];            
    return pr_matrix;
}

Console.WriteLine("Введите число строк в двухмерном массиве для первой матрице: ");
int lineMass1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов в двухмерном массиве для первой матрице: ");
int columnMass1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапозона случайного числа для первой матрице: ");
int minRangeMas1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапозона случайного числа для первой матрице: ");
int maxRangeMas1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число строк в двухмерном массиве для второй матрице: ");
int lineMass2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов в двухмерном массиве для второй матрице: ");
int columnMass2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапозона случайного числа для второй матрице: ");
int minRangeMas2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапозона случайного числа для второй матрице: ");
int maxRangeMas2 = int.Parse(Console.ReadLine()!);

int[,] masDuoRandom1 = InputDuoRandomMassive(lineMass1, columnMass1, minRangeMas1, maxRangeMas1);
PrintDuoMassive(masDuoRandom1);

int[,] masDuoRandom2 = InputDuoRandomMassive(lineMass2, columnMass2, minRangeMas2, maxRangeMas2);
PrintDuoMassive(masDuoRandom2);
Console.WriteLine();
int[,] masDuoRandom3 = MultiplicationMass(masDuoRandom1, masDuoRandom1);
PrintDuoMassive(masDuoRandom3);
