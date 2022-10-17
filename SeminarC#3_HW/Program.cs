/* Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да

bool Polindrom(int num)
{
    int num1 = num / 10000;
    int num2 = num / 1000 % 10;
    int num4 = num % 100 / 10;
    int num5 = num % 10;

    if(num1 == num5 && num2 == num4)
    {
        return true;
    }
    return false;
}

Console.Write("Input five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = Polindrom(number);
Console.WriteLine($"Your number is a palindrome {result}"); */
