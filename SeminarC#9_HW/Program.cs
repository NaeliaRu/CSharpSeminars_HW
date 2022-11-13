/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

/*void ShowNums(int n)
{
    if (n < 1) return;
    Console.Write(n + " ");
    ShowNums(n - 1);
}

Console.Write("Input value N: ");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n);*/

/*-------------------------------------------------------------------------------------------------------------
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

/*int SumOfDigits(int m, int n)
{
    if(m < n) return m += SumOfDigits(m + 1, n);
    if(m > n) return m += SumOfDigits(m - 1, n);
    else return m;
}

Console.WriteLine(SumOfDigits(4, 8));*/

/*-----------------------------------------------------------------------------------------------------------
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/

int AckermanFunction(int m, int n)
{
    if (m == 0) return n + 1;
    else
    if ((m != 0) && (n == 0)) return AckermanFunction(m - 1, 1);
    else return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}

Console.Write("Input value m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input value n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Result of Ackerman Function: " + AckermanFunction(m, n));
