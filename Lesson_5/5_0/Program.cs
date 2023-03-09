//Задача 1: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива. 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Заполнения массива случайными числами
int[] InputRandomMassive(int lengthMas, int minRangeMas, int maxRangeMas)
{
    int[] masRandom = new int[lengthMas]; // Задаем массив
    for (int i = 0; i < lengthMas; i++)
    {
        masRandom[i] = new Random().Next(minRangeMas, maxRangeMas); // случайные числа в диапозоне     
    }
    return masRandom;
}
// Вывод массива
void PrintMassive(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
       Console.Write($" {mas[i]} ");
    Console.WriteLine();     
}

void SumPosNeg(int[] masRandom)
{
    int pos, neg;
    pos = neg = 0;
    for (int i = 0; i < masRandom.Length; i++)
    {
        if (masRandom[i]>0)
            pos +=masRandom[i];
        else
            neg +=masRandom[i];
    }
    Console.WriteLine($"Positive: {pos}, negative: {neg}");
}

Console.WriteLine("Введите длину массива: ");
int lengthMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int minRangeMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int maxRangeMas = int.Parse(Console.ReadLine()!);

int[] masRandom = InputRandomMassive(lengthMas, minRangeMas, maxRangeMas);
PrintMassive(masRandom);
SumPosNeg(masRandom);



