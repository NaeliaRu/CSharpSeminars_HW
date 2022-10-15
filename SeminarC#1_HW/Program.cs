// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

/*Console.Write("Input a first number: ");
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
}*/

/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Console.Write("Input first number ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input third number ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 > max) max = num1;
if (num2 > max) max = num2;
if (num3 > max) max = num3;
if (num1 == num2 && num2 == num3)
{
Console.Write("Your numbers are equel"); 
return;
}

Console.Write("Max number is " + max);
*/

/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Console.Write("Input your number ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 2;

if (result == 0)
Console.Write("Your number is even");
else 
Console.Write("Your number is odd");*/

/*Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Input a number ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 1;

if (num < 0)
{
    current = num;
    num = -num;
}

while (current <= num)
{
    if (current % 2 == 0)
    { 
        Console.Write(current + " ");
        current++;
    }
    else current++;
}
