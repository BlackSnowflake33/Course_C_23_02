// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12



int SumNum(int num)
{
    int numSum = num;
    int summand = 0;
    for(int i=1; numSum>0; i++)
    {
        summand +=numSum % 10;
        numSum = numSum / 10;
    }
    return summand;
}
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int result = SumNum(num);
Console.WriteLine($"Сумма всех цифор в числе {num} равна: {result}");

