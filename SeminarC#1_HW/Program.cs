﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Input a first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == b)
{
    Console.Write("Your numbers are equel");
}
else
{
    if (a > b)
    {
        Console.Write("Number " + a + " bigger then number " + b);
    }
    else 
    Console.Write($"Number {b} bigger then number {a}");
}