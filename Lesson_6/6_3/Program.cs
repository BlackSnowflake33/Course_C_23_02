// Задача 2: Напишите программу, которая будет преобразовывать десятичное число в двоичное

string ConvertBin(int num)
{
    string result = "";
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }

    return result;
}


Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
string ResultEnd = ConvertBin(a);
Console.WriteLine(ResultEnd);