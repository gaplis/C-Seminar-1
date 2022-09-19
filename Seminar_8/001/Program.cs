// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] GetArray(int colString, int colColumnls, int minValue, int maxValue)
{
    int[,] array = new int[colString, colColumnls];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

int[,] ReverseUpAndDownStringArray(int[,] array)
{
    int iStart = 0;
    int iEnd = array.GetLength(0) - 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[iStart, j];
        array[iStart, j] = array[iEnd, j];
        array[iEnd, j] = temp;
    }
    return array;
}

Console.Write("Задайте количество строк массива: ");
int sizeString = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int sizeColumns = int.Parse(Console.ReadLine());

if (sizeString > 0 && sizeColumns > 0)
{
    Console.Write("Задайте минимальное значение чисел: ");
    int numMin = int.Parse(Console.ReadLine());
    Console.Write("Задайте максимальное значение чисел: ");
    int numMax = int.Parse(Console.ReadLine());
    Console.WriteLine();
    if (numMax >= numMin)
    {
        int[,] myArray = GetArray(sizeString, sizeColumns, numMin, numMax);
        PrintArray(myArray);
        Console.WriteLine();
        int[,] myReverseArray = ReverseUpAndDownStringArray(myArray);
        PrintArray(myReverseArray);
    }
    else Console.WriteLine("Максимальное значение числа не может быть меньше минимального.");
}
else Console.WriteLine("Размер строк и столбцов массива не может быть нулевым или отрицательным.");