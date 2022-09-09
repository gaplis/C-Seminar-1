// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int [] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

int [] CopyArray(int [] array)
{
    int size = array.Length;
    int [] copy = new int [size];
    for (int i = 0; i < size; i++)
    {
        copy[i] = array[i];
    }
    return copy;
}

Console.Write("Введите размер массива: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите начало диапазона чисел: ");
int minNum = int.Parse(Console.ReadLine());
Console.Write("Введите конец диапазона чисел: ");
int maxNum = int.Parse(Console.ReadLine());

int [] myArray = GetArray(num, minNum, maxNum);
Console.WriteLine($"Массив: [{String.Join(" ", myArray)}]");

int [] copyMyArray = CopyArray(myArray);
Console.WriteLine($"Копия массива: [{String.Join(", ", copyMyArray)}]");