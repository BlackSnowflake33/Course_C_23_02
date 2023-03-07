// SЗадача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

int ExponentiationNum(int num, int extent)
{
    int result = 1;
    for (int i = 0; i< extent; i++)
           {
                result = num * result;
           } 
        return result;
}

bool CheckingExtent(int extent)
{
    if ( extent<0)
     { 
            Console.WriteLine("Показатель не должен быть меньше нуля");
            return false;
     }
    return true;
}


Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите в какую степень надо возвести число: ");
int b = int.Parse(Console.ReadLine()!);

if (CheckingExtent(b))
{
    Console.WriteLine($"Возвести число {a} в натуральную степень {b} равно: {ExponentiationNum(a, b)}");
}
