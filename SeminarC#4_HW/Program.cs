/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

/*double ShowNumbers(double numA, double numB)
{
    if (numA < 1 || numB < 0) return -1;
    else
    {
        double num = Math.Pow(numA,numB);
        return num;
    }
}

Console.Write("Input your number A: ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input your number B: ");
double numberB = Convert.ToDouble(Console.ReadLine());
double result = ShowNumbers(numberA, numberB);
if (result == -1) Console.WriteLine("You put unacceptable values");
else Console.WriteLine($"Your result is: {result}");*/

/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

/*int SumOfDigits(int num)
{
    int sum = 0;
    int digit = 0;

    if (num < 0) num *= -1;

    while(num > 0)
    {
    digit = num % 10;
    sum += digit;
    num = num / 10;
    }

    return sum;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumOfDigits(number);
Console.WriteLine($"Sum of digits: {sum}");*/

/*Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
m = 5 -> [1, 2, 5, 7, 19]
m = 3 -> [6, 1, 33]*/

/*Решение 1 (когда элементы массива рандомны).

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next();
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] yourArray = CreateArray(size);
ShowArray(yourArray);*/

/* Решение 2 (когда пользователь сам задает элементы массива)*/

int[] CreateArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input array element {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] yourArray = CreateArray(size);
ShowArray(yourArray);

