// Напишите программу, которая принимает на вход число N и выдаёт таблицу квадратов чисел от 1 до N.

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());

int one = 1;

while (one <= n)
{
    int result = one * one;
    Console.Write($"{result} ");
    one++;
}

// for (int one = 1; one <= n; one++)
// {
//     Console.Write($"{result} ");
// }