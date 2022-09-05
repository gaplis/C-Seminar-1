// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int amountNumber(int number)
{
    int count = 0;
    while (number != 0)
    {
        count++;
        number = number / 10;
    }
    return count;
}


Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"{amountNumber(num)}");