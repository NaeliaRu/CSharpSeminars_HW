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

/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*double FindDistans(double x, double y, double z, double x1, double y1, double z1)
{
    double num = 0;
    num = Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2) + Math.Pow((z1 - z), 2);
    num = Math.Sqrt(num);
    num = Math.Round(num, 2);
    return num;
}

Console.Write("Input x coordinate of the first point: ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y coordinate of the first point: ");
double y = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z coordinate of the first point: ");
double z = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x coordinate of the second point: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y coordinate of the second point: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input z coordinate of the second point: ");
double z1 = Convert.ToDouble(Console.ReadLine());

double findDistans = FindDistans(x, y, z, x1, y1, z1);
Console.WriteLine($"Distans between your two point is {findDistans}");*/

/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125

void ShowNumbers(int num)
{
    int count = 1;

    while (count <= num)
    {
        double n = Math.Pow(count,3);
        Console.Write(n + " ");
        count++;
    }
}

Console.Write("Input your number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNumbers(number); */