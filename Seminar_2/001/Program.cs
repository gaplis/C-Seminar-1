int num = new Random().Next(10, 100); // [a, b)
int a1 = num % 10; // 10 % 3 = 1, 11 % 2 = 2, 12 % 3 = 0 (Остаток о числа: 0, 1, 2 - он не может быть больше числа, на которое делят)
int a2 = num / 10; // 123 / 10 = 12, 123 / 10 = 123 

int max = a1;
if (max< a2)
{
    max = a2;
}

Console.WriteLine($"{num}, Max: {max}");