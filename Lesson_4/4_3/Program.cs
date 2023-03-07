// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

void Massive(int mas)
{
    int[] numbers =  new int[mas]; // Размер массива mas = 8 чисел
    for (int i = 0; i < mas; i++)
    {
        numbers[i] = new Random().Next(2); // только 0 и 1, 2 не включается
        Console.WriteLine(numbers[i]);
    }
    
}
Console.WriteLine("Введите размер массива: ");
int mas = int.Parse(Console.ReadLine()!);
Massive(mas);

//massive(8);