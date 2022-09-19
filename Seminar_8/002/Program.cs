// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя. 

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

int[,] SwapRowsAndColumnsArray(int[,] array)
{
    int[,] tempArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempArray[j, i] = array[i, j];
        }
    }
    return tempArray;
}

Console.Write("Задайте количество строк массива: ");
int sizeString = int.Parse(Console.ReadLine());
Console.Write("Задайте количество столбцов массива: ");
int sizeColumns = int.Parse(Console.ReadLine());

if (sizeString == sizeColumns)
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
        int[,] mySwapArray = SwapRowsAndColumnsArray(myArray);
        PrintArray(mySwapArray);
    }
    else Console.WriteLine("Максимальное значение числа не может быть меньше минимального.");
}
else Console.WriteLine("Размер строк и столбцов должен быть одинаковым.");