// 4. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Write("Введите первое число: ");
int N= int.Parse(Console.ReadLine()!);


void Div(int N)
    {
        if (N % 7 ==0 & N % 23 ==0)
            Console.WriteLine("Кратно");
        else
            Console.WriteLine("Не кратно ");
    }


Div(N);

