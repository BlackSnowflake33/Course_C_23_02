﻿//Задача 1: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4. 
//0 1 2 
//3 1 2 
//3 4 2 
//3 4 5

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
string PrintDuoMassive(int[,] masDuo)
{
    string res = String.Empty;
    for (int i = 0; i < masDuo.GetLength(0); i++)
        for (int j = 0; j < masDuo.GetLength(1); j++)
        {
            res += masDuo[i, j];
            if (j != masDuo.GetLength(1) - 1)
                res += "\t";
            else
                res += "\n";
        }
    return res;
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
string printDMas = PrintDuoMassive(masDuoRandom);
Console.WriteLine(printDMas);