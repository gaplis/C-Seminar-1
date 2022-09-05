// Напишите программу, которая принимает на вход число (A) и выдаёт сумму чисел 1 до A.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetNums (int number)
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i; // sum = sum + i;
    }
    return sum;
}

Console.Write("Введите число A: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{GetNums(num)}");