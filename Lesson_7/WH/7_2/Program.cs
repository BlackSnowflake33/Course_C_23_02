// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет


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

string PositionElem(int[,] arr, int posLine, int posCol)
{
    int row = arr.GetLength(0);
    int column = arr.GetLength(1);

    if (posLine > row || posLine <= 0 || posCol > column || posCol <= 0)
        return $"{posLine} {posCol} -> Такой позиции в массиве нет";
    return $"Элемент массива с позицией [{posLine}, {posCol}] = {arr[posLine - 1, posCol - 1]} ";
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

Console.Write("Введите номер строковой позиции: ");
int i = int.Parse(Console.ReadLine()!);
Console.Write("Введите номер столбовой позиции: ");
int j = int.Parse(Console.ReadLine()!);

string result = PositionElem(masDuoRandom, i, j);
Console.WriteLine(result);