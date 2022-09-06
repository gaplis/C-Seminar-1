// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

int[] InitArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

bool SearchNumber(int num, int [] array)
{
    foreach (int position in array)
    {
        if(position == num)
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int [] myArray = InitArray(10, -10, 11);
Console.WriteLine(String.Join(", ", myArray));

if (SearchNumber(number, myArray))
{
    Console.WriteLine("Число найдено!");
}
else
{
    Console.WriteLine("Число не найдено :С");
}