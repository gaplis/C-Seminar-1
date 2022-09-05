// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int [] InitArray()
{
    int[] arr = new int[8]; // - создание массива с 8-ю элементами
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
    }
    return arr;
}

Console.WriteLine(String.Join(", ", InitArray()));

// Другое решение

void ReadArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

ReadArray(InitArray());