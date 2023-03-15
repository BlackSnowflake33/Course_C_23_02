//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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

int OddNumber(int[] arry)
{
    int sumOddnum = 0;
    Console.WriteLine($"Из массива находящиеся на нечетных позициях: ");
    for (int i = 0; i < arry.Length; i += 2)
    {
        Console.Write($"{arry[i]} ");
        sumOddnum +=arry[i];
    }
    return sumOddnum;
}

Console.WriteLine("Введите длину массива: ");
int lengthMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int minRangeMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int maxRangeMas = int.Parse(Console.ReadLine()!);
int[] masRandom = InputRandomMassive(lengthMas, minRangeMas, maxRangeMas);
PrintMassive(masRandom);


int result = OddNumber(masRandom);
Console.WriteLine($"\n{result}");