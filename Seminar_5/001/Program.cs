// Задайте массив из 12 элементов, заполненнфый случайными числами из промежутся [-9 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
int[] InitArray(int N, int min, int max)
{
    int[] arr = new int[N];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int [] PositiveAndNegativeSum(int [] array)
{
        int [] res = new int [2];

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                res[0] += array[i];
            }
            else
            {
                res[1] += array[i];
            }
        }
        return res;
}

void PositiveSum(int [] array)
{
    int positiveSum = 0;

    foreach(int el in array)
    {
        positiveSum += el > 0 ? el : 0; // если el > 0, то будет el, а иначе 0 (? el : 0)
                                        // if (el > 0)
                                        // {
                                        //     positiveSum += el;
                                        // }
                                        // else
                                        // {
                                        //     positiveSum += 0;
                                        // }
    }
    Console.WriteLine($"{positiveSum}");
}

int[] myArray = InitArray(12, -9, 10);
int[] result = PositiveAndNegativeSum(myArray);
Console.WriteLine(String.Join(", ", myArray));
Console.WriteLine(String.Join(", ", result));
PositiveSum(myArray);