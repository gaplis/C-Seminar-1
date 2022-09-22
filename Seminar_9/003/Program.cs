// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12

int RecursionSumNumbers(int num)
{
    int result = 0;
    if (num != 0)
    {
        result += (num % 10) + RecursionSumNumbers(num / 10);
    }
    return result;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int res = RecursionSumNumbers(number);
Console.Write(res);