// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void RecursionAllNumbers(int numM, int numN)
{
    if (numN > numM)
    {
        RecursionAllNumbers(numM, numN - 1);
        Console.Write($"{numN} ");
    }
    else Console.Write($"{numN} ");
}

string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
RecursionAllNumbers(m, n);
Console.WriteLine();
string result = PrintNumbers(m, n);
Console.WriteLine(result);