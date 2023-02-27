// Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.


//int FirstThird(int num)
//{
  //  Console.WriteLine(num);
  //  return num % 10;
//}


//int result = FirstThird(new Random().Next(100, 1000));
//Console.WriteLine(result);
int a = 123;

var str = number.ToString();

number = int.Parse(str.Remove(str.Length - 1, 1));