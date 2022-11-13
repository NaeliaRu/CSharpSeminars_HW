/* Задача 54: Задайте двумерный массив. Напишите программу, 
которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

/* int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1) - 1; j++)
      for (int k = 0; k < array.GetLength(1) - 1; k++)
        if (array[i, k + 1] > array[i, k])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
  }
}

int[,] userArray = CreateRandom2dArray();
Show2dArray(userArray);
SortArray(userArray);
Console.WriteLine();
Console.WriteLine("Sorted array");
Console.WriteLine();
Show2dArray(userArray); */

/*------------------------------------------------------------------------------------------------------------------- 
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

/* int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

void MinSumLineIndex(int[,] array)
{
    int[] sumLineArray = new int[array.GetLength(0)];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
            sumLineArray[i] = sum;
        } 
        //Console.WriteLine(sum);
    }

    int minSumLine = sumLineArray[0];
    int index = 0;

    for(int i = 1; i < sumLineArray.Length; i++ )
        if (sumLineArray[i] < minSumLine)
        {
            minSumLine = sumLineArray[i];
            index = i;
        }
    Console.WriteLine($"The row with the smallest sum of elements: {index + 1}, sum of elements is: {minSumLine}");
}

int[,] userArray = CreateRandom2dArray();
if (userArray.GetLength(0) == userArray.GetLength(1))
    Console.WriteLine("Array is not rectangular, enter a new array");
else 
    {
        Show2dArray(userArray);
        MinSumLineIndex(userArray);
    } */

/*----------------------------------------------------------------------------------------------------------------
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows,colums];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < colums; j++)
            array[i,j] = new Random().Next(minValue, maxValue + 1);
    }

    return array;
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i,j] + " ");

        Console.WriteLine();
    }
}

int[,] MatrixMultiplication(int[,] matrix1, int[,] matrix2)
{
    if(matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Multiplication is not possible");
        System.Environment.Exit(0);
    }

    int[,] resultMatrix = new int[matrix1.GetLength(0),matrix2.GetLength(1)];

    for(int i = 0; i < matrix1.GetLength(0); i++)
    {
        for(int j = 0; j < matrix2.GetLength(1); j++)
        {
            for(int n = 0; n < matrix1.GetLength(1); n++)
            {
                resultMatrix[i,j] += matrix1[i,n]*matrix2[n,j];
            }
        } 
    }

    return resultMatrix;
}
Console.WriteLine("Enter the first matrix parameters");
int[,] userArray1 = CreateRandom2dArray();
Console.WriteLine("Enter the second matrix parameters");
int[,] userArray2 = CreateRandom2dArray();
Show2dArray(userArray1);
Console.WriteLine();
Show2dArray(userArray2);
int[,] result = MatrixMultiplication(userArray1, userArray2);
Console.WriteLine();
Console.WriteLine("Product of two matrices");
Show2dArray(result);



