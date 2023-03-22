//Задача 1: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₙₙ = m+n. 
//Выведите полученный массив на экран.

int[,] InputDuoMassive(int rows, int columns)
{
    int[,] masDuo = new int[rows, columns]; // Задаем массив
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            masDuo[i, j] = i+j; 
        }
    return masDuo;
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
}



Console.WriteLine("Введите число строк в двухмерного массива: ");
int lineMass = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число столбцов в двухмерного массива: ");
int columnMass = int.Parse(Console.ReadLine()!);


int[,] masDuo = InputDuoMassive(lineMass, columnMass);
PrintDuoMassive(masDuo);
Console.WriteLine();
