Console.WriteLine("Является ли первое число квадратом второго?");
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if(num1 == Math.Pow(num2, 2))
{
    Console.WriteLine("Да!");
}
else
{
    Console.WriteLine("Нет:(");
}