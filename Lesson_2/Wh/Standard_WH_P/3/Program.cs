// 3. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то
//    программа выводит остаток от деление.
//    34, 5 -> не кратно, остаток 4
//    16, 4 -> кратно

void ThirdNum(int num)
{
    Console.Write($"{num} -> ");
    if (num < 100)
    {
        Console.WriteLine("The number is not three-digit!");
        return;
    }
    while(num>999) num/=10;
    Console.WriteLine(num % 10);
}

ThirdNum(int.Parse(Console.ReadLine()!));
