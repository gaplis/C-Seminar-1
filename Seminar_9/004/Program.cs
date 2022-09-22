// Напишите программу, которая на вход принимает два числа A и B, и возводит число A в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243

int RecursionPower(int numA, int numB)
{
    int result = numA;
    if (numB > 1)
    {
        result *= RecursionPower(numA, numB - 1);
    }
    return result;
}

Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
int res = RecursionPower(A, B);
Console.Write(res);