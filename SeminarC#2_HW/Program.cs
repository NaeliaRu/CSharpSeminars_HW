﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

int FindSecondDigit(int num)
{
    int result = num % 100 /10;
    return result;
}

Console.Write("Input a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int secondDigit = FindSecondDigit(number);
Console.WriteLine($"Second digit of {number} is {secondDigit}"); */

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 

int FindThirdDigit(int num)
{
    int result;

    if (num < 100)
    return -1;

    else
    {
        while (num >= 1000) 
        {
            num = num / 10;
        }
        result = num % 10;
    }
    return result;
}

Console.Write("Input a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int thirdDigit = FindThirdDigit(number);
Console.Write($"Third digit of {number} is {thirdDigit}"); */

/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

bool WeekEnds(int num)
{
    if(num == 6 || num == 7)
    {
        return true;
    }
    return false;
}

Console.Write("Enter the day of the week ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

bool result = WeekEnds(dayNumber);
Console.WriteLine($"This day of the week is a holiday: {result}");*/
