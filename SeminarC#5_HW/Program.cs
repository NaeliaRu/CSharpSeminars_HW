/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

/*int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(100,1000);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int Count(int[] array)
{
    int current = 0;

    for(int i = 0; i < array.Length; i++)

        if(array[i] % 2 == 0)
            current++;

    return current;
}

Console.Write("Input numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] userArray = CreateRandomArray(size);
ShowArray(userArray);
int result = Count(userArray);
Console.WriteLine("Number of even numbers in the array; " + result);*/

/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

/*int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue,maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int Sum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)

        if (i % 2 != 0) //для пользователя счет начинается с 1-ой позииции, а это четные индексы
                        //если нужно посчитать сумму элементов на четных индексах то меняем if(i % 2 == 0)
        sum += array[i];

    return sum;
}

Console.Write("Input numbers of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value; ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] userArray = CreateRandomArray(size, min, max);
ShowArray(userArray);
int result = Sum(userArray);
Console.WriteLine("Sum of elements in odd position; " + result);*/

/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double[] CreateArray(int size)
{
    double[] array = new double[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input array element {i + 1}: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

/*double Diff(double[] array) - решение без вевидения min и max
{
    double max = array[0];
    double min = array[0];

    for(int i = 0; i < array.Length; i++)
        if(array[i] > max) max = array[i];

    for(int i = 0; i < array.Length; i++)
        if(array[i] < min) min = array[i];

    double diff = max - min;
    return diff;
}*/

double Max(double[] array)
{
    double max = array[0];

    for(int i = 0; i < array.Length; i++)
        if(array[i] > max) max = array[i];

    return max;
}

double Min(double[] array)
{
    double min = array[0];

    for(int i = 0; i < array.Length; i++)
        if(array[i] < min) min = array[i];

    return min;
}

Console.Write("Input number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] yourArray = CreateArray(size);
ShowArray(yourArray);
double max = Max(yourArray);
Console.WriteLine("Max value of array: " + max);
double min = Min(yourArray);
Console.WriteLine("Min value of array: " + min);
double different = max - min;
//double different = Diff(yourArray);
Console.Write("Differen between max and min value is: " + different);
