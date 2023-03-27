// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.



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

bool Chek(int row, int column)
{
    bool result = row != column;
    return result;
}

string RowToColumn(int[,] arr)
{
    if(Chek(arr.GetLength(0),arr.GetLength(1))) return "No";
    {int arrRow = arr.GetLength(0);
    int arrColumn = arr.GetLength(1);
    for (int i = 1; i < arrRow; i++)
        for (int j = 1; j < i; j++)
        (arr[i, j], arr[j, i]) = (arr[j, i], arr[i, j]);
    }
    string printDMas = PrintDuoMassive(arr);
    Console.WriteLine(printDMas);
    return "Yes";
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

//Chek(lineMass,columnMass);
string rowToColumn=RowToColumn(masDuoRandom);
///string printDMas1 = PrintDuoMassive(masDuoRandom);
Console.WriteLine(rowToColumn);