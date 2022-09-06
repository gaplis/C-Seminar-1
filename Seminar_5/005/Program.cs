// Найдите произведение пар чисел в одномерном массиве. 
// Парой считается первый и последний элемент, второй и предпоследний и т.д Результат запишите в новом массиве. 

int[] InitArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int [] Power(int [] array)
{
    int [] result = new int [array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - 1 - i];
    }
    return result;
}

int [] myArray = InitArray(5, 1, 10);
Console.WriteLine(String.Join(", ", myArray));

int[] res = Power(myArray);
Console.WriteLine(String.Join(", ", res));