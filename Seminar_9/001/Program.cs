// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. 
// N = 5 -> 1, 2, 3, 4, 5

void RecursionAllNumbers(int num)
{
    if (num > 1)
    {
        RecursionAllNumbers(num - 1);
        Console.Write($"{num} ");
    }
    else Console.Write($"{num} ");
}

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
RecursionAllNumbers(n);