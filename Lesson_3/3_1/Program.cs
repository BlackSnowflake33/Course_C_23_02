// Напишите программу, которая по заданому номеру четверти, показывает диапозон
//возможных координат точек  в этой четверти

void Quarters(int num)
{
    if (num ==1)
        Console.WriteLine("x>0, y>0");
    else if (num == 2)
            Console.WriteLine("x<0, y>0");
    else if (num == 3)
            Console.WriteLine("x<0, y<0");
    else if (num == 4)
            Console.WriteLine("x>0, y<0");
    else 
            Console.WriteLine("Нет такой четверти");

}
Console.WriteLine("Введите номер четверти: ");
Quarters(int.Parse(Console.ReadLine()!));

