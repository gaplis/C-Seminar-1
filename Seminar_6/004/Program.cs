// Не используя рекурсию,. выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


// Моё решение

void Fibonacci(int number)
{
    int number1 = 0;
    int number2 = 1;
    int numberF = 0;
    Console.Write($"{number1} {number2} ");
    for (int i = 0; i < number - 2 ; i++)
    {
        numberF = number1 + number2;
        Console.Write($"{numberF} ");
        number1 = number2;
        number2 = numberF;
    }
}

Console.Write("Введите число Фибоначчи: ");
int num = int.Parse(Console.ReadLine());

if (num >= 2) 
{
    Fibonacci(num); 
    Console.WriteLine();
}
else if (num == 1) Console.WriteLine("0");
else Console.WriteLine("Нет последовательности");

// Решение с массивами

int[] Fibonacci2(int number)
{
    int [] fArray = new int [num];
    fArray[0] = 0;
    fArray[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fArray[i] = fArray[i-2] + fArray[i-1];
    }
    return fArray;
}

if (num >= 2) Console.WriteLine(String.Join(" ", Fibonacci2(num)));
else if (num == 1) Console.WriteLine("0");
else Console.WriteLine("Нет последовательности");