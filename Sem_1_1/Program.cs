/* 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет
*/

Console.Clear();
Console.Write("Введите число a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b = ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"{Math.Pow(b, 2) == a}");
if (Math.Pow(b, 2) == a)
{
    Console.WriteLine("а квадрат в");
}
else
{
    Console.WriteLine("а не является квадратом в");
}
