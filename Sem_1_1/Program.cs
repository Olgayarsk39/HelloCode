/* 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

a = 25; b = 5 -> да
a = 2 b = 10 -> нет
a = 9; b = -3 -> да
a = -3 b = 9 -> нет
Console.WriteLine("Hello, World!");*/

Console.Clear();
Console.Write("Введите число a = ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите число b = ");
int number = int.Parse(Console.ReadLine());
int sqr = Convert.ToInt32(Math.Pow(number, 2));

if (number1 == sqr)
{
    Console.WriteLine($"-> да");
}
else
{
    Console.WriteLine("нет");
}
