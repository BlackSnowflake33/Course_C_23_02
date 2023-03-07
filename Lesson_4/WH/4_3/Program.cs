// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//minRangeMas минимальное значение диапозона для массва
// maxRangeMas максимальное значение диапозона для массва
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

// Вод заданого массива
int[] InputManualMassive(int lengthManualMas)
{
    int[] masManual = new int[lengthManualMas]; // Задаем массив 
    for (int i = 0; i < lengthManualMas; i++)
    {
        Console.WriteLine($" ");
        Console.Write($"Введите {i} элемент массива: ");
        masManual[i] = int.Parse(Console.ReadLine()!);
    }
    return masManual;
}


// Вывод массива
void PrintMassive(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
       Console.Write($" {mas[i]} ");
        
}

Console.WriteLine("Введите длину массива: ");
int lengthMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int minRangeMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int maxRangeMas = int.Parse(Console.ReadLine()!);

int[] masRandom = InputRandomMassive(lengthMas, minRangeMas, maxRangeMas);
PrintMassive(masRandom);
int[] masManual = InputManualMassive(lengthMas);
PrintMassive(masManual);






