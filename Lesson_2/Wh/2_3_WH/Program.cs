// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int FirstThird(int num)
{
    Console.WriteLine(num);
    if(num/1000>0)
        return num % 10;
    else 
     Console.WriteLine("У числа нет третьей цифры");
}


int result = FirstThird(new Random().Next(1, 1000));
Console.WriteLine($"Третьей цифрой числа является: {result}");



