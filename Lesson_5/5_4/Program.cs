// 4. Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.

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

int[] MultiMas(int[] arry)
{
    int size = arry.Length;
    int[] newMass = new int[size / 2 + size % 2];
    for (int i = 0; i < size / 2; i++)
    {
        newMass[i] = arry[i] * arry[size - 1 - i];
    }
    if (size % 2 == 1)
    {
        newMass[newMass.Length - 1] = arry[arry.Length / 2];
    }
    return newMass;
}

Console.WriteLine("Введите длину массива: ");
int lengthMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int minRangeMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int maxRangeMas = int.Parse(Console.ReadLine()!);
int[] masRandom = InputRandomMassive(lengthMas, minRangeMas, maxRangeMas);
Console.WriteLine("Вывод массива");
PrintMassive(masRandom);

int[] newNewMass = MultiMas(masRandom);
Console.WriteLine("Вывод нового массива");
PrintMassive(newNewMass); 
