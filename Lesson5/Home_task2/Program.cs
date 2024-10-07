// Задание 2: Поиск суммы элементов в каждом столбце
// Описание: Задайте двумерный массив целых чисел. Напишите программу, которая
// находит сумму элементов в каждом столбце массива и выводит её.

// Пример входных данных:
// 1 2 3
// 4 5 6
// 7 8 9
// 10 11 12

// Пример результата:
// Сумма элементов в столбце 0: 22
// Сумма элементов в столбце 1: 26
// Сумма элементов в столбце 2: 30

using System;
class Program
{
    static void FindSumInColumns(int[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);
        int sum;

        for (int i = 0; i < rows; i++)
        {
            sum = 0;
            for (int j = 0; j < cols; j++)
            {
                sum += array[i, j];
            }
            Console.WriteLine($"Сумма элементов в столбце {i}: {sum}");
        }
    }

    static void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    static void Main()
    {
        int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
        PrintArray(array);
        Console.WriteLine();
        FindSumInColumns(array);
    }
}

