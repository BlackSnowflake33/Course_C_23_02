// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


void Weekend(int num)
{
    string text = "no";

    if (num == 7 || num == 6) text = "Weekend";
    else if (num < 6 && num >0) text = "Workday";
        else text = "not quite a week";

    Console.WriteLine($"{num} -> {text}");
}

Weekend(int.Parse(Console.ReadLine()!));
