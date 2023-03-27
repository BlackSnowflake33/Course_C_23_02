// Задача 3: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. Использовать рекурсию. 
//453 -> 12 
//45 -> 9

int SumDigts(int num)
{
    if (num == 0) return 0;
    return SumDigts(num / 10) + num % 10;
}



Console.WriteLine("Введите число: ");
int numbers = int.Parse(Console.ReadLine()!);
//int result=SumDigts(numbers);
Console.WriteLine(SumDigts(numbers));
