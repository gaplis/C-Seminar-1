// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool Triangle(int a, int b, int c)
{
    return a < b + c && b < a + c && c < b + a;
}

Console.Write("Введите сторону a: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите сторону b: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите сторону c: ");
int num3 = int.Parse(Console.ReadLine());

if(Triangle(num1, num2, num3)) Console.WriteLine("Может существовать.");
else Console.WriteLine("Не может существовать.");