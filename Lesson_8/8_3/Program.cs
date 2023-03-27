// Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int InputNum(string messang)
{
    System.Console.WriteLine(messang);
    return Convert.ToInt32(Console.ReadLine()!);
}
int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void InputDuoRandomMassive(int[,] arr, int masValue)
{
   Random rnd=new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j <arr.GetLength(1); j++)
        {
            arr[i,j] = rnd.Next(0, masValue + 1); // случайные числа в диапозоне   
        }
}
// Вывод массива
string PrintDuoMassive(int[,] masDuo)
{
    string res = String.Empty;
    for (int i = 0; i < masDuo.GetLength(0); i++)
        for (int j = 0; j < masDuo.GetLength(1); j++)
        {
            res += masDuo[i, j];
            if (j != masDuo.GetLength(1) - 1)
                res += "\t";
            else
                res += "\n";
        }
    return res;
}

int[] Frequency(int[,] arr, int maxValue)
{
    int[] dict = new int[maxValue + 1];
    foreach (int element in arr)
    {
        dict[element] += 1;
    }
    return dict;
}

string PrintFrequency(int[] arr)
{
    string res = String.Empty;
    for (int i = 0; i < arr.Length; i++)
        res += $"Число{i} встречается {arr[i]} раз\n";
    return res;
}

int numRows = InputNum("Введите колличество строк: ");
int numCols = InputNum("Введите колличество столбцов: ");
int[,] myArr = Create2DArray(numRows, numCols);
int max = InputNum("Введите максимальное значение для диапозона случайного числа:  ");
InputDuoRandomMassive(myArr, max);
string printDMas = PrintDuoMassive(myArr);
Console.WriteLine(printDMas);

int[] dictionary = Frequency(myArr, max);
string res = PrintFrequency(dictionary);
Console.WriteLine(res);




