// Напишите программу, которая по заданному номеру четверти, показывает диапозон возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер блока координат: ");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("x - положительный, y - положительный");
}
else
if (num == 2)
{
    Console.WriteLine("x - отрицательный, y - положительный");
}
else
if (num == 3)
{
    Console.WriteLine("x - отрицательный, y - отрицательный");
}
else
if (num == 4)
{
    Console.WriteLine("x - положительныйй, y - отрицательный");
}
else 
{
    Console.WriteLine("Введите правильный номер четверти");
}