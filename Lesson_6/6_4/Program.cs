// Задача 3: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. 
//Если N = 5 -> 0 1 1 2 3 
//Если N = 3 -> 0 1 1 
//Если N = 7 -> 0 1 1 2 3 5 8

void FibonacciNum(int num)
{
    int festNum = 0;
    int secondNum = 1;
    for (int i = 0; i < num; i++)
    {
        Console.Write(festNum + "");
        (festNum, secondNum) = (secondNum, festNum + secondNum);
    }
}


Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
FibonacciNum(num);