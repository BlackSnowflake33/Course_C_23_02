// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.Write("Введите число от 1 до 7: ");
int dayNumber = int.Parse(Console.ReadLine()!);

void Weekend(int dayNumber)
{
       if (dayNumber == 7 || dayNumber == 6)
           Console.WriteLine("Выходной");
        else
            if(dayNumber>=1 & dayNumber<6)
                 Console.WriteLine("Рабочий");
            else
                Console.WriteLine("Вы вели число не пределах от 1 до 7, поэтому нет возможности определить");     
}
Weekend(dayNumber);