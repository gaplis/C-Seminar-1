// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

int[] Array2Dto1D(int[,] array)
{
    int[] tempArray = new int[array.GetLength(0) * array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempArray[k] = array[i, j];
            Console.Write($"{tempArray[k]} ");
            k++;
        }
    }
    return tempArray;
}

int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
    return array;
}

void PrintColNumbers(int[] array)
{
    int count = 1;
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (array[i] == array[i + 1])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"Число {array[i]} встречается {count} раз.");
            count = 1;
        }
    }
    Console.WriteLine($"Число {array[array.Length - 1]} встречается {count} раз.");
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
        int[] myArray1D = Array2Dto1D(myArray2D);
        Console.WriteLine();
        int[] mySortArray = SortArray(myArray1D);
        Console.WriteLine(String.Join(" ", mySortArray));
        PrintColNumbers(mySortArray);

    }
    else Console.WriteLine("Максимальное значение числа не может быть меньше минимального.");
}
else Console.WriteLine("Размер строк и столбцов массива не может быть нулевым или отрицательным.");