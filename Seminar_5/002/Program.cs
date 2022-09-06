// Напишите программу зымены элементов массива: положительные элементы заменить на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [2, 8, -8, -2]

int[] InitArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

void NegativMassive(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}

int [] mass = InitArray(10, -10, 11);
Console.WriteLine(String.Join(",", mass));

NegativMassive(mass); // void - ничего не возвращается, поэтому просто вызываем
Console.WriteLine(String.Join(",", mass)); // - возвращаются числа, поэтому через Console.WriteLine