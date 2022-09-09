// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - последнем и т.д.)
int [] GetArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

int[] ReverseArray(int [] array)
{
    int size = array.Length;
    int[] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = array[size - 1 - i];
    }
    return result;
}

void ReverseArray2(int [] array)
{
    int size = array.Length;
    for (int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - 1 - i];
        array[size - 1 - i] = temp;
    }
}

int [] array = GetArray(10, 0, 10);
Console.Write(String.Join(" ", array));
Console.WriteLine();
Console.Write(String.Join(" ", ReverseArray(array)));
Console.WriteLine();
ReverseArray2(array);
Console.Write(String.Join(" ", array));