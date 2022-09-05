// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int proizNum(int number)
{
    int result = 1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    return result;
}

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"{proizNum(n)}");