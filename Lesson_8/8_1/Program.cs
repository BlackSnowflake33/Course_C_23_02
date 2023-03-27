// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


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

void ReplaceIndex(int[,] arr)
{
    int arrRow = arr.GetLength(0);
    int arrColumn = arr.GetLength(1);
    for (int j = 0; j < arrColumn; j++)
        (arr[0, j], arr[arrRow - 1, j]) = (arr[arrRow - 1, j], arr[0, j]);
   
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
ReplaceIndex(masDuoRandom);
string printDMas1 = PrintDuoMassive(masDuoRandom);
Console.WriteLine(printDMas1);