Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());

int div = num1 % num2;

if (div == 0) Console.WriteLine($"Число {num2} кратно числу {num1}!");
else Console.WriteLine($"Число {num2} не кратно числу {num1}, остаток {div} :С");