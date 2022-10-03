// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2; b = 10 -> max = 10
// a = -9; b = -3 -> max = -3

Console.WriteLine("Введите число a: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введитe число b: ");
double b = Convert.ToInt32(Console.ReadLine());
double max = a;
if (a > b)
{
    max = a;
    Console.Write("max = ");
    Console.Write(max);
}
else
{
    max = b;
    Console.Write("max = ");
    Console.Write(max);
}
