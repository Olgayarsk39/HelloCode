﻿/* 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.

3 -> Среда
5 ->  Пятница
*/
Console.Clear();
Console.Write("Введите номер дня недели - ");
int num = int.Parse(Console.ReadLine());

if(num < 1 || num > 7)
{
     Console.WriteLine("Введите корректное число");
     return;
}

if(num == 1) Console.WriteLine("Понедельник");
if(num == 2) Console.WriteLine("Вторник");
if(num == 3) Console.WriteLine("Среда");
if(num == 4) Console.WriteLine("Четверг");
if(num == 5) Console.WriteLine("Пятница");
if(num == 6) Console.WriteLine("Суббота");
if(num == 7) Console.WriteLine("Воскресение");