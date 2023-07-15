// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int[,] ElementPosition(int[,] array, int pozElemRows, int pozElemColumns)
{
    if (pozElemRows < array.GetLength(0) && pozElemColumns < array.GetLength(1))
    {
        Console.WriteLine(array[pozElemRows, pozElemColumns]);
    }
    else Console.WriteLine($"{pozElemRows},{pozElemColumns} -> числа с такими координатами НЕТ в массиве!!!");
    return array;
}

System.Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of array element: ");
int minValue = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of array element: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Input element position i: ");
int pozElemRows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input element position j: ");
int pozElemColumns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns, minValue, maxValue);
Print2DArray(myArray);
ElementPosition(myArray, pozElemRows, pozElemColumns);
