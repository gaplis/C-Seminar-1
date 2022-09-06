// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10, 99]

int[] InitArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int MassiveSum(int [] array)
{
    int amountSum = 0;
    foreach (int item in array)
    {
        if (item >= 10 && item <= 99)
        {
            amountSum++;
        }
    }
    return amountSum;
}

int [] myArray = InitArray(123, -20, 130);
Console.WriteLine(String.Join(", ", myArray));

int result = MassiveSum(myArray);
Console.WriteLine(result);
