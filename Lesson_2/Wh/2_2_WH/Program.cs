// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.


int FirstThird(int num)
{
    Console.WriteLine(num);
    return ((num/100 % 10) + num %10);
}


int result = FirstThird(new Random().Next(100, 1000));
Console.WriteLine($"Если из техзначного числа удалить вторую цифру, то получится число: {result}");
