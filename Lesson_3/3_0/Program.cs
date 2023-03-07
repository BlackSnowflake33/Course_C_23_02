// Напишите программу, которая принимает на вход кординаты точек (X, Y) и выдает номер четверти плоскости, в которой находится эта точка

void Quarters(int x, int y)
{
    if (x==0 || y==0)
        Console.WriteLine("x=0, y=0");
    else if (x>0 && y>0)
            Console.WriteLine("I");
    else if (x<0 && y>0)
            Console.WriteLine("II");
    else if (x<0 && y<0)
            Console.WriteLine("III");
    else if (x>0 && y<0)
            Console.WriteLine("IV");

}
Console.WriteLine("Введите координаты x, y: ");
Quarters(int.Parse(Console.ReadLine()!), int.Parse(Console.ReadLine()!));

