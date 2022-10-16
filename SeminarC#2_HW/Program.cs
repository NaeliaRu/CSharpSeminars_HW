/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int FindSecondDigit(int num)
{
    int result = num % 100 /10;
    return result;
}

Console.Write("Input a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = FindSecondDigit(number);
Console.WriteLine($"Second digit of {number} is {secondDigit}");



