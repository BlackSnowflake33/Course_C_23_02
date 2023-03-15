// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] InputRandomMassive(int lengthMas, int minRangeMas, int maxRangeMas)
{
    double[] masRandom = new double[lengthMas]; // Задаем массив
    Random n_new = new Random();
    for (int i = 0; i < lengthMas; i++)
    {
        masRandom[i] = Math.Round(n_new.NextDouble() * (maxRangeMas + minRangeMas) - maxRangeMas, 2); // случайные числа в диапозоне     
    }
    return masRandom;
}
// Вывод массива
void PrintMassive(double[] mas)
{
    for (int i = 0; i < mas.Length; i++)
        Console.Write($" {mas[i]} ");
    Console.WriteLine();
}

double DifferenceMaxMin(double[] arry)
{
    double difference = 0;
    double maxNum = arry[0];
    double minNum = arry[0];

    for (int i = 0; i < arry.Length; i++)
    {
        if (maxNum < arry[i])
            maxNum = arry[i];
        else
            if (minNum > arry[i])
                minNum = arry[i];
    }
    difference = Math.Round(maxNum - minNum, 2);
    Console.WriteLine($"Mаксимальное элемент массива: {maxNum}. \nМинимальное элемент массива: {minNum}.");
   
    return difference;
}

Console.WriteLine("Введите длину массива: ");
int lengthMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int minRangeMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int maxRangeMas = int.Parse(Console.ReadLine()!);
double[] masRandom = InputRandomMassive(lengthMas, minRangeMas, maxRangeMas);
PrintMassive(masRandom);

double result = DifferenceMaxMin(masRandom);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {result} ");