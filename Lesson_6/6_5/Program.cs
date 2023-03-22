// Задача 4: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


// Заполнения массива случайными числами
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
        for (int j = 0; j < masDuo.GetLength(1); j++)
        {
            Console.Write($" {masDuo[i, j]} ");
        }
        Console.WriteLine();
}
int[,] CopyMass(int[,] arr)
{
    int newRow=arr.GetLength(0);
    int newColumns=arr.GetLength(1);
    int[,] newMass=new int[newRow, newColumns];
    for (int i = 0; i < newRow; i++)
        for (int j = 0; j < newColumns; j++)
        {
            newMass[i,j]=arr[i,j];
        }
        return newMass;
}


Console.WriteLine("Введите число строк в двухмерного массива: ");
int lineMass = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов в двухмерного массива: ");
int columnMass = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int maxRangeMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int minRangeMas = int.Parse(Console.ReadLine()!);

int[,] masDuoRandom = InputDuoRandomMassive(lineMass, columnMass, minRangeMas, maxRangeMas);
PrintDuoMassive(masDuoRandom);
Console.WriteLine();
int[,] newCopyDuoMass = CopyMass(masDuoRandom);
PrintDuoMassive(newCopyDuoMass);