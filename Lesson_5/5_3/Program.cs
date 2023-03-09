// Задача 3: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123 
//[5, 18, 123, 6, 2] -> 1 
//[1, 2, 3, 6, 2] -> 0 
//[10, 11, 12, 13, 14] -> 5


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

int RetNum(int[] arry, int from, int to)
{
    int count = 0;
    Console.WriteLine($"Число из массива которые лежат в отрезке: ");
    
    for (int i = 0; i < arry.Length; i++)
    {
        if (arry[i] >= from & arry[i] <= to)
        {
            //Console.WriteLine($"Число из массива которые лежат в отрезке: ");
            Console.Write($"{arry[i]} ");
            count ++;
        }
    }
    Console.WriteLine($"\nКоличество элементов массива, значения которых лежат в отрезке [{from}, {to}]: {count}");
    return count;
}

Console.WriteLine("Введите длину массива: ");
int lengthMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение для диапозона случайного числа: ");
int minRangeMas = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение для диапозона случайного числа: ");
int maxRangeMas = int.Parse(Console.ReadLine()!);
int[] masRandom = InputRandomMassive(lengthMas, minRangeMas, maxRangeMas);
PrintMassive(masRandom);

Console.WriteLine("Введите начало отрезка: ");
int from = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конец отрезка: ");
int to = int.Parse(Console.ReadLine()!);

int result = RetNum(masRandom, from, to);
Console.WriteLine(result);
