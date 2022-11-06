/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4*/

/*int CountNumbers(int size)
{
    int count = 0;

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input your number {i + 1}: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num > 0) count++;
    }
    return count;
}

Console.Write("Input number of numbers: ");
int size = Convert.ToInt32(Console.ReadLine());
int result = CountNumbers(size);
Console.Write("Number of positive numbers: " + result);*/

/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

void IntersectionPoint()
{
    Console.Write("Input value b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input value k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input value b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Input value k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());

    double x = (b2-b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.Write($"Point of intersection of two lines: x = {x}, y = {y}");
}

IntersectionPoint();