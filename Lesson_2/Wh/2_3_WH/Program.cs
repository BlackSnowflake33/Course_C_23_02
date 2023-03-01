// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number =  new Random().Next(1, 10000);
int count = number.ToString().Length;
Console.WriteLine($"Случайное число: {number}");
Console.WriteLine($"Длина числа: {count}");

void Find3Number(int a, int b)
{
    if (b<3)
        Console.WriteLine("Третьей цифры нет");
    else
       { 
        int c = 1;
        int i=b;
           while (i > 3)
            {
                c = c*10;
                i--;
            }
        int result = (a / (c)) % 10;
            Console.WriteLine($"Третья цифра числа: {result}");
       }
        
};
Find3Number(number, count);



