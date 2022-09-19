// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива. 

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

int[] FindMinInArray(int[,] array)
{
    int min = array[0, 0];
    int[] minCoordinateArray = new int[2];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minCoordinateArray[0] = i;
                minCoordinateArray[1] = j;
            }
        }
    }
    return minCoordinateArray;
}

int[,] ChangeArray(int[,] array, int[] deleteArray)
{
    int k = 0;
    int l = 0;
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != deleteArray[0])
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != deleteArray[1])
                {
                    result[l, k] = array[i, j];
                    k++;
                }
            }
            k = 0;
            l++;
        }
    }
    return result;
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
        int[,] myArray2D = GetArray(sizeString, sizeColumns, numMin, numMax);
        PrintArray(myArray2D);
        Console.WriteLine();
        int[] minNum = FindMinInArray(myArray2D);
        Console.WriteLine(String.Join(" ", minNum));
        Console.WriteLine();
        int[,] delArray = ChangeArray(myArray2D, minNum);
        PrintArray(delArray);
    }
    else Console.WriteLine("Максимальное значение числа не может быть меньше минимального.");
}
else Console.WriteLine("Размер строк и столбцов массива не может быть нулевым или отрицательным.");