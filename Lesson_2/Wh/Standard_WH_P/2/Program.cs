// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

string SecondNum(int num)
{
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
        return $"{num} -> {num/100 *10 + num % 10}";
    
    return "The number is not three-digit!";
    
}

Console.WriteLine(SecondNum(int.Parse(Console.ReadLine()!)));

void NumRendm()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"{num} -> {num/100}{num % 10}");
}
NumRendm();